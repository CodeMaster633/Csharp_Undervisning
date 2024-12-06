using DataAccessStuderende2.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DataAccessStuderende2.Context
{
    internal class StuderendeContext : DbContext
    {
        public StuderendeContext()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-TT7JTDJT\\SQLEXPRESS;Initial Catalog=Studerende;Integrated Security = SSPI; TrustServerCertificate=true");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studerende>().HasData(new Studerende[] {
        new Studerende { StuderendeId = 1, Navn = "Steve", Studiestart = new DateTime(2022, 09, 01), Alder = 26, Studietype = Studietype.Master },
        new Studerende { StuderendeId = 2, Navn = "Jim", Studiestart = new DateTime(2022, 09, 01), Alder = 26, Studietype = Studietype.Master },
        new Studerende { StuderendeId = 3, Navn = "Benjamin", Studiestart = new DateTime(2022, 09, 01), Alder = 26, Studietype = Studietype.Master }
    });
        }

        public DbSet<Studerende> Studerendes { get; set; }
    }
}
