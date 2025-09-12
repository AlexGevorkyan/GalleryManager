namespace GalleryManager
{
    public partial class Form1 : Form
    {
        string fileSize;
        string fileSizer;
        public Form1()
        {
            InitializeComponent();

            string localDir = "./images";
            if (!Directory.Exists(localDir))
            {
                Directory.CreateDirectory(localDir);
            }
            fileSizer = maxFileSize1.Text;
            MessageBox.Show(fileSizer);
            fileSize = maxFileSize.Text;
// MessageBox.Show(fileSize);
        }

        private void label1_Click(object sender, EventArgs e)
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