using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace QLQuanCafe.GUI.Dialog
{
    partial class NhapKho
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
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.LMaNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.LTenNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.LGiaNhap = new DevComponents.DotNetBar.LabelX();
            this.LSoLuong = new DevComponents.DotNetBar.LabelX();
            this.LDonViTinh = new DevComponents.DotNetBar.LabelX();
            this.txtMaNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGiaNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dipSoLuong = new DevComponents.Editors.DoubleInput();
            this.txtDonViTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            ((System.ComponentModel.ISupportInitialize)(this.dipSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(58, 393);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 0;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(186, 393);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // LMaNguyenLieu
            // 
            this.LMaNguyenLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LMaNguyenLieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LMaNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.LMaNguyenLieu.Location = new System.Drawing.Point(21, 146);
            this.LMaNguyenLieu.Name = "LMaNguyenLieu";
            this.LMaNguyenLieu.Size = new System.Drawing.Size(96, 23);
            this.LMaNguyenLieu.TabIndex = 2;
            this.LMaNguyenLieu.Text = "Mã Nguyên Liệu :";
            // 
            // LTenNguyenLieu
            // 
            this.LTenNguyenLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LTenNguyenLieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTenNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.LTenNguyenLieu.Location = new System.Drawing.Point(21, 194);
            this.LTenNguyenLieu.Name = "LTenNguyenLieu";
            this.LTenNguyenLieu.Size = new System.Drawing.Size(96, 23);
            this.LTenNguyenLieu.TabIndex = 3;
            this.LTenNguyenLieu.Text = "Tên Nguyên Liệu :";
            // 
            // LGiaNhap
            // 
            this.LGiaNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LGiaNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LGiaNhap.ForeColor = System.Drawing.Color.Black;
            this.LGiaNhap.Location = new System.Drawing.Point(21, 242);
            this.LGiaNhap.Name = "LGiaNhap";
            this.LGiaNhap.Size = new System.Drawing.Size(75, 23);
            this.LGiaNhap.TabIndex = 4;
            this.LGiaNhap.Text = "Giá Nhập :";
            // 
            // LSoLuong
            // 
            this.LSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LSoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LSoLuong.ForeColor = System.Drawing.Color.Black;
            this.LSoLuong.Location = new System.Drawing.Point(21, 333);
            this.LSoLuong.Name = "LSoLuong";
            this.LSoLuong.Size = new System.Drawing.Size(75, 23);
            this.LSoLuong.TabIndex = 5;
            this.LSoLuong.Text = "Số Lượng :";
            // 
            // LDonViTinh
            // 
            this.LDonViTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LDonViTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.LDonViTinh.Location = new System.Drawing.Point(21, 289);
            this.LDonViTinh.Name = "LDonViTinh";
            this.LDonViTinh.Size = new System.Drawing.Size(75, 23);
            this.LDonViTinh.TabIndex = 6;
            this.LDonViTinh.Text = "Đơn Vị Tính :";
            // 
            // txtMaNguyenLieu
            // 
            this.txtMaNguyenLieu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMaNguyenLieu.Border.Class = "TextBoxBorder";
            this.txtMaNguyenLieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNguyenLieu.DisabledBackColor = System.Drawing.Color.White;
            this.txtMaNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.txtMaNguyenLieu.Location = new System.Drawing.Point(123, 147);
            this.txtMaNguyenLieu.Name = "txtMaNguyenLieu";
            this.txtMaNguyenLieu.ReadOnly = true;
            this.txtMaNguyenLieu.Size = new System.Drawing.Size(138, 20);
            this.txtMaNguyenLieu.TabIndex = 7;
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenNguyenLieu.Border.Class = "TextBoxBorder";
            this.txtTenNguyenLieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNguyenLieu.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(123, 195);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.ReadOnly = true;
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(138, 20);
            this.txtTenNguyenLieu.TabIndex = 8;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtGiaNhap.Border.Class = "TextBoxBorder";
            this.txtGiaNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaNhap.DisabledBackColor = System.Drawing.Color.White;
            this.txtGiaNhap.ForeColor = System.Drawing.Color.Black;
            this.txtGiaNhap.Location = new System.Drawing.Point(123, 243);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(138, 20);
            this.txtGiaNhap.TabIndex = 9;
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
            this.dipSoLuong.Location = new System.Drawing.Point(123, 334);
            this.dipSoLuong.MinValue = 0D;
            this.dipSoLuong.Name = "dipSoLuong";
            this.dipSoLuong.ShowUpDown = true;
            this.dipSoLuong.Size = new System.Drawing.Size(138, 20);
            this.dipSoLuong.TabIndex = 12;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDonViTinh.Border.Class = "TextBoxBorder";
            this.txtDonViTinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonViTinh.DisabledBackColor = System.Drawing.Color.White;
            this.txtDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.txtDonViTinh.Location = new System.Drawing.Point(123, 290);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(138, 20);
            this.txtDonViTinh.TabIndex = 9;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.ForeColor = System.Drawing.Color.Black;
            this.reflectionImage1.Image = global::QLQuanCafe.Properties.Resources.NhapKho;
            this.reflectionImage1.Location = new System.Drawing.Point(88, 15);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.ReflectionEnabled = false;
            this.reflectionImage1.Size = new System.Drawing.Size(128, 108);
            this.reflectionImage1.TabIndex = 14;
            // 
            // NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 439);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.dipSoLuong);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Controls.Add(this.txtMaNguyenLieu);
            this.Controls.Add(this.LDonViTinh);
            this.Controls.Add(this.LSoLuong);
            this.Controls.Add(this.LGiaNhap);
            this.Controls.Add(this.LTenNguyenLieu);
            this.Controls.Add(this.LMaNguyenLieu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapKho";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Nhập Kho</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.NhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dipSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonX btnDongY;
        private ButtonX btnHuy;
        private LabelX LMaNguyenLieu;
        private LabelX LTenNguyenLieu;
        private LabelX LGiaNhap;
        private LabelX LSoLuong;
        private LabelX LDonViTinh;
        private TextBoxX txtMaNguyenLieu;
        private TextBoxX txtTenNguyenLieu;
        private TextBoxX txtGiaNhap;
        private DoubleInput dipSoLuong;
        private ReflectionImage reflectionImage1;
        private TextBoxX txtDonViTinh;
    }
}