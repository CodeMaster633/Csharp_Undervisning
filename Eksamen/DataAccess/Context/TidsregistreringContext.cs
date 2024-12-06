using DataAccess.Model;
//using DTOL.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DataAccess.Context
{
    public class TidsregistreringContext : DbContext
    {
        public TidsregistreringContext()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-TT7JTDJT\\SQLEXPRESS;Initial Catalog=TidsSystem;Integrated Security = SSPI; TrustServerCertificate=true");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
            

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for Afdeling
            modelBuilder.Entity<Afdeling>().HasData(new Afdeling[]
            {
                new Afdeling { Navn = "IT", AfdelingId = 1 },
                new Afdeling { Navn = "Økonomi", AfdelingId = 2 },
                new Afdeling { Navn = "Produktion", AfdelingId = 3 }
            });

            // Seed data for Sag
            modelBuilder.Entity<Sag>().HasData(new Sag[]
            {
                new Sag { SagId = 1, Beskrivelse = "Frontend arbejde", AfdelingId = 1, Overskrift = "Programmering" },
                new Sag { SagId = 2, Beskrivelse = "Backend arbejde", AfdelingId = 1, Overskrift = "Programmering" },
                new Sag { SagId = 3, Beskrivelse = "Hardware arbejde", AfdelingId = 3, Overskrift = "Programmering" }
            });

            // Seed data for Medarbejder
            modelBuilder.Entity<Medarbejder>().HasData(new Medarbejder[]
            {
                new Medarbejder { MedarbejderId = 1, CprNummer = "010101-1234", Navn = "Anders Andersen", AfdelingId = 1 },
                new Medarbejder { MedarbejderId = 2, CprNummer = "020202-5678", Navn = "Bente Bentsen", AfdelingId = 2 },
                new Medarbejder { MedarbejderId = 3, CprNummer = "030303-9101", Navn = "Carl Carlsen", AfdelingId = 3 }
            });

            // Seed data for Tidsregistrering
            modelBuilder.Entity<Tidsregistrering>().HasData(new Tidsregistrering[]
            {
                new Tidsregistrering
                {
                    TidsregistreringId = 1,
                    StartTid = new DateTime(2024, 12, 1, 9, 0, 0),
                    SlutTid = new DateTime(2024, 12, 1, 17, 0, 0),
                    MedarbejderId = 1,
                    SagId = 1
                },
                new Tidsregistrering
                {
                    TidsregistreringId = 2,
                    StartTid = new DateTime(2024, 12, 2, 10, 0, 0),
                    SlutTid = new DateTime(2024, 12, 2, 15, 0, 0),
                    MedarbejderId = 2,
                    SagId = 2
                },
                new Tidsregistrering
                {
                    TidsregistreringId = 3,
                    StartTid = new DateTime(2024, 12, 3, 8, 0, 0),
                    SlutTid = new DateTime(2024, 12, 3, 12, 0, 0),
                    MedarbejderId = 3,
                    SagId = 3
                },
                new Tidsregistrering
                {
                    TidsregistreringId = 4,
                    StartTid = new DateTime(2024, 11, 23, 8, 0, 0),
                    SlutTid = new DateTime(2024, 11, 23, 12, 0, 0),
                    MedarbejderId = 3,
                    SagId = 3
                },
                new Tidsregistrering
                {
                    TidsregistreringId = 5,
                    StartTid = new DateTime(2024, 10, 3, 8, 0, 0),
                    SlutTid = new DateTime(2024, 10, 3, 12, 0, 0),
                    MedarbejderId = 3,
                    SagId = 3
                }
            });

            modelBuilder.Entity<Tidsregistrering>()
                .HasOne(tr => tr.Sag)
                .WithMany(s => s.Tidsregistreringer)
                .HasForeignKey(tr => tr.SagId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Tidsregistrering>()
                .HasOne(tr => tr.Medarbejder)
                .WithMany(m => m.Tidsregistreringer)
                .HasForeignKey(tr => tr.MedarbejderId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Afdeling> Afdelinger { get; set; }
        public DbSet<Sag> Sager { get; set; }
        public DbSet<Tidsregistrering> Tidsregistreringer { get; set; }
        public DbSet<Medarbejder> Medarbejdere { get; set; }

    }
}
