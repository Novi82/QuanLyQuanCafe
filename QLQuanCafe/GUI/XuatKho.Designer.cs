namespace QLQuanCafe.GUI
{
    partial class XuatKho
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
            this.LSoLuong = new DevComponents.DotNetBar.LabelX();
            this.LMaNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.LTenNguyenLieu = new DevComponents.DotNetBar.LabelX();
            this.LGiaNhap = new DevComponents.DotNetBar.LabelX();
            this.LDonViTinh = new DevComponents.DotNetBar.LabelX();
            this.BAccept = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.MaNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TenNguyenLieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GiaNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DonViTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SoLuong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
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
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(58, 390);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(75, 23);
            this.BAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAccept.TabIndex = 5;
            this.BAccept.Text = "Đồng Ý";
            // 
            // BCancel
            // 
            this.BCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BCancel.Location = new System.Drawing.Point(206, 390);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 6;
            this.BCancel.Text = "Hủy Bỏ";
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MaNguyenLieu.Border.Class = "TextBoxBorder";
            this.MaNguyenLieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MaNguyenLieu.DisabledBackColor = System.Drawing.Color.White;
            this.MaNguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.MaNguyenLieu.Location = new System.Drawing.Point(153, 150);
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            this.MaNguyenLieu.Size = new System.Drawing.Size(121, 20);
            this.MaNguyenLieu.TabIndex = 8;
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
            this.TenNguyenLieu.Location = new System.Drawing.Point(153, 190);
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            this.TenNguyenLieu.Size = new System.Drawing.Size(121, 20);
            this.TenNguyenLieu.TabIndex = 9;
            // 
            // GiaNhap
            // 
            this.GiaNhap.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.GiaNhap.Border.Class = "TextBoxBorder";
            this.GiaNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GiaNhap.DisabledBackColor = System.Drawing.Color.White;
            this.GiaNhap.ForeColor = System.Drawing.Color.Black;
            this.GiaNhap.Location = new System.Drawing.Point(153, 234);
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Size = new System.Drawing.Size(121, 20);
            this.GiaNhap.TabIndex = 10;
            // 
            // DonViTinh
            // 
            this.DonViTinh.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.DonViTinh.Border.Class = "TextBoxBorder";
            this.DonViTinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DonViTinh.DisabledBackColor = System.Drawing.Color.White;
            this.DonViTinh.ForeColor = System.Drawing.Color.Black;
            this.DonViTinh.Location = new System.Drawing.Point(153, 283);
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Size = new System.Drawing.Size(121, 20);
            this.DonViTinh.TabIndex = 11;
            // 
            // SoLuong
            // 
            this.SoLuong.DisplayMember = "Text";
            this.SoLuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SoLuong.ForeColor = System.Drawing.Color.Black;
            this.SoLuong.FormattingEnabled = true;
            this.SoLuong.ItemHeight = 14;
            this.SoLuong.Location = new System.Drawing.Point(153, 326);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(121, 20);
            this.SoLuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SoLuong.TabIndex = 12;
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
            this.reflectionImage1.Image = global::QLQuanCafe.GUI.Properties.Resources.XuatKho;
            this.reflectionImage1.Location = new System.Drawing.Point(94, 12);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.ReflectionEnabled = false;
            this.reflectionImage1.Size = new System.Drawing.Size(128, 116);
            this.reflectionImage1.TabIndex = 7;
            // 
            // XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 425);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.DonViTinh);
            this.Controls.Add(this.GiaNhap);
            this.Controls.Add(this.TenNguyenLieu);
            this.Controls.Add(this.MaNguyenLieu);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.LDonViTinh);
            this.Controls.Add(this.LGiaNhap);
            this.Controls.Add(this.LTenNguyenLieu);
            this.Controls.Add(this.LMaNguyenLieu);
            this.Controls.Add(this.LSoLuong);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "XuatKho";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Xuất Kho</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.XuatKho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX LSoLuong;
        private DevComponents.DotNetBar.LabelX LMaNguyenLieu;
        private DevComponents.DotNetBar.LabelX LTenNguyenLieu;
        private DevComponents.DotNetBar.LabelX LGiaNhap;
        private DevComponents.DotNetBar.LabelX LDonViTinh;
        private DevComponents.DotNetBar.ButtonX BAccept;
        private DevComponents.DotNetBar.ButtonX BCancel;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.TextBoxX MaNguyenLieu;
        private DevComponents.DotNetBar.Controls.TextBoxX TenNguyenLieu;
        private DevComponents.DotNetBar.Controls.TextBoxX GiaNhap;
        private DevComponents.DotNetBar.Controls.TextBoxX DonViTinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx SoLuong;
    }
}