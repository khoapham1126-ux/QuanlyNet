using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuanlyNet.DAL.Entity
{
    public class MayTinh
    {
        [Key]
        [StringLength(20)]
        public string MaMay { get; set; }

        [Required]
        [StringLength(100)]
        public string TenMay { get; set; }

        [Required]
        [StringLength(50)]
        public string TrangThaiMay { get; set; }

        [Column(TypeName = "decimal")]
        public decimal DonGiaTheoGio { get; set; }
    }
}
