using QLBH_UNIQLO.BUS;
using QLBH_UNIQLO.DAL;
using QLBH_UNIQLO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLBH_UNIQLO
{
    public partial class frmDoiTraHang : Form
    {
        private ComboBox cbSanPham;
        private TextBox txtSoLuong;
        private ComboBox cbTrangThai;
        private DataGridView dgvDoiTra;
        private TextBox txtLyDo;
        private Button btnThem;
        private Button btnXacNhan;
        private Button btnHuy;




        private void InitializeComponent()
        {
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.dgvDoiTra = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimDonHang = new System.Windows.Forms.Button();
            this.txtMaDonSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiTra)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSanPham
            // 
            this.cbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanPham.Location = new System.Drawing.Point(30, 179);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(340, 24);
            this.cbSanPham.TabIndex = 1;
            this.cbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbSanPham_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(395, 179);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(80, 22);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.Location = new System.Drawing.Point(599, 179);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(120, 24);
            this.cbTrangThai.TabIndex = 3;
            this.cbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbTrangThai_SelectedIndexChanged);
            // 
            // dgvDoiTra
            // 
            this.dgvDoiTra.ColumnHeadersHeight = 29;
            this.dgvDoiTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvDoiTra.Location = new System.Drawing.Point(30, 222);
            this.dgvDoiTra.Name = "dgvDoiTra";
            this.dgvDoiTra.RowHeadersWidth = 51;
            this.dgvDoiTra.Size = new System.Drawing.Size(685, 200);
            this.dgvDoiTra.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã CT Sản phẩm";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Trạng thái";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(30, 460);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(685, 58);
            this.txtLyDo.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(490, 179);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 24);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm SP";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(400, 544);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(120, 30);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(550, 544);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 30);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm đơn hàng";
            // 
            // btnTimDonHang
            // 
            this.btnTimDonHang.Location = new System.Drawing.Point(190, 41);
            this.btnTimDonHang.Name = "btnTimDonHang";
            this.btnTimDonHang.Size = new System.Drawing.Size(75, 23);
            this.btnTimDonHang.TabIndex = 10;
            this.btnTimDonHang.Text = "Tìm";
            this.btnTimDonHang.UseVisualStyleBackColor = true;
            this.btnTimDonHang.Click += new System.EventHandler(this.btnTimDonHang_Click);
            // 
            // txtMaDonSearch
            // 
            this.txtMaDonSearch.Location = new System.Drawing.Point(30, 42);
            this.txtMaDonSearch.Name = "txtMaDonSearch";
            this.txtMaDonSearch.Size = new System.Drawing.Size(130, 22);
            this.txtMaDonSearch.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(30, 100);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(168, 22);
            this.txtTenKH.TabIndex = 13;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(262, 100);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(176, 22);
            this.txtNgay.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chọn sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Loại yêu cầu";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(588, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "Về trang chủ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lý do đổi trả";
            // 
            // frmDoiTraHang
            // 
            this.ClientSize = new System.Drawing.Size(749, 592);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDonSearch);
            this.Controls.Add(this.btnTimDonHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSanPham);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDoiTra);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.Name = "frmDoiTraHang";
            this.Text = "Quản lý đổi / trả hàng";
            this.Load += new System.EventHandler(this.frmDoiTraHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label1;
        private Button btnTimDonHang;
        private TextBox txtMaDonSearch;
        private Label label2;
        private TextBox txtTenKH;
        private TextBox txtNgay;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Label label7;


        // ... (các hàm btnThem_Click, btnXacNhan_Click đã có trong code chính)
    }
}
