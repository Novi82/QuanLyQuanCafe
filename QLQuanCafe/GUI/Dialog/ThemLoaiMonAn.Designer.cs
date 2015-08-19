using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Dialog
{
    partial class ThemLoaiMonAn
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
            this.LTenLoaiMonAn = new DevComponents.DotNetBar.LabelX();
            this.txtTenLoaiMon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
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
            // txtTenLoaiMon
            // 
            this.txtTenLoaiMon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenLoaiMon.Border.Class = "TextBoxBorder";
            this.txtTenLoaiMon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLoaiMon.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenLoaiMon.ForeColor = System.Drawing.Color.Black;
            this.txtTenLoaiMon.Location = new System.Drawing.Point(117, 39);
            this.txtTenLoaiMon.Name = "txtTenLoaiMon";
            this.txtTenLoaiMon.Size = new System.Drawing.Size(119, 20);
            this.txtTenLoaiMon.TabIndex = 1;
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(36, 87);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(161, 87);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // ThemLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtTenLoaiMon);
            this.Controls.Add(this.LTenLoaiMonAn);
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

        private LabelX LTenLoaiMonAn;
        private TextBoxX txtTenLoaiMon;
        private ButtonX btnDongY;
        private ButtonX btnHuy;
    }
}