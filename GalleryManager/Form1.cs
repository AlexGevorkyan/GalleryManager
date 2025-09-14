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


            this.Text = "Gallery Manager";

            context = new GalleryContext();

            tabPage2.AllowDrop = true;

            tabPage2.DragDrop += TabPage2_DragDrop;
            tabPage2.DragEnter += TabPage2_DragEnter;


            if (!Directory.Exists(localDir))
            {
                Directory.CreateDirectory(localDir);
            }
            fileSizer = maxFileSize1.Text;
            MessageBox.Show(fileSizer);
            fileSize = maxFileSize.Text;
            // MessageBox.Show(fileSize);
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

            string imagePath = dataGridView1.Rows[e.RowIndex].Cells["ImagePath"].Value.ToString();

            if (!File.Exists(imagePath))
            {
                MessageBox.Show("File not found: " + imagePath);
                return;
            }

            ImageForm form = new ImageForm((DataTable)dataGridView1.DataSource, e.RowIndex);
            form.Show();

        }

        private void TabPage2_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void TabPage2_DragDrop(object? sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
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

                MessageBox.Show("The image is added!");
            }
        }

        private void bt_addPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
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

                MessageBox.Show("The image is added!");
            }
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