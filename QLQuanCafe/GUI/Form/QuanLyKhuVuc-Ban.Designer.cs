using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Form
{
    partial class QuanLyKhuVuc_Ban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKhuVuc_Ban));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThemKhuVuc = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaKv = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaKv = new DevComponents.DotNetBar.ButtonX();
            this.btnThemBan = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaBan = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaBan = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.areaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemKhuVuc
            // 
            this.btnThemKhuVuc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemKhuVuc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnThemKhuVuc, "btnThemKhuVuc");
            this.btnThemKhuVuc.Name = "btnThemKhuVuc";
            this.btnThemKhuVuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnThemKhuVuc.Click += new System.EventHandler(this.btnThemKhuVuc_Click);
            // 
            // btnSuaKv
            // 
            this.btnSuaKv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaKv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnSuaKv, "btnSuaKv");
            this.btnSuaKv.Name = "btnSuaKv";
            this.btnSuaKv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaKv.Click += new System.EventHandler(this.btnSuaKv_Click);
            // 
            // btnXoaKv
            // 
            this.btnXoaKv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaKv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnXoaKv, "btnXoaKv");
            this.btnXoaKv.Name = "btnXoaKv";
            this.btnXoaKv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaKv.Click += new System.EventHandler(this.btnXoaKv_Click);
            // 
            // btnThemBan
            // 
            this.btnThemBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnThemBan, "btnThemBan");
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnSuaBan, "btnSuaBan");
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaBan.Click += new System.EventHandler(this.btnSuaBan_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnXoaBan, "btnXoaBan");
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.Name = "labelX1";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.Name = "labelX2";
            // 
            // dataGridViewX2
            // 
            this.dataGridViewX2.AllowUserToAddRows = false;
            this.dataGridViewX2.AllowUserToDeleteRows = false;
            this.dataGridViewX2.AutoGenerateColumns = false;
            this.dataGridViewX2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewX2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewX2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableIdDataGridViewTextBoxColumn,
            this.tableNameDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.tableStateDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn1});
            this.dataGridViewX2.DataSource = this.tableDataBindingSource;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX2.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewX2.EnableHeadersVisualStyles = false;
            this.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.dataGridViewX2, "dataGridViewX2");
            this.dataGridViewX2.MultiSelect = false;
            this.dataGridViewX2.Name = "dataGridViewX2";
            this.dataGridViewX2.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX2.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewX2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX2.SelectionChanged += new System.EventHandler(this.dataGridViewX2_SelectionChanged);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaIdDataGridViewTextBoxColumn,
            this.areaNameDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.areaDataBindingSource;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewX1.EnableHeadersVisualStyles = false;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.dataGridViewX1, "dataGridViewX1");
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.SelectionChanged += new System.EventHandler(this.dataGridViewX1_SelectionChanged);
            // 
            // areaIdDataGridViewTextBoxColumn
            // 
            this.areaIdDataGridViewTextBoxColumn.DataPropertyName = "AreaId";
            resources.ApplyResources(this.areaIdDataGridViewTextBoxColumn, "areaIdDataGridViewTextBoxColumn");
            this.areaIdDataGridViewTextBoxColumn.Name = "areaIdDataGridViewTextBoxColumn";
            this.areaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaNameDataGridViewTextBoxColumn
            // 
            this.areaNameDataGridViewTextBoxColumn.DataPropertyName = "AreaName";
            resources.ApplyResources(this.areaNameDataGridViewTextBoxColumn, "areaNameDataGridViewTextBoxColumn");
            this.areaNameDataGridViewTextBoxColumn.Name = "areaNameDataGridViewTextBoxColumn";
            this.areaNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            resources.ApplyResources(this.noteDataGridViewTextBoxColumn, "noteDataGridViewTextBoxColumn");
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDataBindingSource
            // 
            this.areaDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.AreaData);
            // 
            // tableIdDataGridViewTextBoxColumn
            // 
            this.tableIdDataGridViewTextBoxColumn.DataPropertyName = "TableId";
            resources.ApplyResources(this.tableIdDataGridViewTextBoxColumn, "tableIdDataGridViewTextBoxColumn");
            this.tableIdDataGridViewTextBoxColumn.Name = "tableIdDataGridViewTextBoxColumn";
            this.tableIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableNameDataGridViewTextBoxColumn
            // 
            this.tableNameDataGridViewTextBoxColumn.DataPropertyName = "TableName";
            resources.ApplyResources(this.tableNameDataGridViewTextBoxColumn, "tableNameDataGridViewTextBoxColumn");
            this.tableNameDataGridViewTextBoxColumn.Name = "tableNameDataGridViewTextBoxColumn";
            this.tableNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            resources.ApplyResources(this.areaDataGridViewTextBoxColumn, "areaDataGridViewTextBoxColumn");
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableStateDataGridViewTextBoxColumn
            // 
            this.tableStateDataGridViewTextBoxColumn.DataPropertyName = "TableState";
            resources.ApplyResources(this.tableStateDataGridViewTextBoxColumn, "tableStateDataGridViewTextBoxColumn");
            this.tableStateDataGridViewTextBoxColumn.Name = "tableStateDataGridViewTextBoxColumn";
            this.tableStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "Note";
            resources.ApplyResources(this.noteDataGridViewTextBoxColumn1, "noteDataGridViewTextBoxColumn1");
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            this.noteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tableDataBindingSource
            // 
            this.tableDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.TableData);
            // 
            // QuanLyKhuVuc_Ban
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.dataGridViewX2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnXoaBan);
            this.Controls.Add(this.btnSuaBan);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.btnXoaKv);
            this.Controls.Add(this.btnSuaKv);
            this.Controls.Add(this.btnThemKhuVuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QuanLyKhuVuc_Ban";
            this.ShowIcon = false;
            this.TitleText = "<font color=\"#000000\">Quản Lý Khu Vực - Bàn</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.QuanLyKhuVuc_Ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonX btnThemKhuVuc;
        private ButtonX btnSuaKv;
        private ButtonX btnXoaKv;
        private ButtonX btnThemBan;
        private ButtonX btnSuaBan;
        private ButtonX btnXoaBan;
        private LabelX labelX1;
        private LabelX labelX2;
        private DataGridViewX dataGridViewX2;
        private DataGridViewX dataGridViewX1;
        private BindingSource tableDataBindingSource;
        private DataGridViewTextBoxColumn areaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private BindingSource areaDataBindingSource;
        private DataGridViewTextBoxColumn tableIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tableNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tableStateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
    }
}