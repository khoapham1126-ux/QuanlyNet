using QuanlyNet.VIEW;
using QuanLyNet.DAL.DBContext;
using QuanLyNet.Entity;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNet.DAL
{
    public class PhienSuDungDAL
    {
        public List<PhienSuDung> GetAll()
        {
            using (var db = new QuanLyNetDbContext())
            {
                return db.PhienSuDungs.ToList();
            }
        }

        public PhienSuDung getByID(int id)
        {
            using (var db = new QuanLyNetDbContext())
            {
                return db.PhienSuDungs.Find(id);
            }
        }
        public void BatDauPhien(PhienSuDung phien)
        {
            using (var db = new QuanLyNetDbContext())
            {
                phien.GioBatDau = DateTime.Now;
                phien.GioKetThuc = null;
                phien.ThanhTien = 0;
                phien.TrangThai = false;
                db.PhienSuDungs.Add(phien);
                db.SaveChanges();
            }
        }
        public void KetThucPhien(int maPhien)
        {
            using (var db = new QuanLyNetDbContext())
            {
                var phien = db.PhienSuDungs.Find(maPhien);
                if (phien != null)
                {
                    phien.GioKetThuc = DateTime.Now;
                    phien.TrangThai = true;
                    db.SaveChanges();
                }
            }
        }
        public bool KiemtraPhienDangSuDung(int id)
        {
            using (var db = new QuanLyNetDbContext())
            {
                var phien = db.PhienSuDungs.Find(id);
                if (phien != null)
                {
                    return !phien.TrangThai;
                }
                return false;
            }
        }
    }
}
