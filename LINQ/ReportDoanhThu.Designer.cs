namespace LINQ
{
    partial class ReportDoanhThu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLGaraDataset = new LINQ.QLGaraDataset();
            this.pHIEUTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUTableAdapter = new LINQ.QLGaraDatasetTableAdapters.PHIEUTHUTableAdapter();
            this.pHIEUTHU1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHU1TableAdapter = new LINQ.QLGaraDatasetTableAdapters.PHIEUTHU1TableAdapter();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHU1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pHIEUTHUBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.pHIEUTHU1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LINQ.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(926, 796);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLGaraDataset
            // 
            this.qLGaraDataset.DataSetName = "QLGaraDataset";
            this.qLGaraDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUTHUBindingSource
            // 
            this.pHIEUTHUBindingSource.DataMember = "PHIEUTHU";
            this.pHIEUTHUBindingSource.DataSource = this.qLGaraDataset;
            // 
            // pHIEUTHUTableAdapter
            // 
            this.pHIEUTHUTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUTHU1BindingSource
            // 
            this.pHIEUTHU1BindingSource.DataMember = "PHIEUTHU1";
            this.pHIEUTHU1BindingSource.DataSource = this.qLGaraDataset;
            // 
            // pHIEUTHU1TableAdapter
            // 
            this.pHIEUTHU1TableAdapter.ClearBeforeFill = true;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(64, 29);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(172, 31);
            this.txtTim.TabIndex = 6;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(266, 29);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(129, 34);
            this.btn_Tim.TabIndex = 5;
            this.btn_Tim.Text = "Tìm PT";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // ReportDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 896);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportDoanhThu";
            this.Text = "ReportDoanhThu";
            this.Load += new System.EventHandler(this.ReportDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHU1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLGaraDataset qLGaraDataset;
        private System.Windows.Forms.BindingSource pHIEUTHUBindingSource;
        private QLGaraDatasetTableAdapters.PHIEUTHUTableAdapter pHIEUTHUTableAdapter;
        private System.Windows.Forms.BindingSource pHIEUTHU1BindingSource;
        private QLGaraDatasetTableAdapters.PHIEUTHU1TableAdapter pHIEUTHU1TableAdapter;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btn_Tim;
    }
}