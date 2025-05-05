using System.Windows.Forms;

namespace QLBH_UNIQLO
{
    partial class frmThanhToan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblPTTT;
        private System.Windows.Forms.Label lblTienNhan;
        private System.Windows.Forms.Label lblTienThoi;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cbPTTT;
        private System.Windows.Forms.TextBox txtTienNhan;
        private System.Windows.Forms.TextBox txtTienThoi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblPTTT = new System.Windows.Forms.Label();
            this.lblTienNhan = new System.Windows.Forms.Label();
            this.lblTienThoi = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.cbPTTT = new System.Windows.Forms.ComboBox();
            this.txtTienNhan = new System.Windows.Forms.TextBox();
            this.txtTienThoi = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(30, 30);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(100, 23);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng thanh toán:";
            // 
            // lblPTTT
            // 
            this.lblPTTT.Location = new System.Drawing.Point(30, 70);
            this.lblPTTT.Name = "lblPTTT";
            this.lblPTTT.Size = new System.Drawing.Size(100, 23);
            this.lblPTTT.TabIndex = 2;
            this.lblPTTT.Text = "Phương thức:";
            // 
            // lblTienNhan
            // 
            this.lblTienNhan.Location = new System.Drawing.Point(30, 110);
            this.lblTienNhan.Name = "lblTienNhan";
            this.lblTienNhan.Size = new System.Drawing.Size(100, 23);
            this.lblTienNhan.TabIndex = 4;
            this.lblTienNhan.Text = "Tiền khách đưa:";
            // 
            // lblTienThoi
            // 
            this.lblTienThoi.Location = new System.Drawing.Point(30, 150);
            this.lblTienThoi.Name = "lblTienThoi";
            this.lblTienThoi.Size = new System.Drawing.Size(100, 23);
            this.lblTienThoi.TabIndex = 6;
            this.lblTienThoi.Text = "Tiền thối lại:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(160, 30);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(200, 22);
            this.txtTongTien.TabIndex = 1;
            // 
            // cbPTTT
            // 
            this.cbPTTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTTT.Location = new System.Drawing.Point(160, 70);
            this.cbPTTT.Name = "cbPTTT";
            this.cbPTTT.Size = new System.Drawing.Size(200, 24);
            this.cbPTTT.TabIndex = 3;
            this.cbPTTT.SelectedIndexChanged += new System.EventHandler(this.cbPTTT_SelectedIndexChanged);
            // 
            // txtTienNhan
            // 
            this.txtTienNhan.Location = new System.Drawing.Point(160, 110);
            this.txtTienNhan.Name = "txtTienNhan";
            this.txtTienNhan.Size = new System.Drawing.Size(200, 22);
            this.txtTienNhan.TabIndex = 5;
            this.txtTienNhan.TextChanged += new System.EventHandler(this.txtTienNhan_TextChanged);
            // 
            // txtTienThoi
            // 
            this.txtTienThoi.Location = new System.Drawing.Point(160, 150);
            this.txtTienThoi.Name = "txtTienThoi";
            this.txtTienThoi.ReadOnly = true;
            this.txtTienThoi.Size = new System.Drawing.Size(200, 22);
            this.txtTienThoi.TabIndex = 7;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(50, 200);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(200, 200);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThanhToan
            // 
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblPTTT);
            this.Controls.Add(this.cbPTTT);
            this.Controls.Add(this.lblTienNhan);
            this.Controls.Add(this.txtTienNhan);
            this.Controls.Add(this.lblTienThoi);
            this.Controls.Add(this.txtTienThoi);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.Name = "frmThanhToan";
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
