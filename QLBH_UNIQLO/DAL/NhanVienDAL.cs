using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_UNIQLO.DTO;

namespace QLBH_UNIQLO.DAL
{
    public class NhanVienDAL
    {
        public NhanVienDTO LayThongTinDangNhap(string tenDangNhap, string matKhau)
        {
            string sql = "SELECT * FROM NhanVien WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
            using (var con = DBConnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new NhanVienDTO
                        {
                            MaNhanVien = (int)reader["MaNhanVien"],
                            TenNhanVien = reader["TenNhanVien"].ToString(),
                            TenDangNhap = reader["TenDangNhap"].ToString(),
                            MatKhau = reader["MatKhau"].ToString(),
                            MaBoPhan = (int)reader["MaBoPhan"]
                        };
                    }
                }
            }
            return null;
        }


        public List<NhanVienDTO> GetAll()
        {
            var list = new List<NhanVienDTO>();
            string query = "SELECT MaNhanVien, TenNhanVien, TenDangNhap, MatKhau, DiaChi, GioiTinh, SDT, NgaySinh, Email, MaBoPhan FROM NhanVien";

            using (var con = DBConnect.Connect())
            using (var cmd = new SqlCommand(query, con))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new NhanVienDTO
                    {
                        MaNhanVien = Convert.ToInt32(reader["MaNhanVien"]),
                        TenNhanVien = reader["TenNhanVien"].ToString(),
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        Email = reader["Email"].ToString(),
                        NgaySinh = reader["NgaySinh"] == DBNull.Value ? null : (DateTime?)reader["NgaySinh"],
                        MaBoPhan = Convert.ToInt32(reader["MaBoPhan"])
                    });
                }
            }

            return list;
        }

        public void Insert(NhanVienDTO nv)
        {
            string query = @"INSERT INTO NhanVien (MaNhanVien, TenNhanVien, TenDangNhap,MatKhau, DiaChi, GioiTinh, 
                                SDT, NgaySinh, Email, MaBoPhan)
                             VALUES (@Ma, @Ten, @User, @Pass, @DiaChi, @GT, @SDT, @NgaySinh, @Email, @BP)";
            SqlParameter[] prms = {
                new SqlParameter("@Ma", nv.MaNhanVien),
                new SqlParameter("@Ten", nv.TenNhanVien),
                new SqlParameter("@User", nv.TenDangNhap),
                new SqlParameter("@Pass",nv.MatKhau),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@GT", nv.GioiTinh),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@NgaySinh", (object)nv.NgaySinh ?? DBNull.Value),
                new SqlParameter("@Email", nv.Email),
                new SqlParameter("@BP", nv.MaBoPhan)
            };

            DBConnect.ExecuteNonQuery(query, prms);
        }

        public void Update(NhanVienDTO nv)
        {
            string query = @"UPDATE NhanVien SET TenNhanVien = @Ten, TenDangNhap = @User, MatKhau = @Pass, 
                                DiaChi = @DiaChi, GioiTinh = @GT, SDT = @SDT, NgaySinh = @NgaySinh,
                                Email = @Email, MaBoPhan = @BP
                             WHERE MaNhanVien = @Ma";
            SqlParameter[] prms = {
                new SqlParameter("@Ma", nv.MaNhanVien),
                new SqlParameter("@Ten", nv.TenNhanVien),
                new SqlParameter("@User", nv.TenDangNhap),
                new SqlParameter("@Pass",nv.MatKhau),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@GT", nv.GioiTinh),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@NgaySinh", (object)nv.NgaySinh ?? DBNull.Value),
                new SqlParameter("@Email", nv.Email),
                new SqlParameter("@BP", nv.MaBoPhan)
            };

            DBConnect.ExecuteNonQuery(query, prms);
        }

        public void Delete(int maNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNhanVien = @Ma";
            SqlParameter[] prms = { new SqlParameter("@Ma", maNV) };
            DBConnect.ExecuteNonQuery(query, prms);
        }

        public int GetNextMaNhanVien()
        {
            string query = "SELECT ISNULL(MAX(MaNhanVien), 0) + 1 FROM NhanVien";
            using (var con = DBConnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                return (int)cmd.ExecuteScalar();
            }
        }

        public static bool KiemTraMatKhau(int maNV, string matKhauCu)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @ma AND MatKhau = @mk";
            SqlParameter[] prms = {
            new SqlParameter("@ma", maNV),
            new SqlParameter("@mk", matKhauCu)
        };
            int count = (int)DBConnect.ExecuteScalar(sql, prms);
            return count > 0;
        }

        public static void CapNhatMatKhau(int maNV, string matKhauMoi)
        {
            string sql = "UPDATE NhanVien SET MatKhau = @mkMoi WHERE MaNhanVien = @ma";
            SqlParameter[] prms = {
            new SqlParameter("@ma", maNV),
            new SqlParameter("@mkMoi", matKhauMoi)
        };
            DBConnect.ExecuteNonQuery(sql, prms);
        }
    }
}
