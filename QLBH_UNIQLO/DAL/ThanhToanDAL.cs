using QLBH_UNIQLO.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.DAL
{
    public class ThanhToanDAL
    {
        public static int ThemThanhToan(ThanhToanDTO thanhToan)
        {
            int maMoi = GetNextMaThanhToan();

            string query = @"INSERT INTO ThanhToan (MaThanhToan, NgayThanhToan, TienThanhToan, PhuongThucThanhToan)
                     VALUES (@Ma, @Ngay, @Tien, @PhuongThuc)";

            using (var con = DBConnect.Connect())
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Ma", maMoi);
                cmd.Parameters.AddWithValue("@Ngay", thanhToan.NgayThanhToan);
                cmd.Parameters.AddWithValue("@Tien", thanhToan.TienThanhToan);
                cmd.Parameters.AddWithValue("@PhuongThuc", thanhToan.PhuongThucThanhToan);
                cmd.ExecuteNonQuery();
            }

            return maMoi;
        }

        public static int GetNextMaThanhToan()
        {
            string query = "SELECT ISNULL(MAX(MaThanhToan), 0) + 1 FROM ThanhToan";
            using (var con = DBConnect.Connect())
            using (var cmd = new SqlCommand(query, con))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}