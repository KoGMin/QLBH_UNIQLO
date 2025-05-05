using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_UNIQLO.DAL;
using QLBH_UNIQLO.DTO;

namespace QLBH_UNIQLO.BUS
{
    public class BanHangBUS
    {
        public int TaoDonHang(DonHangDTO donHang, List<ChiTietDonHangDTO> chiTietList)
        {
            int maDonHang = DonHangDAL.LayMaDonHangMoiNhat();
            donHang.MaDonHang = maDonHang;

            DonHangDAL.ThemDonHang(donHang);

            /*foreach (var ct in chiTietList)
            {
                ct.MaDonHang = maDonHang;
                ChiTietDonHangDAL.ThemChiTiet(ct);
            }*/

            return maDonHang;
        }

        public void CapNhatTrangThaiSauThanhToan(int maDonHang, int maThanhToan)
        {
            DonHangDAL.CapNhatThanhToanVaTrangThai(maDonHang, maThanhToan);

           
        }
    }
}
