using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.DTO
{
    public class YeuCauDoiTraDTO
    {
        public int MaYeuCau { get; set; }
        public DateTime NgayTao { get; set; }
        public string LyDo { get; set; }
        public string TrangThai { get; set; }
        public int MaKhachHang { get; set; }
        public int MaDonHang { get; set; }
    }
}
