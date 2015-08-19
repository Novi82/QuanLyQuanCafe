using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI
{
    partial class XuatKho
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
            this.LSoLuong = new DevComponents.DotNetBar.LabelX();
            this.LMaNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.LTenNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.LGiaNhap = new DevComponents.DotNetBar.LabelX();
            this.LDonViTinh = new DevComponents.DotNetBar.LabelX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.txtMaNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGiaNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDonViTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.dipSoLuong = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.dipSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // LSoLuong
            // 
            this.LSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LSoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LSoLuong.ForeColor = System.Drawing.Color.Black;
            this.LSoLuong.Location = new System.Drawing.Point(24, 325);
            this.LSoLuong.Name = "LSoLuong";
            this.LSoLuong.Size = new System.Drawing.Size(75, 23);
            this.LSoLuong.TabIndex = 0;
            this.LSoLuong.Text = "Số Lượng :";
            // 
            // LMaNguyenLieu
            // 
            this.LMaNguyenLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LMaNguyenLieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LMaNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.LMaNguyenLieu.Location = new System.Drawing.Point(24, 148);
            this.LMaNguyenLieu.Name = "LMaNguyenLieu";
            this.LMaNguyenLieu.Size = new System.Drawing.Size(99, 23);
            this.LMaNguyenLieu.TabIndex = 1;
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
            this.LTenNguyenLieu.Location = new System.Drawing.Point(24, 188);
            this.LTenNguyenLieu.Name = "LTenNguyenLieu";
            this.LTenNguyenLieu.Size = new System.Drawing.Size(91, 23);
            this.LTenNguyenLieu.TabIndex = 2;
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
            this.LGiaNhap.Location = new System.Drawing.Point(24, 232);
            this.LGiaNhap.Name = "LGiaNhap";
            this.LGiaNhap.Size = new System.Drawing.Size(75, 23);
            this.LGiaNhap.TabIndex = 3;
            this.LGiaNhap.Text = "Giá Nhập :";
            // 
            // LDonViTinh
            // 
            this.LDonViTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LDonViTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.LDonViTinh.Location = new System.Drawing.Point(24, 281);
            this.LDonViTinh.Name = "LDonViTinh";
            this.LDonViTinh.Size = new System.Drawing.Size(75, 23);
            this.LDonViTinh.TabIndex = 4;
            this.LDonViTinh.Text = "Đơn Vị Tính :";
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(48, 390);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 5;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(199, 390);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.txtMaNguyenLieu.Location = new System.Drawing.Point(153, 150);
            this.txtMaNguyenLieu.Name = "txtMaNguyenLieu";
            this.txtMaNguyenLieu.ReadOnly = true;
            this.txtMaNguyenLieu.Size = new System.Drawing.Size(121, 20);
            this.txtMaNguyenLieu.TabIndex = 8;
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
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(153, 190);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.ReadOnly = true;
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(121, 20);
            this.txtTenNguyenLieu.TabIndex = 9;
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
            this.txtGiaNhap.Location = new System.Drawing.Point(153, 234);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(121, 20);
            this.txtGiaNhap.TabIndex = 10;
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
            this.txtDonViTinh.Location = new System.Drawing.Point(153, 283);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(121, 20);
            this.txtDonViTinh.TabIndex = 11;
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
            this.reflectionImage1.Image = global::QLQuanCafe.Properties.Resources.XuatKho;
            this.reflectionImage1.Location = new System.Drawing.Point(94, 12);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.ReflectionEnabled = false;
            this.reflectionImage1.Size = new System.Drawing.Size(128, 116);
            this.reflectionImage1.TabIndex = 7;
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
            this.dipSoLuong.Location = new System.Drawing.Point(153, 326);
            this.dipSoLuong.MinValue = 0D;
            this.dipSoLuong.Name = "dipSoLuong";
            this.dipSoLuong.ShowUpDown = true;
            this.dipSoLuong.Size = new System.Drawing.Size(121, 20);
            this.dipSoLuong.TabIndex = 13;
            // 
            // XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 438);
            this.Controls.Add(this.dipSoLuong);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Controls.Add(this.txtMaNguyenLieu);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.LDonViTinh);
            this.Controls.Add(this.LGiaNhap);
            this.Controls.Add(this.LTenNguyenLieu);
            this.Controls.Add(this.LMaNguyenLieu);
            this.Controls.Add(this.LSoLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "XuatKho";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Xuất Kho</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.XuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dipSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX LSoLuong;
        private LabelX LMaNguyenLieu;
        private LabelX LTenNguyenLieu;
        private LabelX LGiaNhap;
        private LabelX LDonViTinh;
        private ButtonX btnDongY;
        private ButtonX btnHuy;
        private ReflectionImage reflectionImage1;
        private TextBoxX txtMaNguyenLieu;
        private TextBoxX txtTenNguyenLieu;
        private TextBoxX txtGiaNhap;
        private TextBoxX txtDonViTinh;
        private DevComponents.Editors.DoubleInput dipSoLuong;
    }
}