using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLBH_UNIQLO.Shared;
using QLBH_UNIQLO.DAL;
using QLBH_UNIQLO.DTO;
using System.Drawing;

namespace QLBH_UNIQLO
{
    public partial class frmBanHang2 : Form
    {
        ChiTietSanPhamDAL ctspDAL = new ChiTietSanPhamDAL();
        DonHangDAL donHangDAL = new DonHangDAL();
        KhachHangDAL khDAL = new KhachHangDAL();
        int MaKH;
        public frmBanHang2()
        {
            InitializeComponent();
            
        }

        private void frmBanHang2_Load(object sender, EventArgs e)
        {
            KhoiTaoGrid();
            LoadChiTietSanPham();
            txtMaNhanVien.Text = Session.MaNhanVien.ToString();
            txtTenNhanVien.Text = Session.TenNhanVien;
            txtMaDonHang.Text = donHangDAL.GetNextMaDonHang().ToString();
            dateNgayTao.Value = DateTime.Now;

            
        }

        private void LoadChiTietSanPham()
        {
            var dt = ChiTietSanPhamDAL.GetDanhSachChiTietSPWithFormat();
            cbChiTietSanPham.DisplayMember = "DisplayText";
            //cbChiTietSanPham.DisplayMember = "LuongHang";
            cbChiTietSanPham.ValueMember = "MaCTSanPham";
            cbChiTietSanPham.DataSource = dt;
        }

        private void cbChiTietSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoLuong.Text, out int soLuong) && int.TryParse(txtMaSanPham.Text, out int maCT))
            {
                var ct = ctspDAL.GetChiTietSanPhamById(maCT);
                if (ct != null && soLuong <= ct.LuongHang)
                {
                    float thanhTien = soLuong * ct.GiaTien;
                    dgvSanPham.Rows.Add(maCT, cbChiTietSanPham.Text, soLuong, ct.GiaTien.ToString("N0"), thanhTien.ToString("N0"));
                    TinhTien();
                }
                else
                {
                    MessageBox.Show("Số lượng vượt quá tồn kho.");
                }
            }
        }

        private void TinhTien()
        {
            float tienHang = 0;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells["GiaTien"].Value != null)
                {
                    tienHang += (float.Parse(row.Cells["GiaTien"].Value.ToString()) * int.Parse(row.Cells["SoLuong"].Value.ToString()));
                }
            }

            txtThanhTien.Text = tienHang.ToString("N0");
            float vat = tienHang * 0.1f;
            txtThueVAT.Text = vat.ToString("N0");
            txtTongPhaiTra.Text = (tienHang + vat).ToString("N0");
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            
        }

        

        private void chkKhachVangLai_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Chưa chọn khách hàng.");
                return;
            }
            var donHang = new DonHangDTO
            {
                MaDonHang = int.Parse(txtMaDonHang.Text),
                NgayTao = dateNgayTao.Value,
                TrangThaiDonHang = "Chờ thanh toán",
                TienHang = float.Parse(txtThanhTien.Text),
                ThueVAT = float.Parse(txtThueVAT.Text),
                MaKhachHang = MaKH,
                MaThanhToan = null,
                MaNhanVien = int.Parse(txtMaNhanVien.Text)
            };

            
            // 1. Tạo đơn hàng
            DonHangDAL.ThemDonHang(donHang);

            // 2. Thêm chi tiết đơn hàng
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells["MaCTSP"].Value != null)
                {
                    int maDon = int.Parse(txtMaDonHang.Text);
                    int maCT = int.Parse(row.Cells["MaCTSP"].Value.ToString());
                    int sl = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    ChiTietDonHangDAL.ThemChiTietDonHang(maDon, maCT, sl);
                }
            }

            MessageBox.Show("Tạo đơn hàng thành công!");
            
        }

        private void txtMaDonHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoLuong.Text, out int soLuong) && int.TryParse(txtMaSanPham.Text, out int maCT))
            {
                var ct = ctspDAL.GetChiTietSanPhamById(maCT);
                if (ct != null && soLuong <= ct.LuongHang)
                {
                    float thanhTien = soLuong * ct.GiaTien;
                    dgvSanPham.Rows.Add(maCT, cbChiTietSanPham.Text, soLuong, ct.GiaTien.ToString("N0"), thanhTien.ToString("N0"));
                    TinhTien();
                }
                else
                {
                    MessageBox.Show("Số lượng vượt quá tồn kho.");
                }
            }
        }

        private void btnTimKH_Click_1(object sender, EventArgs e)
        {
            var sdtOrEmail = txtSDTEmail.Text.Trim();
            if (!string.IsNullOrEmpty(sdtOrEmail))
            {
                var kh = khDAL.GetKhachHangBySDTEmail(sdtOrEmail);
                if (kh != null)
                {
                    txtTenKH.Text = kh.TenKhachHang;
                    txtSDT.Text = kh.SDT;
                    txtEmail.Text = kh.Email;
                    MaKH = kh.MaKhachHang;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy KH.");
                }
            }
        }

        private void chkKhachVangLai_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkKhachVangLai.Checked)
            {
                // reset và gán mặc định mã khách hàng vãng lai

                txtTenKH.Text = "Khách vãng lai";
                txtSDT.Text = "";
                txtEmail.Text = "";
                MaKH = 1;
            }
        }
        private void KhoiTaoGrid()
        {
            dgvSanPham.Columns.Clear(); // Nếu có thể load lại nhiều lần
            dgvSanPham.Columns.Add("MaCTSP", "Mã CTSP");
            dgvSanPham.Columns.Add("TenSP", "Tên SP - Màu - Size");
            dgvSanPham.Columns.Add("SoLuong", "Số lượng");
            dgvSanPham.Columns.Add("GiaTien", "Giá");
            //dgvSanPham.Columns.Add("ThanhTien", "Thành tiền");
            // Căn giữa dữ liệu và header
            foreach (DataGridViewColumn col in dgvSanPham.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            }

            // Tùy chỉnh riêng độ rộng nếu cần
            dgvSanPham.Columns["MaCTSP"].Width = 120;
            dgvSanPham.Columns["TenSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSanPham.Columns["SoLuong"].Width = 80;
            dgvSanPham.Columns["GiaTien"].Width = 100;
            dgvSanPham.Columns["GiaTien"].DefaultCellStyle.Format = "N0";

            // Format số cho các cột giá
            dgvSanPham.Columns["GiaTien"].DefaultCellStyle.Format = "N0";
            //dgvSanPham.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            // Không cho người dùng tự thêm dòng mới
            dgvSanPham.AllowUserToAddRows = false;
        }

        private void cbChiTietSanPham_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbChiTietSanPham.SelectedValue != null)
            {
                var ct = ctspDAL.GetChiTietSanPhamById(Convert.ToInt32(cbChiTietSanPham.SelectedValue));
                txtDonGia.Text = ct?.GiaTien.ToString("N0");
                txtMaSanPham.Text = ct?.MaCTSanPham.ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (txtTrangThaiDonHang.Text != "Chờ thanh toán")
            {
                MessageBox.Show("Bạn cần tạo đơn hàng trước khi thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu cần gửi
            float thanhTien = float.Parse(txtThanhTien.Text);
            float tongTien = float.Parse(txtTongPhaiTra.Text);
            int maDon = int.Parse(txtMaDonHang.Text);

            // Mở form thanh toán
            frmThanhToan frm = new frmThanhToan(thanhTien,tongTien, maDon);
            
            frm.Owner = this; 
            frm.ShowDialog();


        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Chưa chọn khách hàng.");
                return;
            }

            if (dgvSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất 1 sản phẩm trước khi tạo đơn hàng.");
                return;
            }

            var donHang = new DonHangDTO
            {
                MaDonHang = int.Parse(txtMaDonHang.Text),
                NgayTao = dateNgayTao.Value,
                TrangThaiDonHang = "Chờ thanh toán",
                TienHang = float.Parse(txtThanhTien.Text),
                ThueVAT = float.Parse(txtThueVAT.Text),
                MaKhachHang = MaKH,
                MaThanhToan = null,
                MaNhanVien = int.Parse(txtMaNhanVien.Text)
            };


            // 1. Tạo đơn hàng
            DonHangDAL.ThemDonHang(donHang);

            // 2. Thêm chi tiết đơn hàng
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells["MaCTSP"].Value != null)
                {
                    int maDon = int.Parse(txtMaDonHang.Text);
                    int maCT = int.Parse(row.Cells["MaCTSP"].Value.ToString());
                    int sl = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    ChiTietDonHangDAL.ThemChiTietDonHang(maDon, maCT, sl);
                }
            }

            MessageBox.Show("Tạo đơn hàng thành công!");
            txtTrangThaiDonHang.Text = "Chờ thanh toán";
        }


        public void CapNhatSauKhiThanhToan()
        {
            txtTrangThaiDonHang.Text = "Đã thanh toán";
            btnThanhToan.Enabled = false;
            btnThemSanPham.Enabled = false;
            btnTaoDonHang.Enabled = false;
            cbChiTietSanPham.Enabled = false;

            
            
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells["MaCTSP"].Value != null)
                {
                    
                    int maCT = int.Parse(row.Cells["MaCTSP"].Value.ToString());
                    int sl = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    ChiTietSanPhamDAL.CapNhatTonKho(maCT, -sl);
                }
            }
        }

        private void btnTaoLaiDonHang_Click(object sender, EventArgs e)
        {
            cbChiTietSanPham.Enabled = true;
            dgvSanPham.Rows.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSanPham.Clear();

            txtThanhTien.Text = "0";
            txtThueVAT.Text = "0";
            txtTongPhaiTra.Text = "0";

            txtMaDonHang.Text = donHangDAL.GetNextMaDonHang().ToString();
            dateNgayTao.Value = DateTime.Now;
            txtTrangThaiDonHang.Text = "Đang tạo";

            // Reset KH
            txtTenKH.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            MaKH = 0;

            chkKhachVangLai.Checked = false;

            btnThanhToan.Enabled=true;
        }
         
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form home;
            
            home = new frmTrangChu();
            

            home.Show();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mã đơn hàng từ TextBox
            string maDonHang = txtMaDonHang.Text;

            // Kiểm tra mã đơn hàng không trống
            if (string.IsNullOrEmpty(maDonHang))
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTrangThaiDonHang.Text == "Đã thanh toán")
            {
                // Mở frmBaoCaoDonHang và truyền MaDonHang
                frmBaoCaoDonHang frmBaoCao = new frmBaoCaoDonHang(maDonHang);
                frmBaoCao.ShowDialog();
            }
            else
            {

                MessageBox.Show("Vui lòng thanh toán trước khi tạo hóa đơn");
                return;

            }
            
        }
    }
}
