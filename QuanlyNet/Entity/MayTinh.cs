using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNet.Entity
{
    public class MayTinh
    {
        [Key]
        public int MaMay { get; set; }
        public string TenMay { get; set; }
        public string TrangThaiMay { get; set; }
        public decimal DonGiaTheoGio { get; set; }
    }
}