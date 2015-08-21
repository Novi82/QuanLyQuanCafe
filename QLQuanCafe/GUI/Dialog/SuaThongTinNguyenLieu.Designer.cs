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
            this.LDonGia = new DevComponents.DotNetBar.LabelX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.cbxDonViTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.unitDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThemDonViTinh = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LTenNguyenLieu
            // 
            this.LTenNguyenLieu.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LTenNguyenLieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTenNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.LTenNguyenLieu.Location = new System.Drawing.Point(25, 21);
            this.LTenNguyenLieu.Name = "LTenNguyenLieu";
            this.LTenNguyenLieu.Size = new System.Drawing.Size(111, 23);
            this.LTenNguyenLieu.TabIndex = 0;
            this.LTenNguyenLieu.Text = "Tên Nguyên Liệu :";
            // 
            // LDonGia
            // 
            this.LDonGia.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonGia.ForeColor = System.Drawing.Color.Black;
            this.LDonGia.Location = new System.Drawing.Point(25, 59);
            this.LDonGia.Name = "LDonGia";
            this.LDonGia.Size = new System.Drawing.Size(75, 23);
            this.LDonGia.TabIndex = 2;
            this.LDonGia.Text = "Đơn Vị Tính :";
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(52, 116);
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
            this.btnHuy.Location = new System.Drawing.Point(192, 116);
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
            this.cbxDonViTinh.Location = new System.Drawing.Point(133, 59);
            this.cbxDonViTinh.Name = "cbxDonViTinh";
            this.cbxDonViTinh.Size = new System.Drawing.Size(105, 20);
            this.cbxDonViTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDonViTinh.TabIndex = 5;
            // 
            // unitDataBindingSource
            // 
            this.unitDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.UnitData);
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
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(133, 21);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(134, 20);
            this.txtTenNguyenLieu.TabIndex = 7;
            // 
            // btnThemDonViTinh
            // 
            this.btnThemDonViTinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemDonViTinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemDonViTinh.Location = new System.Drawing.Point(244, 59);
            this.btnThemDonViTinh.Name = "btnThemDonViTinh";
            this.btnThemDonViTinh.Size = new System.Drawing.Size(23, 20);
            this.btnThemDonViTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemDonViTinh.TabIndex = 8;
            this.btnThemDonViTinh.Text = "+";
            this.btnThemDonViTinh.Click += new System.EventHandler(this.btnThemDonViTinh_Click);
            // 
            // frmSuaThongTinNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.btnThemDonViTinh);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Controls.Add(this.cbxDonViTinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.LDonGia);
            this.Controls.Add(this.LTenNguyenLieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuaThongTinNguyenLieu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Sửa Thông Tin Nguyên Liệu</font>";
            this.Load += new System.EventHandler(this.SuaThongTinNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX LTenNguyenLieu;
        private LabelX LDonGia;
        private ButtonX btnDongY;
        private ButtonX btnHuy;
        private ComboBoxEx cbxDonViTinh;
        private TextBoxX txtTenNguyenLieu;
        private ButtonX btnThemDonViTinh;
        private System.Windows.Forms.BindingSource unitDataBindingSource;
    }
}