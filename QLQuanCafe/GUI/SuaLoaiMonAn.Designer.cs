namespace QLQuanCafe.GUI
{
    partial class SuaLoaiMonAn
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
            this.LTenLoaiMonAn = new DevComponents.DotNetBar.LabelX();
            this.SuaTenLoaiMonAn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BAccept = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // LTenLoaiMonAn
            // 
            // 
            // 
            // 
            this.LTenLoaiMonAn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTenLoaiMonAn.Location = new System.Drawing.Point(12, 47);
            this.LTenLoaiMonAn.Name = "LTenLoaiMonAn";
            this.LTenLoaiMonAn.Size = new System.Drawing.Size(98, 23);
            this.LTenLoaiMonAn.TabIndex = 0;
            this.LTenLoaiMonAn.Text = "Tên Loại Món Ăn :";
            // 
            // SuaTenLoaiMonAn
            // 
            this.SuaTenLoaiMonAn.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.SuaTenLoaiMonAn.Border.Class = "TextBoxBorder";
            this.SuaTenLoaiMonAn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
          //  this.SuaTenLoaiMonAn.DisabledBackColor = System.Drawing.Color.White;
            this.SuaTenLoaiMonAn.ForeColor = System.Drawing.Color.Black;
            this.SuaTenLoaiMonAn.Location = new System.Drawing.Point(128, 47);
            this.SuaTenLoaiMonAn.Name = "SuaTenLoaiMonAn";
            this.SuaTenLoaiMonAn.Size = new System.Drawing.Size(110, 20);
            this.SuaTenLoaiMonAn.TabIndex = 1;
            // 
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(24, 97);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(75, 23);
            this.BAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAccept.TabIndex = 2;
            this.BAccept.Text = "Đồng Ý";
            // 
            // BCancel
            // 
            this.BCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BCancel.Location = new System.Drawing.Point(163, 97);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 3;
            this.BCancel.Text = "Hủy Bỏ";
            // 
            // SuaLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.SuaTenLoaiMonAn);
            this.Controls.Add(this.LTenLoaiMonAn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SuaLoaiMonAn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Sửa Loại Món Ăn</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.SuaLoaiMonAn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX LTenLoaiMonAn;
        private DevComponents.DotNetBar.Controls.TextBoxX SuaTenLoaiMonAn;
        private DevComponents.DotNetBar.ButtonX BAccept;
        private DevComponents.DotNetBar.ButtonX BCancel;
    }
}