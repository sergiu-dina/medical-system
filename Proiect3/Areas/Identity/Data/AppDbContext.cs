using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proiect3.Areas.Identity.Data;
using Proiect3.Models;

namespace Proiect3.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Medic> Medics { get; set; }
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<MedicPacient> MedicPacients { get; set; }
        public DbSet<Medicament> Medicamente { get; set; }
        public DbSet<Consultatie> Consultatii { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MedicPacient>()
                .HasKey(mp => new { mp.MedicId, mp.PacientId });
            builder.Entity<MedicPacient>()
                .HasOne(mp => mp.Medic)
                .WithMany(m => m.MedicPacients)
                .HasForeignKey(mp => mp.MedicId);
            builder.Entity<MedicPacient>()
                .HasOne(mp => mp.Pacient)
                .WithMany(p => p.MedicPacients)
                .HasForeignKey(mp => mp.PacientId);

            builder.Entity<Consultatie>()
                .HasKey(c => new { c.MedicamentId, c.PacientId });
            builder.Entity<Consultatie>()
                .HasOne(c => c.Medicament)
                .WithMany(m => m.Consultatii)
                .HasForeignKey(c => c.MedicamentId);
            builder.Entity<Consultatie>()
                .HasOne(c => c.Pacient)
                .WithMany(p => p.Consultatii)
                .HasForeignKey(c => c.PacientId);

            base.OnModelCreating(builder);
        }
    }
}
