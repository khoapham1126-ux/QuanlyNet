using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNet.Entity
{
    public class PhienSuDung
    {
        [Key]
        [StringLength(20)]
        public int MaPhien { get; set; }

        [ForeignKey("MaNguoiDung")]
        [StringLength(20)]
        public int MaNguoiDung { get; set; }

        [ForeignKey("MaMay")]
        [StringLength(20)]
        public int MaMay { get; set; }  

        public DateTime GioBatDau { get; set; }
        public DateTime? GioKetThuc { get; set; }
        public decimal DonGiaTheoGio { get; set; }
        public decimal ThanhTien { get; set; }
        public bool TrangThai { get; set; }
    }
}
