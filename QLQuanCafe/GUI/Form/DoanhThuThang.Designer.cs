namespace QLQuanCafe.GUI.Form
{
    partial class DoanhThuThang
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listBillTodayBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.coffeemanagementDataSet4 = new QLQuanCafe.coffeemanagementDataSet4();
            this.donvitinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donvitinhTableAdapter = new QLQuanCafe.coffeemanagementDataSet4TableAdapters.donvitinhTableAdapter();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoadonTableAdapter = new QLQuanCafe.coffeemanagementDataSet4TableAdapters.hoadonTableAdapter();
            this.listBillTodayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homePageBllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBillTodayBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeemanagementDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donvitinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBillTodayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePageBllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.ForeColor = System.Drawing.Color.Black;
            reportDataSource1.Name = "DSHOADON";
            reportDataSource1.Value = this.hoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLQuanCafe.Report.DS HOADON.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(625, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // coffeemanagementDataSet4
            // 
            this.coffeemanagementDataSet4.DataSetName = "coffeemanagementDataSet4";
            this.coffeemanagementDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donvitinhBindingSource
            // 
            this.donvitinhBindingSource.DataMember = "donvitinh";
            this.donvitinhBindingSource.DataSource = this.coffeemanagementDataSet4;
            // 
            // donvitinhTableAdapter
            // 
            this.donvitinhTableAdapter.ClearBeforeFill = true;
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.coffeemanagementDataSet4;
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // listBillTodayBindingSource
            // 
            this.listBillTodayBindingSource.DataMember = "ListBillToday";
            this.listBillTodayBindingSource.DataSource = this.homePageBllBindingSource;
            // 
            // homePageBllBindingSource
            // 
            this.homePageBllBindingSource.DataSource = typeof(QLQuanCafe.BLL.HomePageBll);
            // 
            // DoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DoanhThuThang";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.DoanhThuThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBillTodayBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeemanagementDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donvitinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBillTodayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePageBllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listBillTodayBindingSource1;
        private coffeemanagementDataSet4 coffeemanagementDataSet4;
        private System.Windows.Forms.BindingSource donvitinhBindingSource;
        private coffeemanagementDataSet4TableAdapters.donvitinhTableAdapter donvitinhTableAdapter;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private coffeemanagementDataSet4TableAdapters.hoadonTableAdapter hoadonTableAdapter;
        private System.Windows.Forms.BindingSource listBillTodayBindingSource;
        private System.Windows.Forms.BindingSource homePageBllBindingSource;
    }
}