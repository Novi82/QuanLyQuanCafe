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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuVuc_BanUC));
            this.mainPanel = new DevComponents.DotNetBar.PanelEx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTachBan = new DevComponents.DotNetBar.ButtonX();
            this.btnGopBan = new DevComponents.DotNetBar.ButtonX();
            this.btnChuyenBan = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyDatBan = new DevComponents.DotNetBar.ButtonX();
            this.btnDatBan = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyBan = new DevComponents.DotNetBar.ButtonX();
            this.btnMoBan = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBanThanhToan = new DevComponents.DotNetBar.LabelX();
            this.lblGioDen = new DevComponents.DotNetBar.LabelX();
            this.lblTrangThai = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblTenBan = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnThanhToan = new DevComponents.DotNetBar.ButtonX();
            this.btnChuanBi = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lblTongTien = new DevComponents.DotNetBar.LabelX();
            this.btnGoiMon = new DevComponents.DotNetBar.ButtonX();
            this.stcKhuVuc = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.dgvMonDaGoi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableImage = new System.Windows.Forms.ImageList(this.components);
            this.menuItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDetailDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stcKhuVuc)).BeginInit();
            this.stcKhuVuc.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDaGoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailDataBindingSource)).BeginInit();
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
            this.mainPanel.Size = new System.Drawing.Size(772, 380);
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelEx1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.stcKhuVuc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelEx2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTachBan);
            this.panel1.Controls.Add(this.btnGopBan);
            this.panel1.Controls.Add(this.btnChuyenBan);
            this.panel1.Controls.Add(this.btnHuyDatBan);
            this.panel1.Controls.Add(this.btnDatBan);
            this.panel1.Controls.Add(this.btnHuyBan);
            this.panel1.Controls.Add(this.btnMoBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(258, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 243);
            this.panel1.TabIndex = 0;
            // 
            // btnTachBan
            // 
            this.btnTachBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTachBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTachBan.Location = new System.Drawing.Point(3, 183);
            this.btnTachBan.Name = "btnTachBan";
            this.btnTachBan.Size = new System.Drawing.Size(75, 23);
            this.btnTachBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTachBan.TabIndex = 21;
            this.btnTachBan.Text = "Tách Bàn";
            this.btnTachBan.Click += new System.EventHandler(this.btnTachBan_Click);
            // 
            // btnGopBan
            // 
            this.btnGopBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGopBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGopBan.Location = new System.Drawing.Point(3, 154);
            this.btnGopBan.Name = "btnGopBan";
            this.btnGopBan.Size = new System.Drawing.Size(75, 23);
            this.btnGopBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGopBan.TabIndex = 20;
            this.btnGopBan.Text = "Gộp Bàn";
            this.btnGopBan.Click += new System.EventHandler(this.btnGopBan_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuyenBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuyenBan.Location = new System.Drawing.Point(3, 125);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChuyenBan.TabIndex = 19;
            this.btnChuyenBan.Text = "Chuyển Bàn";
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // btnHuyDatBan
            // 
            this.btnHuyDatBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyDatBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyDatBan.Enabled = false;
            this.btnHuyDatBan.Location = new System.Drawing.Point(3, 90);
            this.btnHuyDatBan.Name = "btnHuyDatBan";
            this.btnHuyDatBan.Size = new System.Drawing.Size(75, 23);
            this.btnHuyDatBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuyDatBan.TabIndex = 4;
            this.btnHuyDatBan.Text = "Hủy Đặt Bàn";
            this.btnHuyDatBan.Click += new System.EventHandler(this.btnHuyDatBan_Click);
            // 
            // btnDatBan
            // 
            this.btnDatBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDatBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDatBan.Enabled = false;
            this.btnDatBan.Location = new System.Drawing.Point(3, 61);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(75, 23);
            this.btnDatBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDatBan.TabIndex = 4;
            this.btnDatBan.Text = "Đặt bàn";
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyBan.Enabled = false;
            this.btnHuyBan.Location = new System.Drawing.Point(3, 32);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuyBan.TabIndex = 4;
            this.btnHuyBan.Text = "Hủy Bàn";
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // btnMoBan
            // 
            this.btnMoBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMoBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMoBan.Enabled = false;
            this.btnMoBan.EnableMarkup = false;
            this.btnMoBan.Location = new System.Drawing.Point(3, 3);
            this.btnMoBan.Name = "btnMoBan";
            this.btnMoBan.Size = new System.Drawing.Size(75, 23);
            this.btnMoBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMoBan.TabIndex = 4;
            this.btnMoBan.Text = "Mở Bàn";
            this.btnMoBan.Click += new System.EventHandler(this.btnMoBan_Click);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.lblBanThanhToan);
            this.panel2.Controls.Add(this.lblGioDen);
            this.panel2.Controls.Add(this.lblTrangThai);
            this.panel2.Controls.Add(this.labelX4);
            this.panel2.Controls.Add(this.labelX3);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Controls.Add(this.lblTenBan);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 125);
            this.panel2.TabIndex = 2;
            // 
            // lblBanThanhToan
            // 
            // 
            // 
            // 
            this.lblBanThanhToan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBanThanhToan.Location = new System.Drawing.Point(121, 99);
            this.lblBanThanhToan.Name = "lblBanThanhToan";
            this.lblBanThanhToan.Size = new System.Drawing.Size(75, 23);
            this.lblBanThanhToan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblBanThanhToan.TabIndex = 1;
            // 
            // lblGioDen
            // 
            // 
            // 
            // 
            this.lblGioDen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblGioDen.Location = new System.Drawing.Point(121, 72);
            this.lblGioDen.Name = "lblGioDen";
            this.lblGioDen.Size = new System.Drawing.Size(75, 23);
            this.lblGioDen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblGioDen.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            // 
            // 
            // 
            this.lblTrangThai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTrangThai.Location = new System.Drawing.Point(121, 43);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(75, 23);
            this.lblTrangThai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblTrangThai.TabIndex = 1;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(19, 99);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "Bàn thanh toán";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(19, 72);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Giờ đền";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(19, 43);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Trạng Thái";
            // 
            // lblTenBan
            // 
            // 
            // 
            // 
            this.lblTenBan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTenBan.Location = new System.Drawing.Point(121, 14);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(75, 23);
            this.lblTenBan.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelX1.Location = new System.Drawing.Point(19, 14);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Bàn - ";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnThanhToan);
            this.panelEx1.Controls.Add(this.btnChuanBi);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.lblTongTien);
            this.panelEx1.Controls.Add(this.btnGoiMon);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(348, 252);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(421, 125);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(253, 72);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(165, 40);
            this.btnThanhToan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextColor = System.Drawing.Color.Maroon;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnChuanBi
            // 
            this.btnChuanBi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuanBi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuanBi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuanBi.Enabled = false;
            this.btnChuanBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnChuanBi.Location = new System.Drawing.Point(136, 72);
            this.btnChuanBi.Name = "btnChuanBi";
            this.btnChuanBi.Size = new System.Drawing.Size(111, 40);
            this.btnChuanBi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChuanBi.TabIndex = 18;
            this.btnChuanBi.Text = "Chuẩn bị";
            this.btnChuanBi.Click += new System.EventHandler(this.btnChuanBi_Click);
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Red;
            this.labelX5.Location = new System.Drawing.Point(356, 3);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(62, 46);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "vnd";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblTongTien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(136, 3);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(220, 46);
            this.lblTongTien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "tongTien";
            this.lblTongTien.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGoiMon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGoiMon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGoiMon.Enabled = false;
            this.btnGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnGoiMon.Location = new System.Drawing.Point(3, 72);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(127, 40);
            this.btnGoiMon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGoiMon.TabIndex = 18;
            this.btnGoiMon.Text = "Gọi món";
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // stcKhuVuc
            // 
            this.stcKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.stcKhuVuc.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.stcKhuVuc.ControlBox.MenuBox.Name = "";
            this.stcKhuVuc.ControlBox.Name = "";
            this.stcKhuVuc.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stcKhuVuc.ControlBox.MenuBox,
            this.stcKhuVuc.ControlBox.CloseBox});
            this.stcKhuVuc.Controls.Add(this.superTabControlPanel1);
            this.stcKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcKhuVuc.ForeColor = System.Drawing.Color.Black;
            this.stcKhuVuc.Location = new System.Drawing.Point(3, 3);
            this.stcKhuVuc.Name = "stcKhuVuc";
            this.stcKhuVuc.ReorderTabsEnabled = true;
            this.stcKhuVuc.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.stcKhuVuc.SelectedTabIndex = 0;
            this.stcKhuVuc.Size = new System.Drawing.Size(249, 243);
            this.stcKhuVuc.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stcKhuVuc.TabIndex = 5;
            this.stcKhuVuc.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1});
            this.stcKhuVuc.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(249, 218);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "superTabItem1";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.dgvMonDaGoi);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(348, 3);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(421, 243);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 6;
            // 
            // dgvMonDaGoi
            // 
            this.dgvMonDaGoi.AllowUserToAddRows = false;
            this.dgvMonDaGoi.AllowUserToDeleteRows = false;
            this.dgvMonDaGoi.AutoGenerateColumns = false;
            this.dgvMonDaGoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonDaGoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonDaGoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonDaGoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuItemDataGridViewTextBoxColumn,
            this.DonGia,
            this.quantityDataGridViewTextBoxColumn,
            this.ThanhTien,
            this.noteDataGridViewTextBoxColumn});
            this.dgvMonDaGoi.DataSource = this.billDetailDataBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonDaGoi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonDaGoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonDaGoi.EnableHeadersVisualStyles = false;
            this.dgvMonDaGoi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvMonDaGoi.Location = new System.Drawing.Point(0, 0);
            this.dgvMonDaGoi.MultiSelect = false;
            this.dgvMonDaGoi.Name = "dgvMonDaGoi";
            this.dgvMonDaGoi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonDaGoi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonDaGoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonDaGoi.Size = new System.Drawing.Size(421, 243);
            this.dgvMonDaGoi.TabIndex = 19;
            this.dgvMonDaGoi.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMonDaGoi_RowsAdded);
            this.dgvMonDaGoi.SelectionChanged += new System.EventHandler(this.dgvMonDaGoi_SelectionChanged);
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 71;
            // 
            // tableImage
            // 
            this.tableImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tableImage.ImageStream")));
            this.tableImage.TransparentColor = System.Drawing.Color.Transparent;
            this.tableImage.Images.SetKeyName(0, "Trong");
            this.tableImage.Images.SetKeyName(1, "CoNguoi");
            this.tableImage.Images.SetKeyName(2, "ChuaDon");
            this.tableImage.Images.SetKeyName(3, "DaDat");
            // 
            // menuItemDataGridViewTextBoxColumn
            // 
            this.menuItemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuItemDataGridViewTextBoxColumn.DataPropertyName = "MenuItem";
            this.menuItemDataGridViewTextBoxColumn.HeaderText = "Món";
            this.menuItemDataGridViewTextBoxColumn.Name = "menuItemDataGridViewTextBoxColumn";
            this.menuItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 78;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ThanhTien.DataPropertyName = "TotalMoney";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 87;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 70;
            // 
            // billDetailDataBindingSource
            // 
            this.billDetailDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.BillDetailData);
            // 
            // KhuVuc_BanUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "KhuVuc_BanUC";
            this.Size = new System.Drawing.Size(772, 380);
            this.Load += new System.EventHandler(this.KhuVuc_BanUC_Load);
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stcKhuVuc)).EndInit();
            this.stcKhuVuc.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDaGoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnMoBan;
        private DevComponents.DotNetBar.ButtonX btnChuyenBan;
        private DevComponents.DotNetBar.ButtonX btnGopBan;
        private DevComponents.DotNetBar.ButtonX btnTachBan;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX lblGioDen;
        private DevComponents.DotNetBar.LabelX lblTrangThai;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblTenBan;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnThanhToan;
        private DevComponents.DotNetBar.LabelX lblTongTien;
        private DevComponents.DotNetBar.SuperTabControl stcKhuVuc;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private System.Windows.Forms.ImageList tableImage;
        private DevComponents.DotNetBar.ButtonX btnHuyBan;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btnChuanBi;
        private DevComponents.DotNetBar.ButtonX btnGoiMon;
        private DevComponents.DotNetBar.ButtonX btnDatBan;
        private DevComponents.DotNetBar.ButtonX btnHuyDatBan;
        private System.Windows.Forms.BindingSource billDetailDataBindingSource;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMonDaGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.LabelX lblBanThanhToan;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}
