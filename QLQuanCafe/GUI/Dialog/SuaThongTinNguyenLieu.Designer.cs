using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace QLQuanCafe.GUI.Dialog
{
    partial class frmSuaThongTinNguyenLieu
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
            this.LTenNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.LDonViTinh = new DevComponents.DotNetBar.LabelX();
            this.LDonGia = new DevComponents.DotNetBar.LabelX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.cbxDonViTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.unitDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dipDonGia = new DevComponents.Editors.DoubleInput();
            this.txtTenNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThemDonViTinh = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // LTenNguyenLieu
            // 
            this.LTenNguyenLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LTenNguyenLieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTenNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.LTenNguyenLieu.Location = new System.Drawing.Point(15, 40);
            this.LTenNguyenLieu.Name = "LTenNguyenLieu";
            this.LTenNguyenLieu.Size = new System.Drawing.Size(111, 23);
            this.LTenNguyenLieu.TabIndex = 0;
            this.LTenNguyenLieu.Text = "Tên Nguyên Liệu :";
            // 
            // LDonViTinh
            // 
            this.LDonViTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LDonViTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.LDonViTinh.Location = new System.Drawing.Point(15, 82);
            this.LDonViTinh.Name = "LDonViTinh";
            this.LDonViTinh.Size = new System.Drawing.Size(75, 23);
            this.LDonViTinh.TabIndex = 1;
            this.LDonViTinh.Text = "Đơn Giá :";
            // 
            // LDonGia
            // 
            this.LDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonGia.ForeColor = System.Drawing.Color.Black;
            this.LDonGia.Location = new System.Drawing.Point(15, 125);
            this.LDonGia.Name = "LDonGia";
            this.LDonGia.Size = new System.Drawing.Size(75, 23);
            this.LDonGia.TabIndex = 2;
            this.LDonGia.Text = "Đơn Vị Tính :";
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(42, 182);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 3;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(182, 182);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbxDonViTinh
            // 
            this.cbxDonViTinh.DataSource = this.unitDataBindingSource;
            this.cbxDonViTinh.DisplayMember = "UnitName";
            this.cbxDonViTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.cbxDonViTinh.FormattingEnabled = true;
            this.cbxDonViTinh.ItemHeight = 14;
            this.cbxDonViTinh.Location = new System.Drawing.Point(123, 125);
            this.cbxDonViTinh.Name = "cbxDonViTinh";
            this.cbxDonViTinh.Size = new System.Drawing.Size(105, 20);
            this.cbxDonViTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDonViTinh.TabIndex = 5;
            // 
            // unitDataBindingSource
            // 
            this.unitDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.UnitData);
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
            this.dipDonGia.Location = new System.Drawing.Point(123, 84);
            this.dipDonGia.MinValue = 0D;
            this.dipDonGia.Name = "dipDonGia";
            this.dipDonGia.ShowUpDown = true;
            this.dipDonGia.Size = new System.Drawing.Size(134, 20);
            this.dipDonGia.TabIndex = 6;
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
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(123, 43);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(134, 20);
            this.txtTenNguyenLieu.TabIndex = 7;
            // 
            // btnThemDonViTinh
            // 
            this.btnThemDonViTinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemDonViTinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemDonViTinh.Location = new System.Drawing.Point(234, 125);
            this.btnThemDonViTinh.Name = "btnThemDonViTinh";
            this.btnThemDonViTinh.Size = new System.Drawing.Size(23, 20);
            this.btnThemDonViTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemDonViTinh.TabIndex = 8;
            this.btnThemDonViTinh.Text = "+";
            // 
            // frmSuaThongTinNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.btnThemDonViTinh);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Controls.Add(this.dipDonGia);
            this.Controls.Add(this.cbxDonViTinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.LDonGia);
            this.Controls.Add(this.LDonViTinh);
            this.Controls.Add(this.LTenNguyenLieu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSuaThongTinNguyenLieu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Sửa Thông Tin Nguyên Liệu</font>";
            this.Load += new System.EventHandler(this.SuaThongTinNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDonGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX LTenNguyenLieu;
        private LabelX LDonViTinh;
        private LabelX LDonGia;
        private ButtonX btnDongY;
        private ButtonX btnHuy;
        private ComboBoxEx cbxDonViTinh;
        private DoubleInput dipDonGia;
        private TextBoxX txtTenNguyenLieu;
        private ButtonX btnThemDonViTinh;
        private System.Windows.Forms.BindingSource unitDataBindingSource;
    }
}