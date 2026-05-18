using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNet.Entity;
using QuanLyNet.DAL;

namespace QuanlyNet.BLL
{
    internal class PhienSuDungBLL
    {
        private readonly PhienSuDungDAL dal = new PhienSuDungDAL();
        public List<PhienSuDung> GetAll()
        {
            return dal.GetAll();
        }
        public void BatDauPhien(int maND, int maMay, decimal donGiaTheoGio)
        {
            var phien = new PhienSuDung
            {
                MaNguoiDung = maND,
                MaMay = maMay,
                DonGiaTheoGio = donGiaTheoGio
            };
            dal.BatDauPhien(phien);
        }
        public void KetThucPhien(int maPhien)
        {
            dal.KetThucPhien(maPhien);
        }
    }
}
