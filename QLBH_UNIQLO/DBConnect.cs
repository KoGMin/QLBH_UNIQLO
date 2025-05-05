using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBH_UNIQLO
{ 

    public static class DBConnect
    {
        private static string _StrConn = @"Server=MINHDEPTRAI\SQLEXPRESS;Database=QLBH_TCH_UNIQLO;Integrated Security=True";
        private static bool _ConnStatus;
        private static SqlConnection _Conn;
        public static string StrConn { get => _StrConn; set => _StrConn = value; }
        public static bool ConnStatus { get => _ConnStatus; set => _ConnStatus = value; }
        public static SqlConnection Conn { get => _Conn; set => _Conn = value; }

      

        public static SqlConnection Connect()
        {
           
                try
                {
                    Conn = new SqlConnection(_StrConn);                   
                    Conn.Open();
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi kết nối cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            return Conn;
        }

        public static int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(_StrConn))
            {
                conn.Open();
                SqlCommand cdm = new SqlCommand(query, conn);
                data = cdm.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }

        public static void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = Connect())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string query)
        {
            using (SqlConnection conn = Connect())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return cmd.ExecuteScalar();
            }
        }

        public static object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = Connect())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(_StrConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter laydulieu = new SqlDataAdapter(cmd);
                laydulieu.Fill(data);
                conn.Close();
            }
            return data;
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_StrConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
