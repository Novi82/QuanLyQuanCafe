using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Dialog
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDangNhap = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Pass = new DevComponents.DotNetBar.LabelX();
            this.User = new DevComponents.DotNetBar.LabelX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ILogin = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserName.DisabledBackColor = System.Drawing.Color.White;
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(145, 140);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDangNhap.Location = new System.Drawing.Point(41, 259);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDangNhap.SymbolColor = System.Drawing.Color.Maroon;
            this.btnDangNhap.SymbolSize = 10F;
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(191, 259);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.SymbolColor = System.Drawing.Color.Maroon;
            this.btnHuy.SymbolSize = 10F;
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.Pass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Pass.ForeColor = System.Drawing.Color.Black;
            this.Pass.Location = new System.Drawing.Point(24, 188);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(75, 23);
            this.Pass.TabIndex = 0;
            this.Pass.Text = "Mật Khẩu :";
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.User.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.User.ForeColor = System.Drawing.Color.Black;
            this.User.Location = new System.Drawing.Point(24, 140);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(92, 23);
            this.User.TabIndex = 0;
            this.User.Text = "Tên Tài Khoản :";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.DisabledBackColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(145, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // ILogin
            // 
            this.ILogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ILogin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ILogin.ForeColor = System.Drawing.Color.Black;
            this.ILogin.Image = ((System.Drawing.Image)(resources.GetObject("ILogin.Image")));
            this.ILogin.Location = new System.Drawing.Point(96, 3);
            this.ILogin.Name = "ILogin";
            this.ILogin.Size = new System.Drawing.Size(111, 119);
            this.ILogin.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(310, 312);
            this.Controls.Add(this.ILogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\" >Đăng Nhập</font><font color=\"#0072BC\"></font>";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxX txtUserName;
        private ButtonX btnDangNhap;
        private ButtonX btnHuy;
        private ImageList imageList1;
        private LabelX Pass;
        private LabelX User;
        private TextBoxX txtPassword;
        private LabelX ILogin;
    }
}