using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.DTO
{
    public class NhanVienDTO
    {
        

        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public int MaBoPhan { get; set; }
    }
}
