using EF_05_MA.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_05_MA
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Loaimonan> Loaimonan { get; set; }
        public DbSet<Monan> Monan { get; set; }
        public DbSet<Congthuc> Congthucs { get; set; }
        public DbSet<Nguyenlieu> Nguyenlieu { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TUANNM\\TUANNM; database = MonAn; integrated security = sspi; encrypt = true; trustservercertificate = true;");
        }
    }
}
