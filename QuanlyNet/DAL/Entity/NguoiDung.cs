using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanlyNet.DAL.Entity
{
    public class NguoiDung
    {
        [Key]
        [StringLength(20)]
        public string MaNguoiDung { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(20)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [Column(TypeName = "decimal")]
        public decimal SoDu { get; set; }
    }
}
