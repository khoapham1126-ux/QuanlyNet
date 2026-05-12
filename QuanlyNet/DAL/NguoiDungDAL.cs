using QuanlyNet.VIEW;
using QuanLyNet.DAL.DBContext;
using QuanLyNet.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyNet.DAL
{
    public class NguoiDungDAL
    {
        public List<NguoiDung> GetAll()
        {
            using (var db = new QuanLyNetDbContext())
            {
                return db.NguoiDungs.ToList();
            }
        }
        public NguoiDung getByID(int id)
        {
            using (var db = new QuanLyNetDbContext())
            {
                return db.NguoiDungs.Find(id);
            }
        }
        public void Add(NguoiDung nguoiDung)
        {
            using (var db = new QuanLyNetDbContext())
            {
                db.NguoiDungs.Add(nguoiDung);
                db.SaveChanges();
            }
        }
        public void Update(NguoiDung nguoiDung)
        {
            using (var db = new QuanLyNetDbContext())
            {
                var existingNguoiDung = db.NguoiDungs.Find(nguoiDung.MaNguoiDung);
                if (existingNguoiDung != null)
                {
                    existingNguoiDung.MatKhau = nguoiDung.MatKhau;
                    existingNguoiDung.HoTen = nguoiDung.HoTen;
                    existingNguoiDung.SoDienThoai = nguoiDung.SoDienThoai;
                    existingNguoiDung.TaiKhoan = nguoiDung.TaiKhoan;
                    existingNguoiDung.SoDu = nguoiDung.SoDu;
                    db.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (var db = new QuanLyNetDbContext())
            {
                var NguoiDung = db.NguoiDungs.Find(id);
                if (NguoiDung != null)
                {
                    db.NguoiDungs.Remove(NguoiDung);
                    db.SaveChanges();
                }
            }
        }
    }
}
