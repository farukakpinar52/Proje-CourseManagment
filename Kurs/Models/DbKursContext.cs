using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kurs.Models
{
    public partial class DbKursContext : DbContext
    {
        private static DbKursContext instance;
        public static DbKursContext GetInstance { 
        get
            {
                return instance;
            }
        }
        private DbKursContext()
        {
        }
        static DbKursContext()
        {
            instance= new DbKursContext();
        }
        public DbKursContext(DbContextOptions<DbKursContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDersler> TblDerslers { get; set; } = null!;
        public virtual DbSet<TblNotlar> TblNotlars { get; set; } = null!;
        public virtual DbSet<TblOgrenciler> TblOgrencilers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-P7KA77K\\SQLEXPRESS;User ID=sa;Password=1234;Database=DbKurs;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDersler>(entity =>
            {
                entity.ToTable("TBL_Dersler");

                entity.Property(e => e.Adi)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNotlar>(entity =>
            {
                entity.ToTable("TBL_Notlar");

                entity.Property(e => e.Ortalama).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Ders)
                    .WithMany(p => p.TblNotlars)
                    .HasForeignKey(d => d.DersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_Notlar_TBL_Dersler");

                entity.HasOne(d => d.Ogr)
                    .WithMany(p => p.TblNotlars)
                    .HasForeignKey(d => d.OgrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_Notlar_TBL_Ogrenciler");
            });

            modelBuilder.Entity<TblOgrenciler>(entity =>
            {
                entity.ToTable("TBL_Ogrenciler");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
