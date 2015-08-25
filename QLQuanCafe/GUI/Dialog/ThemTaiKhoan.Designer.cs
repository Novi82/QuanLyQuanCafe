using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Dialog
{
    partial class ThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTaiKhoan));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.AUser = new DevComponents.DotNetBar.LabelX();
            this.txtTenTaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.APass = new DevComponents.DotNetBar.LabelX();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtMatKhau2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cbxQuyen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.permissionDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.IAddUser = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.permissionDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(118, 38);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(8, 8);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "labelX1";
            // 
            // AUser
            // 
            this.AUser.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.AUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AUser.ForeColor = System.Drawing.Color.Black;
            this.AUser.Location = new System.Drawing.Point(39, 161);
            this.AUser.Name = "AUser";
            this.AUser.Size = new System.Drawing.Size(93, 23);
            this.AUser.TabIndex = 2;
            this.AUser.Text = "Tên Tài Khoản :";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenTaiKhoan.Border.Class = "TextBoxBorder";
            this.txtTenTaiKhoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenTaiKhoan.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(150, 164);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(137, 20);
            this.txtTenTaiKhoan.TabIndex = 3;
            // 
            // APass
            // 
            this.APass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.APass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.APass.ForeColor = System.Drawing.Color.Black;
            this.APass.Location = new System.Drawing.Point(39, 210);
            this.APass.Name = "APass";
            this.APass.Size = new System.Drawing.Size(75, 23);
            this.APass.TabIndex = 4;
            this.APass.Text = "Mật Khẩu :";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhau.DisabledBackColor = System.Drawing.Color.White;
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(150, 212);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(137, 20);
            this.txtMatKhau.TabIndex = 5;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(39, 261);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(111, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Nhập Lại Mật Khẩu :";
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMatKhau2.Border.Class = "TextBoxBorder";
            this.txtMatKhau2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhau2.DisabledBackColor = System.Drawing.Color.White;
            this.txtMatKhau2.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau2.Location = new System.Drawing.Point(150, 263);
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.PasswordChar = '*';
            this.txtMatKhau2.Size = new System.Drawing.Size(137, 20);
            this.txtMatKhau2.TabIndex = 7;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(39, 316);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Quyền :";
            // 
            // cbxQuyen
            // 
            this.cbxQuyen.DataSource = this.permissionDataBindingSource;
            this.cbxQuyen.DisplayMember = "PermissionName";
            this.cbxQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuyen.ForeColor = System.Drawing.Color.Black;
            this.cbxQuyen.FormattingEnabled = true;
            this.cbxQuyen.ItemHeight = 14;
            this.cbxQuyen.Location = new System.Drawing.Point(150, 317);
            this.cbxQuyen.Name = "cbxQuyen";
            this.cbxQuyen.Size = new System.Drawing.Size(137, 20);
            this.cbxQuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxQuyen.TabIndex = 9;
            // 
            // permissionDataBindingSource
            // 
            this.permissionDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.PermissionData);
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(75, 375);
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
            this.btnHuy.Location = new System.Drawing.Point(212, 375);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // IAddUser
            // 
            this.IAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.IAddUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IAddUser.ForeColor = System.Drawing.Color.Black;
            this.IAddUser.Image = ((System.Drawing.Image)(resources.GetObject("IAddUser.Image")));
            this.IAddUser.Location = new System.Drawing.Point(118, 12);
            this.IAddUser.Name = "IAddUser";
            this.IAddUser.Size = new System.Drawing.Size(112, 115);
            this.IAddUser.TabIndex = 1;
            this.IAddUser.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(344, 420);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.cbxQuyen);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtMatKhau2);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.APass);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.AUser);
            this.Controls.Add(this.IAddUser);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemTaiKhoan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Thêm Tài Khoản</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.ThemTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.permissionDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX labelX1;
        private LabelX IAddUser;
        private LabelX AUser;
        private TextBoxX txtTenTaiKhoan;
        private LabelX APass;
        private TextBoxX txtMatKhau;
        private LabelX labelX4;
        private TextBoxX txtMatKhau2;
        private LabelX labelX5;
        private ComboBoxEx cbxQuyen;
        private ButtonX btnDongY;
        private ButtonX btnHuy;
        private System.Windows.Forms.BindingSource permissionDataBindingSource;
    }
}