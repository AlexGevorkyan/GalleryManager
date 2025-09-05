using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryManager.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ImagePath { get; set; }
        public int FileSize { get; set; }
        public DateTime CreatedAT { get; set; }
    }
}
