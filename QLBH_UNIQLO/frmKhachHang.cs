using QLBH_UNIQLO;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using QLBH_UNIQLO.BUS;
using QLBH_UNIQLO.DTO;
using System.Collections.Generic;

namespace QLBH_UNIQLO
{
    public partial class frmKhachHang : Form
    {
        private Form _parent;
        private KhachHangBUS _bus = new KhachHangBUS();
        public frmKhachHang(Form parentForm)
        {
            InitializeComponent();
            LoadKhachHang();
            _parent = parentForm;
        }
        private void LoadKhachHang()
        {
            dgvKhachHang.Rows.Clear();
            List<KhachHangDTO> list = _bus.GetAll();

            foreach (var kh in list)
            {
                int i = dgvKhachHang.Rows.Add();
                DataGridViewRow row = dgvKhachHang.Rows[i];
                row.Cells["MaKhachHang"].Value = kh.MaKhachHang;
                row.Cells["TenKhachHang"].Value = kh.TenKhachHang;
                row.Cells["DiaChi"].Value = kh.DiaChi;
                row.Cells["GioiTinh"].Value = kh.GioiTinh;
                row.Cells["SDT"].Value = kh.SDT;
                row.Cells["Email"].Value = kh.Email;
            }
        }

        private void btnDongKH_Click(object sender, EventArgs e)
        {
        
            _parent.Show();
            Hide();
        }
        private void XoaRong()
        {
            
            txtMaKH.Clear();
            txtHoTenKH.Clear();
            txtDiaChi.Clear();
            txtSDTKH.Clear();
            rdNam.Checked = true;
            txtEmailKH.Clear();
            txtMaKH.Focus();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnNhapLaiKH_Click(object sender, EventArgs e)
        {
            XoaRong();
        }
        private KhachHangDTO LayThongTinKH()
        {
            return new KhachHangDTO
            {
                MaKhachHang = string.IsNullOrEmpty(txtMaKH.Text) ? _bus.getNextMaKhachHang() : int.Parse(txtMaKH.Text),
                TenKhachHang = txtHoTenKH.Text,
                DiaChi = txtDiaChi.Text,
                GioiTinh = rdNam.Checked ? "Nam" : "Nữ",
                SDT = txtSDTKH.Text,
                Email = txtEmailKH.Text
            };
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string errorMsg = "";

            string hoTen = txtHoTenKH.Text.Trim();
            string email = txtEmailKH.Text.Trim();
            string sdt = txtSDTKH.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                errorMsg += "- Vui lòng nhập tên khách hàng\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(sdt))
            {
                errorMsg += "- Phải nhập ít nhất 1 trong 2: Email hoặc Số điện thoại\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Dữ liệu không hợp lệ:\n" + errorMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var kh = LayThongTinKH();
            try
            {
                _bus.Them(kh);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
                XoaRong();
                
                
            }
            catch (Exception exception)
            {
                if (exception.HResult == -2146232060)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(exception.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            var kh = LayThongTinKH();
            try
            {
                _bus.Sua(kh);
                
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhachHang.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int maKH = Convert.ToInt32(dgvKhachHang.SelectedRows[0].Cells["MaKhachHang"].Value);
                    _bus.Xoa(maKH);
                    
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKhachHang();
                        XoaRong();
                    
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = dgvKhachHang.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
                txtMaKH.ReadOnly = true; // không cho sửa mã
                txtHoTenKH.Text = dgvKhachHang.SelectedRows[0].Cells["TenKhachHang"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                rdNam.Checked = dgvKhachHang.SelectedRows[0].Cells["GioiTinh"].Value.ToString() == "Nam";
                rdNu.Checked = dgvKhachHang.SelectedRows[0].Cells["GioiTinh"].Value.ToString() == "Nữ";
                txtSDTKH.Text = dgvKhachHang.SelectedRows[0].Cells["SDT"].Value.ToString();
                txtEmailKH.Text = dgvKhachHang.SelectedRows[0].Cells["Email"].Value.ToString();
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}