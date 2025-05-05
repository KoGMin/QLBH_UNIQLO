using QLBH_UNIQLO.DAL;
using QLBH_UNIQLO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAL dal = new KhachHangDAL();

        public List<KhachHangDTO> GetAll()
        {
            return dal.GetAll();
        }

        public void Them(KhachHangDTO kh)
        {
           dal.Insert(kh);
            
        }

        public void Sua(KhachHangDTO kh)
        {
            dal.Update(kh);    }

        public void  Xoa(int maKH)
        {
            dal.Delete(maKH);
        }

        public int getNextMaKhachHang()
        {
            return dal.GetNextMaKhachHang();
        }
    }
}
