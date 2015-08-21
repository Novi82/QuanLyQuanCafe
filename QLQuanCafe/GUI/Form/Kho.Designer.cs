using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Form
{
    partial class Kho
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKho = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnNhap = new DevComponents.DotNetBar.ButtonX();
            this.btnXuat = new DevComponents.DotNetBar.ButtonX();
            this.btnHieuChinh = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.materialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryLogDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryLogDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKho
            // 
            this.dgvKho.AllowUserToAddRows = false;
            this.dgvKho.AllowUserToDeleteRows = false;
            this.dgvKho.AllowUserToResizeRows = false;
            this.dgvKho.AutoGenerateColumns = false;
            this.dgvKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIdDataGridViewTextBoxColumn,
            this.materialNameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvKho.DataSource = this.materialDataBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKho.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKho.EnableHeadersVisualStyles = false;
            this.dgvKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvKho.Location = new System.Drawing.Point(12, 12);
            this.dgvKho.MultiSelect = false;
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKho.RowHeadersVisible = false;
            this.dgvKho.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKho.Size = new System.Drawing.Size(613, 383);
            this.dgvKho.TabIndex = 0;
            this.dgvKho.SelectionChanged += new System.EventHandler(this.dgvKho_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(29, 427);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhap.Location = new System.Drawing.Point(140, 427);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập Kho";
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuat.Location = new System.Drawing.Point(253, 427);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuat.TabIndex = 3;
            this.btnXuat.Text = "Xuất Kho";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.btnHieuChinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHieuChinh.Location = new System.Drawing.Point(371, 427);
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.Size = new System.Drawing.Size(75, 23);
            this.btnHieuChinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHieuChinh.TabIndex = 4;
            this.btnHieuChinh.Text = "Hiệu Chỉnh";
            this.btnHieuChinh.Click += new System.EventHandler(this.btnHieuChinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(508, 427);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // materialIdDataGridViewTextBoxColumn
            // 
            this.materialIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialId";
            this.materialIdDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.materialIdDataGridViewTextBoxColumn.Name = "materialIdDataGridViewTextBoxColumn";
            this.materialIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "Nguyên Liệu";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            this.materialNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Đơn Vị Tính";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDataBindingSource
            // 
            this.materialDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.MaterialData);
            // 
            // inventoryLogDataBindingSource
            // 
            this.inventoryLogDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.InventoryLogData);
            // 
            // Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 480);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHieuChinh);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvKho);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kho";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Kho</font>";
            this.Load += new System.EventHandler(this.Kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryLogDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewX dgvKho;
        private ButtonX btnThem;
        private ButtonX btnNhap;
        private ButtonX btnXuat;
        private ButtonX btnHieuChinh;
        private ButtonX btnThoat;
        private BindingSource materialDataBindingSource;
        private BindingSource inventoryLogDataBindingSource;
        private DataGridViewTextBoxColumn materialIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}