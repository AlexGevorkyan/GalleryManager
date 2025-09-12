using Microsoft.Data.SqlClient;
using System.Data;
using GalleryManager.Data;
using GalleryManager.Models;
using System.Security.Cryptography;

namespace GalleryManager
{
    public partial class Form1 : Form
    {

        string fileSize;
        string fileSizer;

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadPicturesTable();
        }

        private readonly GalleryContext context;

        private string localDir = "./images";


        public Form1()
        {
            InitializeComponent();


            this.Load += new EventHandler(Form1_Load);

            dataGridView1.CellClick += dataGridView1_CellClick;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string localDir = "./images";


            context = new GalleryContext();

            tabPage2.AllowDrop = true;

            tabPage2.DragDrop += TabPage2_DragDrop;
            tabPage2.DragEnter += TabPage2_DragEnter;


            if (!Directory.Exists(localDir))
            {
                Directory.CreateDirectory(localDir);
            }
            fileSize = maxFileSize.Text;
        }


        private void LoadPicturesTable()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GalleryDb;Integrated Security=True";
            string query = "SELECT Id, FileName, ImagePath, FileSize, CreatedAt FROM Pictures";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = table;
            }
        }

        int imageCounter = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                // Отримуємо шлях до зображення з таблиці
                string imagePath = dataGridView1.Rows[e.RowIndex].Cells["ImagePath"].Value.ToString();

                if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
                {
                    MessageBox.Show("Файл зображення не знайдено: " + imagePath);
                    return;
                }

                // Завантажуємо картинку з файлу
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    Image img = Image.FromStream(fs);

                    DataTable table = (DataTable)dataGridView1.DataSource;
                    int selectedIndex = e.RowIndex;
                    ImageForm form = new ImageForm(table, selectedIndex);

                    form.pictureBox1.Image = img;
                    form.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні зображення: " + ex.Message);
            }
        }


        //private void tabPage1_Click(object sender, EventArgs e)

        private void TabPage2_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void TabPage2_DragDrop(object? sender, DragEventArgs e)
        {
            long maxSize = GetMaxFileSizeBytes();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                long fileSize = new FileInfo(file).Length;

                if (fileSize > maxSize)
                {
                    MessageBox.Show(
                        $"Файл {Path.GetFileName(file)} занадто великий! Максимальний розмір: {maxFileSize.Text} MB"
                    );
                    continue;
                }

                string fileName = Path.GetFileName(file);
                string path = Path.Combine(localDir, fileName);
                File.Copy(file, path, true);

                Picture picture = new Picture()
                {
                    FileName = fileName,
                    ImagePath = path,
                    FileSize = (int)new FileInfo(file).Length,
                    CreatedAT = new FileInfo(file).CreationTime
                };
                context.Pictures.Add(picture);
                context.SaveChanges();
                LoadPicturesTable();
                MessageBox.Show("Успішно додано!");
            }
        }

        private void bt_addPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                long maxSize = GetMaxFileSizeBytes();
                long fileSize = new FileInfo(ofd.FileName).Length;

                if (fileSize > maxSize)
                {
                    MessageBox.Show($"Файл занадто великий! Максимальний розмір: {maxFileSize.Text} MB");
                    return;
                }
                string path = Path.Combine(localDir, Path.GetFileName(ofd.FileName));
                File.Copy(ofd.FileName, path, true);

                Picture picture = new Picture()
                {
                    FileName = Path.GetFileName(ofd.FileName),
                    ImagePath = Path.Combine(localDir, Path.GetFileName(ofd.FileName)),
                    FileSize = (int)new FileInfo(ofd.FileName).Length,
                    CreatedAT = new FileInfo(ofd.FileName).CreationTime
                };
                context.Pictures.Add(picture);
                context.SaveChanges();
                LoadPicturesTable();
                MessageBox.Show("Успішно додано!");
            }
        }
        private long GetMaxFileSizeBytes()
        {
            if (long.TryParse(maxFileSize.Text, out long sizeInMb))
            {
                return sizeInMb * 1024 * 1024;
            }
            return 5 * 1024 * 1024;
        }
    }
}
//  ./  - current folder
//  ..  - one level up
//  OpenFileDialoge ofd = new OpenFileDialoge();
//  if(ofd.ShowDialog() == DialogResult.OK)
//  {
//      string path = Path.Combine(localDir, Path.GetFileName(ofd.FileName));
//      File.Copy(ofd.FileName, path, true);
//  }