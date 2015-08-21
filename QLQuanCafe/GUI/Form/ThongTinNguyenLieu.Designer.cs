﻿using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Form
{
    partial class ThongTinNguyenLieu
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
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
=======

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> 4470b037919d8002e3ce1925386742ff9b60fe81
            this.dgvNguyenLieu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.materialDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThemNguyenLieu = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaNguyenLieu = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaNguyenLieu = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.materialDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialIdDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.AllowUserToAddRows = false;
            this.dgvNguyenLieu.AllowUserToDeleteRows = false;
            this.dgvNguyenLieu.AllowUserToResizeRows = false;
            this.dgvNguyenLieu.AutoGenerateColumns = false;
            this.dgvNguyenLieu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIdDataGridViewTextBoxColumn,
            this.materialNameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvNguyenLieu.DataSource = this.materialDataBindingSource;
<<<<<<< HEAD
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguyenLieu.DefaultCellStyle = dataGridViewCellStyle2;
=======

            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguyenLieu.DefaultCellStyle = dataGridViewCellStyle5;
>>>>>>> 4470b037919d8002e3ce1925386742ff9b60fe81
            this.dgvNguyenLieu.EnableHeadersVisualStyles = false;
            this.dgvNguyenLieu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.dgvNguyenLieu.Location = new System.Drawing.Point(12, 25);
            this.dgvNguyenLieu.MultiSelect = false;
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguyenLieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNguyenLieu.RowHeadersVisible = false;
            this.dgvNguyenLieu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(564, 463);
            this.dgvNguyenLieu.TabIndex = 0;
            this.dgvNguyenLieu.SelectionChanged += new System.EventHandler(this.dgvNguyenLieu_SelectionChanged);
            // 
            // materialDataBindingSource
            // 
            this.materialDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.MaterialData);
            // 
            // btnThemNguyenLieu
            // 
            this.btnThemNguyenLieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNguyenLieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNguyenLieu.Location = new System.Drawing.Point(12, 522);
            this.btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            this.btnThemNguyenLieu.Size = new System.Drawing.Size(75, 23);
            this.btnThemNguyenLieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemNguyenLieu.TabIndex = 1;
            this.btnThemNguyenLieu.Text = "Thêm ";
            this.btnThemNguyenLieu.Click += new System.EventHandler(this.btnThemNguyenLieu_Click);
            // 
            // btnSuaNguyenLieu
            // 
            this.btnSuaNguyenLieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaNguyenLieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaNguyenLieu.Location = new System.Drawing.Point(165, 522);
            this.btnSuaNguyenLieu.Name = "btnSuaNguyenLieu";
            this.btnSuaNguyenLieu.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNguyenLieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaNguyenLieu.TabIndex = 2;
            this.btnSuaNguyenLieu.Text = "Sửa";
            this.btnSuaNguyenLieu.Click += new System.EventHandler(this.btnSuaNguyenLieu_Click);
            // 
            // btnXoaNguyenLieu
            // 
            this.btnXoaNguyenLieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaNguyenLieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaNguyenLieu.Location = new System.Drawing.Point(331, 522);
            this.btnXoaNguyenLieu.Name = "btnXoaNguyenLieu";
            this.btnXoaNguyenLieu.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNguyenLieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaNguyenLieu.TabIndex = 3;
            this.btnXoaNguyenLieu.Text = "Xóa";
            this.btnXoaNguyenLieu.Click += new System.EventHandler(this.btnXoaNguyenLieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(498, 522);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // materialDataBindingSource
            // 
            this.materialDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.MaterialData);
            // 
            // materialIdDataGridViewTextBoxColumn
            // 
            this.materialIdDataGridViewTextBoxColumn.Checked = true;
            this.materialIdDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.materialIdDataGridViewTextBoxColumn.CheckValue = "N";
            this.materialIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialId";
            this.materialIdDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.materialIdDataGridViewTextBoxColumn.Name = "materialIdDataGridViewTextBoxColumn";
            this.materialIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materialIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            this.materialNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.unitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.unitDataGridViewTextBoxColumn.HeaderText = "Đơn Vị Tính";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ThongTinNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 575);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaNguyenLieu);
            this.Controls.Add(this.btnSuaNguyenLieu);
            this.Controls.Add(this.btnThemNguyenLieu);
            this.Controls.Add(this.dgvNguyenLieu);

            this.MaximizeBox = false;
            this.Name = "ThongTinNguyenLieu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Thông Tin Nguyên Liệu</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.ThongTinNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewX dgvNguyenLieu;
        private ButtonX btnThemNguyenLieu;
        private ButtonX btnSuaNguyenLieu;
        private ButtonX btnXoaNguyenLieu;
        private BindingSource materialDataBindingSource;
        private ButtonX btnThoat;
        private DataGridViewCheckBoxXColumn materialIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}