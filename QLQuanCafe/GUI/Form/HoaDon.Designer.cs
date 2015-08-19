using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QLQuanCafe.GUI.Form
{
    partial class HoaDon
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
            this.dtiTuNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dtiDenNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbxKhuVuc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxBan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.btnDatLai = new DevComponents.DotNetBar.ButtonX();
            this.dgvHoaDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtiTuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiDenNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtiTuNgay
            // 
            // 
            // 
            // 
            this.dtiTuNgay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiTuNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiTuNgay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiTuNgay.ButtonDropDown.Visible = true;
            this.dtiTuNgay.IsPopupCalendarOpen = false;
            this.dtiTuNgay.Location = new System.Drawing.Point(62, 32);
            // 
            // 
            // 
            this.dtiTuNgay.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiTuNgay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiTuNgay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtiTuNgay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiTuNgay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiTuNgay.MonthCalendar.DisplayMonth = new System.DateTime(2015, 8, 1, 0, 0, 0, 0);
            this.dtiTuNgay.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtiTuNgay.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiTuNgay.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiTuNgay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiTuNgay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiTuNgay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiTuNgay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiTuNgay.MonthCalendar.TodayButtonVisible = true;
            this.dtiTuNgay.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtiTuNgay.Name = "dtiTuNgay";
            this.dtiTuNgay.Size = new System.Drawing.Size(97, 20);
            this.dtiTuNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiTuNgay.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(33, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Từ :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(178, 29);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(33, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Đến :";
            // 
            // dtiDenNgay
            // 
            // 
            // 
            // 
            this.dtiDenNgay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiDenNgay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDenNgay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiDenNgay.ButtonDropDown.Visible = true;
            this.dtiDenNgay.IsPopupCalendarOpen = false;
            this.dtiDenNgay.Location = new System.Drawing.Point(217, 32);
            // 
            // 
            // 
            this.dtiDenNgay.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiDenNgay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDenNgay.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtiDenNgay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiDenNgay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDenNgay.MonthCalendar.DisplayMonth = new System.DateTime(2015, 8, 1, 0, 0, 0, 0);
            this.dtiDenNgay.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtiDenNgay.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiDenNgay.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiDenNgay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiDenNgay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiDenNgay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiDenNgay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiDenNgay.MonthCalendar.TodayButtonVisible = true;
            this.dtiDenNgay.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtiDenNgay.Name = "dtiDenNgay";
            this.dtiDenNgay.Size = new System.Drawing.Size(97, 20);
            this.dtiDenNgay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiDenNgay.TabIndex = 0;
            // 
            // cbxKhuVuc
            // 
            this.cbxKhuVuc.DisplayMember = "Text";
            this.cbxKhuVuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxKhuVuc.FormattingEnabled = true;
            this.cbxKhuVuc.ItemHeight = 14;
            this.cbxKhuVuc.Location = new System.Drawing.Point(334, 32);
            this.cbxKhuVuc.Name = "cbxKhuVuc";
            this.cbxKhuVuc.Size = new System.Drawing.Size(121, 20);
            this.cbxKhuVuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxKhuVuc.TabIndex = 2;
            this.cbxKhuVuc.WatermarkText = "<i>Khu Vực</i>";
            // 
            // cbxBan
            // 
            this.cbxBan.DisplayMember = "Text";
            this.cbxBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBan.FormattingEnabled = true;
            this.cbxBan.ItemHeight = 14;
            this.cbxBan.Location = new System.Drawing.Point(483, 32);
            this.cbxBan.Name = "cbxBan";
            this.cbxBan.Size = new System.Drawing.Size(109, 20);
            this.cbxBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxBan.TabIndex = 2;
            this.cbxBan.WatermarkText = "<i>Bàn</i>";
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(638, 29);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            // 
            // btnDatLai
            // 
            this.btnDatLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDatLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDatLai.Location = new System.Drawing.Point(731, 29);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(75, 23);
            this.btnDatLai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDatLai.TabIndex = 3;
            this.btnDatLai.Text = "Đặt Lại";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIdDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.totalMoneyDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.tableDataGridViewTextBoxColumn});
            this.dgvHoaDon.DataSource = this.billDataBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 92);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(887, 414);
            this.dgvHoaDon.TabIndex = 4;
            this.dgvHoaDon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvHoaDon_RowsAdded);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(824, 29);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Table";
            this.dataGridViewTextBoxColumn1.HeaderText = "Khu Vực";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.HeaderText = "Khu Vực";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.areaDataGridViewTextBoxColumn.Width = 150;
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "Hóa Đơn";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.billIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.totalMoneyDataGridViewTextBoxColumn.Width = 150;
            // 
            // tableDataGridViewTextBoxColumn
            // 
            this.tableDataGridViewTextBoxColumn.DataPropertyName = "Table";
            this.tableDataGridViewTextBoxColumn.HeaderText = "Bàn";
            this.tableDataGridViewTextBoxColumn.Name = "tableDataGridViewTextBoxColumn";
            this.tableDataGridViewTextBoxColumn.ReadOnly = true;
            this.tableDataGridViewTextBoxColumn.Width = 150;
            // 
            // billDataBindingSource
            // 
            this.billDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.BillData);
            // 
            // tableDataBindingSource
            // 
            this.tableDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.TableData);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 518);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cbxBan);
            this.Controls.Add(this.cbxKhuVuc);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtiDenNgay);
            this.Controls.Add(this.dtiTuNgay);
            this.MaximizeBox = false;
            this.Name = "HoaDon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.TitleText = "<font color=\"#000000\">Hóa Đơn\r\n</font>";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtiTuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiDenNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimeInput dtiTuNgay;
        private LabelX labelX1;
        private LabelX labelX2;
        private DateTimeInput dtiDenNgay;
        private ComboBoxEx cbxKhuVuc;
        private ComboBoxEx cbxBan;
        private ButtonX btnTim;
        private ButtonX btnDatLai;
        private DataGridViewX dgvHoaDon;
        private ButtonX btnThoat;
        private BindingSource billDataBindingSource;
        private BindingSource tableDataBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tableDataGridViewTextBoxColumn;
    }
}