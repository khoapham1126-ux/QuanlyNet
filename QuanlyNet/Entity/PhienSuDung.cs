using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNet.Entity
{
    public class PhienSuDung
    {
        [Key]
        [StringLength(20)]
        public string MaPhien { get; set; }

        [StringLength(20)]
        public string MaNguoiDung { get; set; }

        [StringLength(20)]
        public string MaMay { get; set; }

        public DateTime GioBatDau { get; set; }
        public DateTime? GioKetThuc { get; set; }
        public decimal DonGiaTheoGio { get; set; }
        public decimal ThanhTien { get; set; }
        public bool TrangThai { get; set; }
    }
}
