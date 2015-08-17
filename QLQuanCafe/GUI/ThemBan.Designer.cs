namespace QLQuanCafe.GUI
{
    partial class ThemBan
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
            this.ATable = new DevComponents.DotNetBar.LabelX();
            this.TATable = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BAccept = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
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
            // TATable
            // 
            this.TATable.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TATable.Border.Class = "TextBoxBorder";
            this.TATable.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TATable.DisabledBackColor = System.Drawing.Color.White;
            this.TATable.ForeColor = System.Drawing.Color.Black;
            this.TATable.Location = new System.Drawing.Point(127, 153);
            this.TATable.Name = "TATable";
            this.TATable.Size = new System.Drawing.Size(129, 20);
            this.TATable.TabIndex = 1;
            // 
            // BAccept
            // 
            this.BAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAccept.BackColor = System.Drawing.Color.White;
            this.BAccept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAccept.Location = new System.Drawing.Point(37, 265);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(75, 23);
            this.BAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.BAccept.TabIndex = 3;
            this.BAccept.Text = "Đồng Ý";
            // 
            // BCancel
            // 
            this.BCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(181, 265);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.BCancel.TabIndex = 4;
            this.BCancel.Text = "Hủy Bỏ";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(26, 198);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Khu Vực :";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(127, 199);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(129, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 6;
            // 
            // IOpenTable
            // 
            this.IOpenTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.IOpenTable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IOpenTable.ForeColor = System.Drawing.Color.Black;
            this.IOpenTable.Image = global::QLQuanCafe.GUI.Properties.Resources.AddTable;
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
            this.CancelButton = this.BCancel;
            this.ClientSize = new System.Drawing.Size(308, 333);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.IOpenTable);
            this.Controls.Add(this.TATable);
            this.Controls.Add(this.ATable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ThemBan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Thêm Bàn</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.ThemBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX ATable;
        private DevComponents.DotNetBar.Controls.TextBoxX TATable;
        private DevComponents.DotNetBar.LabelX IOpenTable;
        private DevComponents.DotNetBar.ButtonX BAccept;
        private DevComponents.DotNetBar.ButtonX BCancel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
    }
}