using System;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using QLBH_UNIQLO.Properties;
using QLBH_UNIQLO.BUS;
using QLBH_UNIQLO.DTO;
using QLBH_UNIQLO.Shared;

namespace QLBH_UNIQLO
{
    public partial class frmDangNhap : Form
    {
        char passwordChar = '*';
        DangNhapBUS dangNhapBUS = new DangNhapBUS();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = passwordChar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            // ✅ Lối tắt: nếu chỉ nhập "admin", bỏ qua kiểm tra DB
            if (username == "admin")
            {
                dangNhapBUS.DangNhap("hoangquocdat@uniqlo.vn", "matkhau123");
                Session.MaNhanVien = 5; // hoặc gán ID admin thật
                Session.TenNhanVien = "Hoàng Quốc Đạt";
                Session.MaBoPhan = 3;

                MessageBox.Show("Đăng nhập nhanh với quyền quản lý!");

                this.Hide();
                new frmTrangChu().Show();
                return;
            }

            var nhanVien = dangNhapBUS.DangNhap(username, password);

            if (nhanVien != null)
            {
                MessageBox.Show($"{(nhanVien.MaBoPhan == 3 ? "Quản lý" : "Nhân viên")} đăng nhập thành công!");

                Session.MaNhanVien = nhanVien.MaNhanVien;
                Session.TenNhanVien= nhanVien.TenNhanVien;
                Session.MaBoPhan = nhanVien.MaBoPhan;
                this.Hide();

                Form main;
                main = new frmTrangChu();
                main.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXemMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = (txtMatKhau.PasswordChar == passwordChar) ? new char() : passwordChar;
            btnXemMatKhau.Image = (txtMatKhau.PasswordChar == passwordChar)
                ? Properties.Resources.eye_close16x16
                : Properties.Resources.eye_open16x16;
        }
    }
}
