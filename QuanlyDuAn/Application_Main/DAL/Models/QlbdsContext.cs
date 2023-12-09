using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDuAnBDS.Models;

public partial class QlbdsContext : DbContext
{
    public QlbdsContext()
    {
    }

    public QlbdsContext(DbContextOptions<QlbdsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DuAnChuaDuyet> DuAnChuaDuyets { get; set; }

    public virtual DbSet<DuAnDaDuyet> DuAnDaDuyets { get; set; }

    public virtual DbSet<TkDangNhap> TkDangNhaps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ONLYK;Initial Catalog=QLBDS;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DuAnChuaDuyet>(entity =>
        {
            entity.HasKey(e => e.Idda).HasName("PK__DuAnChua__B87EBCC95372C198");

            entity.ToTable("DuAnChuaDuyet");

            entity.Property(e => e.Idda).HasColumnName("IDda");
            entity.Property(e => e.Idtk).HasColumnName("IDtk");

            entity.HasOne(d => d.IdtkNavigation).WithMany(p => p.DuAnChuaDuyets)
                .HasForeignKey(d => d.Idtk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DuAnChuaDu__IDtk__4BAC3F29");
        });

        modelBuilder.Entity<DuAnDaDuyet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DuAnDaDuyet");

            entity.Property(e => e.Idda)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDda");
            entity.Property(e => e.Idtk).HasColumnName("IDtk");

            entity.HasOne(d => d.IdtkNavigation).WithMany()
                .HasForeignKey(d => d.Idtk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DuAnDaDuye__IDtk__4D94879B");
        });

        modelBuilder.Entity<TkDangNhap>(entity =>
        {
            entity.HasKey(e => e.Idtk).HasName("PK__TkDangNh__B87D3ECBE5F4EF57");

            entity.ToTable("TkDangNhap");

            entity.Property(e => e.Idtk).HasColumnName("IDtk");
            entity.Property(e => e.Chucdanh)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Gt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ns).HasColumnType("date");
            entity.Property(e => e.Sdt).HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
