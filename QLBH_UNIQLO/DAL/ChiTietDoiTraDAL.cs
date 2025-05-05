using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.DAL
{
    public class ChiTietDoiTraDAL
    {
        public static void ThemChiTiet(int maYeuCau, int maCT, int soLuong, string moTa)
        {
            string query = @"INSERT INTO ChiTietDoiTra (MaYeuCau, MaCTSanPham, SoLuong, TrangThaiSanPham)
                     VALUES (@MaYC, @MaCT, @SL, @TT)";
            SqlParameter[] prms = {
        new SqlParameter("@MaYC", maYeuCau),
        new SqlParameter("@MaCT", maCT),
        new SqlParameter("@SL", soLuong),
        new SqlParameter("@TT", moTa)
    };
            DBConnect.ExecuteNonQuery(query, prms);
        }
    }
}
