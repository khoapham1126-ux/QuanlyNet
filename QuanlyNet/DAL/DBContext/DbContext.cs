using QuanlyNet.DAL.Entity;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNet.DAL.DBContext
{
    public class QuanLyNetDbContext : DbContext
    {
        public QuanLyNetDbContext() : base("name=QuanLyNetDbContext")
        {
        }

        public DbSet<MayTinh> MayTinhs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<PhienSuDung> PhienSuDungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
