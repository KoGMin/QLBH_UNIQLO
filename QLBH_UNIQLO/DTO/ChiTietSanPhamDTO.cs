using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.DTO
{
    public class ChiTietSanPhamDTO
    {
        public int MaCTSanPham { get; set; }
        public string KichThuoc { get; set; }
        public string MauSac { get; set; }
        public int LuongHang { get; set; }
        public float GiaTien { get; set; }
        public int MaSanPham { get; set; }

        public string DisplayText { get; set; }
    }
}
