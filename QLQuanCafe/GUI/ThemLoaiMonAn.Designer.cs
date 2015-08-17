namespace QLQuanCafe.GUI
{
    partial class ThemLoaiMonAn
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
            this.TenLoaiMon = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.LTenLoaiMonAn.Location = new System.Drawing.Point(17, 39);
            this.LTenLoaiMonAn.Name = "LTenLoaiMonAn";
            this.LTenLoaiMonAn.Size = new System.Drawing.Size(94, 23);
            this.LTenLoaiMonAn.TabIndex = 0;
            this.LTenLoaiMonAn.Text = "Tên Loại Món Ăn :";
            // 
            // TenLoaiMon
            // 
            this.TenLoaiMon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TenLoaiMon.Border.Class = "TextBoxBorder";
            this.TenLoaiMon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TenLoaiMon.DisabledBackColor = System.Drawing.Color.White;
            this.TenLoaiMon.ForeColor = System.Drawing.Color.Black;
            this.TenLoaiMon.Location = new System.Drawing.Point(117, 39);
            this.TenLoaiMon.Name = "TenLoaiMon";
            this.TenLoaiMon.Size = new System.Drawing.Size(119, 20);
            this.TenLoaiMon.TabIndex = 1;
            // 
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(36, 87);
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
            this.BCancel.Location = new System.Drawing.Point(161, 87);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 3;
            this.BCancel.Text = "Hủy Bỏ";
            // 
            // ThemLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.TenLoaiMon);
            this.Controls.Add(this.LTenLoaiMonAn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ThemLoaiMonAn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Thêm Loại Món Ăn</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.ThemLoaiMonAn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX LTenLoaiMonAn;
        private DevComponents.DotNetBar.Controls.TextBoxX TenLoaiMon;
        private DevComponents.DotNetBar.ButtonX BAccept;
        private DevComponents.DotNetBar.ButtonX BCancel;
    }
}