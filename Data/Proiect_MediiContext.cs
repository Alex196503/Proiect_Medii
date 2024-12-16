using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii.Models;

namespace Proiect_Medii.Data
{
    public class Proiect_MediiContext : DbContext
    {
        public Proiect_MediiContext (DbContextOptions<Proiect_MediiContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Medii.Models.Member> Member { get; set; } = default!;
        public DbSet<Proiect_Medii.Models.Membership> Membership { get; set; } = default!;
        public DbSet<Proiect_Medii.Models.Trainer> Trainer { get; set; } = default!;
        public DbSet<Proiect_Medii.Models.Review> Review { get; set; } = default!;
        public DbSet<Proiect_Medii.Models.Reservation> Reservation { get; set; } = default!;
        public DbSet<Proiect_Medii.Models.Teren> Teren { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Teren)
                .WithMany(t => t.Reservations)
                .HasForeignKey(r => r.TerenID)
                .OnDelete(DeleteBehavior.Cascade);
     
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>()
                .HasOne(m => m.Trainer)
                .WithMany(t => t.Members)
                .HasForeignKey(m => m.TrainerID)
                .OnDelete(DeleteBehavior.Cascade); // Adăugăm ștergerea în cascadă
        }

    }


}

