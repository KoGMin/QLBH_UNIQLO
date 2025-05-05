namespace QLBH_UNIQLO
{
    partial class frmBanHang2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChiTietSanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTaoDonHang = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnTaoLaiDonHang = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTongPhaiTra = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtThueVAT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTrangThaiDonHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkKhachVangLai = new System.Windows.Forms.CheckBox();
            this.txtSDTEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateNgayTao = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChiTietSanPham);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtMaSanPham);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.btnThemSanPham);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 139);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbChiTietSanPham
            // 
            this.cbChiTietSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiTietSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbChiTietSanPham.FormattingEnabled = true;
            this.cbChiTietSanPham.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cbChiTietSanPham.Location = new System.Drawing.Point(157, 27);
            this.cbChiTietSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cbChiTietSanPham.Name = "cbChiTietSanPham";
            this.cbChiTietSanPham.Size = new System.Drawing.Size(319, 32);
            this.cbChiTietSanPham.TabIndex = 41;
            this.cbChiTietSanPham.SelectedIndexChanged += new System.EventHandler(this.cbChiTietSanPham_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(688, 27);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(159, 29);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(159, 86);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(172, 27);
            this.txtMaSanPham.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(470, 86);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(159, 27);
            this.txtSoLuong.TabIndex = 2;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.Green;
            this.btnThemSanPham.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnThemSanPham.ForeColor = System.Drawing.Color.White;
            this.btnThemSanPham.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThemSanPham.Location = new System.Drawing.Point(673, 80);
            this.btnThemSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(174, 39);
            this.btnThemSanPham.TabIndex = 75;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Crimson;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(1148, 13);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(149, 41);
            this.btnDong.TabIndex = 78;
            this.btnDong.Text = "Về trang chủ";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTaoDonHang
            // 
            this.btnTaoDonHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTaoDonHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTaoDonHang.ForeColor = System.Drawing.Color.White;
            this.btnTaoDonHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTaoDonHang.Location = new System.Drawing.Point(937, 493);
            this.btnTaoDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoDonHang.Name = "btnTaoDonHang";
            this.btnTaoDonHang.Size = new System.Drawing.Size(163, 41);
            this.btnTaoDonHang.TabIndex = 77;
            this.btnTaoDonHang.Text = "Tạo đơn hàng";
            this.btnTaoDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoDonHang.UseVisualStyleBackColor = false;
            this.btnTaoDonHang.Click += new System.EventHandler(this.btnTaoDonHang_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.Goldenrod;
            this.btnInHoaDon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnInHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnInHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInHoaDon.Location = new System.Drawing.Point(1132, 493);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(165, 41);
            this.btnInHoaDon.TabIndex = 76;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnTaoLaiDonHang
            // 
            this.btnTaoLaiDonHang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTaoLaiDonHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTaoLaiDonHang.ForeColor = System.Drawing.Color.White;
            this.btnTaoLaiDonHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTaoLaiDonHang.Location = new System.Drawing.Point(1134, 556);
            this.btnTaoLaiDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoLaiDonHang.Name = "btnTaoLaiDonHang";
            this.btnTaoLaiDonHang.Size = new System.Drawing.Size(163, 41);
            this.btnTaoLaiDonHang.TabIndex = 74;
            this.btnTaoLaiDonHang.Text = "Tạo lại đơn hàng";
            this.btnTaoLaiDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoLaiDonHang.UseVisualStyleBackColor = false;
            this.btnTaoLaiDonHang.Click += new System.EventHandler(this.btnTaoLaiDonHang_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(39, 493);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(869, 199);
            this.dgvSanPham.TabIndex = 73;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThanhToan);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtTongPhaiTra);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtThueVAT);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtThanhTien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(937, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 394);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thanh toán";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(15, 191);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(148, 52);
            this.btnThanhToan.TabIndex = 76;
            this.btnThanhToan.Text = "ThanhToan";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 20);
            this.label19.TabIndex = 75;
            this.label19.Text = "Tổng phải trả:";
            // 
            // txtTongPhaiTra
            // 
            this.txtTongPhaiTra.Location = new System.Drawing.Point(149, 125);
            this.txtTongPhaiTra.Name = "txtTongPhaiTra";
            this.txtTongPhaiTra.Size = new System.Drawing.Size(159, 27);
            this.txtTongPhaiTra.TabIndex = 74;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 20);
            this.label17.TabIndex = 72;
            this.label17.Text = "Thuế VAT:";
            // 
            // txtThueVAT
            // 
            this.txtThueVAT.Location = new System.Drawing.Point(149, 89);
            this.txtThueVAT.Name = "txtThueVAT";
            this.txtThueVAT.Size = new System.Drawing.Size(159, 27);
            this.txtThueVAT.TabIndex = 71;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 70;
            this.label16.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(149, 50);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(159, 27);
            this.txtThanhTien.TabIndex = 69;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTrangThaiDonHang);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.chkKhachVangLai);
            this.groupBox2.Controls.Add(this.txtSDTEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtMaDonHang);
            this.groupBox2.Controls.Add(this.txtMaNhanVien);
            this.groupBox2.Controls.Add(this.btnTimKH);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTenNhanVien);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dateNgayTao);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 254);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng và nhân viên";
            // 
            // txtTrangThaiDonHang
            // 
            this.txtTrangThaiDonHang.Location = new System.Drawing.Point(673, 205);
            this.txtTrangThaiDonHang.Name = "txtTrangThaiDonHang";
            this.txtTrangThaiDonHang.Size = new System.Drawing.Size(174, 27);
            this.txtTrangThaiDonHang.TabIndex = 81;
            this.txtTrangThaiDonHang.Text = "Đang tạo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(22, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "Khách hàng thành viên";
            // 
            // chkKhachVangLai
            // 
            this.chkKhachVangLai.AutoSize = true;
            this.chkKhachVangLai.BackColor = System.Drawing.Color.DarkSalmon;
            this.chkKhachVangLai.Location = new System.Drawing.Point(23, 33);
            this.chkKhachVangLai.Name = "chkKhachVangLai";
            this.chkKhachVangLai.Size = new System.Drawing.Size(181, 24);
            this.chkKhachVangLai.TabIndex = 78;
            this.chkKhachVangLai.Text = "Khách hàng vãng lai";
            this.chkKhachVangLai.UseVisualStyleBackColor = false;
            this.chkKhachVangLai.CheckedChanged += new System.EventHandler(this.chkKhachVangLai_CheckedChanged_1);
            // 
            // txtSDTEmail
            // 
            this.txtSDTEmail.Location = new System.Drawing.Point(171, 102);
            this.txtSDTEmail.Name = "txtSDTEmail";
            this.txtSDTEmail.Size = new System.Drawing.Size(172, 27);
            this.txtSDTEmail.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Email/Sdt";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(535, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 20);
            this.label20.TabIndex = 75;
            this.label20.Text = "Mã đơn hàng:";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(673, 108);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(174, 27);
            this.txtMaDonHang.TabIndex = 74;
            this.txtMaDonHang.TextChanged += new System.EventHandler(this.txtMaDonHang_TextChanged);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(673, 26);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(174, 27);
            this.txtMaNhanVien.TabIndex = 72;
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTimKH.Location = new System.Drawing.Point(366, 99);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(97, 32);
            this.btnTimKH.TabIndex = 70;
            this.btnTimKH.Text = "Tìm";
            this.btnTimKH.UseVisualStyleBackColor = false;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(538, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "TrangThai:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(535, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 20);
            this.label13.TabIndex = 64;
            this.label13.Text = "Tên nhân viên:";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(673, 64);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(174, 27);
            this.txtTenNhanVien.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(538, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Ngày tạo:";
            // 
            // dateNgayTao
            // 
            this.dateNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateNgayTao.Location = new System.Drawing.Point(673, 159);
            this.dateNgayTao.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayTao.Name = "dateNgayTao";
            this.dateNgayTao.Size = new System.Drawing.Size(174, 29);
            this.dateNgayTao.TabIndex = 61;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(172, 27);
            this.txtEmail.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Email:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(168, 172);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(172, 27);
            this.txtSDT.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã nhân viên:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(168, 139);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(172, 27);
            this.txtTenKH.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên khách hàng:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(43, 6);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(176, 31);
            this.label23.TabIndex = 80;
            this.label23.Text = "Tạo đơn hàng";
            // 
            // frmBanHang2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 731);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTaoDonHang);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnTaoLaiDonHang);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmBanHang2";
            this.Text = "Tạo đơn hàng";
            this.Load += new System.EventHandler(this.frmBanHang2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbChiTietSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTaoDonHang;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnTaoLaiDonHang;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTongPhaiTra;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtThueVAT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateNgayTao;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDTEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkKhachVangLai;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtTrangThaiDonHang;
    }
}