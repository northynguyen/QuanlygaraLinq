namespace LINQ.DangNhap
{
    partial class ReportHopDong
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
            this.qLGaraDataset = new LINQ.QLGaraDataset();
            this.hOPDONGCHITIETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOPDONG_CHITIETTableAdapter = new LINQ.QLGaraDatasetTableAdapters.HOPDONG_CHITIETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGCHITIETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hOPDONGCHITIETBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LINQ.ReportHopDong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1508, 894);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLGaraDataset
            // 
            this.qLGaraDataset.DataSetName = "QLGaraDataset";
            this.qLGaraDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOPDONGCHITIETBindingSource
            // 
            this.hOPDONGCHITIETBindingSource.DataMember = "HOPDONG_CHITIET";
            this.hOPDONGCHITIETBindingSource.DataSource = this.qLGaraDataset;
            // 
            // hOPDONG_CHITIETTableAdapter
            // 
            this.hOPDONG_CHITIETTableAdapter.ClearBeforeFill = true;
            // 
            // ReportHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 905);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportHopDong";
            this.Text = "ReportHopDong";
            this.Load += new System.EventHandler(this.ReportHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGCHITIETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLGaraDataset qLGaraDataset;
        private System.Windows.Forms.BindingSource hOPDONGCHITIETBindingSource;
        private QLGaraDatasetTableAdapters.HOPDONG_CHITIETTableAdapter hOPDONG_CHITIETTableAdapter;
    }
}