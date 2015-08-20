using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Dialog
{
    partial class SuaKhuVuc
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
            this.LTenKhuVuc = new DevComponents.DotNetBar.LabelX();
            this.txtTenKhuVuc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuybo = new DevComponents.DotNetBar.ButtonX();
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
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenKhuVuc.Border.Class = "TextBoxBorder";
            this.txtTenKhuVuc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenKhuVuc.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenKhuVuc.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhuVuc.Location = new System.Drawing.Point(114, 35);
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.Size = new System.Drawing.Size(127, 20);
            this.txtTenKhuVuc.TabIndex = 1;
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(36, 94);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuybo
            // 
            this.btnHuybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuybo.Location = new System.Drawing.Point(166, 94);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(75, 23);
            this.btnHuybo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuybo.TabIndex = 3;
            this.btnHuybo.Text = "Hủy Bỏ";
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // SuaKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtTenKhuVuc);
            this.Controls.Add(this.LTenKhuVuc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SuaKhuVuc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Sửa Khu Vực</font>";
            this.Load += new System.EventHandler(this.SuaKhuVuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX LTenKhuVuc;
        private TextBoxX txtTenKhuVuc;
        private ButtonX btnDongY;
        private ButtonX btnHuybo;
    }
}