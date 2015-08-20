using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace QLQuanCafe.GUI.Dialog
{
    partial class SuaMonAn
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
            this.cbxLoaiMonAn = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.menuCategoryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BAdd = new DevComponents.DotNetBar.ButtonX();
            this.dipDonGia = new DevComponents.Editors.DoubleInput();
            this.cbxDonViTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.unitDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.bntDongY = new DevComponents.DotNetBar.ButtonX();
            this.txtTenMonAn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lDonViTinh = new DevComponents.DotNetBar.LabelX();
            this.LDonGia = new DevComponents.DotNetBar.LabelX();
            this.LLoaiMon = new DevComponents.DotNetBar.LabelX();
            this.LTenMonAn = new DevComponents.DotNetBar.LabelX();
            this.imgMonAn = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.menuCategoryDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLoaiMonAn
            // 
            this.cbxLoaiMonAn.DataSource = this.menuCategoryDataBindingSource;
            this.cbxLoaiMonAn.DisplayMember = "MenuCategoryName";
            this.cbxLoaiMonAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLoaiMonAn.ForeColor = System.Drawing.Color.Black;
            this.cbxLoaiMonAn.FormattingEnabled = true;
            this.cbxLoaiMonAn.ItemHeight = 14;
            this.cbxLoaiMonAn.Location = new System.Drawing.Point(104, 76);
            this.cbxLoaiMonAn.Name = "cbxLoaiMonAn";
            this.cbxLoaiMonAn.Size = new System.Drawing.Size(134, 20);
            this.cbxLoaiMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxLoaiMonAn.TabIndex = 26;
            // 
            // menuCategoryDataBindingSource
            // 
            this.menuCategoryDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.MenuCategoryData);
            // 
            // BAdd
            // 
            this.BAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAdd.Location = new System.Drawing.Point(211, 180);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(27, 20);
            this.BAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAdd.TabIndex = 25;
            this.BAdd.Text = "+";
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
            this.dipDonGia.Location = new System.Drawing.Point(103, 124);
            this.dipDonGia.MinValue = 0D;
            this.dipDonGia.Name = "dipDonGia";
            this.dipDonGia.ShowUpDown = true;
            this.dipDonGia.Size = new System.Drawing.Size(135, 20);
            this.dipDonGia.TabIndex = 24;
            // 
            // cbxDonViTinh
            // 
            this.cbxDonViTinh.DataSource = this.unitDataBindingSource;
            this.cbxDonViTinh.DisplayMember = "UnitName";
            this.cbxDonViTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.cbxDonViTinh.FormattingEnabled = true;
            this.cbxDonViTinh.ItemHeight = 14;
            this.cbxDonViTinh.Location = new System.Drawing.Point(103, 180);
            this.cbxDonViTinh.Name = "cbxDonViTinh";
            this.cbxDonViTinh.Size = new System.Drawing.Size(102, 20);
            this.cbxDonViTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDonViTinh.TabIndex = 23;
            // 
            // unitDataBindingSource
            // 
            this.unitDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.UnitData);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(334, 241);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // bntDongY
            // 
            this.bntDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntDongY.Location = new System.Drawing.Point(211, 241);
            this.bntDongY.Name = "bntDongY";
            this.bntDongY.Size = new System.Drawing.Size(75, 23);
            this.bntDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bntDongY.TabIndex = 21;
            this.bntDongY.Text = "Đồng Ý";
            this.bntDongY.Click += new System.EventHandler(this.bntDongY_Click);
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenMonAn.Border.Class = "TextBoxBorder";
            this.txtTenMonAn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenMonAn.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtTenMonAn.Location = new System.Drawing.Point(103, 34);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(135, 20);
            this.txtTenMonAn.TabIndex = 20;
            // 
            // lDonViTinh
            // 
            this.lDonViTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lDonViTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.lDonViTinh.Location = new System.Drawing.Point(22, 180);
            this.lDonViTinh.Name = "lDonViTinh";
            this.lDonViTinh.Size = new System.Drawing.Size(75, 23);
            this.lDonViTinh.TabIndex = 19;
            this.lDonViTinh.Text = "Đơn Vị Tính :";
            // 
            // LDonGia
            // 
            this.LDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonGia.ForeColor = System.Drawing.Color.Black;
            this.LDonGia.Location = new System.Drawing.Point(22, 124);
            this.LDonGia.Name = "LDonGia";
            this.LDonGia.Size = new System.Drawing.Size(75, 23);
            this.LDonGia.TabIndex = 18;
            this.LDonGia.Text = "Đơn Giá :";
            // 
            // LLoaiMon
            // 
            this.LLoaiMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LLoaiMon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LLoaiMon.ForeColor = System.Drawing.Color.Black;
            this.LLoaiMon.Location = new System.Drawing.Point(22, 75);
            this.LLoaiMon.Name = "LLoaiMon";
            this.LLoaiMon.Size = new System.Drawing.Size(75, 23);
            this.LLoaiMon.TabIndex = 17;
            this.LLoaiMon.Text = "Loại Món :";
            // 
            // LTenMonAn
            // 
            this.LTenMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LTenMonAn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTenMonAn.ForeColor = System.Drawing.Color.Black;
            this.LTenMonAn.Location = new System.Drawing.Point(22, 31);
            this.LTenMonAn.Name = "LTenMonAn";
            this.LTenMonAn.Size = new System.Drawing.Size(75, 23);
            this.LTenMonAn.TabIndex = 16;
            this.LTenMonAn.Text = "Tên Món :";
            // 
            // imgMonAn
            // 
            this.imgMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.imgMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.imgMonAn.Location = new System.Drawing.Point(279, 31);
            this.imgMonAn.Name = "imgMonAn";
            this.imgMonAn.Size = new System.Drawing.Size(130, 169);
            this.imgMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.imgMonAn.TabIndex = 15;
            this.imgMonAn.Text = "Add Image";
            // 
            // SuaMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 294);
            this.Controls.Add(this.cbxLoaiMonAn);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.dipDonGia);
            this.Controls.Add(this.cbxDonViTinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.bntDongY);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.lDonViTinh);
            this.Controls.Add(this.LDonGia);
            this.Controls.Add(this.LLoaiMon);
            this.Controls.Add(this.LTenMonAn);
            this.Controls.Add(this.imgMonAn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SuaMonAn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Sửa Món Ăn</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.SuaMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuCategoryDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBoxEx cbxLoaiMonAn;
        private ButtonX BAdd;
        private DoubleInput dipDonGia;
        private ComboBoxEx cbxDonViTinh;
        private ButtonX btnHuy;
        private ButtonX bntDongY;
        private TextBoxX txtTenMonAn;
        private LabelX lDonViTinh;
        private LabelX LDonGia;
        private LabelX LLoaiMon;
        private LabelX LTenMonAn;
        private ButtonX imgMonAn;
        private System.Windows.Forms.BindingSource menuCategoryDataBindingSource;
        private System.Windows.Forms.BindingSource unitDataBindingSource;

    }
}