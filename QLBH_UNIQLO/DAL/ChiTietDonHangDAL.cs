using QLBH_UNIQLO.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLBH_UNIQLO.DAL
{
    public class ChiTietDonHangDAL
    {
        public static void ThemChiTietDonHang(int maDonHang, int maCTSanPham, int soLuong)
        {
            string query = @"INSERT INTO ChiTietDonHang (MaDonHang, MaCTSanPham, SoLuong)
                     VALUES (@MaDH, @MaCTSP, @SoLuong)";

            using (var conn = DBConnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDH", maDonHang);
                cmd.Parameters.AddWithValue("@MaCTSP", maCTSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.ExecuteNonQuery();
            }
        }

        
    }
}