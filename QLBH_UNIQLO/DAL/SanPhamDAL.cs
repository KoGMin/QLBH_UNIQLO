
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_UNIQLO.DTO;

namespace QLBH_UNIQLO.DAL
{
    public static class SanPhamDAL
    {
        public static int InsertSanPham(SanPhamDTO sp)
        {
            string query = @"INSERT INTO SanPham (TenSanPham, MoTa, MaLoaiSanPham)
                             OUTPUT INSERTED.MaSanPham
                             VALUES (@Ten, @MoTa, @Loai)";

            SqlParameter[] prms = new SqlParameter[]
            {
                new SqlParameter("@Ten", sp.TenSanPham),
                new SqlParameter("@MoTa", sp.MoTa),
                new SqlParameter("@Loai", sp.MaLoaiSanPham)
            };

            return (int)DBConnect.ExecuteScalar(query, prms);
        }

        public static DataTable GetAllSanPhamWithChiTiet()
        {
            string query = @"SELECT sp.MaSanPham, sp.TenSanPham, sp.MoTa, ct.MaCTSanPham,
                                    ct.KichThuoc, ct.MauSac, ct.LuongHang, ct.GiaTien
                             FROM SanPham sp
                             JOIN ChiTietSanPham ct ON sp.MaSanPham = ct.MaSanPham";
            return DBConnect.ExecuteQuery(query);
        }

        public static int GetNextMaSanPham()
        {
            string query = "SELECT ISNULL(MAX(MaSanPham), 0) + 1 FROM SanPham";
            return (int)DBConnect.ExecuteScalar(query);
        }

        public static void InsertSanPhamWithId(SanPhamDTO sp)
        {
            string query = @"INSERT INTO SanPham (MaSanPham, TenSanPham, MoTa, MaLoaiSanPham)
                     VALUES (@Ma, @Ten, @MoTa, @Loai)";
            SqlParameter[] prms = {
        new SqlParameter("@Ma", sp.MaSanPham),
        new SqlParameter("@Ten", sp.TenSanPham),
        new SqlParameter("@MoTa", sp.MoTa),
        new SqlParameter("@Loai", sp.MaLoaiSanPham)
    };
            DBConnect.ExecuteNonQuery(query, prms);
        }
    }
}
