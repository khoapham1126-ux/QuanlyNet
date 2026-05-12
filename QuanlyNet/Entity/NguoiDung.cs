using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNet.Entity
{
    public class NguoiDung
    {
        [Key]
        public string MaNguoiDung { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string TaiKhoan { get; set; }
        public decimal SoDu { get; set; }
    }
}
