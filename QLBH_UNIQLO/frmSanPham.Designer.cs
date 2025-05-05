namespace QLBH_UNIQLO
{
    partial class frmSanPham
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

        private void InitializeComponent()
        {
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNhapLaiNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSanPham.ColumnHeadersHeight = 29;
            this.dgvSanPham.Location = new System.Drawing.Point(20, 250);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.Size = new System.Drawing.Size(942, 300);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(20, 57);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(200, 22);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(310, 57);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(200, 22);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(20, 144);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 22);
            this.txtSize.TabIndex = 4;
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(220, 144);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(100, 22);
            this.txtMau.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(430, 144);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(80, 22);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(590, 144);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 7;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.Location = new System.Drawing.Point(590, 57);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(150, 24);
            this.cbLoaiSP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Loại sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Màu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số lượng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "GIá";
            // 
            // btnNhapLaiNV
            // 
            this.btnNhapLaiNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNhapLaiNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLaiNV.ForeColor = System.Drawing.Color.White;
            this.btnNhapLaiNV.Image = global::QLBH_UNIQLO.Properties.Resources.refresh16x16;
            this.btnNhapLaiNV.Location = new System.Drawing.Point(775, 189);
            this.btnNhapLaiNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapLaiNV.Name = "btnNhapLaiNV";
            this.btnNhapLaiNV.Size = new System.Drawing.Size(187, 41);
            this.btnNhapLaiNV.TabIndex = 30;
            this.btnNhapLaiNV.Text = " Nhập lại";
            this.btnNhapLaiNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLaiNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapLaiNV.UseVisualStyleBackColor = false;
            this.btnNhapLaiNV.Click += new System.EventHandler(this.btnNhapLaiNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV.Image = global::QLBH_UNIQLO.Properties.Resources.trash16x16;
            this.btnXoaNV.Location = new System.Drawing.Point(522, 189);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(187, 41);
            this.btnXoaNV.TabIndex = 29;
            this.btnXoaNV.Text = " Xóa";
            this.btnXoaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSuaNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.ForeColor = System.Drawing.Color.White;
            this.btnSuaNV.Image = global::QLBH_UNIQLO.Properties.Resources.editor16x16;
            this.btnSuaNV.Location = new System.Drawing.Point(269, 189);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(187, 41);
            this.btnSuaNV.TabIndex = 28;
            this.btnSuaNV.Text = " Sửa";
            this.btnSuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThemNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Image = global::QLBH_UNIQLO.Properties.Resources.plus16x16;
            this.btnThemNV.Location = new System.Drawing.Point(16, 189);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(187, 41);
            this.btnThemNV.TabIndex = 27;
            this.btnThemNV.Text = " Thêm";
            this.btnThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Crimson;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.SeaShell;
            this.btnDong.Location = new System.Drawing.Point(826, 14);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(136, 41);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Về trang chủ";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmSanPham
            // 
            this.ClientSize = new System.Drawing.Size(993, 600);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnNhapLaiNV);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.cbLoaiSP);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtMau);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Name = "frmSanPham";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNhapLaiNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnDong;
    }
}
