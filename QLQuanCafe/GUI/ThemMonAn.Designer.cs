namespace QLQuanCafe.GUI
{
    partial class ThemMonAn
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
            this.ImgaeA = new DevComponents.DotNetBar.ButtonX();
            this.LTenMonAn = new DevComponents.DotNetBar.LabelX();
            this.LLoaiMon = new DevComponents.DotNetBar.LabelX();
            this.LDonGia = new DevComponents.DotNetBar.LabelX();
            this.lDonViTinh = new DevComponents.DotNetBar.LabelX();
            this.TenMonAn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BAccept = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.DonViTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.DonGia = new DevComponents.Editors.DoubleInput();
            this.BAdd = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.DonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgaeA
            // 
            this.ImgaeA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ImgaeA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ImgaeA.Location = new System.Drawing.Point(283, 31);
            this.ImgaeA.Name = "ImgaeA";
            this.ImgaeA.Size = new System.Drawing.Size(130, 169);
            this.ImgaeA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ImgaeA.TabIndex = 0;
            this.ImgaeA.Text = "Add Image";
            this.ImgaeA.Click += new System.EventHandler(this.ImgaeA_Click);
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
            // LLoaiMon
            // 
            this.LLoaiMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LLoaiMon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LLoaiMon.ForeColor = System.Drawing.Color.Black;
            this.LLoaiMon.Location = new System.Drawing.Point(26, 75);
            this.LLoaiMon.Name = "LLoaiMon";
            this.LLoaiMon.Size = new System.Drawing.Size(75, 23);
            this.LLoaiMon.TabIndex = 2;
            this.LLoaiMon.Text = "Loại Món :";
            // 
            // LDonGia
            // 
            this.LDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonGia.ForeColor = System.Drawing.Color.Black;
            this.LDonGia.Location = new System.Drawing.Point(26, 124);
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
            this.lDonViTinh.Location = new System.Drawing.Point(26, 180);
            this.lDonViTinh.Name = "lDonViTinh";
            this.lDonViTinh.Size = new System.Drawing.Size(75, 23);
            this.lDonViTinh.TabIndex = 4;
            this.lDonViTinh.Text = "Đơn Vị Tính :";
            // 
            // TenMonAn
            // 
            this.TenMonAn.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TenMonAn.Border.Class = "TextBoxBorder";
            this.TenMonAn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         //   this.TenMonAn.DisabledBackColor = System.Drawing.Color.White;
            this.TenMonAn.ForeColor = System.Drawing.Color.Black;
            this.TenMonAn.Location = new System.Drawing.Point(107, 34);
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Size = new System.Drawing.Size(135, 20);
            this.TenMonAn.TabIndex = 5;
            // 
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(215, 241);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(75, 23);
            this.BAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAccept.TabIndex = 9;
            this.BAccept.Text = "Đồng Ý";
            // 
            // BCancel
            // 
            this.BCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BCancel.Location = new System.Drawing.Point(338, 241);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 10;
            this.BCancel.Text = "Cancel";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DisplayMember = "Text";
            this.DonViTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DonViTinh.ForeColor = System.Drawing.Color.Black;
            this.DonViTinh.FormattingEnabled = true;
            this.DonViTinh.ItemHeight = 14;
            this.DonViTinh.Location = new System.Drawing.Point(107, 180);
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Size = new System.Drawing.Size(102, 20);
            this.DonViTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DonViTinh.TabIndex = 11;
            // 
            // DonGia
            // 
            this.DonGia.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.DonGia.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DonGia.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.DonGia.ForeColor = System.Drawing.Color.Black;
            this.DonGia.Increment = 1D;
            this.DonGia.Location = new System.Drawing.Point(107, 124);
            this.DonGia.Name = "DonGia";
            this.DonGia.ShowUpDown = true;
            this.DonGia.Size = new System.Drawing.Size(135, 20);
            this.DonGia.TabIndex = 12;
            // 
            // BAdd
            // 
            this.BAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAdd.Location = new System.Drawing.Point(215, 180);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(27, 20);
            this.BAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAdd.TabIndex = 13;
            this.BAdd.Text = "+";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(108, 76);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(134, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 14;
            // 
            // ThemMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(430, 294);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.DonViTinh);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.TenMonAn);
            this.Controls.Add(this.lDonViTinh);
            this.Controls.Add(this.LDonGia);
            this.Controls.Add(this.LLoaiMon);
            this.Controls.Add(this.LTenMonAn);
            this.Controls.Add(this.ImgaeA);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ThemMonAn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Thêm Món</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.ThemMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX ImgaeA;
        private DevComponents.DotNetBar.LabelX LTenMonAn;
        private DevComponents.DotNetBar.LabelX LLoaiMon;
        private DevComponents.DotNetBar.LabelX LDonGia;
        private DevComponents.DotNetBar.LabelX lDonViTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX TenMonAn;
        private DevComponents.DotNetBar.ButtonX BAccept;
        private DevComponents.DotNetBar.ButtonX BCancel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx DonViTinh;
        private DevComponents.Editors.DoubleInput DonGia;
        private DevComponents.DotNetBar.ButtonX BAdd;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
    }
}