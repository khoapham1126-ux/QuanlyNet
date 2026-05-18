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
        public NguoiDung DangNhap(string taiKhoan, string matKhau)
        {
            using (var db = new QuanLyNetDbContext())
            {
                return db.NguoiDungs.FirstOrDefault(nd => nd.TaiKhoan == taiKhoan && nd.MatKhau == matKhau);
            }
        }
        public void Naptien(string taiKhoan, decimal soTien)
        {
            using (var db = new QuanLyNetDbContext())
            {
                var nguoiDung = db.NguoiDungs.FirstOrDefault(nd => nd.TaiKhoan == taiKhoan);
                if (nguoiDung != null)
                {
                    nguoiDung.SoDu += soTien;
                    db.SaveChanges();
                }
            }
        }
        public void Trutien(string taikhoan, decimal soTien)
        {
            using (var db = new QuanLyNetDbContext())
            {
                var nguoiDung = db.NguoiDungs.FirstOrDefault(nd => nd.TaiKhoan == taikhoan);
                if (nguoiDung != null)
                {
                    nguoiDung.SoDu -= soTien;
                    db.SaveChanges();
                }
            }
        }
    }
}
