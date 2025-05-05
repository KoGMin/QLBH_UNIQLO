using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLBH_UNIQLO.DTO;

namespace QLBH_UNIQLO.DAL
{
    public class KhachHangDAL
    {
        public KhachHangDTO GetKhachHangBySDTEmail(string sdtemail)
        {
            string query = "SELECT * FROM KhachHang WHERE SDT = @sdtemail or Email = @sdtemail";
            using (var con = DBConnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@sdtemail", sdtemail);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new KhachHangDTO
                        {
                            MaKhachHang = (int)reader["MaKhachHang"],
                            TenKhachHang = reader["TenKhachHang"].ToString(),
                            Email = reader["Email"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public int ThemKhachHang(KhachHangDTO kh)
        {
            string query = @"INSERT INTO KhachHang (TenKhachHang, Email, DiaChi, SDT, GioiTinh) 
                             OUTPUT INSERTED.MaKhachHang
                             VALUES (@TenKhachHang, @Email, @DiaChi, @SDT, @GioiTinh)";
            using (var con = DBConnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@Email", kh.Email ?? "");
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi ?? "");
                cmd.Parameters.AddWithValue("@SDT", kh.SDT ?? "");
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh ?? "Khác");

                return (int)cmd.ExecuteScalar();
            }
        }

        public int GetNextMaKhachHang()
        {
            string query = "SELECT ISNULL(MAX(MaKhachHang), 0) + 1 FROM KhachHang";
            using (var con = DBConnect.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                return (int)cmd.ExecuteScalar();
            }
        }

        public List<KhachHangDTO> GetAll()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            string query = "SELECT * FROM KhachHang";

            using (var con = DBConnect.Connect())
            using (var cmd = new SqlCommand(query, con))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new KhachHangDTO
                    {
                        MaKhachHang = Convert.ToInt32(reader["MaKhachHang"]),
                        TenKhachHang = reader["TenKhachHang"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        Email = reader["Email"].ToString()
                    });
                }
            }
            return list;
        }

        public void Insert(KhachHangDTO kh)
        {
            string query = @"INSERT INTO KhachHang (MaKhachHang,TenKhachHang, DiaChi, GioiTinh, SDT, Email)
                             VALUES (@MaKH,@Ten, @DiaChi, @GioiTinh, @SDT, @Email)";
            SqlParameter[] prms = {
                new SqlParameter("@MaKH",kh.MaKhachHang),
                new SqlParameter("@Ten", kh.TenKhachHang),
                new SqlParameter("@DiaChi", kh.DiaChi),
                new SqlParameter("@GioiTinh", kh.GioiTinh),
                new SqlParameter("@SDT", kh.SDT),
                new SqlParameter("@Email", kh.Email)
            };

             DBConnect.ExecuteNonQuery(query, prms);
        }

        public void Update(KhachHangDTO kh)
        {
            string query = @"UPDATE KhachHang SET TenKhachHang=@Ten, DiaChi=@DiaChi, GioiTinh=@GioiTinh,
                             SDT=@SDT, Email=@Email WHERE MaKhachHang=@Ma";
            SqlParameter[] prms = {
                new SqlParameter("@Ten", kh.TenKhachHang),
                new SqlParameter("@DiaChi", kh.DiaChi),
                new SqlParameter("@GioiTinh", kh.GioiTinh),
                new SqlParameter("@SDT", kh.SDT),
                new SqlParameter("@Email", kh.Email),
                new SqlParameter("@Ma", kh.MaKhachHang)
            };

            DBConnect.ExecuteNonQuery(query, prms);
        }

        public void Delete(int ma)
        {
            string query = "DELETE FROM KhachHang WHERE MaKhachHang = @Ma";
            SqlParameter[] prms = { new SqlParameter("@Ma", ma) };
            DBConnect.ExecuteNonQuery(query, prms);
        }


    }
}
