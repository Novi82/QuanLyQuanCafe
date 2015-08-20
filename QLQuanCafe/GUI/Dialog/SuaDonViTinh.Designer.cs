using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Dialog
{
    partial class SuaDonViTinh
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.bntCancel = new DevComponents.DotNetBar.ButtonX();
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
            this.LDonViTinh.Location = new System.Drawing.Point(12, 35);
            this.LDonViTinh.Name = "LDonViTinh";
            this.LDonViTinh.Size = new System.Drawing.Size(99, 23);
            this.LDonViTinh.TabIndex = 0;
            this.LDonViTinh.Text = "Tên Đơn Vị Tính :";
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
            this.DonViTinh.Location = new System.Drawing.Point(128, 38);
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Size = new System.Drawing.Size(108, 20);
            this.DonViTinh.TabIndex = 1;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(43, 93);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "Đồng Ý";
            this.buttonX1.Click += new System.EventHandler(this.btnAccept);
            // 
            // bntCancel
            // 
            this.bntCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntCancel.Location = new System.Drawing.Point(170, 93);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bntCancel.TabIndex = 3;
            this.bntCancel.Text = "Hủy Bỏ";
            // 
            // SuaDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.DonViTinh);
            this.Controls.Add(this.LDonViTinh);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuaDonViTinh";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Sửa Đơn Vị Tính</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.SuaDonViTinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX LDonViTinh;
        private TextBoxX DonViTinh;
        private ButtonX buttonX1;
        private ButtonX bntCancel;
    }
}