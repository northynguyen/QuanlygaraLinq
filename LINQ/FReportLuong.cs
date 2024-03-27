using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class FReportLuong : Form
    {
        public FReportLuong()
        {
            InitializeComponent();
        }

        private void FReportLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLGaraDataset1.LUONG2' table. You can move, or remove it, as needed.
            this.lUONG2TableAdapter.Fill(this.qLGaraDataset1.LUONG2);
            // TODO: This line of code loads data into the 'qLGaraDataset.LUONG' table. You can move, or remove it, as needed.
            this.lUONGTableAdapter.Fill(this.qLGaraDataset.LUONG);

            this.reportViewer1.RefreshReport();

            
        }
    }
}
