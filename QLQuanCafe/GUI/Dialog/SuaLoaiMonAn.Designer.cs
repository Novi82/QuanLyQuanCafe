using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Dialog
{
    partial class SuaLoaiMonAn
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
            this.txtTenLoaiMonAn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // LTenLoaiMonAn
            // 
            this.LTenLoaiMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LTenLoaiMonAn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTenLoaiMonAn.ForeColor = System.Drawing.Color.Black;
            this.LTenLoaiMonAn.Location = new System.Drawing.Point(12, 47);
            this.LTenLoaiMonAn.Name = "LTenLoaiMonAn";
            this.LTenLoaiMonAn.Size = new System.Drawing.Size(98, 23);
            this.LTenLoaiMonAn.TabIndex = 0;
            this.LTenLoaiMonAn.Text = "Tên Loại Món  :";
            // 
            // txtTenLoaiMonAn
            // 
            this.txtTenLoaiMonAn.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenLoaiMonAn.Border.Class = "TextBoxBorder";
            this.txtTenLoaiMonAn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLoaiMonAn.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenLoaiMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtTenLoaiMonAn.Location = new System.Drawing.Point(128, 47);
            this.txtTenLoaiMonAn.Name = "txtTenLoaiMonAn";
            this.txtTenLoaiMonAn.Size = new System.Drawing.Size(110, 20);
            this.txtTenLoaiMonAn.TabIndex = 1;
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(24, 97);
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
            this.btnHuy.Location = new System.Drawing.Point(163, 97);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // SuaLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtTenLoaiMonAn);
            this.Controls.Add(this.LTenLoaiMonAn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SuaLoaiMonAn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Sửa Loại Món Ăn</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.SuaLoaiMonAn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX LTenLoaiMonAn;
        private TextBoxX txtTenLoaiMonAn;
        private ButtonX btnDongY;
        private ButtonX btnHuy;
    }
}