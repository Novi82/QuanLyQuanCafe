using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace QLQuanCafe.GUI.Dialog
{
    partial class CapNhatKho
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
            this.LMaNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.LDonViTinh = new DevComponents.DotNetBar.LabelX();
            this.LSoLuong = new DevComponents.DotNetBar.LabelX();
            this.LTenNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.LGiaNhap = new DevComponents.DotNetBar.LabelX();
            this.dipSoLuong = new DevComponents.Editors.DoubleInput();
            this.txtMaNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGiaNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDonViTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dipSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // LMaNguyenLieu
            // 
            // 
            // 
            // 
            this.LMaNguyenLieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LMaNguyenLieu.Location = new System.Drawing.Point(24, 55);
            this.LMaNguyenLieu.Name = "LMaNguyenLieu";
            this.LMaNguyenLieu.Size = new System.Drawing.Size(95, 23);
            this.LMaNguyenLieu.TabIndex = 0;
            this.LMaNguyenLieu.Text = "Mã Nguyên Liệu :";
            // 
            // LDonViTinh
            // 
            // 
            // 
            // 
            this.LDonViTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonViTinh.Location = new System.Drawing.Point(24, 182);
            this.LDonViTinh.Name = "LDonViTinh";
            this.LDonViTinh.Size = new System.Drawing.Size(75, 23);
            this.LDonViTinh.TabIndex = 1;
            this.LDonViTinh.Text = "Đơn Vị Tính :";
            // 
            // LSoLuong
            // 
            // 
            // 
            // 
            this.LSoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LSoLuong.Location = new System.Drawing.Point(24, 227);
            this.LSoLuong.Name = "LSoLuong";
            this.LSoLuong.Size = new System.Drawing.Size(75, 23);
            this.LSoLuong.TabIndex = 2;
            this.LSoLuong.Text = "Số Lượng :";
            // 
            // LTenNguyenLieu
            // 
            // 
            // 
            // 
            this.LTenNguyenLieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTenNguyenLieu.Location = new System.Drawing.Point(24, 100);
            this.LTenNguyenLieu.Name = "LTenNguyenLieu";
            this.LTenNguyenLieu.Size = new System.Drawing.Size(95, 23);
            this.LTenNguyenLieu.TabIndex = 3;
            this.LTenNguyenLieu.Text = "Tên Nguyên Liệu";
            // 
            // LGiaNhap
            // 
            // 
            // 
            // 
            this.LGiaNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LGiaNhap.Location = new System.Drawing.Point(24, 142);
            this.LGiaNhap.Name = "LGiaNhap";
            this.LGiaNhap.Size = new System.Drawing.Size(75, 23);
            this.LGiaNhap.TabIndex = 4;
            this.LGiaNhap.Text = "Giá Nhập :";
            // 
            // dipSoLuong
            // 
            this.dipSoLuong.AllowEmptyState = false;
            // 
            // 
            // 
            this.dipSoLuong.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dipSoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dipSoLuong.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dipSoLuong.DisplayFormat = "0";
            this.dipSoLuong.Increment = 1D;
            this.dipSoLuong.Location = new System.Drawing.Point(126, 227);
            this.dipSoLuong.MinValue = 0D;
            this.dipSoLuong.Name = "dipSoLuong";
            this.dipSoLuong.ShowUpDown = true;
            this.dipSoLuong.Size = new System.Drawing.Size(133, 20);
            this.dipSoLuong.TabIndex = 5;
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
            this.txtMaNguyenLieu.Location = new System.Drawing.Point(126, 57);
            this.txtMaNguyenLieu.Name = "txtMaNguyenLieu";
            this.txtMaNguyenLieu.ReadOnly = true;
            this.txtMaNguyenLieu.Size = new System.Drawing.Size(133, 20);
            this.txtMaNguyenLieu.TabIndex = 6;
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
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(126, 102);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.ReadOnly = true;
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(133, 20);
            this.txtTenNguyenLieu.TabIndex = 7;
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
            this.txtGiaNhap.Location = new System.Drawing.Point(126, 144);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(133, 20);
            this.txtGiaNhap.TabIndex = 8;
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
            this.txtDonViTinh.Location = new System.Drawing.Point(126, 184);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(133, 20);
            this.txtDonViTinh.TabIndex = 9;
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(44, 302);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 10;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(184, 302);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // CapNhatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 362);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Controls.Add(this.txtMaNguyenLieu);
            this.Controls.Add(this.dipSoLuong);
            this.Controls.Add(this.LGiaNhap);
            this.Controls.Add(this.LTenNguyenLieu);
            this.Controls.Add(this.LSoLuong);
            this.Controls.Add(this.LDonViTinh);
            this.Controls.Add(this.LMaNguyenLieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CapNhatKho";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Hiệu Chỉnh Số Lượng</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.HieuChinhSoLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dipSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX LMaNguyenLieu;
        private LabelX LDonViTinh;
        private LabelX LSoLuong;
        private LabelX LTenNguyenLieu;
        private LabelX LGiaNhap;
        private DoubleInput dipSoLuong;
        private TextBoxX txtMaNguyenLieu;
        private TextBoxX txtTenNguyenLieu;
        private TextBoxX txtGiaNhap;
        private TextBoxX txtDonViTinh;
        private ButtonX btnDongY;
        private ButtonX btnHuy;
    }
}