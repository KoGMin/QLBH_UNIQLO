using QLBH_UNIQLO.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_UNIQLO
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chào " + Session.TenNhanVien.ToString();
            label2.Text = "Chức vụ:" + (Session.MaBoPhan == 1 ? "Nhân viên bán hàng" : (Session.MaBoPhan == 2? "Nhân vien kho": "Quản lý"));

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Cảnh báo", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                // Xóa session
                Session.MaNhanVien = 0;
                Session.TenNhanVien = null;
                Session.MaBoPhan = 0;

            }
            else
            return;
            
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session.MaBoPhan == 3)
            {
                frmNhanVien nhanvien = new frmNhanVien();
                nhanvien.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Đây là form dành riêng cho quản lý!");
            
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKhachHang qLMenu = new frmKhachHang(this);
            qLMenu.Show();
            this.Hide();

        }

        private void báoBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void traCứuSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void traCứuNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void kháchHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTraCuuKH frmTraCuuKH = new frmTraCuuKH(this);
            frmTraCuuKH.Show();
            this.Hide();
        }

       

        private void sảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            if (Session.MaBoPhan == 3 || Session.MaBoPhan==2)
            {
                frmSanPham frmSanPham = new frmSanPham();
                frmSanPham.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Đây là form dành riêng cho quản lý và nhân viên kho!");
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        this.Hide();
        }

        private void báoBiểuNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void tạoĐơnHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Session.MaBoPhan == 2)
            {
                MessageBox.Show("Không thuộc phạm vi sử dụng!");
                return;
            }
            else
            {
                frmBanHang2 frmBanHang = new frmBanHang2();
                frmBanHang.Show();
                this.Hide();

            }    
            
        }

        private void cậpNhậtVậnChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void báoCáoDanhSáchĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoBieuHoaDon frm = new frmBaoBieuHoaDon();
            frm.Show();
            this.Hide();
        }

        private void đơnHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTraCuuDH frm = new frmTraCuuDH(this);
            frm.Show();
            this.Hide();
        }

        private void đổiTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmDoiTraHang frm = new frmDoiTraHang();
            frm.Show();
            this.Hide();
        }

        private void xửLýĐóngGóiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonHang frm = new frmDonHang();
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
