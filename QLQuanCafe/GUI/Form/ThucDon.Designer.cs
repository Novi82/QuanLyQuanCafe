using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Form
{
    partial class ThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvLoaiMonAn = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgvMonAn = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.BtnThemLoaiMonAn = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaLoaiMonAn = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaLoaiMonAn = new DevComponents.DotNetBar.ButtonX();
            this.btnThemMonAn = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaMonAn = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaMonAn = new DevComponents.DotNetBar.ButtonX();
            this.menuItemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCategoryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCategoryDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Loại Món Ăn :";
            // 
            // dgvLoaiMonAn
            // 
            this.dgvLoaiMonAn.AllowUserToAddRows = false;
            this.dgvLoaiMonAn.AllowUserToDeleteRows = false;
            this.dgvLoaiMonAn.AutoGenerateColumns = false;
            this.dgvLoaiMonAn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLoaiMonAn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuCategoryIdDataGridViewTextBoxColumn,
            this.menuCategoryNameDataGridViewTextBoxColumn});
            this.dgvLoaiMonAn.DataSource = this.menuCategoryDataBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiMonAn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiMonAn.EnableHeadersVisualStyles = false;
            this.dgvLoaiMonAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvLoaiMonAn.Location = new System.Drawing.Point(12, 52);
            this.dgvLoaiMonAn.MultiSelect = false;
            this.dgvLoaiMonAn.Name = "dgvLoaiMonAn";
            this.dgvLoaiMonAn.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiMonAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiMonAn.Size = new System.Drawing.Size(289, 315);
            this.dgvLoaiMonAn.TabIndex = 8;
            this.dgvLoaiMonAn.SelectionChanged += new System.EventHandler(this.dgvLoaiMonAn_SelectionChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(364, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Món Ăn :";
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToAddRows = false;
            this.dgvMonAn.AllowUserToDeleteRows = false;
            this.dgvMonAn.AutoGenerateColumns = false;
            this.dgvMonAn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMonAn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuItemIdDataGridViewTextBoxColumn,
            this.menuItemNameDataGridViewTextBoxColumn,
            this.imagePathDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.menuCategoryDataGridViewTextBoxColumn});
            this.dgvMonAn.DataSource = this.menuItemDataBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonAn.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMonAn.EnableHeadersVisualStyles = false;
            this.dgvMonAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvMonAn.Location = new System.Drawing.Point(352, 52);
            this.dgvMonAn.MultiSelect = false;
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(652, 315);
            this.dgvMonAn.TabIndex = 9;
            this.dgvMonAn.SelectionChanged += new System.EventHandler(this.dgvMonAn_SelectionChanged);
            // 
            // BtnThemLoaiMonAn
            // 
            this.BtnThemLoaiMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnThemLoaiMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnThemLoaiMonAn.Location = new System.Drawing.Point(12, 397);
            this.BtnThemLoaiMonAn.Name = "BtnThemLoaiMonAn";
            this.BtnThemLoaiMonAn.Size = new System.Drawing.Size(85, 23);
            this.BtnThemLoaiMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnThemLoaiMonAn.TabIndex = 10;
            this.BtnThemLoaiMonAn.Text = "Thêm Loại Món";
            this.BtnThemLoaiMonAn.Click += new System.EventHandler(this.BtnThemLoaiMonAn_Click);
            // 
            // btnSuaLoaiMonAn
            // 
            this.btnSuaLoaiMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaLoaiMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaLoaiMonAn.Location = new System.Drawing.Point(122, 397);
            this.btnSuaLoaiMonAn.Name = "btnSuaLoaiMonAn";
            this.btnSuaLoaiMonAn.Size = new System.Drawing.Size(75, 23);
            this.btnSuaLoaiMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaLoaiMonAn.TabIndex = 10;
            this.btnSuaLoaiMonAn.Text = "Sửa Loại Món";
            this.btnSuaLoaiMonAn.Click += new System.EventHandler(this.btnSuaLoaiMonAn_Click);
            // 
            // btnXoaLoaiMonAn
            // 
            this.btnXoaLoaiMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaLoaiMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaLoaiMonAn.Location = new System.Drawing.Point(226, 397);
            this.btnXoaLoaiMonAn.Name = "btnXoaLoaiMonAn";
            this.btnXoaLoaiMonAn.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLoaiMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaLoaiMonAn.TabIndex = 10;
            this.btnXoaLoaiMonAn.Text = "Xóa Loại Món";
            this.btnXoaLoaiMonAn.Click += new System.EventHandler(this.btnXoaLoaiMonAn_Click);
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMonAn.Location = new System.Drawing.Point(352, 397);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(75, 23);
            this.btnThemMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemMonAn.TabIndex = 10;
            this.btnThemMonAn.Text = "Thêm Món Ăn";
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // btnSuaMonAn
            // 
            this.btnSuaMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaMonAn.Location = new System.Drawing.Point(472, 397);
            this.btnSuaMonAn.Name = "btnSuaMonAn";
            this.btnSuaMonAn.Size = new System.Drawing.Size(75, 23);
            this.btnSuaMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaMonAn.TabIndex = 10;
            this.btnSuaMonAn.Text = "Sửa Món Ăn";
            this.btnSuaMonAn.Click += new System.EventHandler(this.btnSuaMonAn_Click);
            // 
            // btnXoaMonAn
            // 
            this.btnXoaMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaMonAn.Location = new System.Drawing.Point(603, 397);
            this.btnXoaMonAn.Name = "btnXoaMonAn";
            this.btnXoaMonAn.Size = new System.Drawing.Size(75, 23);
            this.btnXoaMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaMonAn.TabIndex = 10;
            this.btnXoaMonAn.Text = "Xóa Món Ăn";
            this.btnXoaMonAn.Click += new System.EventHandler(this.btnXoaMonAn_Click);
            // 
            // menuItemIdDataGridViewTextBoxColumn
            // 
            this.menuItemIdDataGridViewTextBoxColumn.DataPropertyName = "MenuItemId";
            this.menuItemIdDataGridViewTextBoxColumn.HeaderText = "Mã Món Ăn";
            this.menuItemIdDataGridViewTextBoxColumn.Name = "menuItemIdDataGridViewTextBoxColumn";
            this.menuItemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuItemIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // menuItemNameDataGridViewTextBoxColumn
            // 
            this.menuItemNameDataGridViewTextBoxColumn.DataPropertyName = "MenuItemName";
            this.menuItemNameDataGridViewTextBoxColumn.HeaderText = "Tên Món Ăn";
            this.menuItemNameDataGridViewTextBoxColumn.Name = "menuItemNameDataGridViewTextBoxColumn";
            this.menuItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuItemNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // imagePathDataGridViewTextBoxColumn
            // 
            this.imagePathDataGridViewTextBoxColumn.DataPropertyName = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.HeaderText = "Hình Ảnh";
            this.imagePathDataGridViewTextBoxColumn.Name = "imagePathDataGridViewTextBoxColumn";
            this.imagePathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 50;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Đơn Vị Tính";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 80;
            // 
            // menuCategoryDataGridViewTextBoxColumn
            // 
            this.menuCategoryDataGridViewTextBoxColumn.DataPropertyName = "MenuCategory";
            this.menuCategoryDataGridViewTextBoxColumn.HeaderText = "Loại Món Ăn";
            this.menuCategoryDataGridViewTextBoxColumn.Name = "menuCategoryDataGridViewTextBoxColumn";
            this.menuCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuCategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // menuItemDataBindingSource
            // 
            this.menuItemDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.MenuItemData);
            // 
            // menuCategoryIdDataGridViewTextBoxColumn
            // 
            this.menuCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "MenuCategoryId";
            this.menuCategoryIdDataGridViewTextBoxColumn.HeaderText = "Mã Loại";
            this.menuCategoryIdDataGridViewTextBoxColumn.Name = "menuCategoryIdDataGridViewTextBoxColumn";
            this.menuCategoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuCategoryIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // menuCategoryNameDataGridViewTextBoxColumn
            // 
            this.menuCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "MenuCategoryName";
            this.menuCategoryNameDataGridViewTextBoxColumn.HeaderText = "Loại Món Ăn";
            this.menuCategoryNameDataGridViewTextBoxColumn.Name = "menuCategoryNameDataGridViewTextBoxColumn";
            this.menuCategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuCategoryNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // menuCategoryDataBindingSource
            // 
            this.menuCategoryDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.MenuCategoryData);
            // 
            // ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 457);
            this.Controls.Add(this.btnXoaMonAn);
            this.Controls.Add(this.btnSuaMonAn);
            this.Controls.Add(this.btnThemMonAn);
            this.Controls.Add(this.btnXoaLoaiMonAn);
            this.Controls.Add(this.btnSuaLoaiMonAn);
            this.Controls.Add(this.BtnThemLoaiMonAn);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.dgvLoaiMonAn);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.MaximizeBox = false;
            this.Name = "ThucDon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Thực Đơn</font>";
            this.Load += new System.EventHandler(this.ThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuCategoryDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelX labelX1;
        private DataGridViewX dgvLoaiMonAn;
        private LabelX labelX2;
        private DataGridViewX dgvMonAn;
        private ButtonX BtnThemLoaiMonAn;
        private ButtonX btnSuaLoaiMonAn;
        private ButtonX btnXoaLoaiMonAn;
        private ButtonX btnThemMonAn;
        private ButtonX btnSuaMonAn;
        private ButtonX btnXoaMonAn;
        private DataGridViewTextBoxColumn menuCategoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuCategoryNameDataGridViewTextBoxColumn;
        private BindingSource menuCategoryDataBindingSource;
        private DataGridViewTextBoxColumn menuItemIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuItemNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuCategoryDataGridViewTextBoxColumn;
        private BindingSource menuItemDataBindingSource;
    }
}