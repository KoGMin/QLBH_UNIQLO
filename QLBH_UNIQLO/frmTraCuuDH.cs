using QLBH_UNIQLO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBH_UNIQLO
{
    public partial class frmTraCuuDH : Form
    {
        private Form _parent;
        public frmTraCuuDH(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {

        }

        //thêm số thứ tự datagridview
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvKQ.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            _parent.Show();
            Hide();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void TimKiem()
        {
           
                var sql = @"
                SELECT dh.MaDonHang, kh.TenKhachHang, dh.MaNhanVien, dh.MaKhachHang, 
                dh.TrangThaiDonHang, dh.MaThanhToan, 
                CONVERT(NVARCHAR(10), dh.NgayTao, 103) AS NgayTao
                FROM DonHang dh
                JOIN KhachHang kh ON kh.MaKhachHang = dh.MaKhachHang
                WHERE dh.MaDonHang LIKE N'%' + @TuKhoa + '%'
                OR kh.TenKhachHang LIKE N'%' + @TuKhoa + '%'
                OR dh.MaNhanVien LIKE N'%' + @TuKhoa + '%'
                OR dh.MaKhachHang LIKE N'%' + @TuKhoa + '%'";

                SqlCommand cmd = new SqlCommand(sql, DBConnect.Connect());
                cmd.Parameters.AddWithValue("TuKhoa", txtTuKhoa.Text);
                var dr = cmd.ExecuteReader();
                //Xóa dữ liệu cũ trong datagridview
                dgvKQ.Rows.Clear();

                // lập qua từng dòng trong bảng SanPham, thêm vào datagridview
                while (dr.Read())
                {
                    var i = dgvKQ.Rows.Add();
                    var row = dgvKQ.Rows[i];
                    row.Cells["MaDonHang"].Value = dr["MaDonHang"];
                    row.Cells["TenKhachHang"].Value = dr["TenKhachHang"];
                    row.Cells["MaNhanVien"].Value = dr["MaNhanVien"];
                    row.Cells["MaKhachHang"].Value = dr["MaKhachHang"];
                    row.Cells["TrangThaiDonHang"].Value = dr["TrangThaiDonHang"];
                    row.Cells["MaThanhToan"].Value = dr["MaThanhToan"];
                    row.Cells["NgayTao"].Value = dr["NgayTao"];




                }

                dr.Close();
            
            

        }
        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            //"Enter"
            if (e.KeyChar == 13)
            {
                TimKiem();

            }
        }

        private void dgvKQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}