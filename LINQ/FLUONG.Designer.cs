namespace LINQ
{
    partial class FLUONG
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maThoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUONG2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLGaraDataset = new LINQ.QLGaraDataset();
            this.lUONG2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lUONG2TableAdapter = new LINQ.QLGaraDatasetTableAdapters.LUONG2TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONG2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONG2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThoDataGridViewTextBoxColumn,
            this.tenThoDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lUONG2BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(40, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(607, 643);
            this.dataGridView1.TabIndex = 0;
            // 
            // maThoDataGridViewTextBoxColumn
            // 
            this.maThoDataGridViewTextBoxColumn.DataPropertyName = "MaTho";
            this.maThoDataGridViewTextBoxColumn.HeaderText = "MaTho";
            this.maThoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maThoDataGridViewTextBoxColumn.Name = "maThoDataGridViewTextBoxColumn";
            this.maThoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenThoDataGridViewTextBoxColumn
            // 
            this.tenThoDataGridViewTextBoxColumn.DataPropertyName = "TenTho";
            this.tenThoDataGridViewTextBoxColumn.HeaderText = "TenTho";
            this.tenThoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenThoDataGridViewTextBoxColumn.Name = "tenThoDataGridViewTextBoxColumn";
            this.tenThoDataGridViewTextBoxColumn.Width = 150;
            // 
            // luongDataGridViewTextBoxColumn
            // 
            this.luongDataGridViewTextBoxColumn.DataPropertyName = "luong";
            this.luongDataGridViewTextBoxColumn.HeaderText = "luong";
            this.luongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.luongDataGridViewTextBoxColumn.Name = "luongDataGridViewTextBoxColumn";
            this.luongDataGridViewTextBoxColumn.ReadOnly = true;
            this.luongDataGridViewTextBoxColumn.Width = 150;
            // 
            // lUONG2BindingSource1
            // 
            this.lUONG2BindingSource1.DataMember = "LUONG2";
            this.lUONG2BindingSource1.DataSource = this.qLGaraDataset;
            // 
            // qLGaraDataset
            // 
            this.qLGaraDataset.DataSetName = "QLGaraDataset";
            this.qLGaraDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lUONG2BindingSource
            // 
            this.lUONG2BindingSource.DataMember = "LUONG2";
            this.lUONG2BindingSource.DataSource = this.qLGaraDataset;
            // 
            // lUONG2TableAdapter
            // 
            this.lUONG2TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "XUẤT REPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FLUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 816);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FLUONG";
            this.Text = "FLUONG";
            this.Load += new System.EventHandler(this.FLUONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONG2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGaraDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONG2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLGaraDataset qLGaraDataset;
        private System.Windows.Forms.BindingSource lUONG2BindingSource;
        private QLGaraDatasetTableAdapters.LUONG2TableAdapter lUONG2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource lUONG2BindingSource1;
    }
}