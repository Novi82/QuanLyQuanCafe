using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace QLQuanCafe.GUI
{
    partial class YeuCauMon
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
            this.LThanhTien = new DevComponents.DotNetBar.LabelX();
            this.SoLuong = new DevComponents.Editors.DoubleInput();
            this.LSoLuong = new DevComponents.DotNetBar.LabelX();
            this.LDonGia = new DevComponents.DotNetBar.LabelX();
            this.BAccept = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // LThanhTien
            // 
            this.LThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LThanhTien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LThanhTien.ForeColor = System.Drawing.Color.Black;
            this.LThanhTien.Location = new System.Drawing.Point(33, 136);
            this.LThanhTien.Name = "LThanhTien";
            this.LThanhTien.Size = new System.Drawing.Size(75, 23);
            this.LThanhTien.TabIndex = 3;
            this.LThanhTien.Text = "Thành Tiền :";
            // 
            // SoLuong
            // 
            this.SoLuong.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.SoLuong.BackgroundStyle.Class = "DateTimeInputBackground";
            this.SoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SoLuong.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.SoLuong.ForeColor = System.Drawing.Color.Black;
            this.SoLuong.Increment = 1D;
            this.SoLuong.Location = new System.Drawing.Point(126, 88);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ShowUpDown = true;
            this.SoLuong.Size = new System.Drawing.Size(100, 20);
            this.SoLuong.TabIndex = 2;
            // 
            // LSoLuong
            // 
            this.LSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LSoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LSoLuong.ForeColor = System.Drawing.Color.Black;
            this.LSoLuong.Location = new System.Drawing.Point(33, 85);
            this.LSoLuong.Name = "LSoLuong";
            this.LSoLuong.Size = new System.Drawing.Size(75, 23);
            this.LSoLuong.TabIndex = 1;
            this.LSoLuong.Text = "Số Lượng :";
            // 
            // LDonGia
            // 
            this.LDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LDonGia.ForeColor = System.Drawing.Color.Black;
            this.LDonGia.Location = new System.Drawing.Point(33, 39);
            this.LDonGia.Name = "LDonGia";
            this.LDonGia.Size = new System.Drawing.Size(75, 23);
            this.LDonGia.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.LDonGia.TabIndex = 0;
            this.LDonGia.Text = "Đơn Giá :";
            // 
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(33, 196);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(75, 23);
            this.BAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAccept.TabIndex = 1;
            this.BAccept.Text = "Đồng Ý";
            // 
            // BCancel
            // 
            this.BCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BCancel.Location = new System.Drawing.Point(176, 196);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 2;
            this.BCancel.Text = "Hủy Bỏ";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(126, 39);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 4;
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX2.ForeColor = System.Drawing.Color.Black;
            this.textBoxX2.Location = new System.Drawing.Point(126, 138);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(100, 20);
            this.textBoxX2.TabIndex = 5;
            // 
            // YeuCauMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 248);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.LThanhTien);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.LSoLuong);
            this.Controls.Add(this.LDonGia);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "YeuCauMon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Gọi Món</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.YeuCauMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX LDonGia;
        private LabelX LThanhTien;
        private DoubleInput SoLuong;
        private LabelX LSoLuong;
        private ButtonX BAccept;
        private ButtonX BCancel;
        private TextBoxX textBoxX1;
        private TextBoxX textBoxX2;
    }
}