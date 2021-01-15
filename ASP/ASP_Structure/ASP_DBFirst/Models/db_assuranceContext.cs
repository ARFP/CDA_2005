using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ASP_DBFirst.Models
{
    public partial class db_assuranceContext : DbContext
    {
        public db_assuranceContext()
        {
        }

        public db_assuranceContext(DbContextOptions<db_assuranceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Compagny> Compagnies { get; set; }
        public virtual DbSet<Entreprise> Entreprises { get; set; }
        public virtual DbSet<Foyer> Foyers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=db_assurance");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("client_name");

                entity.Property(e => e.CompagnieId).HasColumnName("compagnie_id");

                entity.Property(e => e.EtsId).HasColumnName("ets_id");

                entity.Property(e => e.FoyerId).HasColumnName("foyer_id");

                entity.HasOne(d => d.Compagnie)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CompagnieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__clients__compagn__4316F928");

                entity.HasOne(d => d.Ets)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.EtsId)
                    .HasConstraintName("FK__clients__ets_id__412EB0B6");

                entity.HasOne(d => d.Foyer)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.FoyerId)
                    .HasConstraintName("FK__clients__foyer_i__4222D4EF");
            });

            modelBuilder.Entity<Compagny>(entity =>
            {
                entity.HasKey(e => e.CompagnieId)
                    .HasName("PK__compagni__43435D153D5AB6FD");

                entity.ToTable("compagnies");

                entity.Property(e => e.CompagnieId).HasColumnName("compagnie_id");

                entity.Property(e => e.CompagnieName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("compagnie_name");
            });

            modelBuilder.Entity<Entreprise>(entity =>
            {
                entity.HasKey(e => e.EtsId)
                    .HasName("PK__entrepri__986F5FA80E4EA5B7");

                entity.ToTable("entreprises");

                entity.Property(e => e.EtsId).HasColumnName("ets_id");
            });

            modelBuilder.Entity<Foyer>(entity =>
            {
                entity.ToTable("foyers");

                entity.Property(e => e.FoyerId).HasColumnName("foyer_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
