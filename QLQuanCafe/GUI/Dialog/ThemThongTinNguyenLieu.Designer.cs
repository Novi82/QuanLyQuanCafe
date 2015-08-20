using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace QLQuanCafe.GUI.Dialog
{
    partial class frmThemNguyenLieu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNguyenLieu));
            this.TenNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.TxtTenNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DonGia = new DevComponents.DotNetBar.LabelX();
            this.dipDonGia = new DevComponents.Editors.DoubleInput();
            this.DonViTinh = new DevComponents.DotNetBar.LabelX();
            this.btnThemDvt = new DevComponents.DotNetBar.ButtonX();
            this.cbxDonViTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.unitDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            ((System.ComponentModel.ISupportInitialize)(this.dipDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.TenNguyenLieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TenNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.TenNguyenLieu.Location = new System.Drawing.Point(12, 117);
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            this.TenNguyenLieu.Size = new System.Drawing.Size(98, 23);
            this.TenNguyenLieu.TabIndex = 0;
            this.TenNguyenLieu.Text = "Tên Nguyên Liệu :";
            // 
            // TxtTenNguyenLieu
            // 
            this.TxtTenNguyenLieu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtTenNguyenLieu.Border.Class = "TextBoxBorder";
            this.TxtTenNguyenLieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtTenNguyenLieu.DisabledBackColor = System.Drawing.Color.White;
            this.TxtTenNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.TxtTenNguyenLieu.Location = new System.Drawing.Point(116, 117);
            this.TxtTenNguyenLieu.Name = "TxtTenNguyenLieu";
            this.TxtTenNguyenLieu.Size = new System.Drawing.Size(129, 20);
            this.TxtTenNguyenLieu.TabIndex = 1;
            // 
            // DonGia
            // 
            this.DonGia.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.DonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DonGia.ForeColor = System.Drawing.Color.Black;
            this.DonGia.Location = new System.Drawing.Point(12, 159);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(75, 23);
            this.DonGia.TabIndex = 2;
            this.DonGia.Text = "Đơn Giá :";
            // 
            // dipDonGia
            // 
            this.dipDonGia.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dipDonGia.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dipDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dipDonGia.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dipDonGia.ForeColor = System.Drawing.Color.Black;
            this.dipDonGia.Increment = 1D;
            this.dipDonGia.Location = new System.Drawing.Point(116, 159);
            this.dipDonGia.MinValue = 0D;
            this.dipDonGia.Name = "dipDonGia";
            this.dipDonGia.ShowUpDown = true;
            this.dipDonGia.Size = new System.Drawing.Size(129, 20);
            this.dipDonGia.TabIndex = 3;
            // 
            // DonViTinh
            // 
            this.DonViTinh.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.DonViTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DonViTinh.ForeColor = System.Drawing.Color.Black;
            this.DonViTinh.Location = new System.Drawing.Point(12, 197);
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Size = new System.Drawing.Size(75, 23);
            this.DonViTinh.TabIndex = 4;
            this.DonViTinh.Text = "Đơn Vị Tính :";
            // 
            // btnThemDvt
            // 
            this.btnThemDvt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemDvt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemDvt.Location = new System.Drawing.Point(216, 198);
            this.btnThemDvt.Name = "btnThemDvt";
            this.btnThemDvt.Size = new System.Drawing.Size(29, 20);
            this.btnThemDvt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemDvt.TabIndex = 5;
            this.btnThemDvt.Text = "+";
            // 
            // cbxDonViTinh
            // 
            this.cbxDonViTinh.DataSource = this.unitDataBindingSource;
            this.cbxDonViTinh.DisplayMember = "UnitName";
            this.cbxDonViTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.cbxDonViTinh.FormattingEnabled = true;
            this.cbxDonViTinh.ItemHeight = 14;
            this.cbxDonViTinh.Location = new System.Drawing.Point(116, 198);
            this.cbxDonViTinh.Name = "cbxDonViTinh";
            this.cbxDonViTinh.Size = new System.Drawing.Size(94, 20);
            this.cbxDonViTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDonViTinh.TabIndex = 6;
            // 
            // unitDataBindingSource
            // 
            this.unitDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.UnitData);
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(35, 251);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 7;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(174, 251);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(71, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(86, 9);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.ReflectionEnabled = false;
            this.reflectionImage1.Size = new System.Drawing.Size(104, 102);
            this.reflectionImage1.TabIndex = 9;
            // 
            // frmThemNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(280, 292);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.cbxDonViTinh);
            this.Controls.Add(this.btnThemDvt);
            this.Controls.Add(this.DonViTinh);
            this.Controls.Add(this.dipDonGia);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.TxtTenNguyenLieu);
            this.Controls.Add(this.TenNguyenLieu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemNguyenLieu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Thêm Thông Tin Nguyên Liệu</font><font color=\"#ffffff\"></fo" +
    "nt>";
            this.Load += new System.EventHandler(this.ThemThongTinNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dipDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX TenNguyenLieu;
        private TextBoxX TxtTenNguyenLieu;
        private LabelX DonGia;
        private DoubleInput dipDonGia;
        private LabelX DonViTinh;
        private ButtonX btnThemDvt;
        private ComboBoxEx cbxDonViTinh;
        private ButtonX btnDongY;
        private ButtonX btnHuy;
        private ReflectionImage reflectionImage1;
        private System.Windows.Forms.BindingSource unitDataBindingSource;
    }
}