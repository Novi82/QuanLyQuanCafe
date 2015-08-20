using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Dialog
{
    partial class ThemDonViTinh
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
            this.LDonViTinh = new DevComponents.DotNetBar.LabelX();
            this.DonViTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BAccept = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // LDonViTinh
            // 
            this.LDonViTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LDonViTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.LDonViTinh.Location = new System.Drawing.Point(17, 29);
            this.LDonViTinh.Name = "LDonViTinh";
            this.LDonViTinh.Size = new System.Drawing.Size(75, 23);
            this.LDonViTinh.TabIndex = 0;
            this.LDonViTinh.Text = "Đơn Vị Tính :";
            // 
            // DonViTinh
            // 
            this.DonViTinh.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.DonViTinh.Border.Class = "TextBoxBorder";
            this.DonViTinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DonViTinh.DisabledBackColor = System.Drawing.Color.White;
            this.DonViTinh.ForeColor = System.Drawing.Color.Black;
            this.DonViTinh.Location = new System.Drawing.Point(110, 31);
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Size = new System.Drawing.Size(135, 20);
            this.DonViTinh.TabIndex = 1;
            // 
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(41, 88);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(75, 23);
            this.BAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAccept.TabIndex = 2;
            this.BAccept.Text = "Đồng Ý";
            this.BAccept.Click += new System.EventHandler(this.BAccept_Click);
            // 
            // BCancel
            // 
            this.BCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(170, 88);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 3;
            this.BCancel.Text = "Hủy Bỏ";
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // ThemDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.BCancel;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.DonViTinh);
            this.Controls.Add(this.LDonViTinh);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemDonViTinh";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Thêm Đơn Vị Tính</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.ThemDonViTinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX LDonViTinh;
        private TextBoxX DonViTinh;
        private ButtonX BAccept;
        private ButtonX BCancel;
    }
}