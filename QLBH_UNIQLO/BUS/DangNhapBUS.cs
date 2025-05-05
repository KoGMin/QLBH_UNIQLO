using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_UNIQLO.DTO;
using QLBH_UNIQLO.DAL;


namespace QLBH_UNIQLO.BUS
{
    public class DangNhapBUS
    {
        private NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public NhanVienDTO DangNhap(string tenDangNhap, string matKhau)
        {
            return nhanVienDAL.LayThongTinDangNhap(tenDangNhap, matKhau);
        }
    }
}