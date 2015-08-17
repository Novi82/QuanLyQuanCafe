namespace QLQuanCafe.GUI
{
    partial class SuaKhuVuc
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
            this.LTenKhuVuc = new DevComponents.DotNetBar.LabelX();
            this.TenKhuVuc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BAccept = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // LTenKhuVuc
            // 
            // 
            // 
            // 
            this.LTenKhuVuc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTenKhuVuc.Location = new System.Drawing.Point(12, 35);
            this.LTenKhuVuc.Name = "LTenKhuVuc";
            this.LTenKhuVuc.Size = new System.Drawing.Size(75, 23);
            this.LTenKhuVuc.TabIndex = 0;
            this.LTenKhuVuc.Text = "Tên Khu Vực :";
            // 
            // TenKhuVuc
            // 
            this.TenKhuVuc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TenKhuVuc.Border.Class = "TextBoxBorder";
            this.TenKhuVuc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
           // this.TenKhuVuc.DisabledBackColor = System.Drawing.Color.White;
            this.TenKhuVuc.ForeColor = System.Drawing.Color.Black;
            this.TenKhuVuc.Location = new System.Drawing.Point(114, 35);
            this.TenKhuVuc.Name = "TenKhuVuc";
            this.TenKhuVuc.Size = new System.Drawing.Size(127, 20);
            this.TenKhuVuc.TabIndex = 1;
            // 
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(36, 94);
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
            this.BCancel.Location = new System.Drawing.Point(166, 94);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 3;
            this.BCancel.Text = "Hủy Bỏ";
            // 
            // SuaKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.TenKhuVuc);
            this.Controls.Add(this.LTenKhuVuc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SuaKhuVuc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Sửa Khu Vực</font>";
            this.Load += new System.EventHandler(this.SuaKhuVuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX LTenKhuVuc;
        private DevComponents.DotNetBar.Controls.TextBoxX TenKhuVuc;
        private DevComponents.DotNetBar.ButtonX BAccept;
        private DevComponents.DotNetBar.ButtonX BCancel;
    }
}