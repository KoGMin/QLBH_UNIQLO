using QLBH_UNIQLO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBH_UNIQLO
{
    public partial class frmTraCuuKH : Form
    {
        private Form _parent;
        public frmTraCuuKH(Form parent)
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
            try
            {
                string TuKhoa;
                if (txtTuKhoa.Text == "")
                     TuKhoa = "";
                else
                    TuKhoa = txtTuKhoa.Text;

                var sql = @" SELECT MaKhachHang, TenKhachHang, DiaChi, GioiTinh, SDT, Email
                FROM KhachHang
                WHERE MaKhachHang LIKE N'%' + @TuKhoa + '%'
                      OR TenKhachHang LIKE N'%' + @TuKhoa + '%'
                      OR DiaChi LIKE N'%' + @TuKhoa + '%'
                      OR GioiTinh LIKE N'%' + @TuKhoa + '%'
                      OR SDT LIKE N'%' + @TuKhoa + '%'
                      OR Email LIKE N'%' + @TuKhoa + '%'";
                SqlCommand cmd = new SqlCommand(sql, DBConnect.Connect());
                cmd.Parameters.AddWithValue("@TuKhoa", TuKhoa);
                SqlDataReader dr = cmd.ExecuteReader();
                //Xóa dữ liệu cũ trong datagridview
                dgvKQ.Rows.Clear();

                // lập qua từng dòng trong bảng SanPham, thêm vào datagridview
                while (dr.Read())
                {
                    var i = dgvKQ.Rows.Add();
                    var row = dgvKQ.Rows[i];
                    row.Cells["MaKhachHang"].Value = dr["MaKhachHang"];
                    row.Cells["TenKhachHang"].Value = dr["TenKhachHang"];
                    row.Cells["DiaChi"].Value = dr["DiaChi"];
                    row.Cells["GioiTinh"].Value = dr["GioiTinh"];
                    row.Cells["SDT"].Value = dr["SDT"];
                    row.Cells["Email"].Value = dr["Email"];
                }

                dr.Close();
            }
            catch (Exception e)
            {
            }

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