using Microsoft.EntityFrameworkCore;
using L10_Entity_Framework.Models;
using System.Diagnostics;


namespace L10_Entity_Framework.DAL
{
    public class BogContext : DbContext
    {
        public BogContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-TT7JTDJT\\SQLEXPRESS;Initial Catalog=Boger1;Integrated Security=SSPI; TrustServerCertificate=true");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Bibliotek bibliotek = new Bibliotek("123", "Abc Bib");
            modelBuilder.Entity<Bibliotek>().HasData(new Bibliotek[] {
                bibliotek
             });

            modelBuilder.Entity<Bog>().HasData(new Bog[] {
                new Bog{BogID=1,Name="Ringenes herre - Femhærskrigen" , BibliotekID = bibliotek.BibliotekID },
                new Bog{BogID=2,Name="Ringenes herre - Eventyret" , BibliotekID = bibliotek.BibliotekID }
            });
        }

        public DbSet<Bog> Boger { get; set; }
        public DbSet<Bibliotek> Biblioteker { get; set; }


    }
}
