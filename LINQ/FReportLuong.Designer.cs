namespace LINQ
{
    partial class FReportLuong
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
            this.lUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLGaraDataset = new LINQ.QLGaraDataset();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lUONGTableAdapter = new LINQ.QLGaraDatasetTableAdapters.LUONGTableAdapter();
            this.LUONG1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LUONG2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLGaraDataset1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLGaraDataset1 = new LINQ.QLGaraDataset();
            this.lUONG2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lUONG2TableAdapter = new LINQ.QLGaraDatasetTableAdapters.LUONG2TableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUONG1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUONG2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONG2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lUONGBindingSource
            // 
            this.lUONGBindingSource.DataMember = "LUONG";
            this.lUONGBindingSource.DataSource = this.qLGaraDataset;
            // 
            // qLGaraDataset
            // 
            this.qLGaraDataset.DataSetName = "QLGaraDataset";
            this.qLGaraDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lUONGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LINQ.ReportLuong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 137);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(975, 689);
            this.reportViewer1.TabIndex = 0;
            // 
            // lUONGTableAdapter
            // 
            this.lUONGTableAdapter.ClearBeforeFill = true;
            // 
            // LUONG1BindingSource
            // 
            this.LUONG1BindingSource.DataMember = "LUONG1";
            this.LUONG1BindingSource.DataSource = this.qLGaraDataset;
            // 
            // LUONG2BindingSource
            // 
            this.LUONG2BindingSource.DataMember = "LUONG2";
            this.LUONG2BindingSource.DataSource = this.qLGaraDataset;
            // 
            // qLGaraDataset1BindingSource
            // 
            this.qLGaraDataset1BindingSource.DataSource = this.qLGaraDataset1;
            this.qLGaraDataset1BindingSource.Position = 0;
            // 
            // qLGaraDataset1
            // 
            this.qLGaraDataset1.DataSetName = "QLGaraDataset";
            this.qLGaraDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lUONG2BindingSource1
            // 
            this.lUONG2BindingSource1.DataMember = "LUONG2";
            this.lUONG2BindingSource1.DataSource = this.qLGaraDataset1BindingSource;
            // 
            // lUONG2TableAdapter
            // 
            this.lUONG2TableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã thợ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FReportLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 838);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FReportLuong";
            this.Text = "FReportLuong";
            this.Load += new System.EventHandler(this.FReportLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUONG1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUONG2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONG2BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLGaraDataset qLGaraDataset;
        private System.Windows.Forms.BindingSource lUONGBindingSource;
        private QLGaraDatasetTableAdapters.LUONGTableAdapter lUONGTableAdapter;
        private System.Windows.Forms.BindingSource LUONG1BindingSource;
        private System.Windows.Forms.BindingSource LUONG2BindingSource;
        private System.Windows.Forms.BindingSource qLGaraDataset1BindingSource;
        private QLGaraDataset qLGaraDataset1;
        private System.Windows.Forms.BindingSource lUONG2BindingSource1;
        private QLGaraDatasetTableAdapters.LUONG2TableAdapter lUONG2TableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}