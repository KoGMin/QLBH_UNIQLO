using QLBH_UNIQLO.BUS;
using QLBH_UNIQLO.DTO;
using QLBH_UNIQLO.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace QLBH_UNIQLO
{
    public partial class frmNhanVien : Form
    {
        private NhanVienBUS _bus = new NhanVienBUS();
        public frmNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
            dateNS.Format = DateTimePickerFormat.Custom;
            dateNS.CustomFormat = "dd/MM/yyyy";
        }
        private void LoadNhanVien()
        {
            if (Session.MaBoPhan != 3) // 3 là mã quản lý
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // hoặc return;
                return;
            }

            dgvNhanVien.Rows.Clear();
            List<NhanVienDTO> list = _bus.GetAll();

            foreach (var nv in list)
            {
                int i = dgvNhanVien.Rows.Add();
                var row = dgvNhanVien.Rows[i];
                row.Cells["MaNhanVien"].Value = nv.MaNhanVien;
                row.Cells["TenNhanVien"].Value = nv.TenNhanVien;
                row.Cells["TenDangNhap"].Value = nv.TenDangNhap;
                row.Cells["MatKhau"].Value = nv.MatKhau;
                row.Cells["DiaChi"].Value = nv.DiaChi;
                row.Cells["GioiTinh"].Value = nv.GioiTinh;
                row.Cells["SDT"].Value = nv.SDT;
                row.Cells["Email"].Value = nv.Email;
                row.Cells["NgaySinh"].Value = nv.NgaySinh?.ToString("dd/MM/yyyy") ?? "";
                row.Cells["MaBoPhan"].Value = nv.MaBoPhan;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {


        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string errorMsg = "";

            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string tendn = txtTenDN.Text.Trim();
            string mabp = cbBoPhan.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                errorMsg += "- Vui lòng nhập tên nhân viên\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(sdt))
            {
                errorMsg += "- Phải nhập ít nhất 1 trong 2: Email hoặc Số điện thoại\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tendn))
            {
                errorMsg += "- Vui lòng nhập tên đăng nhập\n";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(mabp))
            {
                errorMsg += "- Vui lòng nhập mã bộ phận\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Dữ liệu không hợp lệ:\n" + errorMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhanVienDTO nv = LayThongTinNV();
            try
            {
                     _bus.Them(nv);
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                    XoaTrong();
            }
            catch (Exception exception)
            {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnNhapLaiNV_Click(object sender, EventArgs e)
        {
            XoaTrong();
        }

        private void XoaTrong()
        {
            txtMaNhanVien.ReadOnly = false;
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtTenDN.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            rdNam.Checked = true;
            dateNS.ResetText();
            txtEmail.Clear();
            txtMaNhanVien.Focus();
            cbBoPhan.Text = string.Empty;
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienDTO nv = LayThongTinNV();

                _bus.Sua(nv);
                
                 MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 LoadNhanVien();
                
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNhanVien.Text = dgvNhanVien.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                txtMaNhanVien.ReadOnly = true; // không cho sửa mã
                txtHoTen.Text = dgvNhanVien.SelectedRows[0].Cells["TenNhanVien"].Value.ToString();
                txtTenDN.Text = dgvNhanVien.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                rdNam.Checked = dgvNhanVien.SelectedRows[0].Cells["GioiTinh"].Value.ToString() == "Nam";
                rdNu.Checked = dgvNhanVien.SelectedRows[0].Cells["GioiTinh"].Value.ToString() == "Nữ";
                txtSDT.Text = dgvNhanVien.SelectedRows[0].Cells["SDT"].Value.ToString();
                txtEmail.Text = dgvNhanVien.SelectedRows[0].Cells["Email"].Value.ToString();
                cbBoPhan.Text = (int.Parse(dgvNhanVien.SelectedRows[0].Cells["MaBoPhan"].Value.ToString())==1?"Nhân viên bán hàng": (int.Parse(dgvNhanVien.SelectedRows[0].Cells["MaBoPhan"].Value.ToString()) == 2?"Nhân viên kho":"Quản lý"));
                txtMatKhau.Text = dgvNhanVien.SelectedRows[0].Cells["MatKhau"].Value.ToString();
                //đặt ngày theo dữ liệu trong csdl
                try
                {
                    dateNS.Value = DateTime.ParseExact(
                        dgvNhanVien.SelectedRows[0].Cells["NgaySinh"].Value.ToString(),
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhanVien.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                    return;
                }

                int maNV = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells["MaNhanVien"].Value);

                _bus.Xoa(maNV);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                    XoaTrong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frmTrangChu frmMain = new frmTrangChu();
            frmMain.Show();
            this.Hide();
        }

        private void NhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1) e.Handled = true;

        }

        private NhanVienDTO LayThongTinNV()
        {
            int boPhan;
            if(cbBoPhan.Text=="Nhân viên bán hàng")
                boPhan=1;
            else if(cbBoPhan.Text=="Nhân viên kho")
                boPhan=2;
            else
                boPhan = 3;
            return new NhanVienDTO
            {
                MaNhanVien = string.IsNullOrEmpty(txtMaNhanVien.Text) ? _bus.getNextMaNhanVien() : int.Parse(txtMaNhanVien.Text),
                TenNhanVien = txtHoTen.Text,
                TenDangNhap = txtTenDN.Text,
                MatKhau = txtMatKhau.Text,
                DiaChi = txtDiaChi.Text,
                GioiTinh = rdNam.Checked ? "Nam" : "Nữ",
                SDT = txtSDT.Text,
                Email = txtEmail.Text,
                NgaySinh = dateNS.Value,
                MaBoPhan = boPhan
            };
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
