using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentalKendaraan_03.Models
{
    public partial class RentalKendaraanContext : DbContext
    {
        public RentalKendaraanContext()
        {
        }

        public RentalKendaraanContext(DbContextOptions<RentalKendaraanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Jaminan> Jaminan { get; set; }
        public virtual DbSet<JenisKendaraan> JenisKendaraan { get; set; }
        public virtual DbSet<Kendaraan> Kendaraan { get; set; }
        public virtual DbSet<KondisiKendaraan> KondisiKendaraan { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }
        public virtual DbSet<Peminjaman> Peminjaman { get; set; }
        public virtual DbSet<Pengembalian> Pengembalian { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("ID_Customer")
                    .ValueGeneratedNever();

                entity.Property(e => e.Alamat)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdGender).HasColumnName("ID_Gender");

                entity.Property(e => e.NamaCustomer)
                    .HasColumnName("Nama_Customer")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nik)
                    .HasColumnName("NIK")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NoHp)
                    .HasColumnName("No_HP")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.IdGender);

                entity.Property(e => e.IdGender)
                    .HasColumnName("ID_Gender")
                    .ValueGeneratedNever();

                entity.Property(e => e.NamaGender)
                    .HasColumnName("Nama_Gender")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGenderNavigation)
                    .WithOne(p => p.Gender)
                    .HasForeignKey<Gender>(d => d.IdGender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gender_Customer");
            });

            modelBuilder.Entity<Jaminan>(entity =>
            {
                entity.HasKey(e => e.IdJaminan);

                entity.Property(e => e.IdJaminan)
                    .HasColumnName("ID_Jaminan")
                    .ValueGeneratedNever();

                entity.Property(e => e.NamaJaminan)
                    .HasColumnName("Nama_Jaminan")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdJaminanNavigation)
                    .WithOne(p => p.Jaminan)
                    .HasForeignKey<Jaminan>(d => d.IdJaminan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jaminan_Peminjaman");
            });

            modelBuilder.Entity<JenisKendaraan>(entity =>
            {
                entity.HasKey(e => e.IdJenisKendaraan);

                entity.ToTable("Jenis_Kendaraan");

                entity.Property(e => e.IdJenisKendaraan)
                    .HasColumnName("ID_Jenis_Kendaraan")
                    .ValueGeneratedNever();

                entity.Property(e => e.NamaJenisKendaraan)
                    .HasColumnName("Nama_Jenis_Kendaraan")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kendaraan>(entity =>
            {
                entity.HasKey(e => e.IdKendaraan);

                entity.Property(e => e.IdKendaraan)
                    .HasColumnName("ID_Kendaraan")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdJenisKendaraan).HasColumnName("ID_Jenis_Kendaraan");

                entity.Property(e => e.Ketersediaan)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NamaKendaraan)
                    .HasColumnName("Nama_Kendaraan")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NoPolisi)
                    .HasColumnName("No_Polisi")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NoStnk)
                    .HasColumnName("No_STNK")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdKendaraanNavigation)
                    .WithOne(p => p.Kendaraan)
                    .HasForeignKey<Kendaraan>(d => d.IdKendaraan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kendaraan_Jenis_Kendaraan");

                entity.HasOne(d => d.IdKendaraan1)
                    .WithOne(p => p.Kendaraan)
                    .HasForeignKey<Kendaraan>(d => d.IdKendaraan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kendaraan_Peminjaman");
            });

            modelBuilder.Entity<KondisiKendaraan>(entity =>
            {
                entity.HasKey(e => e.IdKondisi);

                entity.ToTable("Kondisi_Kendaraan");

                entity.Property(e => e.IdKondisi)
                    .HasColumnName("ID_Kondisi")
                    .ValueGeneratedNever();

                entity.Property(e => e.NamaKondisi)
                    .HasColumnName("Nama_Kondisi")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nota>(entity =>
            {
                entity.HasKey(e => e.KodeTransaksi);

                entity.ToTable("nota");

                entity.Property(e => e.KodeTransaksi)
                    .HasColumnName("Kode_Transaksi")
                    .ValueGeneratedNever();

                entity.Property(e => e.Diskon).HasColumnType("money");

                entity.Property(e => e.HargaBarang)
                    .HasColumnName("Harga_Barang")
                    .HasColumnType("money");

                entity.Property(e => e.HargaTotal)
                    .HasColumnName("Harga_Total")
                    .HasColumnType("money");

                entity.Property(e => e.JumlahBarang).HasColumnName("Jumlah_Barang");

                entity.Property(e => e.KodeBarang).HasColumnName("Kode_Barang");

                entity.Property(e => e.NamaBarang)
                    .HasColumnName("Nama_Barang")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pajak).HasColumnType("money");

                entity.Property(e => e.Pelanggan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalTransaksi)
                    .HasColumnName("Tanggal_Transaksi")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Peminjaman>(entity =>
            {
                entity.HasKey(e => e.IdPemimjaman);

                entity.Property(e => e.IdPemimjaman)
                    .HasColumnName("ID_Pemimjaman")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdCustomer).HasColumnName("ID_Customer");

                entity.Property(e => e.IdJaminan).HasColumnName("ID_Jaminan");

                entity.Property(e => e.IdKendaraan).HasColumnName("ID_Kendaraan");

                entity.Property(e => e.TglPemimjaman)
                    .HasColumnName("Tgl_Pemimjaman")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdPemimjamanNavigation)
                    .WithOne(p => p.Peminjaman)
                    .HasForeignKey<Peminjaman>(d => d.IdPemimjaman)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Peminjaman_Customer");
            });

            modelBuilder.Entity<Pengembalian>(entity =>
            {
                entity.HasKey(e => e.IdPengembalian);

                entity.Property(e => e.IdPengembalian)
                    .HasColumnName("ID_Pengembalian")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdKondisi).HasColumnName("ID_Kondisi");

                entity.Property(e => e.IdPeminjaman).HasColumnName("ID_Peminjaman");

                entity.Property(e => e.TglPengembalian)
                    .HasColumnName("Tgl_Pengembalian")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdPengembalianNavigation)
                    .WithOne(p => p.Pengembalian)
                    .HasForeignKey<Pengembalian>(d => d.IdPengembalian)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pengembalian_Kondisi_Kendaraan");

                entity.HasOne(d => d.IdPengembalian1)
                    .WithOne(p => p.Pengembalian)
                    .HasForeignKey<Pengembalian>(d => d.IdPengembalian)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pengembalian_Peminjaman");
            });
        }
    }
}
