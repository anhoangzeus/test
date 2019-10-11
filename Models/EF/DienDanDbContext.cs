namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DienDanDbContext : DbContext
    {
        public DienDanDbContext()
            : base("name=DienDanDbContext")
        {
        }

        public virtual DbSet<BaiViet> BaiViets { get; set; }
        public virtual DbSet<CardGame> CardGames { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<QlPhanHoi> QlPhanHois { get; set; }
        public virtual DbSet<QlTuongTac> QlTuongTacs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaiViet>()
                .Property(e => e.NoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<BaiViet>()
                .HasMany(e => e.QlTuongTacs)
                .WithRequired(e => e.BaiViet)
                .HasForeignKey(e => e.IDBaiViet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.SoBaiViet)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DanhMuc>()
                .HasMany(e => e.BaiViets)
                .WithOptional(e => e.DanhMuc)
                .HasForeignKey(e => e.TheLoai);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.CMND)
                .IsFixedLength();

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.QlPhanHois)
                .WithOptional(e => e.NguoiDung)
                .HasForeignKey(e => e.IDNguoiPH);

            modelBuilder.Entity<QlPhanHoi>()
                .Property(e => e.NoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
