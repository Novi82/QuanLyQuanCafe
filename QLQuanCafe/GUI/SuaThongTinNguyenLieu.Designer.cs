namespace QLQuanCafe.GUI
{
    partial class SuaThongTinNguyenLieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.LTenNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.LDonViTinh = new DevComponents.DotNetBar.LabelX();
            this.LDonGia = new DevComponents.DotNetBar.LabelX();
            this.BAccept = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.DonGia = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.DonViTinh = new DevComponents.Editors.DoubleInput();
            this.TenNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.AddDonGia = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.DonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // LTenNguyenLieu
            // 
            // 
            // 
            // 
            this.LTenNguyenLieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTenNguyenLieu.Location = new System.Drawing.Point(15, 40);
            this.LTenNguyenLieu.Name = "LTenNguyenLieu";
            this.LTenNguyenLieu.Size = new System.Drawing.Size(111, 23);
            this.LTenNguyenLieu.TabIndex = 0;
            this.LTenNguyenLieu.Text = "Tên Nguyên Liệu :";
            // 
            // LDonViTinh
            // 
            // 
            // 
            // 
            this.LDonViTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonViTinh.Location = new System.Drawing.Point(15, 82);
            this.LDonViTinh.Name = "LDonViTinh";
            this.LDonViTinh.Size = new System.Drawing.Size(75, 23);
            this.LDonViTinh.TabIndex = 1;
            this.LDonViTinh.Text = "Đơn Giá :";
            // 
            // LDonGia
            // 
            // 
            // 
            // 
            this.LDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonGia.Location = new System.Drawing.Point(15, 125);
            this.LDonGia.Name = "LDonGia";
            this.LDonGia.Size = new System.Drawing.Size(75, 23);
            this.LDonGia.TabIndex = 2;
            this.LDonGia.Text = "Đơn Vị Tính :";
            // 
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(42, 182);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(75, 23);
            this.BAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAccept.TabIndex = 3;
            this.BAccept.Text = "Đồng Ý";
            // 
            // BCancel
            // 
            this.BCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BCancel.Location = new System.Drawing.Point(182, 182);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 4;
            this.BCancel.Text = "Hủy Bỏ";
            // 
            // DonGia
            // 
            this.DonGia.DisplayMember = "Text";
            this.DonGia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DonGia.FormattingEnabled = true;
            this.DonGia.ItemHeight = 14;
            this.DonGia.Location = new System.Drawing.Point(123, 125);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(105, 20);
            this.DonGia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DonGia.TabIndex = 5;
            // 
            // DonViTinh
            // 
            // 
            // 
            // 
            this.DonViTinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DonViTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DonViTinh.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.DonViTinh.Increment = 1D;
            this.DonViTinh.Location = new System.Drawing.Point(123, 84);
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ShowUpDown = true;
            this.DonViTinh.Size = new System.Drawing.Size(134, 20);
            this.DonViTinh.TabIndex = 6;
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TenNguyenLieu.Border.Class = "TextBoxBorder";
            this.TenNguyenLieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TenNguyenLieu.DisabledBackColor = System.Drawing.Color.White;
            this.TenNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.TenNguyenLieu.Location = new System.Drawing.Point(123, 43);
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            this.TenNguyenLieu.Size = new System.Drawing.Size(134, 20);
            this.TenNguyenLieu.TabIndex = 7;
            // 
            // AddDonGia
            // 
            this.AddDonGia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AddDonGia.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AddDonGia.Location = new System.Drawing.Point(234, 125);
            this.AddDonGia.Name = "AddDonGia";
            this.AddDonGia.Size = new System.Drawing.Size(23, 20);
            this.AddDonGia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AddDonGia.TabIndex = 8;
            this.AddDonGia.Text = "+";
            // 
            // SuaThongTinNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.AddDonGia);
            this.Controls.Add(this.TenNguyenLieu);
            this.Controls.Add(this.DonViTinh);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.LDonGia);
            this.Controls.Add(this.LDonViTinh);
            this.Controls.Add(this.LTenNguyenLieu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SuaThongTinNguyenLieu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Sửa Thông Tin Nguyên Liệu</font>";
            this.Load += new System.EventHandler(this.SuaThongTinNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonViTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX LTenNguyenLieu;
        private DevComponents.DotNetBar.LabelX LDonViTinh;
        private DevComponents.DotNetBar.LabelX LDonGia;
        private DevComponents.DotNetBar.ButtonX BAccept;
        private DevComponents.DotNetBar.ButtonX BCancel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx DonGia;
        private DevComponents.Editors.DoubleInput DonViTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX TenNguyenLieu;
        private DevComponents.DotNetBar.ButtonX AddDonGia;
    }
}