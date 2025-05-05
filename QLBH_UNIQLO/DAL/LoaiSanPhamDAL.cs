using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.DAL
{
    public class LoaiSanPhamDAL
    {
        public static DataTable GetAll()
        {
            string query = "SELECT MaLoaiSanPham, TenLoaiSanPham FROM LoaiSanPham";
            return DBConnect.ExecuteQuery(query);
        }
    }
}
