using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.CUser = new DevComponents.DotNetBar.LabelX();
            this.TCUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.NPass = new DevComponents.DotNetBar.LabelX();
            this.S2Pass = new DevComponents.DotNetBar.LabelX();
            this.TNPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TNPass2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BAccept = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.IChangePass = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // CUser
            // 
            this.CUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.CUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CUser.ForeColor = System.Drawing.Color.Black;
            this.CUser.Location = new System.Drawing.Point(28, 165);
            this.CUser.Name = "CUser";
            this.CUser.Size = new System.Drawing.Size(96, 23);
            this.CUser.TabIndex = 1;
            this.CUser.Text = "Tên Tài Khoản :";
            // 
            // TCUser
            // 
            this.TCUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TCUser.Border.Class = "TextBoxBorder";
            this.TCUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TCUser.DisabledBackColor = System.Drawing.Color.White;
            this.TCUser.ForeColor = System.Drawing.Color.Black;
            this.TCUser.Location = new System.Drawing.Point(147, 165);
            this.TCUser.Name = "TCUser";
            this.TCUser.Size = new System.Drawing.Size(118, 20);
            this.TCUser.TabIndex = 2;
            // 
            // NPass
            // 
            this.NPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.NPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NPass.ForeColor = System.Drawing.Color.Black;
            this.NPass.Location = new System.Drawing.Point(28, 207);
            this.NPass.Name = "NPass";
            this.NPass.Size = new System.Drawing.Size(75, 23);
            this.NPass.TabIndex = 3;
            this.NPass.Text = "Mật Khẩu Mới :";
            // 
            // S2Pass
            // 
            this.S2Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.S2Pass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.S2Pass.ForeColor = System.Drawing.Color.Black;
            this.S2Pass.Location = new System.Drawing.Point(28, 247);
            this.S2Pass.Name = "S2Pass";
            this.S2Pass.Size = new System.Drawing.Size(108, 23);
            this.S2Pass.TabIndex = 4;
            this.S2Pass.Text = "Nhập Lại Mật Khẩu :";
            // 
            // TNPass
            // 
            this.TNPass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TNPass.Border.Class = "TextBoxBorder";
            this.TNPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TNPass.DisabledBackColor = System.Drawing.Color.White;
            this.TNPass.ForeColor = System.Drawing.Color.Black;
            this.TNPass.Location = new System.Drawing.Point(147, 209);
            this.TNPass.Name = "TNPass";
            this.TNPass.Size = new System.Drawing.Size(118, 20);
            this.TNPass.TabIndex = 5;
            // 
            // TNPass2
            // 
            this.TNPass2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TNPass2.Border.Class = "TextBoxBorder";
            this.TNPass2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TNPass2.DisabledBackColor = System.Drawing.Color.White;
            this.TNPass2.ForeColor = System.Drawing.Color.Black;
            this.TNPass2.Location = new System.Drawing.Point(147, 249);
            this.TNPass2.Name = "TNPass2";
            this.TNPass2.Size = new System.Drawing.Size(118, 20);
            this.TNPass2.TabIndex = 6;
            // 
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(49, 306);
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
            this.BCancel.Location = new System.Drawing.Point(190, 306);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 8;
            this.BCancel.Text = "Hủy Bỏ";
            // 
            // IChangePass
            // 
            this.IChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.IChangePass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IChangePass.ForeColor = System.Drawing.Color.Black;
            this.IChangePass.Image = ((System.Drawing.Image)(resources.GetObject("IChangePass.Image")));
            this.IChangePass.Location = new System.Drawing.Point(100, 12);
            this.IChangePass.Name = "IChangePass";
            this.IChangePass.Size = new System.Drawing.Size(107, 109);
            this.IChangePass.TabIndex = 0;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(307, 355);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.TNPass2);
            this.Controls.Add(this.TNPass);
            this.Controls.Add(this.S2Pass);
            this.Controls.Add(this.NPass);
            this.Controls.Add(this.TCUser);
            this.Controls.Add(this.CUser);
            this.Controls.Add(this.IChangePass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoiMatKhau";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Đổi Mật Khẩu</font><font color=\"#FFFFFF\"></font>";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX IChangePass;
        private LabelX CUser;
        private TextBoxX TCUser;
        private LabelX NPass;
        private LabelX S2Pass;
        private TextBoxX TNPass;
        private TextBoxX TNPass2;
        private ButtonX BAccept;
        private ButtonX BCancel;
    }
}