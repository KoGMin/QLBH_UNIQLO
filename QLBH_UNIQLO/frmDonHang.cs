using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using QLBH_UNIQLO.DAL;
using QLBH_UNIQLO.Properties;

namespace QLBH_UNIQLO
{
    
    public partial class frmDonHang : Form
    {
        
        public frmDonHang()
        {
            InitializeComponent();

            // load danh sách hàng hóa lên datagridview
            LoadDsDonHang();
           


        }

        private void LoadDsDonHang()
        {
            var dt = DonHangDAL.GetDonHangChuaXuLyHoacDaThanhToan();
            dgv.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                var i = dgv.Rows.Add();
                dgv.Rows[i].Cells["MaDonHang"].Value = dr["MaDonHang"];
                dgv.Rows[i].Cells["MaNhanVien"].Value = dr["MaNhanVien"];
                dgv.Rows[i].Cells["MaKhachHang"].Value = dr["MaKhachHang"];
                dgv.Rows[i].Cells["TrangThaiDonHang"].Value = dr["TrangThaiDonHang"];
                dgv.Rows[i].Cells["NgayTao"].Value = dr["NgayTao"];
            }
        }


      


       


        //thêm số thứ tự datagridview
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

      


        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maDon = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["MaDonHang"].Value);
                LoadChiTietDonHang(maDon);
            }
        }



        private void frmSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();
            frm.Show();
            this.Hide();
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                int maDon = Convert.ToInt32(dgv.CurrentRow.Cells["MaDonHang"].Value);

                var chiTiet = DonHangDAL.GetChiTietDonHang(maDon);
                foreach (DataRow row in chiTiet.Rows)
                {
                    int maCT = (int)row["MaCTSanPham"];
                    int sl = (int)row["SoLuong"];
                    ChiTietSanPhamDAL.CapNhatTonKho(maCT, -sl);
                }

                DonHangDAL.CapNhatTrangThaiDonHang(maDon, "Đã nhận hàng");
                MessageBox.Show("Đã cập nhật đơn hàng!");
                LoadDsDonHang();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadChiTietDonHang(int maDon)
        {
             dgvCTDonHang.DataSource = DonHangDAL.GetChiTietDonHang(maDon);
        }

        private void dgvCTDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}