namespace QLQuanCafe.GUI.UserControl
{
    partial class TongTienUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.btnThanhToan = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(3, 3);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(102, 37);
            this.labelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX8.TabIndex = 38;
            this.labelX8.Text = "Tổng Tiền :";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThanhToan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThanhToan.Location = new System.Drawing.Point(120, 52);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(184, 42);
            this.btnThanhToan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThanhToan.TabIndex = 39;
            this.btnThanhToan.Text = "Thanh Toán";
            // 
            // TongTienUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.labelX8);
            this.Name = "TongTienUC";
            this.Size = new System.Drawing.Size(307, 97);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX btnThanhToan;
    }
}
