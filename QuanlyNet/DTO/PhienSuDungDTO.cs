using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNet.DTO
{
    public class PhienSuDungDTO
    {
        public string MaPhien { get; set; }
        public string MaNguoiDung { get; set; }
        public string MaMay { get; set; }
        public DateTime GioBatDau { get; set; }
        public DateTime? GioKetThuc { get; set; }
        public decimal DonGiaTheoGio { get; set; }
        public decimal ThanhTien { get; set; }
        public bool TrangThai { get; set; }
    }
}
