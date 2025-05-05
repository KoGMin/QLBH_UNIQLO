using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using QLBH_UNIQLO;

namespace QLBH_UNIQLO
{
    public partial class frmBaoBieuHoaDon : Form
    {
        public frmBaoBieuHoaDon()
        {
            InitializeComponent();
        }

        private void frmBaoBieuNV_Load(object sender, EventArgs e)
        {
            this.reportDSHoaDon.RefreshReport();
        }

        private void reportNV_Load(object sender, EventArgs e)
        {

        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ DateTimePicker
                DateTime tuNgay = dtpTuNgay.Value;
                DateTime denNgay = dtpDenNgay.Value;

                // Xóa nguồn dữ liệu cũ nếu có
                reportDSHoaDon.LocalReport.DataSources.Clear();

                // Tạo dataset và TableAdapter
                DsDonHang ds = new DsDonHang(); // Dataset thực tế
                DsDonHangTableAdapters.sp_XemDanhSachHoaDonTableAdapter adapter = new DsDonHangTableAdapters.sp_XemDanhSachHoaDonTableAdapter();

                // Fill dữ liệu vào dataset
                adapter.Fill(ds.sp_XemDanhSachHoaDon, tuNgay, denNgay);

                // Gán dataset vào ReportViewer
                ReportDataSource source = new ReportDataSource("DsDonHang", ds.Tables["sp_XemDanhSachHoaDon"]);
                reportDSHoaDon.LocalReport.DataSources.Add(source);

                // Làm mới báo cáo
                reportDSHoaDon.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmTrangChu frmMain = new frmTrangChu();
            frmMain.Show();
            this.Hide();
        }
    }
}
