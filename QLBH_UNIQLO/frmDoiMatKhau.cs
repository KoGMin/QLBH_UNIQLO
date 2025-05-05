using System;
using System.Windows.Forms;
using QLBH_UNIQLO.DAL; // Giả sử có NhanVienDAL để kiểm tra & cập nhật mật khẩu
using QLBH_UNIQLO.Shared;

namespace QLBH_UNIQLO
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string mkCu = txtMatKhauCu.Text;
            string mkMoi = txtMatKhauMoi.Text;
            string xacNhan = txtXacNhan.Text;

            if (string.IsNullOrEmpty(mkCu) || string.IsNullOrEmpty(mkMoi) || string.IsNullOrEmpty(xacNhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (mkMoi != xacNhan)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp.");
                return;
            }

            // Kiểm tra mật khẩu cũ đúng không (giả sử Session.MaNhanVien đang đăng nhập)
            if (!NhanVienDAL.KiemTraMatKhau(Session.MaNhanVien, mkCu))
            {
                MessageBox.Show("Mật khẩu cũ không chính xác.");
                return;
            }

            // Cập nhật mật khẩu mới
            NhanVienDAL.CapNhatMatKhau(Session.MaNhanVien, mkMoi);
            
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
