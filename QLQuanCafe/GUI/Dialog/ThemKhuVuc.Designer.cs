using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Dialog
{
    partial class ThemKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemKhuVuc));
            this.AddArea = new DevComponents.DotNetBar.LabelX();
            this.txtKhuVuc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.IAddArea = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.SuspendLayout();
            // 
            // AddArea
            // 
            this.AddArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.AddArea.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AddArea.ForeColor = System.Drawing.Color.Black;
            this.AddArea.Location = new System.Drawing.Point(35, 129);
            this.AddArea.Name = "AddArea";
            this.AddArea.Size = new System.Drawing.Size(91, 23);
            this.AddArea.TabIndex = 0;
            this.AddArea.Text = "Thêm Khu Vực :";
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtKhuVuc.Border.Class = "TextBoxBorder";
            this.txtKhuVuc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKhuVuc.DisabledBackColor = System.Drawing.Color.White;
            this.txtKhuVuc.ForeColor = System.Drawing.Color.Black;
            this.txtKhuVuc.Location = new System.Drawing.Point(132, 132);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(112, 20);
            this.txtKhuVuc.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(35, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(169, 182);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // IAddArea
            // 
            this.IAddArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.IAddArea.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IAddArea.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.IAddArea.ForeColor = System.Drawing.Color.Black;
            this.IAddArea.Image = ((System.Drawing.Image)(resources.GetObject("IAddArea.Image")));
            this.IAddArea.Location = new System.Drawing.Point(86, 8);
            this.IAddArea.Name = "IAddArea";
            this.IAddArea.ReflectionEnabled = false;
            this.IAddArea.Size = new System.Drawing.Size(110, 111);
            this.IAddArea.TabIndex = 5;
            // 
            // ThemKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.IAddArea);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtKhuVuc);
            this.Controls.Add(this.AddArea);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThemKhuVuc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Thêm Khu Vực</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.ThemKhuVuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX AddArea;
        private TextBoxX txtKhuVuc;
        private ButtonX btnThem;
        private ButtonX btnHuy;
        private ReflectionImage IAddArea;
    }
}