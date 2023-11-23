using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kt1.Models
{
    public partial class QLDiemContext : DbContext
    {
        public QLDiemContext()
        {
        }

        public QLDiemContext(DbContextOptions<QLDiemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Diem> Diems { get; set; } = null!;
        public virtual DbSet<SinhVien> SinhViens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ONLYK\\MSSQLSERVER01;Initial Catalog=QLDiem;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diem>(entity =>
            {
                entity.HasKey(e => new { e.MaSv, e.MonHoc })
                    .HasName("PK__Diem__7B9A00AE42B9986E");

                entity.ToTable("Diem");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaSV")
                    .IsFixedLength();

                entity.Property(e => e.MonHoc).HasMaxLength(20);
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK__SinhVien__2725081A96616DAE");

                entity.ToTable("SinhVien");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaSV")
                    .IsFixedLength();

                entity.Property(e => e.HoTen).HasMaxLength(30);

                entity.Property(e => e.SoDt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SoDT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
