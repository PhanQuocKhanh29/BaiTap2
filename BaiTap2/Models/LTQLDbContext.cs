using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiTap2.Models
{
    public partial class LTQLDbContext : DbContext

    {
        private const string NameOrConnectionString = "name=LTQLDbContext";

        public LTQLDbContext() : base(NameOrConnectionString)
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
            .Property(e => e.Username)
            .IsUnicode(false);
            modelBuilder.Entity<Student>()
            .Property(e => e.StudentID)
            .IsUnicode(false);
            modelBuilder.Entity<KhachHang>()
            .Property(e => e.MaKH)
            .IsUnicode(false);


        }
    }

}