using System;
using System.Data;
using System.Windows.Forms;
using QLBH_UNIQLO.DAL;
using QLBH_UNIQLO.DTO;

namespace QLBH_UNIQLO
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            
            InitializeComponent();
            LoadDanhMucSanPham();
            LoadLoaiSanPham();
        }

        private void LoadDanhMucSanPham()
        {
            DataTable dt = SanPhamDAL.GetAllSanPhamWithChiTiet();
            dgvSanPham.DataSource = dt;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            // 🔍 Kiểm tra nhập đủ
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text) ||
                string.IsNullOrWhiteSpace(txtMoTa.Text) ||
                cbLoaiSP.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtSize.Text) ||
                string.IsNullOrWhiteSpace(txtMau.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm và chi tiết!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 🔢 Tạo mã tự động
                int maSP = SanPhamDAL.GetNextMaSanPham();
                int maCT = ChiTietSanPhamDAL.GetNextMaChiTietSanPham();

                // 🧾 Tạo sản phẩm
                var sp = new SanPhamDTO
                {
                    MaSanPham = maSP,
                    TenSanPham = txtTenSanPham.Text,
                    MoTa = txtMoTa.Text,
                    MaLoaiSanPham = (int)cbLoaiSP.SelectedValue
                };

                SanPhamDAL.InsertSanPhamWithId(sp); // chèn theo mã tự cấp

                // 🧾 Tạo chi tiết
                var ct = new ChiTietSanPhamDTO
                {
                    MaCTSanPham = maCT,
                    KichThuoc = txtSize.Text,
                    MauSac = txtMau.Text,
                    LuongHang = int.Parse(txtSoLuong.Text),
                    GiaTien = float.Parse(txtGia.Text),
                    MaSanPham = maSP
                };

                ChiTietSanPhamDAL.InsertChiTietWithId(ct);

                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadDanhMucSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                int maCT = (int)dgvSanPham.CurrentRow.Cells["MaCTSanPham"].Value;

                var ct = new ChiTietSanPhamDTO
                {
                    MaCTSanPham = maCT,
                    KichThuoc = txtSize.Text,
                    MauSac = txtMau.Text,
                    LuongHang = int.Parse(txtSoLuong.Text),
                    GiaTien = float.Parse(txtGia.Text)
                };

                ChiTietSanPhamDAL.UpdateChiTiet(ct);

                MessageBox.Show("Đã cập nhật sản phẩm");
                LoadDanhMucSanPham();
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                int maCT = (int)dgvSanPham.CurrentRow.Cells["MaCTSanPham"].Value;

                if (MessageBox.Show("Xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ChiTietSanPhamDAL.DeleteChiTiet(maCT);
                    MessageBox.Show("Đã xóa");
                    LoadDanhMucSanPham();
                }
            }
        }

        private void btnNhapLaiNV_Click(object sender, EventArgs e)
        {
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            txtSize.Clear();
            txtMau.Clear();
            txtSoLuong.Clear();
            txtGia.Clear();
            cbLoaiSP.SelectedIndex = -1;
        }


        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSanPham.Rows[e.RowIndex];
                txtTenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
                txtSize.Text = row.Cells["KichThuoc"].Value.ToString();
                txtMau.Text = row.Cells["MauSac"].Value.ToString();
                txtSoLuong.Text = row.Cells["LuongHang"].Value.ToString();
                txtGia.Text = row.Cells["GiaTien"].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadLoaiSanPham()
        {
            cbLoaiSP.DataSource = LoaiSanPhamDAL.GetAll();
            cbLoaiSP.DisplayMember = "TenLoaiSanPham";
            cbLoaiSP.ValueMember = "MaLoaiSanPham";
            cbLoaiSP.SelectedIndex = -1; // Không chọn mặc định
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();
            frm.Show();
            this.Hide();
        }
    }
}
