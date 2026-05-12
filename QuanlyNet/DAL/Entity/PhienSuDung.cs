using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanlyNet.DAL.Entity
{
    public class PhienSuDung
    {
        [Key]
        [StringLength(20)]
        public string MaPhien { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNguoiDung { get; set; }

        [Required]
        [StringLength(20)]
        public string MaMay { get; set; }

        [Required]
        public DateTime GioBatDau { get; set; }

        public DateTime? GioKetThuc { get; set; }

        [Column(TypeName = "decimal")]
        public decimal DonGiaTheoGio { get; set; }

        [Column(TypeName = "decimal")]
        public decimal ThanhTien { get; set; }

        public bool TrangThai { get; set; }
    }
}
