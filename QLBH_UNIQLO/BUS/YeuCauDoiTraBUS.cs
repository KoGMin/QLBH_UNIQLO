using QLBH_UNIQLO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.BUS
{
    public class YeuCauDoiTraBUS
    {
        public static int GetNextMaDoiTra()
        {
            return YeuCauDoiTraDAL.GetNextMaYeuCauDoiTra();
        }
    }
}
