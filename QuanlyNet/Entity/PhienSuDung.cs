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
        public int MaPhien { get; set; }

        [Required]
        public int MaNguoiDung { get; set; }

        [Required]
        public int MaMay { get; set; }  

        public DateTime GioBatDau { get; set; }
        public DateTime? GioKetThuc { get; set; }
        public decimal DonGiaTheoGio { get; set; }
        public decimal ThanhTien { get; set; }
        public bool TrangThai { get; set; }

        [ForeignKey("MaNguoiDung")]
        public virtual NguoiDung NguoiDung { get; set; }

        [ForeignKey("MaMay")]
        public virtual MayTinh MayTinh { get; set; }
    }
}
