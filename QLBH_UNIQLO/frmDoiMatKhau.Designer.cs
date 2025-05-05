namespace QLBH_UNIQLO
{
    partial class frmDoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMKCu = new System.Windows.Forms.Label();
            this.lblMKMoi = new System.Windows.Forms.Label();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMKCu
            // 
            this.lblMKCu.AutoSize = true;
            this.lblMKCu.Location = new System.Drawing.Point(30, 30);
            this.lblMKCu.Name = "lblMKCu";
            this.lblMKCu.Size = new System.Drawing.Size(109, 16);
            this.lblMKCu.TabIndex = 0;
            this.lblMKCu.Text = "Mật khẩu hiện tại:";
            // 
            // lblMKMoi
            // 
            this.lblMKMoi.AutoSize = true;
            this.lblMKMoi.Location = new System.Drawing.Point(30, 70);
            this.lblMKMoi.Name = "lblMKMoi";
            this.lblMKMoi.Size = new System.Drawing.Size(89, 16);
            this.lblMKMoi.TabIndex = 1;
            this.lblMKMoi.Text = "Mật khẩu mới:";
            // 
            // lblXacNhan
            // 
            this.lblXacNhan.AutoSize = true;
            this.lblXacNhan.Location = new System.Drawing.Point(30, 110);
            this.lblXacNhan.Name = "lblXacNhan";
            this.lblXacNhan.Size = new System.Drawing.Size(147, 16);
            this.lblXacNhan.TabIndex = 2;
            this.lblXacNhan.Text = "Xác nhận mật khẩu mới:";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(180, 27);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(180, 22);
            this.txtMatKhauCu.TabIndex = 3;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(180, 67);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(180, 22);
            this.txtMatKhauMoi.TabIndex = 4;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Location = new System.Drawing.Point(180, 107);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.PasswordChar = '*';
            this.txtXacNhan.Size = new System.Drawing.Size(180, 22);
            this.txtXacNhan.TabIndex = 5;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(180, 150);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(120, 30);
            this.btnDoiMatKhau.TabIndex = 6;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDoiMatKhau
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMKCu);
            this.Controls.Add(this.lblMKMoi);
            this.Controls.Add(this.lblXacNhan);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblMKCu;
        private System.Windows.Forms.Label lblMKMoi;
        private System.Windows.Forms.Label lblXacNhan;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button button1;
    }
}
