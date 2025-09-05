using GalleryManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryManager.Data
{
    public class GalleryContext : DbContext
    {
        public GalleryContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=GalleryDb;Trusted_Connection=true;MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Picture> Pictures { get; set; }
    }
}
