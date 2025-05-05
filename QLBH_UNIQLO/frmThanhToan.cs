using QLBH_UNIQLO.BUS;
using QLBH_UNIQLO.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLBH_UNIQLO
{
    public partial class frmThanhToan : Form
    {
        private readonly int _maDonHang;
        private readonly float _tongTien;
        private readonly ThanhToanBUS thanhToanBUS = new ThanhToanBUS();
        private readonly BanHangBUS banHangBUS = new BanHangBUS();

        public frmThanhToan(float thanhTien, float tongTien, int maDonHang)
        {
            InitializeComponent();
            _maDonHang = maDonHang;
            _tongTien = tongTien;
            
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = _tongTien.ToString("N0");
            cbPTTT.Items.AddRange(new string[] { "Tiền mặt", "Chuyển khoản", "Ví điện tử" });
            cbPTTT.SelectedIndex = 0;
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtTienNhan.Text, out float tienNhan))
            {
                float tienThoi = tienNhan - _tongTien;
                txtTienThoi.Text = (tienThoi >= 0 ? tienThoi : 0).ToString("N0");
            }
            else
            {
                txtTienThoi.Text = "";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbPTTT.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán.");
                return;
            }

            if (cbPTTT.SelectedItem.ToString() == "Tiền mặt")
            {
                if (!float.TryParse(txtTienNhan.Text, out float tienNhan) || tienNhan < _tongTien)
                {
                    MessageBox.Show("Số tiền khách đưa không hợp lệ.");
                    return;
                }
            }

            string phuongThuc = cbPTTT.SelectedItem.ToString();
            int maThanhToan = thanhToanBUS.ThanhToan(_tongTien, phuongThuc);

            banHangBUS.CapNhatTrangThaiSauThanhToan(_maDonHang, maThanhToan);

            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (this.Owner is frmBanHang2 banHangForm)
            {
                banHangForm.CapNhatSauKhiThanhToan();
            }
            this.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPTTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPTTT.SelectedItem.ToString() == "Tiền mặt")
            {
                lblTienNhan.Text = "Tiền khách đưa:";
                lblTienThoi.Text = "Tiền thối:";
            }
            else if(cbPTTT.SelectedItem.ToString() == "Chuyển khoản")
            {
                txtTienNhan.Text = "7291000289314";
                txtTienThoi.Text = "BIDV";
                lblTienNhan.Text = "STK:";
                lblTienThoi.Text = "Ngân hàng:";
                lblTienThoi.Visible = true;
                txtTienThoi.Visible = true;
            }
             else
            {
                lblTienNhan.Text = "SDT:";
                txtTienNhan.Text = "0328214102";
                lblTienThoi.Visible= false;
                txtTienThoi.Visible = false;
            }
            

            
        }
    }
}
