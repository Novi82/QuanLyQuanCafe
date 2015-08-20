using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace QLQuanCafe.GUI.Dialog
{
    partial class ThemMonAn
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
            this.imgMonAn = new DevComponents.DotNetBar.ButtonX();
            this.LTenMonAn = new DevComponents.DotNetBar.LabelX();
            this.LDonGia = new DevComponents.DotNetBar.LabelX();
            this.lDonViTinh = new DevComponents.DotNetBar.LabelX();
            this.txtTenMonAn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.cbxDonViTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.unitDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dipDonGia = new DevComponents.Editors.DoubleInput();
            this.BAdd = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.unitDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMonAn
            // 
            this.imgMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.imgMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.imgMonAn.Location = new System.Drawing.Point(283, 31);
            this.imgMonAn.Name = "imgMonAn";
            this.imgMonAn.Size = new System.Drawing.Size(130, 169);
            this.imgMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.imgMonAn.TabIndex = 0;
            this.imgMonAn.Text = "Add Image";
            this.imgMonAn.Click += new System.EventHandler(this.ImgaeA_Click);
            // 
            // LTenMonAn
            // 
            this.LTenMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LTenMonAn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTenMonAn.ForeColor = System.Drawing.Color.Black;
            this.LTenMonAn.Location = new System.Drawing.Point(26, 31);
            this.LTenMonAn.Name = "LTenMonAn";
            this.LTenMonAn.Size = new System.Drawing.Size(75, 23);
            this.LTenMonAn.TabIndex = 1;
            this.LTenMonAn.Text = "Tên Món :";
            // 
            // LDonGia
            // 
            this.LDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonGia.ForeColor = System.Drawing.Color.Black;
            this.LDonGia.Location = new System.Drawing.Point(26, 73);
            this.LDonGia.Name = "LDonGia";
            this.LDonGia.Size = new System.Drawing.Size(75, 23);
            this.LDonGia.TabIndex = 3;
            this.LDonGia.Text = "Đơn Giá :";
            // 
            // lDonViTinh
            // 
            this.lDonViTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lDonViTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.lDonViTinh.Location = new System.Drawing.Point(26, 116);
            this.lDonViTinh.Name = "lDonViTinh";
            this.lDonViTinh.Size = new System.Drawing.Size(75, 23);
            this.lDonViTinh.TabIndex = 4;
            this.lDonViTinh.Text = "Đơn Vị Tính :";
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
            this.txtTenMonAn.Location = new System.Drawing.Point(107, 34);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(135, 20);
            this.txtTenMonAn.TabIndex = 5;
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(26, 177);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 9;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(146, 177);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Cancel";
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
            this.cbxDonViTinh.Location = new System.Drawing.Point(107, 116);
            this.cbxDonViTinh.Name = "cbxDonViTinh";
            this.cbxDonViTinh.Size = new System.Drawing.Size(102, 20);
            this.cbxDonViTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDonViTinh.TabIndex = 11;
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
            this.dipDonGia.Location = new System.Drawing.Point(107, 73);
            this.dipDonGia.MinValue = 0D;
            this.dipDonGia.Name = "dipDonGia";
            this.dipDonGia.ShowUpDown = true;
            this.dipDonGia.Size = new System.Drawing.Size(135, 20);
            this.dipDonGia.TabIndex = 12;
            // 
            // BAdd
            // 
            this.BAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAdd.Location = new System.Drawing.Point(215, 116);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(27, 20);
            this.BAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAdd.TabIndex = 13;
            this.BAdd.Text = "+";
            // 
            // ThemMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(430, 232);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.dipDonGia);
            this.Controls.Add(this.cbxDonViTinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.lDonViTinh);
            this.Controls.Add(this.LDonGia);
            this.Controls.Add(this.LTenMonAn);
            this.Controls.Add(this.imgMonAn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ThemMonAn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Thêm Món</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.ThemMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dipDonGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonX imgMonAn;
        private LabelX LTenMonAn;
        private LabelX LDonGia;
        private LabelX lDonViTinh;
        private TextBoxX txtTenMonAn;
        private ButtonX btnDongY;
        private ButtonX btnHuy;
        private ComboBoxEx cbxDonViTinh;
        private DoubleInput dipDonGia;
        private ButtonX BAdd;
        private System.Windows.Forms.BindingSource unitDataBindingSource;
    }
}