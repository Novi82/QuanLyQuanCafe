namespace QLQuanCafe.GUI
{
    partial class ThemThongTinNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemThongTinNguyenLieu));
            this.TenNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.TTenNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DonGia = new DevComponents.DotNetBar.LabelX();
            this.CDonGia = new DevComponents.Editors.DoubleInput();
            this.DonViTinh = new DevComponents.DotNetBar.LabelX();
            this.BAdd = new DevComponents.DotNetBar.ButtonX();
            this.ComBDonViTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.BAccept = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            ((System.ComponentModel.ISupportInitialize)(this.CDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            // TTenNguyenLieu
            // 
            this.TTenNguyenLieu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TTenNguyenLieu.Border.Class = "TextBoxBorder";
            this.TTenNguyenLieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TTenNguyenLieu.DisabledBackColor = System.Drawing.Color.White;
            this.TTenNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.TTenNguyenLieu.Location = new System.Drawing.Point(116, 117);
            this.TTenNguyenLieu.Name = "TTenNguyenLieu";
            this.TTenNguyenLieu.Size = new System.Drawing.Size(129, 20);
            this.TTenNguyenLieu.TabIndex = 1;
            // 
            // DonGia
            // 
            this.DonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            // CDonGia
            // 
            this.CDonGia.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.CDonGia.BackgroundStyle.Class = "DateTimeInputBackground";
            this.CDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CDonGia.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.CDonGia.ForeColor = System.Drawing.Color.Black;
            this.CDonGia.Increment = 1D;
            this.CDonGia.Location = new System.Drawing.Point(116, 159);
            this.CDonGia.Name = "CDonGia";
            this.CDonGia.ShowUpDown = true;
            this.CDonGia.Size = new System.Drawing.Size(129, 20);
            this.CDonGia.TabIndex = 3;
            // 
            // DonViTinh
            // 
            this.DonViTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            // BAdd
            // 
            this.BAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAdd.Location = new System.Drawing.Point(216, 198);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(29, 20);
            this.BAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAdd.TabIndex = 5;
            this.BAdd.Text = "+";
            // 
            // ComBDonViTinh
            // 
            this.ComBDonViTinh.DisplayMember = "Text";
            this.ComBDonViTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.ComBDonViTinh.FormattingEnabled = true;
            this.ComBDonViTinh.ItemHeight = 14;
            this.ComBDonViTinh.Location = new System.Drawing.Point(116, 198);
            this.ComBDonViTinh.Name = "ComBDonViTinh";
            this.ComBDonViTinh.Size = new System.Drawing.Size(94, 20);
            this.ComBDonViTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComBDonViTinh.TabIndex = 6;
            // 
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(35, 251);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(75, 23);
            this.BAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAccept.TabIndex = 7;
            this.BAccept.Text = "Đồng Ý";
            // 
            // BCancel
            // 
            this.BCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BCancel.Location = new System.Drawing.Point(174, 251);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(71, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 8;
            this.BCancel.Text = "Hủy Bỏ";
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
            // ThemThongTinNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(280, 292);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.ComBDonViTinh);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.DonViTinh);
            this.Controls.Add(this.CDonGia);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.TTenNguyenLieu);
            this.Controls.Add(this.TenNguyenLieu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ThemThongTinNguyenLieu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Thêm Thông Tin Nguyên Liệu</font><font color=\"#ffffff\"></fo" +
    "nt>";
            this.Load += new System.EventHandler(this.ThemThongTinNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CDonGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX TenNguyenLieu;
        private DevComponents.DotNetBar.Controls.TextBoxX TTenNguyenLieu;
        private DevComponents.DotNetBar.LabelX DonGia;
        private DevComponents.Editors.DoubleInput CDonGia;
        private DevComponents.DotNetBar.LabelX DonViTinh;
        private DevComponents.DotNetBar.ButtonX BAdd;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComBDonViTinh;
        private DevComponents.DotNetBar.ButtonX BAccept;
        private DevComponents.DotNetBar.ButtonX BCancel;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
    }
}