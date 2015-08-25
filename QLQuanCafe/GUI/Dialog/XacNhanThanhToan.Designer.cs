using System.ComponentModel;
using DevComponents.DotNetBar;

namespace QLQuanCafe.GUI.Dialog
{
    partial class XacNhanThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.GThanhtoan = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.BtnDongVaIn = new DevComponents.DotNetBar.ButtonX();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.txtBan = new DevComponents.DotNetBar.LabelX();
            this.txtKhuVuc = new DevComponents.DotNetBar.LabelX();
            this.txtTongTien = new DevComponents.DotNetBar.LabelX();
            this.GThanhtoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // GThanhtoan
            // 
            this.GThanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GThanhtoan.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GThanhtoan.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GThanhtoan.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.GThanhtoan.Controls.Add(this.txtKhuVuc);
            this.GThanhtoan.Controls.Add(this.txtTongTien);
            this.GThanhtoan.Controls.Add(this.txtBan);
            this.GThanhtoan.Controls.Add(this.labelX2);
            this.GThanhtoan.Controls.Add(this.labelX3);
            this.GThanhtoan.Controls.Add(this.labelX1);
            this.GThanhtoan.DisabledBackColor = System.Drawing.Color.Empty;
            this.GThanhtoan.Location = new System.Drawing.Point(3, 12);
            this.GThanhtoan.Name = "GThanhtoan";
            this.GThanhtoan.Size = new System.Drawing.Size(357, 148);
            // 
            // 
            // 
            this.GThanhtoan.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(217)))), ((int)(((byte)(185)))));
            this.GThanhtoan.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.GThanhtoan.Style.BackColorGradientAngle = 90;
            this.GThanhtoan.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GThanhtoan.Style.BorderBottomWidth = 1;
            this.GThanhtoan.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(164)))), ((int)(((byte)(90)))));
            this.GThanhtoan.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GThanhtoan.Style.BorderLeftWidth = 1;
            this.GThanhtoan.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GThanhtoan.Style.BorderRightWidth = 1;
            this.GThanhtoan.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GThanhtoan.Style.BorderTopWidth = 1;
            this.GThanhtoan.Style.CornerDiameter = 4;
            this.GThanhtoan.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GThanhtoan.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GThanhtoan.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(31)))));
            this.GThanhtoan.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GThanhtoan.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GThanhtoan.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GThanhtoan.TabIndex = 8;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(177, 18);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(74, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Khu Vực :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(17, 84);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(85, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tổng Tiền : ";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(17, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(43, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Bàn :";
            // 
            // BtnDongVaIn
            // 
            this.BtnDongVaIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnDongVaIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnDongVaIn.Location = new System.Drawing.Point(12, 189);
            this.BtnDongVaIn.Name = "BtnDongVaIn";
            this.BtnDongVaIn.Size = new System.Drawing.Size(75, 23);
            this.BtnDongVaIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnDongVaIn.TabIndex = 9;
            this.BtnDongVaIn.Text = "Đóng Và In";
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Location = new System.Drawing.Point(142, 189);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 9;
            this.btnIn.Text = "In Hóa Đơn";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(277, 189);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtBan
            // 
            // 
            // 
            // 
            this.txtBan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBan.Location = new System.Drawing.Point(75, 20);
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(96, 23);
            this.txtBan.TabIndex = 10;
            this.txtBan.Text = "labelX4";
            // 
            // txtKhuVuc
            // 
            // 
            // 
            // 
            this.txtKhuVuc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKhuVuc.Location = new System.Drawing.Point(250, 18);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(96, 23);
            this.txtKhuVuc.TabIndex = 10;
            this.txtKhuVuc.Text = "labelX4";
            // 
            // txtTongTien
            // 
            // 
            // 
            // 
            this.txtTongTien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTongTien.Location = new System.Drawing.Point(108, 84);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(240, 23);
            this.txtTongTien.TabIndex = 10;
            this.txtTongTien.Text = "labelX4";
            // 
            // XacNhanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(364, 233);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.BtnDongVaIn);
            this.Controls.Add(this.GThanhtoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XacNhanThanhToan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Xác Nhận Thanh Toán</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.XacNhanThanhToan_Load);
            this.GThanhtoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GThanhtoan;
        private LabelX labelX2;
        private LabelX labelX1;
        private ButtonX BtnDongVaIn;
        private ButtonX btnIn;
        private ButtonX btnThoat;
        private LabelX labelX3;
        private LabelX txtKhuVuc;
        private LabelX txtTongTien;
        private LabelX txtBan;

    }
}