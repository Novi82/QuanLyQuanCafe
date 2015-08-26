using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI
{
    partial class BaoCao_ThongKe
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
            this.cbxThang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbxNam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnThang = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxThang
            // 
            this.cbxThang.DisplayMember = "Text";
            this.cbxThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThang.ForeColor = System.Drawing.Color.Black;
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.ItemHeight = 14;
            this.cbxThang.Location = new System.Drawing.Point(72, 67);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(69, 20);
            this.cbxThang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxThang.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(21, 67);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(45, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Tháng :";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // cbxNam
            // 
            this.cbxNam.DisplayMember = "Text";
            this.cbxNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxNam.DropDownHeight = 200;
            this.cbxNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNam.Enabled = false;
            this.cbxNam.ForeColor = System.Drawing.Color.Black;
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.IntegralHeight = false;
            this.cbxNam.ItemHeight = 14;
            this.cbxNam.Location = new System.Drawing.Point(269, 69);
            this.cbxNam.MaxDropDownItems = 5;
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(69, 20);
            this.cbxNam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxNam.TabIndex = 2;
            this.cbxNam.SelectedIndexChanged += new System.EventHandler(this.cbxNam_SelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(230, 69);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(33, 20);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Năm :";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(185, 135);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Xem";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(292, 135);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Text = "Hủy Bỏ";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.rbtnNam);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.cbxThang);
            this.groupBox1.Controls.Add(this.cbxNam);
            this.groupBox1.Controls.Add(this.rbtnThang);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo Cáo Doanh Thu";
            // 
            // rbtnThang
            // 
            this.rbtnThang.AutoSize = true;
            this.rbtnThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbtnThang.ForeColor = System.Drawing.Color.Black;
            this.rbtnThang.Location = new System.Drawing.Point(21, 24);
            this.rbtnThang.Name = "rbtnThang";
            this.rbtnThang.Size = new System.Drawing.Size(100, 17);
            this.rbtnThang.TabIndex = 0;
            this.rbtnThang.TabStop = true;
            this.rbtnThang.Text = "Báo Cáo Tháng";
            this.rbtnThang.UseVisualStyleBackColor = false;
            this.rbtnThang.CheckedChanged += new System.EventHandler(this.rbtnThang_CheckedChanged);
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbtnNam.ForeColor = System.Drawing.Color.Black;
            this.rbtnNam.Location = new System.Drawing.Point(230, 24);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(91, 17);
            this.rbtnNam.TabIndex = 1;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Báo Cáo Năm";
            this.rbtnNam.UseVisualStyleBackColor = false;
            this.rbtnNam.CheckedChanged += new System.EventHandler(this.rbtnNam_CheckedChanged);
            // 
            // BaoCao_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 176);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaoCao_ThongKe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Báo Cáo Thống Kê</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.BaoCao_ThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBoxEx cbxThang;
        private LabelX labelX1;
        private ComboBoxEx cbxNam;
        private LabelX labelX2;
        private ButtonX buttonX1;
        private ButtonX buttonX2;
        private GroupBox groupBox1;
        private RadioButton rbtnNam;
        private RadioButton rbtnThang;
    }
}