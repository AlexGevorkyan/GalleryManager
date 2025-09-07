using GalleryManager.Data;
using GalleryManager.Models;
using System.Security.Cryptography;

namespace GalleryManager
{
    public partial class Form1 : Form
    {
        private readonly GalleryContext context;

        private string localDir = "./images";
        public Form1()
        {
            InitializeComponent();

            context = new GalleryContext();

            tabPage2.AllowDrop = true;

            tabPage2.DragDrop += TabPage2_DragDrop;
            tabPage2.DragEnter += TabPage2_DragEnter;
            if (!Directory.Exists(localDir))
            {
                Directory.CreateDirectory(localDir);
            }

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

                MessageBox.Show("Зображення додано!");
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
                MessageBox.Show("Зображення додано!");
            }
        }

        private void DD(object sender, DragEventArgs e)
        {

        }

        private void DE(object sender, DragEventArgs e)
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