using Microsoft.EntityFrameworkCore;
using TaskMaster.Models;

namespace TaskMaster.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tache> Taches { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<SousTache> SousTaches { get; set; }
        public DbSet<Etiquette> Etiquettes { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relation entre Tache et Auteur
            modelBuilder.Entity<Tache>()
                .HasOne(t => t.Auteur)
                .WithMany(u => u.TachesCreees)
                .HasForeignKey(t => t.AuteurId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relation entre Tache et Realisateur
            modelBuilder.Entity<Tache>()
                .HasOne(t => t.Realisateur)
                .WithMany(u => u.TachesAssignees)
                .HasForeignKey(t => t.RealisateurId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
