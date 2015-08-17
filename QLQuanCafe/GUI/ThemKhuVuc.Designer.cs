namespace QLQuanCafe.GUI
{
    partial class ThemKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemKhuVuc));
            this.AddArea = new DevComponents.DotNetBar.LabelX();
            this.TAddArea = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BAdd = new DevComponents.DotNetBar.ButtonX();
            this.BCancel = new DevComponents.DotNetBar.ButtonX();
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
            // TAddArea
            // 
            this.TAddArea.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TAddArea.Border.Class = "TextBoxBorder";
            this.TAddArea.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TAddArea.DisabledBackColor = System.Drawing.Color.White;
            this.TAddArea.ForeColor = System.Drawing.Color.Black;
            this.TAddArea.Location = new System.Drawing.Point(132, 132);
            this.TAddArea.Name = "TAddArea";
            this.TAddArea.Size = new System.Drawing.Size(112, 20);
            this.TAddArea.TabIndex = 1;
            // 
            // BAdd
            // 
            this.BAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BAdd.Location = new System.Drawing.Point(35, 182);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BAdd.TabIndex = 3;
            this.BAdd.Text = "Thêm";
            // 
            // BCancel
            // 
            this.BCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BCancel.Location = new System.Drawing.Point(169, 182);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BCancel.TabIndex = 4;
            this.BCancel.Text = "Hủy Bỏ";
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
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.TAddArea);
            this.Controls.Add(this.AddArea);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ThemKhuVuc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Thêm Khu Vực</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.ThemKhuVuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX AddArea;
        private DevComponents.DotNetBar.Controls.TextBoxX TAddArea;
        private DevComponents.DotNetBar.ButtonX BAdd;
        private DevComponents.DotNetBar.ButtonX BCancel;
        private DevComponents.DotNetBar.Controls.ReflectionImage IAddArea;
    }
}