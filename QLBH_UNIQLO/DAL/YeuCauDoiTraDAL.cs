using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_UNIQLO.DTO;

namespace QLBH_UNIQLO.DAL
{
    public class YeuCauDoiTraDAL
    {
        public static void ThemYeuCau(YeuCauDoiTraDTO yc)
        {
            string query = @"INSERT INTO YeuCauDoiTra (MaYeuCau,NgayTao, LyDo, TrangThai, MaKhachHang, MaDonHang)
                      VALUES (@Mayc,@Ngay, @LyDo, @TrangThai, @MaKH, @MaDon)";
            SqlParameter[] prms = {
        new SqlParameter("@Mayc",yc.MaYeuCau),
        new SqlParameter("@Ngay", yc.NgayTao),
        new SqlParameter("@LyDo", yc.LyDo),
        new SqlParameter("@TrangThai", yc.TrangThai),
        new SqlParameter("@MaKH", yc.MaKhachHang),
        new SqlParameter("@MaDon", yc.MaDonHang)
    };
            DBConnect.ExecuteScalar(query, prms);
        }

        public static int GetNextMaYeuCauDoiTra()
        {
            string query = "SELECT ISNULL(MAX(MaYeuCau), 0) + 1 FROM YeuCauDoiTra";
            using (var con = DBConnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                return (int)cmd.ExecuteScalar();
            }
            }
    }

}
