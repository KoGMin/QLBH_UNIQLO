using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBH_UNIQLO
{
    public partial class frmBaoCaoDonHang : Form
    {
        private string maDonHang;
        public frmBaoCaoDonHang(string maDonHang)
        {
            InitializeComponent();
            this.maDonHang = maDonHang;
        }


        private void frmBaoCaoDonHang_Load(object sender, EventArgs e)
        {
            
            LoadReport(maDonHang);
        }

        private void LoadReport(string maDonHang)
        {
            // Lấy dữ liệu từ DataTable dựa trên MaDonHang
            DataTable dataTable = GetDataForMaDonHang(maDonHang);

            if (dataTable.Rows.Count > 0)
            {
                // Thiết lập nguồn dữ liệu cho ReportViewer
                ReportDataSource rds = new ReportDataSource("HoaDonDTS", dataTable); // "HoaDon" là tên DataSet trong file rdlc
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Refresh báo cáo để cập nhật dữ liệu
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn với mã đơn hàng đã chỉ định.");
            }
        }

        private DataTable GetDataForMaDonHang(string maDonHang)
        {
            DataTable dataTable = new DataTable();
            string query = "EXEC sp_GetHoaDonByMaDonHang @MaDonHang";

            using (SqlCommand cmd = new SqlCommand(query, DBConnect.Connect()))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
            }

            return dataTable;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
