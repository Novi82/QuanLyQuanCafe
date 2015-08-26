namespace QLQuanCafe.GUI.Form
{
    partial class Nhap
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.coffeemanagementDataSet3 = new QLQuanCafe.coffeemanagementDataSet3();
            this.ctbaocaokhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctbaocaokhoTableAdapter = new QLQuanCafe.coffeemanagementDataSet3TableAdapters.ctbaocaokhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coffeemanagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbaocaokhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.ForeColor = System.Drawing.Color.Black;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ctbaocaokhoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLQuanCafe.Report.Nhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(625, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // coffeemanagementDataSet3
            // 
            this.coffeemanagementDataSet3.DataSetName = "coffeemanagementDataSet3";
            this.coffeemanagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctbaocaokhoBindingSource
            // 
            this.ctbaocaokhoBindingSource.DataMember = "ctbaocaokho";
            this.ctbaocaokhoBindingSource.DataSource = this.coffeemanagementDataSet3;
            // 
            // ctbaocaokhoTableAdapter
            // 
            this.ctbaocaokhoTableAdapter.ClearBeforeFill = true;
            // 
            // Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Nhap";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.Nhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffeemanagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbaocaokhoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private coffeemanagementDataSet3 coffeemanagementDataSet3;
        private System.Windows.Forms.BindingSource ctbaocaokhoBindingSource;
        private coffeemanagementDataSet3TableAdapters.ctbaocaokhoTableAdapter ctbaocaokhoTableAdapter;
    }
}