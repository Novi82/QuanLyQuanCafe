namespace QLQuanCafe.GUI.UserControl
{
    partial class HoaDonUC
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
            this.pnlMain = new DevComponents.DotNetBar.PanelEx();
            this.lblHoaDonTrongNgay = new DevComponents.DotNetBar.LabelX();
            this.dgvHoaDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.billDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtBan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtKhuVuc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlMain.Controls.Add(this.lblHoaDonTrongNgay);
            this.pnlMain.Controls.Add(this.dgvHoaDon);
            this.pnlMain.Controls.Add(this.txtGhiChu);
            this.pnlMain.Controls.Add(this.labelX11);
            this.pnlMain.Controls.Add(this.labelX10);
            this.pnlMain.Controls.Add(this.txtBan);
            this.pnlMain.Controls.Add(this.txtKhuVuc);
            this.pnlMain.Controls.Add(this.labelX9);
            this.pnlMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(584, 422);
            this.pnlMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlMain.Style.GradientAngle = 90;
            this.pnlMain.TabIndex = 0;
            // 
            // lblHoaDonTrongNgay
            // 
            // 
            // 
            // 
            this.lblHoaDonTrongNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHoaDonTrongNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonTrongNgay.Location = new System.Drawing.Point(155, 20);
            this.lblHoaDonTrongNgay.Name = "lblHoaDonTrongNgay";
            this.lblHoaDonTrongNgay.Size = new System.Drawing.Size(426, 39);
            this.lblHoaDonTrongNgay.TabIndex = 42;
            this.lblHoaDonTrongNgay.Text = "Hóa Đơn Trong Ngày";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIdDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.totalMoneyDataGridViewTextBoxColumn,
            this.KhuVuc,
            this.tableDataGridViewTextBoxColumn});
            this.dgvHoaDon.DataSource = this.billDataBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 94);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(570, 325);
            this.dgvHoaDon.TabIndex = 41;
            // 
            // billDataBindingSource
            // 
            this.billDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.BillData);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhiChu.DisabledBackColor = System.Drawing.Color.White;
            this.txtGhiChu.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChu.Location = new System.Drawing.Point(395, 65);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PreventEnterBeep = true;
            this.txtGhiChu.Size = new System.Drawing.Size(165, 20);
            this.txtGhiChu.TabIndex = 40;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(338, 65);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(51, 23);
            this.labelX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX11.TabIndex = 39;
            this.labelX11.Text = "Ghi Chú :";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(179, 65);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(30, 23);
            this.labelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX10.TabIndex = 38;
            this.labelX10.Text = "Bàn :";
            // 
            // txtBan
            // 
            this.txtBan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBan.Border.Class = "TextBoxBorder";
            this.txtBan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBan.DisabledBackColor = System.Drawing.Color.White;
            this.txtBan.ForeColor = System.Drawing.Color.Black;
            this.txtBan.Location = new System.Drawing.Point(215, 65);
            this.txtBan.Name = "txtBan";
            this.txtBan.PreventEnterBeep = true;
            this.txtBan.ReadOnly = true;
            this.txtBan.Size = new System.Drawing.Size(100, 20);
            this.txtBan.TabIndex = 37;
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
            this.txtKhuVuc.Location = new System.Drawing.Point(57, 65);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.PreventEnterBeep = true;
            this.txtKhuVuc.ReadOnly = true;
            this.txtKhuVuc.Size = new System.Drawing.Size(100, 20);
            this.txtKhuVuc.TabIndex = 36;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(3, 65);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(51, 23);
            this.labelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX9.TabIndex = 35;
            this.labelX9.Text = "Khu Vực :";
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "Hóa Đơn";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Thời Gian";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalMoneyDataGridViewTextBoxColumn
            // 
            this.totalMoneyDataGridViewTextBoxColumn.DataPropertyName = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.HeaderText = "Tổng Tiền";
            this.totalMoneyDataGridViewTextBoxColumn.Name = "totalMoneyDataGridViewTextBoxColumn";
            this.totalMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // KhuVuc
            // 
            this.KhuVuc.HeaderText = "Khu Vực";
            this.KhuVuc.Name = "KhuVuc";
            this.KhuVuc.ReadOnly = true;
            // 
            // tableDataGridViewTextBoxColumn
            // 
            this.tableDataGridViewTextBoxColumn.DataPropertyName = "Table";
            this.tableDataGridViewTextBoxColumn.HeaderText = "Bàn";
            this.tableDataGridViewTextBoxColumn.Name = "tableDataGridViewTextBoxColumn";
            this.tableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HoaDonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "HoaDonUC";
            this.Size = new System.Drawing.Size(584, 422);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlMain;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKhuVuc;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvHoaDon;
        private DevComponents.DotNetBar.LabelX lblHoaDonTrongNgay;
        private System.Windows.Forms.BindingSource billDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableDataGridViewTextBoxColumn;
    }
}
