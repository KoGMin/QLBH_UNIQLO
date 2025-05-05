using QLBH_UNIQLO.BUS;
using QLBH_UNIQLO.DTO;
using QLBH_UNIQLO.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLBH_UNIQLO
{
    public partial class frmHoaDonBanLe : Form
    {
        private Form _parent;
        private List<ChiTietDonHangDTO> gioHang = new List<ChiTietDonHangDTO>();
        private BanHangBUS banHangBUS = new BanHangBUS();
        public frmHoaDonBanLe(Form parentForm)
        {
            InitializeComponent();
            LoadSanPham();
            InitializeDataGridView();
            txtTenNhanVien.Text = Session.TenNhanVien;
            txtMaNhanVien.Text = Session.MaNhanVien.ToString();
            _parent = parentForm;
        }

        private void LoadSanPham()
        {
            try
            {
                string query = @"
                SELECT ct.MaCTSanPham, sp.TenSanPham + ' - ' + ct.MauSac + ' - ' + ct.KichThuoc AS MoTa
                FROM ChiTietSanPham ct
                JOIN SanPham sp ON sp.MaSanPham = ct.MaSanPham";

                DataTable dt = DBConnect.ExecuteQuery(query);
                cbTenSanPham.DisplayMember = "MoTa";
                cbTenSanPham.ValueMember = "MaCTSanPham";
                cbTenSanPham.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void InitializeDataGridView()
        {
            dgvSanPham.Columns.Add("maCTSP", "Mã Sản Phẩm");
            dgvSanPham.Columns.Add("moTa", "Mô tả");
            dgvSanPham.Columns.Add("soLuong", "Số Lượng");
            dgvSanPham.Columns.Add("gia", "Đơn Giá");
            dgvSanPham.Columns.Add("thanhTien", "Thành Tiền");
        }



        private void btnLuuVaThemSanPham_Click(object sender, EventArgs e)
        {
            if (cbTenSanPham.SelectedValue != null && int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                int maCTSP = Convert.ToInt32(cbTenSanPham.SelectedValue);
                DataRowView drv = (DataRowView)cbTenSanPham.SelectedItem;
                string moTa = drv["MoTa"].ToString();

                // Lấy giá từ DB
                string query = $"SELECT GiaTien FROM ChiTietSanPham WHERE MaCTSanPham = {maCTSP}";
                float gia = Convert.ToSingle(DBConnect.ExecuteScalar(query));

                float thanhTien = gia * soLuong;
                dgvSanPham.Rows.Add(maCTSP, moTa, soLuong, gia, thanhTien);

                gioHang.Add(new ChiTietDonHangDTO
                {
                    MaCTSanPham = maCTSP,
                    SoLuong = soLuong
                });

                TinhTongTien();
            }
        }
        private void TinhTongTien()
        {
            float tong = 0;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tong += Convert.ToSingle(row.Cells["ThanhTien"].Value);
                }
            }

            txtThanhTien.Text = tong.ToString("N0");
            txtThueVAT.Text = (tong * 0.1f).ToString("N0");
            txtTongPhaiTra.Text = (tong * 1.1f).ToString("N0");
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mã đơn hàng từ TextBox
            string maDonHang = txtMaHoaDon.Text;

            // Kiểm tra mã đơn hàng không trống
            if (string.IsNullOrEmpty(maDonHang))
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở frmBaoCaoDonHang và truyền MaDonHang
            frmBaoCaoDonHang frmBaoCao = new frmBaoCaoDonHang(maDonHang);
            frmBaoCao.ShowDialog();


        }

        private void btnVeTrangChu_Click(object sender, EventArgs e)
        {
            // Đóng form và trở về trang chủ
            this.Close();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý hiển thị thông tin sản phẩm khi người dùng chọn một dòng trong DataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtMaSanPham.Text = row.Cells["MaSanPham"].Value.ToString();
                cbTenSanPham.SelectedItem = row.Cells["TenSanPham"].Value;
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }

        private void cbMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi chọn mã khách hàng, tự động điền thông tin khách hàng vào các textbox tương ứng
            // Ví dụ: lấy thông tin từ database và hiển thị lên các textbox như txtDiaChi, txtEmail
        }

        private void cbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi chọn mã nhân viên, tự động điền tên nhân viên vào textbox txtTenNhanVien
            // Ví dụ: lấy thông tin từ database và hiển thị lên textbox txtTenNhanVien
        }

        private void btnTaoMoiDonHang_Click_1(object sender, EventArgs e)
        {
                // Xử lý tạo mới đơn hàng
                txtMaHoaDon.Clear();
                txtTenKhachHang.Clear();
                txtDiaChi.Clear();
                txtEmail.Clear();
                txtSoDienThoai.Clear();
                txtTenNhanVien.Clear();
                cbPTTT.SelectedIndex = -1;
                cbPTVC.SelectedIndex = -1;
                txtThanhTien.Clear();
                txtThueVAT.Clear();
                txtTongPhaiTra.Clear();
                dgvSanPham.DataSource = null;
                MessageBox.Show("Đã tạo mới đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenSanPham.SelectedValue != null)
            {
                string selectedMaSanPham = cbTenSanPham.SelectedValue.ToString();
                LoadSanPhamDetails(selectedMaSanPham);
            }
        }

        private void LoadSanPhamDetails(string maSanPham)
        {
            try
            {
                string query = $"SELECT * FROM SanPham WHERE MaSanPham = '{maSanPham}'";
                DataTable dt = DBConnect.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtMaSanPham.Text = row["MaSanPham"].ToString();
                    txtDonGia.Text = row["GiaXuat"].ToString();
                    // Add other fields as needed, such as txtSoLuongNhap, txtChatLieu, etc.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product details: " + ex.Message);
            }
        }

        private void AddProductToDataGridView()
        {
            if (!string.IsNullOrEmpty(txtMaSanPham.Text) &&
                !string.IsNullOrEmpty(cbTenSanPham.Text) &&
                !string.IsNullOrEmpty(txtSoLuong.Text) &&
                !string.IsNullOrEmpty(txtDonGia.Text))
            {
                string maSanPham = txtMaSanPham.Text;
                string tenSanPham = cbTenSanPham.Text;
                int soLuong;
                float donGia;

                // Validate quantity and price
                if (int.TryParse(txtSoLuong.Text, out soLuong) && float.TryParse(txtDonGia.Text, out donGia))
                {
                    float thanhTien = soLuong * donGia;

                    // Check if the product already exists in the DataGridView
                    bool exists = false;
                    foreach (DataGridViewRow row in dgvSanPham.Rows)
                    {
                        if (row.Cells["MaSanPham"].Value != null && row.Cells["MaSanPham"].Value.ToString() == maSanPham)
                        {
                            exists = true;
                            row.Cells["SoLuong"].Value = soLuong;
                            row.Cells["ThanhTien"].Value = thanhTien;
                            break;
                        }
                    }

                    // If the product is not already in the DataGridView, add a new row
                    if (!exists)
                    {
                        dgvSanPham.Rows.Add(maSanPham, tenSanPham, soLuong, donGia, thanhTien);
                    }
                    // Cập nhật tổng tiền và tổng phải trả
                    CalculateTotalAmount();
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity and price.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product and enter the quantity.");
            }
        }

        public void UpdateCustomerInfo(string soDienThoai)
        {
            // Cập nhật thông tin khách hàng vào label trong form chính
            txtSoDienThoai.Text = soDienThoai;
            LoadCustomerDetailsByPhoneNumber(soDienThoai);
        }

        public void UpdateNVInfo(string maNhanVien,string tenNhanVien)
        {
            // Cập nhật thông tin khách hàng vào label trong form chính
            txtMaNhanVien.Text = maNhanVien;
            txtTenNhanVien.Text = tenNhanVien;

        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            

        }


        private void LoadCustomerDetailsByPhoneNumber(string soDienThoai)
        {
            try
            {
                string query = $"SELECT MaKhachHang, HoVaTen, Email, DiaChi FROM KhachHang WHERE SoDienThoai = '{soDienThoai}'";
                DataTable dt = DBConnect.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtMaKhachHang.Text = row["MaKhachHang"].ToString();
                    txtTenKhachHang.Text = row["HoVaTen"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtDiaChi.Text = row["DiaChi"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin khách hàng cho số điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer details: " + ex.Message);
            }
        }


        // Hàm tính tổng tiền cho txtThanhTien
        private void CalculateTotalAmount()
        {
            float totalAmount = 0;

            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    float thanhTien;
                    if (float.TryParse(row.Cells["ThanhTien"].Value.ToString(), out thanhTien))
                    {
                        totalAmount += thanhTien;
                    }
                }
            }

            txtThanhTien.Text = totalAmount.ToString("N2"); // Hiển thị tổng tiền với 2 chữ số thập phân
            CalculateFinalAmount(); // Cập nhật số tiền phải trả cuối cùng khi tổng tiền thay đổi
        }

        // Hàm tính tổng tiền phải trả cuối cùng cho txtTongPhaiTra
        private void CalculateFinalAmount()
        {
            float thanhTien;
            float chiecKhau;
            float tongPhaiTra;

            // Lấy giá trị từ txtThanhTien và txtChiecKhau
            if (float.TryParse(txtThanhTien.Text, out thanhTien) &&
                float.TryParse(txtThueVAT.Text, out chiecKhau))
            {
                // Tính toán tổng số tiền phải trả sau khi chiết khấu
                tongPhaiTra = thanhTien - (thanhTien * chiecKhau / 100);
                txtTongPhaiTra.Text = tongPhaiTra.ToString("N2"); // Hiển thị với 2 chữ số thập phân
            }
        }

        // Gọi hàm CalculateFinalAmount khi thay đổi chiết khấu
        private void txtChiecKhau_TextChanged_1(object sender, EventArgs e)
        {
            CalculateFinalAmount();
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các TextBox và ComboBox bắt buộc
                if (
                    string.IsNullOrWhiteSpace(txtMaVanDon.Text) ||
                    string.IsNullOrWhiteSpace(txtMaHoaDon.Text) ||
                    string.IsNullOrWhiteSpace(txtMaKhachHang.Text) ||
                    string.IsNullOrWhiteSpace(txtMaNhanVien.Text) ||
                    string.IsNullOrWhiteSpace(txtTongPhaiTra.Text) ||
                    cbPTTT.SelectedItem == null ||
                    cbPTVC.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn hàng, bao gồm mã hóa đơn, mã khách hàng, mã nhân viên, tổng phải trả, phương thức thanh toán, và phương thức vận chuyển.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin từ các TextBox và ComboBox
                string maVanDon = txtMaVanDon.Text;
                string maHoaDon = txtMaHoaDon.Text;
                string maKhachHang = txtMaKhachHang.Text;
                string maNhanVien = txtMaNhanVien.Text;
                DateTime ngayTao = dateNgayTao.Value;
                string phuongThucThanhToan = cbPTTT.SelectedItem.ToString();
                string phuongThucVanChuyen = cbPTVC.SelectedItem.ToString();
                float tongPhaiTra = float.Parse(txtTongPhaiTra.Text);


                // Thêm đơn hàng vào bảng DonHang
                string insertDonHangQuery = $"INSERT INTO DonHang (MaDonHang, MaKhachHang, MaNhanVien, NgayTao, PhuongThucThanhToan, PhuongThucVanChuyen) " +
                                            $"VALUES ('{maHoaDon}', '{maKhachHang}', '{maNhanVien}', '{ngayTao}', '{phuongThucThanhToan}', '{phuongThucVanChuyen}')";
                DBConnect.ExecuteNonQuery(insertDonHangQuery);

                // Thêm chi tiết đơn hàng vào bảng CTDH
                foreach (DataGridViewRow row in dgvSanPham.Rows)
                {
                    if (row.Cells["MaSanPham"].Value != null)
                    {
                        string maSanPham = row.Cells["MaSanPham"].Value.ToString();
                        int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());


                        string insertCTDHQuery = $"INSERT INTO CTDH (MaDonHang, MaSanPham, SoLuong) " +
                                                 $"VALUES ('{maHoaDon}', '{maSanPham}', {soLuong})";
                        DBConnect.ExecuteNonQuery(insertCTDHQuery);
                    }
                }

                // Thêm chi tiết vận chuyển vào bảng CTVC
                string insertCTVCQuery = $"INSERT INTO CTVC (MaVanDon,MaDonHang, TienDoGiaoHang) " +
                                         $"VALUES ('{maVanDon }','{maHoaDon}', 1)";
                DBConnect.ExecuteNonQuery(insertCTVCQuery);

                MessageBox.Show("Đơn hàng đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            _parent.Show();
            Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDonBanLe_Load(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
