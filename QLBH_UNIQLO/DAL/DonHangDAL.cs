using QLBH_UNIQLO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.DAL
{
    public class DonHangDAL
    {
        public static int LayMaDonHangMoiNhat()
        {
            string sql = "SELECT ISNULL(MAX(MaDonHang), 0) + 1 FROM DonHang";
            return (int)DBConnect.ExecuteScalar(sql);
        }

        public static void ThemDonHang(DonHangDTO donHang)
        {
            string sql = @"INSERT INTO DonHang (MaDonHang, NgayTao, TrangThaiDonHang, TienHang, ThueVAT, MaKhachHang, MaThanhToan, MaNhanVien)
                           VALUES (@MaDonHang, @NgayTao, @TrangThai, @TienHang, @ThueVAT, @MaKhachHang, NULL, @MaNhanVien)";
            SqlParameter[] parameters = {
                new SqlParameter("@MaDonHang", donHang.MaDonHang),
                new SqlParameter("@NgayTao", donHang.NgayTao),
                new SqlParameter("@TrangThai", donHang.TrangThaiDonHang),
                new SqlParameter("@TienHang", donHang.TienHang),
                new SqlParameter("@ThueVAT", donHang.ThueVAT),
                new SqlParameter("@MaKhachHang", donHang.MaKhachHang),
                new SqlParameter("@MaNhanVien", donHang.MaNhanVien)
            };
            DBConnect.ExecuteNonQuery(sql, parameters);
        }

        public static void CapNhatThanhToanVaTrangThai(int maDonHang, int maThanhToan)
        {
            string sql = "UPDATE DonHang SET MaThanhToan = @MaThanhToan, TrangThaiDonHang = N'Đã thanh toán' WHERE MaDonHang = @MaDonHang";
            SqlParameter[] parameters = {
                new SqlParameter("@MaThanhToan", maThanhToan),
                new SqlParameter("@MaDonHang", maDonHang)
            };
            DBConnect.ExecuteNonQuery(sql, parameters);
        }

        public int GetNextMaDonHang()
        {
            string query = "SELECT ISNULL(MAX(MaDonHang), 0) + 1 FROM DonHang";
            using (var con = DBConnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                return (int)cmd.ExecuteScalar();
            }
        }


        public static DataTable GetDanhSachDonHang()
        {
            string query = "SELECT MaDonHang FROM DonHang";
            return DBConnect.ExecuteQuery(query);
        }

        public static int GetMaKhachHang(int maDonHang)
        {
            string query = "SELECT MaKhachHang FROM DonHang WHERE MaDonHang = @MaDon";
            using (var conn = DBConnect.Connect())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaDon", maDonHang);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static DataTable GetThongTinDonHang(int maDonHang)
        {
            string query = @"SELECT d.MaDonHang, d.NgayTao, k.TenKhachHang, d.TrangThaiDonHang
                             FROM DonHang d
                             JOIN KhachHang k ON d.MaKhachHang = k.MaKhachHang
                             WHERE d.MaDonHang = @MaDon";
            using (var conn = DBConnect.Connect())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaDon", maDonHang);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }


        }

        public static DataTable GetChiTietSanPhamTheoDon(int maDonHang)
        {
            string query = @"
            SELECT 
            ct.MaCTSanPham,
            CONCAT(
                sp.TenSanPham, ' - ', ct.MauSac, ' - ', ct.KichThuoc, 
                ' (SL: ', ctdh.SoLuong, ')',
                CASE 
                    WHEN EXISTS (
                        SELECT 1 
                        FROM ChiTietDoiTra dt
                        JOIN YeuCauDoiTra yc ON dt.MaYeuCau = yc.MaYeuCau
                        WHERE dt.MaCTSanPham = ct.MaCTSanPham
                          AND yc.MaDonHang = @MaDon
                          AND yc.TrangThai = N'Trả hàng'
                    ) THEN N' [Đã trả hàng]'
                    ELSE ''
                END,
                CASE 
                    WHEN EXISTS (
                        SELECT 1 
                        FROM ChiTietDoiTra dt
                        JOIN YeuCauDoiTra yc ON dt.MaYeuCau = yc.MaYeuCau
                        WHERE dt.MaCTSanPham = ct.MaCTSanPham
                          AND yc.MaDonHang = @MaDon
                          AND yc.TrangThai = N'Đổi hàng'
                    ) THEN N' [Đã đổi hàng]'
                    ELSE ''
                END
            ) AS DisplayText,
            ctdh.SoLuong
        FROM ChiTietDonHang ctdh
        JOIN ChiTietSanPham ct ON ct.MaCTSanPham = ctdh.MaCTSanPham
        JOIN SanPham sp ON sp.MaSanPham = ct.MaSanPham
        WHERE ctdh.MaDonHang = @MaDon";

            using (var conn = DBConnect.Connect())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaDon", maDonHang);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void CapNhatTrangThaiDon(int maDon, string trangThai)
        {
            string query = "UPDATE DonHang SET TrangThaiDonHang = @TrangThai WHERE MaDonHang = @MaDon";
            SqlParameter[] prms = {
        new SqlParameter("@TrangThai", trangThai),
        new SqlParameter("@MaDon", maDon)
    };
            DBConnect.ExecuteNonQuery(query, prms);
        }

        public static DataTable GetDonHangChuaXuLyHoacDaThanhToan()
        {
            string query = @"
                SELECT MaDonHang, MaNhanVien, MaKhachHang, TrangThaiDonHang,
                       NgayTao = CONVERT(NVARCHAR(10), NgayTao, 103)
                FROM DonHang
                WHERE TrangThaiDonHang = N'Chờ xử lý' OR TrangThaiDonHang = N'Đã thanh toán'
                ORDER BY MaDonHang DESC";
            return DBConnect.ExecuteQuery(query);
        }

        public static DataTable GetChiTietDonHang(int maDon)
        {
            string query = @"
                SELECT ct.MaCTSanPham, sp.TenSanPham, ct.KichThuoc, ct.MauSac, ctdh.SoLuong
                FROM ChiTietDonHang ctdh
                JOIN ChiTietSanPham ct ON ctdh.MaCTSanPham = ct.MaCTSanPham
                JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham
                WHERE ctdh.MaDonHang = @MaDon";

            SqlParameter[] prms = { new SqlParameter("@MaDon", maDon) };
            return DBConnect.ExecuteQuery(query, prms);
        }

        public static void CapNhatTrangThaiDonHang(int maDon, string trangThai)
        {
            string query = "UPDATE DonHang SET TrangThaiDonHang = @TT WHERE MaDonHang = @Ma";
            SqlParameter[] prms = {
                new SqlParameter("@TT", trangThai),
                new SqlParameter("@Ma", maDon)
            };
            DBConnect.ExecuteNonQuery(query, prms);
        }


    }
}