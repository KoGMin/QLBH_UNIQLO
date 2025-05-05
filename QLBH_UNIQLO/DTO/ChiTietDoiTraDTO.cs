using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.DTO
{
    public class ChiTietDoiTraDTO
    {
        public int MaYeuCau { get; set; }
        public int MaCTSanPham { get; set; }
        public int SoLuong { get; set; }
        public string TrangThaiSanPham { get; set; } // "Trả hàng" hoặc "Đổi hàng"
    }
}
