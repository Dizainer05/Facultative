using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace _21day
{
    internal class Datab : DbContext
    {
        string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nosko\Documents\21day.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Students> Students { get; set; }
        public DbSet<Facultative> Facultative { get; set; }
        public DbSet<FacultativeRecord> FacultativeRecord { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connect);
        }
    }
}
