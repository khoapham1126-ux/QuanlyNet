using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNet.Entity;
using QuanLyNet.DAL;


namespace QuanlyNet.BLL
{
    internal class NguoiDungBLL
    {
        private readonly NguoiDungDAL dal = new NguoiDungDAL();
        public List<NguoiDung> GetAll()
        {
            return dal.GetAll();
        }
        public NguoiDung DangNhap(string taiKhoan, string matKhau)
        {
            return dal.DangNhap(taiKhoan, matKhau);
        }
        public void Add(NguoiDung nd)
        {
            dal.Add(nd);
        }
        public void Update(NguoiDung nd)
        {
            dal.Update(nd);
        }
        public void Delete(int id)
        {
            dal.Delete(id);
        }
        public void NapTien (string taiKhoan, decimal soTien)
        {
            dal.Naptien(taiKhoan, soTien);
        }

        public void TruTien(string taiKhoan, decimal soTien)
        {
            dal.Trutien(taiKhoan, soTien);
        }
    }
}
