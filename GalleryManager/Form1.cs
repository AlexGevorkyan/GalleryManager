using Microsoft.Data.SqlClient;
using System.Data;

namespace GalleryManager
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

            LoadPicturesTable();
        }

        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);

            dataGridView1.CellClick += dataGridView1_CellClick;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string localDir = "./images";
            if (!Directory.Exists(localDir))
            {
                Directory.CreateDirectory(localDir);
            }

        }

        private void LoadPicturesTable()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GalleryDb;Integrated Security=True";
            string query = "SELECT Id, FileName, ImagePath, FileSize, CreatedAt, ImageData FROM Pictures";

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

            byte[] imageData = dataGridView1.Rows[e.RowIndex].Cells["ImageData"].Value as byte[];

            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    DataTable table = (DataTable)dataGridView1.DataSource;
                    int selectedIndex = e.RowIndex;
                    ImageForm form = new ImageForm(table, selectedIndex);

                    Image img = Image.FromStream(ms);
                    form.pictureBox1.Image = img;
                    form.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    form.Show();
                    //Image img = Image.FromStream(ms);

                    //switch (imageCounter % 3)
                    //{
                    //    case 0:
                    //        pictureBox1.Image = img;
                    //        break;
                    //    case 1:
                    //        pictureBox2.Image = img;
                    //        break;
                    //    case 2:
                    //        pictureBox3.Image = img;
                    //        break;
                    //}

                    //imageCounter++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні зображення: " + ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

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