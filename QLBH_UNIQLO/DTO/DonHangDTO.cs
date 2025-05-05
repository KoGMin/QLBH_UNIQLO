using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.DTO
{
    public class DonHangDTO
    {
        public int MaDonHang { get; set; }
        public DateTime NgayTao { get; set; }
        public string TrangThaiDonHang { get; set; }
        public float TienHang { get; set; }
        public float ThueVAT { get; set; }
        public int MaKhachHang { get; set; }
        public int? MaThanhToan { get; set; }  // nullable
        public int MaNhanVien { get; set; }
    }
}
