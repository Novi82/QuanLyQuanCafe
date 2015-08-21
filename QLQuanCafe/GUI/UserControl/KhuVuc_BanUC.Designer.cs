namespace QLQuanCafe.GUI.UserControl
{
    partial class KhuVuc_BanUC
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
            this.mainPanel = new DevComponents.DotNetBar.PanelEx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDonBan = new DevComponents.DotNetBar.ButtonX();
            this.btnTachBan = new DevComponents.DotNetBar.ButtonX();
            this.btnGopBan = new DevComponents.DotNetBar.ButtonX();
            this.btnChuyenBan = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyMon = new DevComponents.DotNetBar.ButtonX();
            this.btnMoBan = new DevComponents.DotNetBar.ButtonX();
            this.tabKhuVuc1 = new QLQuanCafe.GUI.UserControl.TabKhuVuc();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.mainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mainPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(315, 380);
            this.mainPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mainPanel.Style.GradientAngle = 90;
            this.mainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabKhuVuc1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDonBan);
            this.panel1.Controls.Add(this.btnTachBan);
            this.panel1.Controls.Add(this.btnGopBan);
            this.panel1.Controls.Add(this.btnChuyenBan);
            this.panel1.Controls.Add(this.btnHuyMon);
            this.panel1.Controls.Add(this.btnMoBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(223, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 374);
            this.panel1.TabIndex = 0;
            // 
            // btnDonBan
            // 
            this.btnDonBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDonBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDonBan.Location = new System.Drawing.Point(3, 213);
            this.btnDonBan.Name = "btnDonBan";
            this.btnDonBan.Size = new System.Drawing.Size(75, 23);
            this.btnDonBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDonBan.TabIndex = 22;
            this.btnDonBan.Text = "Dọn Bàn";
            // 
            // btnTachBan
            // 
            this.btnTachBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTachBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTachBan.Location = new System.Drawing.Point(3, 171);
            this.btnTachBan.Name = "btnTachBan";
            this.btnTachBan.Size = new System.Drawing.Size(75, 23);
            this.btnTachBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTachBan.TabIndex = 21;
            this.btnTachBan.Text = "Tách Bàn";
            // 
            // btnGopBan
            // 
            this.btnGopBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGopBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGopBan.Location = new System.Drawing.Point(3, 129);
            this.btnGopBan.Name = "btnGopBan";
            this.btnGopBan.Size = new System.Drawing.Size(75, 23);
            this.btnGopBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGopBan.TabIndex = 20;
            this.btnGopBan.Text = "Gộp Bàn";
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuyenBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuyenBan.Location = new System.Drawing.Point(3, 87);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChuyenBan.TabIndex = 19;
            this.btnChuyenBan.Text = "Chuyển Bàn";
            // 
            // btnHuyMon
            // 
            this.btnHuyMon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyMon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyMon.Location = new System.Drawing.Point(3, 45);
            this.btnHuyMon.Name = "btnHuyMon";
            this.btnHuyMon.Size = new System.Drawing.Size(75, 23);
            this.btnHuyMon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuyMon.TabIndex = 18;
            this.btnHuyMon.Text = "Hủy Món";
            // 
            // btnMoBan
            // 
            this.btnMoBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMoBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMoBan.Location = new System.Drawing.Point(3, 3);
            this.btnMoBan.Name = "btnMoBan";
            this.btnMoBan.Size = new System.Drawing.Size(75, 23);
            this.btnMoBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMoBan.TabIndex = 4;
            this.btnMoBan.Text = "Mở Bàn";
            // 
            // tabKhuVuc1
            // 
            this.tabKhuVuc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabKhuVuc1.Location = new System.Drawing.Point(3, 3);
            this.tabKhuVuc1.Name = "tabKhuVuc1";
            this.tabKhuVuc1.Size = new System.Drawing.Size(214, 374);
            this.tabKhuVuc1.TabIndex = 1;
            // 
            // KhuVuc_BanUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "KhuVuc_BanUC";
            this.Size = new System.Drawing.Size(315, 380);
            this.Load += new System.EventHandler(this.KhuVuc_BanUC_Load);
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnMoBan;
        private DevComponents.DotNetBar.ButtonX btnHuyMon;
        private DevComponents.DotNetBar.ButtonX btnChuyenBan;
        private DevComponents.DotNetBar.ButtonX btnGopBan;
        private DevComponents.DotNetBar.ButtonX btnTachBan;
        private TabKhuVuc tabKhuVuc1;
        private DevComponents.DotNetBar.ButtonX btnDonBan;
    }
}
