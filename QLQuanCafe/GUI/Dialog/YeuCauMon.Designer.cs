using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace QLQuanCafe.GUI.Dialog
{
    partial class YeuCauMon
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
            this.LThanhTien = new DevComponents.DotNetBar.LabelX();
            this.dipSoLuong = new DevComponents.Editors.DoubleInput();
            this.LSoLuong = new DevComponents.DotNetBar.LabelX();
            this.LDonGia = new DevComponents.DotNetBar.LabelX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.txtDonGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtThanhTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTenMon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.imgMonAn = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.dipSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // LThanhTien
            // 
            this.LThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LThanhTien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LThanhTien.ForeColor = System.Drawing.Color.Black;
            this.LThanhTien.Location = new System.Drawing.Point(267, 105);
            this.LThanhTien.Name = "LThanhTien";
            this.LThanhTien.Size = new System.Drawing.Size(75, 23);
            this.LThanhTien.TabIndex = 3;
            this.LThanhTien.Text = "Thành Tiền :";
            // 
            // dipSoLuong
            // 
            this.dipSoLuong.AllowEmptyState = false;
            this.dipSoLuong.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dipSoLuong.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dipSoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dipSoLuong.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dipSoLuong.DisplayFormat = "0";
            this.dipSoLuong.ForeColor = System.Drawing.Color.Black;
            this.dipSoLuong.Increment = 1D;
            this.dipSoLuong.Location = new System.Drawing.Point(508, 60);
            this.dipSoLuong.MinValue = 0D;
            this.dipSoLuong.Name = "dipSoLuong";
            this.dipSoLuong.ShowUpDown = true;
            this.dipSoLuong.Size = new System.Drawing.Size(103, 20);
            this.dipSoLuong.TabIndex = 1;
            this.dipSoLuong.ValueChanged += new System.EventHandler(this.dipSoLuong_ValueChanged);
            // 
            // LSoLuong
            // 
            this.LSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LSoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LSoLuong.ForeColor = System.Drawing.Color.Black;
            this.LSoLuong.Location = new System.Drawing.Point(495, 57);
            this.LSoLuong.Name = "LSoLuong";
            this.LSoLuong.Size = new System.Drawing.Size(18, 23);
            this.LSoLuong.TabIndex = 1;
            this.LSoLuong.Text = "x";
            // 
            // LDonGia
            // 
            this.LDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonGia.ForeColor = System.Drawing.Color.Black;
            this.LDonGia.Location = new System.Drawing.Point(267, 60);
            this.LDonGia.Name = "LDonGia";
            this.LDonGia.Size = new System.Drawing.Size(75, 23);
            this.LDonGia.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.LDonGia.TabIndex = 0;
            this.LDonGia.Text = "Đơn Giá :";
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(360, 256);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 1;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(536, 256);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDonGia.Border.Class = "TextBoxBorder";
            this.txtDonGia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonGia.DisabledBackColor = System.Drawing.Color.White;
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.Location = new System.Drawing.Point(360, 60);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PreventEnterBeep = true;
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(129, 20);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtThanhTien.Border.Class = "TextBoxBorder";
            this.txtThanhTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtThanhTien.DisabledBackColor = System.Drawing.Color.White;
            this.txtThanhTien.ForeColor = System.Drawing.Color.Black;
            this.txtThanhTien.Location = new System.Drawing.Point(360, 108);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PreventEnterBeep = true;
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(251, 20);
            this.txtThanhTien.TabIndex = 5;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(267, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Món :";
            // 
            // txtTenMon
            // 
            this.txtTenMon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenMon.Border.Class = "TextBoxBorder";
            this.txtTenMon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenMon.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenMon.ForeColor = System.Drawing.Color.Black;
            this.txtTenMon.Location = new System.Drawing.Point(360, 17);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.PreventEnterBeep = true;
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(251, 20);
            this.txtTenMon.TabIndex = 4;
            // 
            // imgMonAn
            // 
            this.imgMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.imgMonAn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.imgMonAn.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.imgMonAn.ForeColor = System.Drawing.Color.Black;
            this.imgMonAn.Location = new System.Drawing.Point(23, 21);
            this.imgMonAn.Name = "imgMonAn";
            this.imgMonAn.Size = new System.Drawing.Size(238, 258);
            this.imgMonAn.TabIndex = 6;
            this.imgMonAn.Text = "Hình Ảnh";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(267, 148);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Ghi Chú :";
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtGhiChu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.Location = new System.Drawing.Point(360, 148);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.txtGhiChu.Size = new System.Drawing.Size(251, 100);
            this.txtGhiChu.TabIndex = 7;
            // 
            // YeuCauMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 295);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.imgMonAn);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.dipSoLuong);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.LThanhTien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.LSoLuong);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.LDonGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YeuCauMon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Gọi Món</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.YeuCauMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dipSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX LDonGia;
        private LabelX LThanhTien;
        private DoubleInput dipSoLuong;
        private LabelX LSoLuong;
        private ButtonX btnDongY;
        private ButtonX btnHuy;
        private TextBoxX txtDonGia;
        private TextBoxX txtThanhTien;
        private LabelX labelX1;
        private TextBoxX txtTenMon;
        private LabelX imgMonAn;
        private LabelX labelX2;
        private RichTextBoxEx txtGhiChu;
    }
}