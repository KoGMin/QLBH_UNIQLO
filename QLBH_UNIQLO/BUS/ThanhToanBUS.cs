using QLBH_UNIQLO.DAL;
using QLBH_UNIQLO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QLBH_UNIQLO.BUS
{
    public class ThanhToanBUS
    {
        public int ThanhToan(float tongTien, string phuongThuc)
        {
            ThanhToanDTO thanhToan = new ThanhToanDTO
            {
                NgayThanhToan = DateTime.Now,
                TienThanhToan = tongTien,
                PhuongThucThanhToan = phuongThuc
            };

            return ThanhToanDAL.ThemThanhToan(thanhToan);
        }
    }
}
