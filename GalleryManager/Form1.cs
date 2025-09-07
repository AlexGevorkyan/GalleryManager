namespace GalleryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string localDir = "./images";
            if(!Directory.Exists(localDir))
            {
                Directory.CreateDirectory(localDir);
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