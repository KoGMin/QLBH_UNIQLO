namespace QLBH_UNIQLO
{
    partial class frmHoaDonBanLe
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
            this.cbTenSanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMaVanDon = new System.Windows.Forms.TextBox();
            this.cbPTVC = new System.Windows.Forms.ComboBox();
            this.cbPTTT = new System.Windows.Forms.ComboBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateNgayTao = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTongPhaiTra = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtThueVAT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnTaoLaiDonHang = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnVeTrangChu = new System.Windows.Forms.Button();
            this.btnTaoDonHang = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTenSanPham);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtMaSanPham);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1258, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbTenSanPham
            // 
            this.cbTenSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbTenSanPham.FormattingEnabled = true;
            this.cbTenSanPham.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cbTenSanPham.Location = new System.Drawing.Point(157, 27);
            this.cbTenSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cbTenSanPham.Name = "cbTenSanPham";
            this.cbTenSanPham.Size = new System.Drawing.Size(338, 32);
            this.cbTenSanPham.TabIndex = 41;
            this.cbTenSanPham.SelectedIndexChanged += new System.EventHandler(this.cbTenSanPham_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(798, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(884, 27);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(159, 29);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(157, 66);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(172, 27);
            this.txtMaSanPham.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(884, 65);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(159, 27);
            this.txtSoLuong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtMaVanDon);
            this.groupBox2.Controls.Add(this.cbPTVC);
            this.groupBox2.Controls.Add(this.cbPTTT);
            this.groupBox2.Controls.Add(this.txtMaNhanVien);
            this.groupBox2.Controls.Add(this.btnTimNV);
            this.groupBox2.Controls.Add(this.btnTimKH);
            this.groupBox2.Controls.Add(this.txtMaKhachHang);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTenNhanVien);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dateNgayTao);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSoDienThoai);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTenKhachHang);
            this.groupBox2.Controls.Add(this.txtMaHoaDon);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 288);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đơn hàng";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(535, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 20);
            this.label20.TabIndex = 75;
            this.label20.Text = "Mã vận đơn:";
            // 
            // txtMaVanDon
            // 
            this.txtMaVanDon.Location = new System.Drawing.Point(673, 108);
            this.txtMaVanDon.Name = "txtMaVanDon";
            this.txtMaVanDon.Size = new System.Drawing.Size(174, 27);
            this.txtMaVanDon.TabIndex = 74;
            // 
            // cbPTVC
            // 
            this.cbPTVC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbPTVC.FormattingEnabled = true;
            this.cbPTVC.Items.AddRange(new object[] {
            "Click and collect",
            "Giao tận nơi",
            "Mua tại chỗ"});
            this.cbPTVC.Location = new System.Drawing.Point(673, 248);
            this.cbPTVC.Margin = new System.Windows.Forms.Padding(4);
            this.cbPTVC.Name = "cbPTVC";
            this.cbPTVC.Size = new System.Drawing.Size(174, 32);
            this.cbPTVC.TabIndex = 73;
            // 
            // cbPTTT
            // 
            this.cbPTTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbPTTT.FormattingEnabled = true;
            this.cbPTTT.Items.AddRange(new object[] {
            "Chuyển khoản ngân hàng",
            "Ví điện tử",
            "Tiền mặt"});
            this.cbPTTT.Location = new System.Drawing.Point(673, 208);
            this.cbPTTT.Margin = new System.Windows.Forms.Padding(4);
            this.cbPTTT.Name = "cbPTTT";
            this.cbPTTT.Size = new System.Drawing.Size(174, 32);
            this.cbPTTT.TabIndex = 42;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(673, 26);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(109, 27);
            this.txtMaNhanVien.TabIndex = 72;
            // 
            // btnTimNV
            // 
            this.btnTimNV.Location = new System.Drawing.Point(788, 28);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(59, 26);
            this.btnTimNV.TabIndex = 71;
            this.btnTimNV.Text = "Tìm";
            this.btnTimNV.UseVisualStyleBackColor = true;
            this.btnTimNV.Click += new System.EventHandler(this.btnTimNV_Click);
            // 
            // btnTimKH
            // 
            this.btnTimKH.Location = new System.Drawing.Point(353, 100);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(75, 26);
            this.btnTimKH.TabIndex = 70;
            this.btnTimKH.Text = "Tìm";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(157, 33);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(172, 27);
            this.txtMaKhachHang.TabIndex = 69;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(535, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 68;
            this.label15.Text = "Mã PTVC:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(535, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "Mã PTTT:";
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
            this.label12.Location = new System.Drawing.Point(535, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Ngày tạo:";
            // 
            // dateNgayTao
            // 
            this.dateNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateNgayTao.Location = new System.Drawing.Point(673, 175);
            this.dateNgayTao.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayTao.Name = "dateNgayTao";
            this.dateNgayTao.Size = new System.Drawing.Size(174, 29);
            this.dateNgayTao.TabIndex = 61;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(157, 165);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(338, 27);
            this.txtDiaChi.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(172, 27);
            this.txtEmail.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Email:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(157, 99);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.ReadOnly = true;
            this.txtSoDienThoai.Size = new System.Drawing.Size(172, 27);
            this.txtSoDienThoai.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 102);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(157, 66);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(172, 27);
            this.txtTenKhachHang.TabIndex = 3;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(673, 141);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(174, 27);
            this.txtMaHoaDon.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên khách hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã khách hàng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtTongPhaiTra);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtThueVAT);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtThanhTien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(918, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 268);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thanh toán";
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
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtThueVAT
            // 
            this.txtThueVAT.Location = new System.Drawing.Point(149, 89);
            this.txtThueVAT.Name = "txtThueVAT";
            this.txtThueVAT.Size = new System.Drawing.Size(159, 27);
            this.txtThueVAT.TabIndex = 71;
            this.txtThueVAT.TextChanged += new System.EventHandler(this.txtChiecKhau_TextChanged_1);
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
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(34, 487);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(1258, 173);
            this.dgvSanPham.TabIndex = 44;
            // 
            // btnTaoLaiDonHang
            // 
            this.btnTaoLaiDonHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTaoLaiDonHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTaoLaiDonHang.ForeColor = System.Drawing.Color.White;
            this.btnTaoLaiDonHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTaoLaiDonHang.Location = new System.Drawing.Point(179, 680);
            this.btnTaoLaiDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoLaiDonHang.Name = "btnTaoLaiDonHang";
            this.btnTaoLaiDonHang.Size = new System.Drawing.Size(187, 41);
            this.btnTaoLaiDonHang.TabIndex = 46;
            this.btnTaoLaiDonHang.Text = "Tạo lại đơn hàng";
            this.btnTaoLaiDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoLaiDonHang.UseVisualStyleBackColor = false;
            this.btnTaoLaiDonHang.Click += new System.EventHandler(this.btnTaoMoiDonHang_Click_1);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.Green;
            this.btnThemSanPham.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnThemSanPham.ForeColor = System.Drawing.Color.White;
            this.btnThemSanPham.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThemSanPham.Location = new System.Drawing.Point(387, 680);
            this.btnThemSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(236, 41);
            this.btnThemSanPham.TabIndex = 47;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnLuuVaThemSanPham_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.Goldenrod;
            this.btnInHoaDon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnInHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnInHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInHoaDon.Location = new System.Drawing.Point(890, 680);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(187, 41);
            this.btnInHoaDon.TabIndex = 51;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnVeTrangChu
            // 
            this.btnVeTrangChu.BackColor = System.Drawing.Color.Crimson;
            this.btnVeTrangChu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnVeTrangChu.Location = new System.Drawing.Point(1113, 841);
            this.btnVeTrangChu.Margin = new System.Windows.Forms.Padding(4);
            this.btnVeTrangChu.Name = "btnVeTrangChu";
            this.btnVeTrangChu.Size = new System.Drawing.Size(149, 41);
            this.btnVeTrangChu.TabIndex = 66;
            this.btnVeTrangChu.Text = "Về trang chủ";
            this.btnVeTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVeTrangChu.UseVisualStyleBackColor = false;
            this.btnVeTrangChu.Click += new System.EventHandler(this.btnVeTrangChu_Click);
            // 
            // btnTaoDonHang
            // 
            this.btnTaoDonHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTaoDonHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTaoDonHang.ForeColor = System.Drawing.Color.White;
            this.btnTaoDonHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTaoDonHang.Location = new System.Drawing.Point(665, 680);
            this.btnTaoDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoDonHang.Name = "btnTaoDonHang";
            this.btnTaoDonHang.Size = new System.Drawing.Size(187, 41);
            this.btnTaoDonHang.TabIndex = 67;
            this.btnTaoDonHang.Text = "Tạo đơn hàng";
            this.btnTaoDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoDonHang.UseVisualStyleBackColor = false;
            this.btnTaoDonHang.Click += new System.EventHandler(this.btnTaoDonHang_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(28, 9);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(193, 31);
            this.label23.TabIndex = 68;
            this.label23.Text = "Hóa đơn bán lẻ";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Crimson;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(1137, 680);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(149, 41);
            this.btnDong.TabIndex = 69;
            this.btnDong.Text = "Về trang chủ";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmHoaDonBanLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 759);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnTaoDonHang);
            this.Controls.Add(this.btnVeTrangChu);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.btnTaoLaiDonHang);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDonBanLe";
            this.Text = "Hóa đơn bán lẻ";
            this.Load += new System.EventHandler(this.frmHoaDonBanLe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cbTenSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateNgayTao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTongPhaiTra;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtThueVAT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnTaoLaiDonHang;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnVeTrangChu;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Button btnTaoDonHang;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.ComboBox cbPTVC;
        private System.Windows.Forms.ComboBox cbPTTT;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMaVanDon;
    }
}