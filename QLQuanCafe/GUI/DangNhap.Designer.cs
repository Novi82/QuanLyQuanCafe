namespace QLQuanCafe.GUI
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BLogin = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Pass = new DevComponents.DotNetBar.LabelX();
            this.User = new DevComponents.DotNetBar.LabelX();
            this.TPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ILogin = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // TUser
            // 
            this.TUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TUser.Border.Class = "TextBoxBorder";
            this.TUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
           // this.TUser.DisabledBackColor = System.Drawing.Color.White;
            this.TUser.ForeColor = System.Drawing.Color.Black;
            this.TUser.Location = new System.Drawing.Point(175, 140);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(140, 20);
            this.TUser.TabIndex = 0;
            // 
            // BLogin
            // 
            this.BLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BLogin.Location = new System.Drawing.Point(54, 247);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(75, 23);
            this.BLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BLogin.SymbolColor = System.Drawing.Color.Maroon;
            this.BLogin.SymbolSize = 10F;
            this.BLogin.TabIndex = 1;
            this.BLogin.Text = "Đăng Nhập";
            // 
            // BCancel
            // 
            this.BCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(223, 247);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.SymbolColor = System.Drawing.Color.Maroon;
            this.BCancel.SymbolSize = 10F;
            this.BCancel.TabIndex = 2;
            this.BCancel.Text = "Hủy Bỏ";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.Pass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Pass.ForeColor = System.Drawing.Color.Black;
            this.Pass.Location = new System.Drawing.Point(54, 188);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(75, 23);
            this.Pass.TabIndex = 5;
            this.Pass.Text = "Mật Khẩu :";
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.User.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.User.ForeColor = System.Drawing.Color.Black;
            this.User.Location = new System.Drawing.Point(54, 140);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(92, 23);
            this.User.TabIndex = 6;
            this.User.Text = "Tên Tài Khoản :";
            // 
            // TPass
            // 
            this.TPass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TPass.Border.Class = "TextBoxBorder";
            this.TPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TPass.DisabledBackColor = System.Drawing.Color.White;
            this.TPass.ForeColor = System.Drawing.Color.Black;
            this.TPass.Location = new System.Drawing.Point(175, 191);
            this.TPass.Name = "TPass";
            this.TPass.Size = new System.Drawing.Size(140, 20);
            this.TPass.TabIndex = 7;
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
            this.ILogin.Location = new System.Drawing.Point(121, 3);
            this.ILogin.Name = "ILogin";
            this.ILogin.Size = new System.Drawing.Size(111, 119);
            this.ILogin.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.BCancel;
            this.ClientSize = new System.Drawing.Size(346, 312);
            this.Controls.Add(this.ILogin);
            this.Controls.Add(this.TPass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.TUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\" >Đăng Nhập</font><font color=\"#0072BC\"></font>";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX TUser;
        private DevComponents.DotNetBar.ButtonX BLogin;
        private DevComponents.DotNetBar.ButtonX BCancel;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.LabelX Pass;
        private DevComponents.DotNetBar.LabelX User;
        private DevComponents.DotNetBar.Controls.TextBoxX TPass;
        private DevComponents.DotNetBar.LabelX ILogin;
    }
}