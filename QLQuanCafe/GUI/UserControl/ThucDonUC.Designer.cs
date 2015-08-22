namespace QLQuanCafe.GUI.UserControl
{
    partial class ThucDonUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ControlPanel = new DevComponents.DotNetBar.PanelEx();
            this.dgvThucDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.menuItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTimKiemMonAn = new DevComponents.DotNetBar.ButtonX();
            this.txtTimKiemMonAn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxLoaiMonAn = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.menuCategoryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCategoryDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.ControlPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ControlPanel.Controls.Add(this.dgvThucDon);
            this.ControlPanel.Controls.Add(this.btnTimKiemMonAn);
            this.ControlPanel.Controls.Add(this.txtTimKiemMonAn);
            this.ControlPanel.Controls.Add(this.cbxLoaiMonAn);
            this.ControlPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(311, 258);
            this.ControlPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.ControlPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ControlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.ControlPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ControlPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.ControlPanel.Style.GradientAngle = 90;
            this.ControlPanel.TabIndex = 0;
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToAddRows = false;
            this.dgvThucDon.AllowUserToDeleteRows = false;
            this.dgvThucDon.AllowUserToResizeRows = false;
            this.dgvThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvThucDon.AutoGenerateColumns = false;
            this.dgvThucDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvThucDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuItemNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.dgvThucDon.DataSource = this.menuItemDataBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThucDon.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThucDon.EnableHeadersVisualStyles = false;
            this.dgvThucDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvThucDon.Location = new System.Drawing.Point(3, 67);
            this.dgvThucDon.MultiSelect = false;
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucDon.Size = new System.Drawing.Size(301, 188);
            this.dgvThucDon.TabIndex = 34;
            this.dgvThucDon.SelectionChanged += new System.EventHandler(this.dgvThucDon_SelectionChanged);
            // 
            // menuItemNameDataGridViewTextBoxColumn
            // 
            this.menuItemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuItemNameDataGridViewTextBoxColumn.DataPropertyName = "MenuItemName";
            this.menuItemNameDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.menuItemNameDataGridViewTextBoxColumn.Name = "menuItemNameDataGridViewTextBoxColumn";
            this.menuItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 51;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.unitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.unitDataGridViewTextBoxColumn.HeaderText = "Đơn Vị Tính";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 93;
            // 
            // menuItemDataBindingSource
            // 
            this.menuItemDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.MenuItemData);
            // 
            // btnTimKiemMonAn
            // 
            this.btnTimKiemMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiemMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimKiemMonAn.Location = new System.Drawing.Point(273, 41);
            this.btnTimKiemMonAn.Name = "btnTimKiemMonAn";
            this.btnTimKiemMonAn.Size = new System.Drawing.Size(31, 20);
            this.btnTimKiemMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiemMonAn.Symbol = "";
            this.btnTimKiemMonAn.SymbolColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTimKiemMonAn.SymbolSize = 11F;
            this.btnTimKiemMonAn.TabIndex = 33;
            // 
            // txtTimKiemMonAn
            // 
            this.txtTimKiemMonAn.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTimKiemMonAn.Border.Class = "TextBoxBorder";
            this.txtTimKiemMonAn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiemMonAn.DisabledBackColor = System.Drawing.Color.White;
            this.txtTimKiemMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemMonAn.Location = new System.Drawing.Point(150, 41);
            this.txtTimKiemMonAn.Name = "txtTimKiemMonAn";
            this.txtTimKiemMonAn.PreventEnterBeep = true;
            this.txtTimKiemMonAn.Size = new System.Drawing.Size(117, 20);
            this.txtTimKiemMonAn.TabIndex = 32;
            // 
            // cbxLoaiMonAn
            // 
            this.cbxLoaiMonAn.DataSource = this.menuCategoryDataBindingSource;
            this.cbxLoaiMonAn.DisplayMember = "MenuCategoryName";
            this.cbxLoaiMonAn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLoaiMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiMonAn.ForeColor = System.Drawing.Color.Black;
            this.cbxLoaiMonAn.FormattingEnabled = true;
            this.cbxLoaiMonAn.ItemHeight = 14;
            this.cbxLoaiMonAn.Location = new System.Drawing.Point(3, 41);
            this.cbxLoaiMonAn.Name = "cbxLoaiMonAn";
            this.cbxLoaiMonAn.Size = new System.Drawing.Size(131, 20);
            this.cbxLoaiMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxLoaiMonAn.TabIndex = 14;
            this.cbxLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiMonAn_SelectedIndexChanged);
            // 
            // menuCategoryDataBindingSource
            // 
            this.menuCategoryDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.MenuCategoryData);
            // 
            // ThucDonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ControlPanel);
            this.Name = "ThucDonUC";
            this.Size = new System.Drawing.Size(311, 258);
            this.Load += new System.EventHandler(this.ThucDonUC_Load);
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCategoryDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx ControlPanel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxLoaiMonAn;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiemMonAn;
        private DevComponents.DotNetBar.ButtonX btnTimKiemMonAn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvThucDon;
        private System.Windows.Forms.BindingSource menuItemDataBindingSource;
        private System.Windows.Forms.BindingSource menuCategoryDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
    }
}
