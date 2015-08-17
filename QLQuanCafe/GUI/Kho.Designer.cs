namespace QLQuanCafe.GUI
{
    partial class Kho
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.BNhapKho = new DevComponents.DotNetBar.ButtonX();
            this.BXuatKho = new DevComponents.DotNetBar.ButtonX();
            this.BHieuChinh = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewX1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNguyenLieu,
            this.TenNguyenLieu,
            this.Gianhap,
            this.DonViTinh,
            this.Soluong});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(613, 383);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.HeaderText = "Mã Nguyên Liệu";
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            this.MaNguyenLieu.ReadOnly = true;
            this.MaNguyenLieu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaNguyenLieu.Width = 120;
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.HeaderText = "Tên Nguyên Liệu";
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            this.TenNguyenLieu.ReadOnly = true;
            this.TenNguyenLieu.Width = 140;
            // 
            // Gianhap
            // 
            this.Gianhap.HeaderText = "Giá Nhập";
            this.Gianhap.Name = "Gianhap";
            this.Gianhap.ReadOnly = true;
            this.Gianhap.Width = 110;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // BThemMoi
            // 
            this.BThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BThemMoi.Location = new System.Drawing.Point(29, 427);
            this.BThemMoi.Name = "BThemMoi";
            this.BThemMoi.Size = new System.Drawing.Size(75, 23);
            this.BThemMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BThemMoi.TabIndex = 1;
            this.BThemMoi.Text = "Thêm Mới";
            // 
            // BNhapKho
            // 
            this.BNhapKho.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BNhapKho.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BNhapKho.Location = new System.Drawing.Point(140, 427);
            this.BNhapKho.Name = "BNhapKho";
            this.BNhapKho.Size = new System.Drawing.Size(75, 23);
            this.BNhapKho.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BNhapKho.TabIndex = 2;
            this.BNhapKho.Text = "Nhập Kho";
            // 
            // BXuatKho
            // 
            this.BXuatKho.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BXuatKho.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BXuatKho.Location = new System.Drawing.Point(253, 427);
            this.BXuatKho.Name = "BXuatKho";
            this.BXuatKho.Size = new System.Drawing.Size(75, 23);
            this.BXuatKho.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BXuatKho.TabIndex = 3;
            this.BXuatKho.Text = "Xuất Kho";
            // 
            // BHieuChinh
            // 
            this.BHieuChinh.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.BHieuChinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BHieuChinh.Location = new System.Drawing.Point(371, 427);
            this.BHieuChinh.Name = "BHieuChinh";
            this.BHieuChinh.Size = new System.Drawing.Size(75, 23);
            this.BHieuChinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BHieuChinh.TabIndex = 4;
            this.BHieuChinh.Text = "Hiệu Chỉnh";
            // 
            // Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 480);
            this.Controls.Add(this.BHieuChinh);
            this.Controls.Add(this.BXuatKho);
            this.Controls.Add(this.BNhapKho);
            this.Controls.Add(this.BThemMoi);
            this.Controls.Add(this.dataGridViewX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Kho";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<font color=\"#000000\">Kho</font>";
            this.Load += new System.EventHandler(this.Kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private DevComponents.DotNetBar.ButtonX BThemMoi;
        private DevComponents.DotNetBar.ButtonX BNhapKho;
        private DevComponents.DotNetBar.ButtonX BXuatKho;
        private DevComponents.DotNetBar.ButtonX BHieuChinh;
    }
}