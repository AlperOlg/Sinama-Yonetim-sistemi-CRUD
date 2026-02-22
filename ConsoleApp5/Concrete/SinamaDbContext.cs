using ConsoleApp5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Concrete
{
    public class SinamaDbContext : DbContext
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Yonetmen> Yonetmenler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=SinamaDenemeDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var films = modelBuilder.Entity<Film>();
            films.HasKey(f => f.ID);
            films.HasOne(f => f.Yonetmen).WithMany(y => y.Films).HasForeignKey(f => f.YonetmenID);
            films.Property(f => f.Name).IsRequired().HasMaxLength(50);

            var directors = modelBuilder.Entity<Yonetmen>();
            directors.HasKey(y=>y.ID);
            directors.Property(y => y.Name).IsRequired().HasMaxLength(30) ;
            directors.Property(y => y.Surname).IsRequired().HasMaxLength(30) ;
            base.OnModelCreating(modelBuilder);
        }
    }
}
