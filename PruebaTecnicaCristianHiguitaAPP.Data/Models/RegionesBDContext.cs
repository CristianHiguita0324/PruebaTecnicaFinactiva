using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PruebaTecnicaCristianHiguitaAPP.Data.Models
{
    public partial class RegionesBDContext : DbContext
    {
        public RegionesBDContext()
        {
        }

        public RegionesBDContext(DbContextOptions<RegionesBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblMunicipio> TblMunicipio { get; set; }
        public virtual DbSet<TblRegion> TblRegion { get; set; }
        public virtual DbSet<TblRegionMunicipio> TblRegionMunicipio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PSOFKA0319\\SQLEXPRESS;Database=RegionesBD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblMunicipio>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio)
                    .HasName("PK__tblMunic__6100597810E87E9D");

                entity.ToTable("tblMunicipio");

                entity.Property(e => e.NombreMunicipio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRegion>(entity =>
            {
                entity.HasKey(e => e.IdRegion)
                    .HasName("PK__tblRegio__8CBC09EBC9F00A87");

                entity.ToTable("tblRegion");

                entity.Property(e => e.NombreRegion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRegionMunicipio>(entity =>
            {
                entity.HasKey(e => e.IdRegionMunicipio)
                    .HasName("PK__tblRegio__7CF2F2264E6D7354");

                entity.ToTable("tblRegionMunicipio");

                entity.Property(e => e.Idregion).HasColumnName("IDRegion");

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.TblRegionMunicipio)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblRegion__IdMun__3A81B327");

                entity.HasOne(d => d.IdregionNavigation)
                    .WithMany(p => p.TblRegionMunicipio)
                    .HasForeignKey(d => d.Idregion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblRegion__IDReg__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
