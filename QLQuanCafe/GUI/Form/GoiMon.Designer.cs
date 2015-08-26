using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace QLQuanCafe.GUI.Form
{
    partial class GoiMon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxLoaiMonAn = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.menuCategoryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTimMonAn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTimMonAn = new DevComponents.DotNetBar.ButtonX();
            this.dgvMonAn = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menuCategoryDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemDataBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.cbxLoaiMonAn.Location = new System.Drawing.Point(12, 12);
            this.cbxLoaiMonAn.Name = "cbxLoaiMonAn";
            this.cbxLoaiMonAn.Size = new System.Drawing.Size(147, 20);
            this.cbxLoaiMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxLoaiMonAn.TabIndex = 0;
            this.cbxLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiMonAn_SelectedIndexChanged);
            // 
            // menuCategoryDataBindingSource
            // 
            this.menuCategoryDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.MenuCategoryData);
            // 
            // txtTimMonAn
            // 
            this.txtTimMonAn.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTimMonAn.Border.Class = "TextBoxBorder";
            this.txtTimMonAn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimMonAn.DisabledBackColor = System.Drawing.Color.White;
            this.txtTimMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtTimMonAn.Location = new System.Drawing.Point(177, 12);
            this.txtTimMonAn.Name = "txtTimMonAn";
            this.txtTimMonAn.PreventEnterBeep = true;
            this.txtTimMonAn.Size = new System.Drawing.Size(154, 20);
            this.txtTimMonAn.TabIndex = 1;
            // 
            // btnTimMonAn
            // 
            this.btnTimMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimMonAn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimMonAn.Location = new System.Drawing.Point(337, 12);
            this.btnTimMonAn.Name = "btnTimMonAn";
            this.btnTimMonAn.Size = new System.Drawing.Size(31, 20);
            this.btnTimMonAn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimMonAn.Symbol = "";
            this.btnTimMonAn.SymbolColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTimMonAn.SymbolSize = 11F;
            this.btnTimMonAn.TabIndex = 34;
            this.btnTimMonAn.Click += new System.EventHandler(this.btnTimMonAn_Click);
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToAddRows = false;
            this.dgvMonAn.AllowUserToDeleteRows = false;
            this.dgvMonAn.AllowUserToOrderColumns = true;
            this.dgvMonAn.AutoGenerateColumns = false;
            this.dgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMonAn.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonAn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.dgvMonAn.DataSource = this.menuItemDataBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonAn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMonAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvMonAn.Location = new System.Drawing.Point(12, 47);
            this.dgvMonAn.MultiSelect = false;
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.PaintEnhancedSelection = false;
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonAn.RowHeadersVisible = false;
            this.dgvMonAn.SelectAllSignVisible = false;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(354, 311);
            this.dgvMonAn.TabIndex = 35;
            this.dgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            this.dgvMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellContentClick_1);
            this.dgvMonAn.SelectionChanged += new System.EventHandler(this.dgvMonAn_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MenuItemName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Món";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Unit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn Vị Tính";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // menuItemDataBindingSource
            // 
            this.menuItemDataBindingSource.DataSource = typeof(QLQuanCafe.DTO.MenuItemData);
            // 
            // GoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 370);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.btnTimMonAn);
            this.Controls.Add(this.txtTimMonAn);
            this.Controls.Add(this.cbxLoaiMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GoiMon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#ffffff\">Gọi Món</font><font color=\"#000000\"></font>";
            this.Load += new System.EventHandler(this.YeuCauMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuCategoryDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBoxEx cbxLoaiMonAn;
        private TextBoxX txtTimMonAn;
        private ButtonX btnTimMonAn;
        private DataGridViewX dgvMonAn;

        private System.Windows.Forms.BindingSource menuCategoryDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource menuItemDataBindingSource;

    }
}