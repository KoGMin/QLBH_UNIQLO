using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_UNIQLO.DTO;



namespace QLBH_UNIQLO.DAL
{
    public class ChiTietSanPhamDAL
    {
        public static void TruHangTon(int maCTSanPham, int soLuong)
        {
            string sql = "UPDATE ChiTietSanPham SET LuongHang = LuongHang - @SoLuong WHERE MaCTSanPham = @MaCTSP";
            SqlParameter[] parameters = {
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@MaCTSP", maCTSanPham)
            };
            DBConnect.ExecuteNonQuery(sql, parameters);
        }

        public static List<ChiTietSanPhamDTO> GetDanhSachChiTietSPWithFormat()
        {
            var list = new List<ChiTietSanPhamDTO>();
            string query = @"SELECT ct.MaCTSanPham, sp.TenSanPham, ct.KichThuoc, ct.MauSac, ct.GiaTien
                             FROM ChiTietSanPham ct
                             JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham";
            using (var con = DBConnect.Connect())
            {   
                
                SqlCommand cmd = new SqlCommand(query, con);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ChiTietSanPhamDTO
                        {
                            MaCTSanPham = (int)reader["MaCTSanPham"],
                            DisplayText = $"{reader["TenSanPham"]} - {reader["MauSac"]} - {reader["KichThuoc"]}",
                            GiaTien = (float)(double)reader["GiaTien"]
                        });
                    }
                }
            }
            return list;
        }


        public ChiTietSanPhamDTO GetChiTietSanPhamById(int maCTSP)
        {
            string query = @"SELECT ct.MaCTSanPham, sp.TenSanPham, ct.KichThuoc, ct.MauSac, ct.GiaTien, ct.LuongHang 
                             FROM ChiTietSanPham ct
                             JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham
                             WHERE MaCTSanPham = @id";
            using (var con = DBConnect.Connect())
            {
                
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", maCTSP);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ChiTietSanPhamDTO
                        {
                            MaCTSanPham = (int)reader["MaCTSanPham"],
                            DisplayText = $"{reader["TenSanPham"]} - {reader["MauSac"]} - {reader["KichThuoc"]}",
                            LuongHang = (int)reader["LuongHang"],
                            GiaTien = (float)(double)reader["GiaTien"]
                        };
                    }
                }
            }
            return null;
        }

        public static void CapNhatTonKho(int maCT, int slThayDoi)
        {
            string query = "UPDATE ChiTietSanPham SET LuongHang = LuongHang + @SL WHERE MaCTSanPham = @MaCT";
            SqlParameter[] prms = {
                new SqlParameter("@SL", slThayDoi),
                new SqlParameter("@MaCT", maCT)
            };
            DBConnect.ExecuteNonQuery(query, prms);
        }


        public static void InsertChiTiet(ChiTietSanPhamDTO ct)
        {
            string query = @"INSERT INTO ChiTietSanPham (KichThuoc, MauSac, LuongHang, GiaTien, MaSanPham)
                             VALUES (@Size, @Mau, @SL, @Gia, @MaSP)";
            SqlParameter[] prms = {
                new SqlParameter("@Size", ct.KichThuoc),
                new SqlParameter("@Mau", ct.MauSac),
                new SqlParameter("@SL", ct.LuongHang),
                new SqlParameter("@Gia", ct.GiaTien),
                new SqlParameter("@MaSP", ct.MaSanPham)
            };

            DBConnect.ExecuteNonQuery(query, prms);
        }

        public static void UpdateChiTiet(ChiTietSanPhamDTO ct)
        {
            string query = @"UPDATE ChiTietSanPham
                             SET KichThuoc = @Size, MauSac = @Mau, LuongHang = @SL, GiaTien = @Gia
                             WHERE MaCTSanPham = @MaCT";
            SqlParameter[] prms = {
                new SqlParameter("@Size", ct.KichThuoc),
                new SqlParameter("@Mau", ct.MauSac),
                new SqlParameter("@SL", ct.LuongHang),
                new SqlParameter("@Gia", ct.GiaTien),
                new SqlParameter("@MaCT", ct.MaCTSanPham)
            };

            DBConnect.ExecuteNonQuery(query, prms);
        }

        public static void DeleteChiTiet(int maCT)
        {
            string query = "DELETE FROM ChiTietSanPham WHERE MaCTSanPham = @ma";
            SqlParameter[] prms = {
                new SqlParameter("@ma", maCT)
            };

            DBConnect.ExecuteNonQuery(query, prms);
        }

        public static int GetNextMaChiTietSanPham()
        {
            string query = "SELECT ISNULL(MAX(MaCTSanPham), 0) + 1 FROM ChiTietSanPham";
            return (int)DBConnect.ExecuteScalar(query);
        }

        public static void InsertChiTietWithId(ChiTietSanPhamDTO ct)
        {
            string query = @"INSERT INTO ChiTietSanPham (MaCTSanPham, KichThuoc, MauSac, LuongHang, GiaTien, MaSanPham)
                     VALUES (@MaCT, @Size, @Mau, @SL, @Gia, @MaSP)";
            SqlParameter[] prms = {
        new SqlParameter("@MaCT", ct.MaCTSanPham),
        new SqlParameter("@Size", ct.KichThuoc),
        new SqlParameter("@Mau", ct.MauSac),
        new SqlParameter("@SL", ct.LuongHang),
        new SqlParameter("@Gia", ct.GiaTien),
        new SqlParameter("@MaSP", ct.MaSanPham)
    };
            DBConnect.ExecuteNonQuery(query, prms);
        }
    }
}