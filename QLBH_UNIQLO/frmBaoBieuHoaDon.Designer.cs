namespace QLBH_UNIQLO
{
    partial class frmBaoBieuHoaDon
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
            this.btnDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatBaoBieu = new System.Windows.Forms.Button();
            this.reportDSHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Crimson;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(1069, 51);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(187, 44);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Về trang chủ";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(485, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Báo cáo hóa đơn";
            // 
            // btnXuatBaoBieu
            // 
            this.btnXuatBaoBieu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatBaoBieu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaoBieu.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoBieu.Location = new System.Drawing.Point(13, 51);
            this.btnXuatBaoBieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatBaoBieu.Name = "btnXuatBaoBieu";
            this.btnXuatBaoBieu.Size = new System.Drawing.Size(187, 44);
            this.btnXuatBaoBieu.TabIndex = 4;
            this.btnXuatBaoBieu.Text = "Xuất báo biểu";
            this.btnXuatBaoBieu.UseVisualStyleBackColor = false;
            this.btnXuatBaoBieu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // reportDSHoaDon
            // 
            this.reportDSHoaDon.LocalReport.ReportEmbeddedResource = "QLBH_UNIQLO.DanhSachHoaDon.rdlc";
            this.reportDSHoaDon.Location = new System.Drawing.Point(12, 132);
            this.reportDSHoaDon.Name = "reportDSHoaDon";
            this.reportDSHoaDon.ServerReport.BearerToken = null;
            this.reportDSHoaDon.Size = new System.Drawing.Size(1244, 529);
            this.reportDSHoaDon.TabIndex = 7;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(390, 73);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 22);
            this.dtpTuNgay.TabIndex = 8;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(635, 73);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 22);
            this.dtpDenNgay.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Đến ngày:";
            // 
            // frmBaoBieuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 698);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.reportDSHoaDon);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXuatBaoBieu);
            this.Name = "frmBaoBieuHoaDon";
            this.Text = "Báo cáo hóa đơn";
            this.Load += new System.EventHandler(this.frmBaoBieuNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatBaoBieu;
        private Microsoft.Reporting.WinForms.ReportViewer reportDSHoaDon;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}