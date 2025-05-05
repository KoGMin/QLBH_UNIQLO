using QLBH_UNIQLO.BUS;
using QLBH_UNIQLO.DAL;
using QLBH_UNIQLO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBH_UNIQLO
{
    public partial class frmDoiTraHang : Form
    {
        /*private DonHangDAL donHangDAL = new DonHangDAL();
        private ChiTietSanPhamDAL ctspDAL = new ChiTietSanPhamDAL();
        private YeuCauDoiTraDAL doiTraDAL = new YeuCauDoiTraDAL();
        private ChiTietDoiTraDAL chiTietDoiTraDAL = new ChiTietDoiTraDAL();*/

        public frmDoiTraHang()
        {
            InitializeComponent();
        }

        private void frmDoiTraHang_Load(object sender, EventArgs e)
        {
            SetupDGV();
            LoadDonHang();
            LoadSanPham();
            cbTrangThai.Items.AddRange(new string[] { "Trả hàng", "Đổi hàng" });
            cbTrangThai.SelectedIndex = 0;
        }

        private void LoadDonHang()
        {
            DataTable dt = DonHangDAL.GetDanhSachDonHang();
            
        }

        private void LoadSanPham()
        {
            var data = ChiTietSanPhamDAL.GetDanhSachChiTietSPWithFormat();
            cbSanPham.DataSource = data;
            cbSanPham.DisplayMember = "DisplayText";
            cbSanPham.ValueMember = "MaCTSanPham";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbSanPham.SelectedItem == null || string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng.");
                return;
            }

            string tenSp = cbSanPham.Text;
            int maCT = (int)cbSanPham.SelectedValue;
            int soLuong = int.Parse(txtSoLuong.Text);
            string trangThai = cbTrangThai.SelectedItem.ToString();

            dgvDoiTra.Rows.Add(maCT, tenSp, soLuong, trangThai);
            txtSoLuong.Clear();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDonSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng.");
                return;
            }

            int maDon = int.Parse(txtMaDonSearch.Text);
            string lyDo = txtLyDo.Text.Trim();
            int maKH = DonHangDAL.GetMaKhachHang(maDon);
            string loaiXuLy = cbTrangThai.SelectedItem.ToString();
            int mayc = YeuCauDoiTraBUS.GetNextMaDoiTra();
            // Tạo yêu cầu đổi trả
            var yc = new YeuCauDoiTraDTO
            {
                MaYeuCau = mayc,
                NgayTao = DateTime.Now,
                LyDo = lyDo,
                TrangThai = loaiXuLy,
                MaKhachHang = maKH,
                MaDonHang = maDon
            };

            YeuCauDoiTraDAL.ThemYeuCau(yc);

            // ✅ Nếu là trả hàng toàn đơn
            if (loaiXuLy == "Trả hàng")
            {
                var dsSP = DonHangDAL.GetChiTietSanPhamTheoDon(maDon);
                foreach (DataRow row in dsSP.Rows)
                {
                    int maCT = (int)row["MaCTSanPham"];
                    int soLuong = (int)row["SoLuong"];
                    string moTa = txtLyDo.Text.ToString();

                    ChiTietDoiTraDAL.ThemChiTiet(mayc, maCT, soLuong, moTa);
                    ChiTietSanPhamDAL.CapNhatTonKho(maCT, soLuong);
                }

                DonHangDAL.CapNhatTrangThaiDon(maDon, "Đã hoàn tiền");

                MessageBox.Show("Đã hoàn trả toàn bộ đơn hàng.");
            }
            else // ✅ Nếu là đổi từng sản phẩm
            {
                if (dgvDoiTra.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có sản phẩm được đổi.");
                    return;
                }

                foreach (DataGridViewRow row in dgvDoiTra.Rows)
                {
                    if (row.Cells["MaCTSanPham"].Value == null) continue;

                    int maCT = Convert.ToInt32(row.Cells["MaCTSanPham"].Value);
                    int sl = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    string tt = row.Cells["TrangThaiSanPham"].Value.ToString();

                    ChiTietDoiTraDAL.ThemChiTiet(mayc, maCT, sl, tt);

                    if (tt == "Trả hàng")
                    {
                        ChiTietSanPhamDAL.CapNhatTonKho(maCT, sl);
                    }
                    else if (tt == "Đổi hàng")
                    {
                        ChiTietSanPhamDAL.CapNhatTonKho(maCT, -sl);
                        
                    }
                }

                MessageBox.Show("Đã ghi nhận yêu cầu đổi hàng.");
            }

            dgvDoiTra.Rows.Clear();
            txtLyDo.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrangThai.SelectedItem.ToString() == "Trả hàng")
            {
                cbSanPham.Enabled = false;
                txtSoLuong.Enabled = false;
                btnThem.Enabled = false;
            }
            else
            {
                cbSanPham.Enabled = true;
                txtSoLuong.Enabled = true;
                btnThem.Enabled = true;
            }
        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimDonHang_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaDonSearch.Text, out int maDon))
            {
                var dt = DonHangDAL.GetThongTinDonHang(maDon); // cần thêm hàm này
                if (dt.Rows.Count > 0)
                {
                    txtTenKH.Text = dt.Rows[0]["TenKhachHang"].ToString();
                    txtNgay.Text = Convert.ToDateTime(dt.Rows[0]["NgayTao"]).ToString("dd/MM/yyyy");
                    if (dt.Rows[0]["TrangThaiDonHang"].ToString() == "Đã thanh toán" || dt.Rows[0]["TrangThaiDonHang"].ToString() == "Đã đổi hàng")
                        cbTrangThai.Enabled = true;
                    else
                        cbTrangThai.Enabled= false;

                    var chiTiet = DonHangDAL.GetChiTietSanPhamTheoDon(maDon); // cần thêm
                    cbSanPham.DataSource = chiTiet;
                    cbSanPham.DisplayMember = "TenHienThi";
                    cbSanPham.ValueMember = "MaCTSanPham";
                    cbSanPham.Enabled = true;
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn hàng");
                }
            }
        }

        private void SetupDGV()
        {
            dgvDoiTra.Columns.Clear();
            dgvDoiTra.ColumnCount = 4;
            dgvDoiTra.Columns[0].Name = "MaCTSanPham";
            dgvDoiTra.Columns[ 0 ].HeaderText = "Mã SP";

            dgvDoiTra.Columns[1].Name = "TenSanPham";
            dgvDoiTra.Columns[1].HeaderText = "Tên sản phẩm";

            dgvDoiTra.Columns[2].Name = "SoLuong";
            dgvDoiTra.Columns[2].HeaderText = "Số lượng";

            dgvDoiTra.Columns[3].Name = "TrangThaiSanPham";
            dgvDoiTra.Columns[3].HeaderText = "Trạng thái";

            dgvDoiTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoiTra.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDoiTra.RowTemplate.Height = 28;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
