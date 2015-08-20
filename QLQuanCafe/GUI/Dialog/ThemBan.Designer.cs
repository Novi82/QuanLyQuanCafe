using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Dialog
{
    partial class ThemBan
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
            this.ATable = new DevComponents.DotNetBar.LabelX();
            this.txtTenBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyBo = new DevComponents.DotNetBar.ButtonX();
            this.IOpenTable = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // ATable
            // 
            this.ATable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ATable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ATable.ForeColor = System.Drawing.Color.Black;
            this.ATable.Location = new System.Drawing.Point(26, 153);
            this.ATable.Name = "ATable";
            this.ATable.Size = new System.Drawing.Size(75, 23);
            this.ATable.TabIndex = 0;
            this.ATable.Text = "Thêm Bàn :";
            // 
            // txtTenBan
            // 
            this.txtTenBan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenBan.Border.Class = "TextBoxBorder";
            this.txtTenBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenBan.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenBan.ForeColor = System.Drawing.Color.Black;
            this.txtTenBan.Location = new System.Drawing.Point(127, 153);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(129, 20);
            this.txtTenBan.TabIndex = 1;
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.BackColor = System.Drawing.Color.White;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(30, 201);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnDongY.TabIndex = 3;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyBo.Location = new System.Drawing.Point(170, 201);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // IOpenTable
            // 
            this.IOpenTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.IOpenTable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IOpenTable.ForeColor = System.Drawing.Color.Black;
            this.IOpenTable.Image = global::QLQuanCafe.Properties.Resources.AddTable;
            this.IOpenTable.Location = new System.Drawing.Point(95, 12);
            this.IOpenTable.Name = "IOpenTable";
            this.IOpenTable.Size = new System.Drawing.Size(114, 119);
            this.IOpenTable.TabIndex = 2;
            // 
            // ThemBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnHuyBo;
            this.ClientSize = new System.Drawing.Size(288, 249);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.IOpenTable);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.ATable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemBan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Thêm Bàn</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.ThemBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX ATable;
        private TextBoxX txtTenBan;
        private LabelX IOpenTable;
        private ButtonX btnDongY;
        private ButtonX btnHuyBo;
    }
}