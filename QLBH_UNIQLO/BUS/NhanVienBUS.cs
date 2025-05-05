using QLBH_UNIQLO.DAL;
using QLBH_UNIQLO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_UNIQLO.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL dal = new NhanVienDAL();

        public List<NhanVienDTO> GetAll()
        {
            return dal.GetAll();
        }

        public void Them(NhanVienDTO nv)
        {
            dal.Insert(nv);
        }

        public void Sua(NhanVienDTO nv)
        {
            dal.Update(nv);
        }

        public void Xoa(int maNV)
        {
            dal.Delete(maNV);
        }

        public int getNextMaNhanVien()
        {
            return dal.GetNextMaNhanVien();
        }
    }
    }
