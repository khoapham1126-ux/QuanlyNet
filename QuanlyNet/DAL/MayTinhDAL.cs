using QuanlyNet.VIEW;
using QuanLyNet.DAL.DBContext;
using QuanLyNet.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyNet.DAL
{
    public class MayTinhDAL
    {
        public List<MayTinh> GetAll()
        {
            using (var db = new QuanLyNetDbContext())
            {
                return db.MayTinhs.ToList();
            }
        }
        public MayTinh getByID(int id)
        {
            using (var db = new QuanLyNetDbContext())
            {
                return db.MayTinhs.Find(id);
            }
        }
        public void Add(MayTinh maytinh)
        {
            using (var db = new QuanLyNetDbContext())
            {
                db.MayTinhs.Add(maytinh);
                db.SaveChanges();
            }
        }
        public void Update(MayTinh maytinh)
        {
            using(var db = new QuanLyNetDbContext())
            {
                var exist = db.MayTinhs.Find(maytinh.MaMay);
                if (exist != null)
                {
                    exist.MaMay = maytinh.MaMay;
                    exist.TenMay = maytinh.TenMay;
                    exist.TrangThaiMay = maytinh.TrangThaiMay;
                    exist.DonGiaTheoGio = maytinh.DonGiaTheoGio;
                    db.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (var db = new QuanLyNetDbContext())
            {
                var maytinh = db.MayTinhs.Find(id);
                if(maytinh != null)
                {
                    db.MayTinhs.Remove(maytinh);
                    db.SaveChanges();
                }
            }
        }
        public void NapTien(decimal soTien,int maMay)
        {
            using(var db = new QuanLyNetDbContext())
            {
                var maytinh = db.MayTinhs.Find(maMay);
                if(maytinh != null)
                {
                    maytinh.DonGiaTheoGio += soTien;
                    db.SaveChanges();
                }
            }
        }
    }
}
