using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleryManager
{
    public partial class ImageForm : Form
    {
        private DataTable imageTable;
        private int currentIndex;

        public ImageForm(DataTable table, int startIndex)
        {
            InitializeComponent();
            imageTable = table;
            currentIndex = startIndex;
            ShowImage(currentIndex);
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ShowImage(int index)
        {
            string imagePath = imageTable.Rows[index]["ImagePath"].ToString();

            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("File is not found: " + imagePath);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowImage(currentIndex);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < imageTable.Rows.Count - 1)
            {
                currentIndex++;
                ShowImage(currentIndex);
            }
        }
    }
}