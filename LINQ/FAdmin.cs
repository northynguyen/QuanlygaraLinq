using LINQ.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class FAdmin : Form
    {
      
        public FAdmin(string TK)
        {
            InitializeComponent();
            lblTenNguoiDung.Text = TK;
           
        }
        private void lblTenNguoiDung_Click(object sender, EventArgs e)
        {

        }


        private void FNguoiDung_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage kh = new TabPage("Khách Hàng");
            FKhachHangLinQ myForm = new FKhachHangLinQ();
            myForm.FormBorderStyle = FormBorderStyle.None;           
            AddTab(kh, myForm);       
        }

        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage pt = new TabPage("Phiếu Thu");
            FPhieuThuLinQ myForm = new FPhieuThuLinQ();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(pt, myForm);
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage hd = new TabPage("Hợp Đồng");
            FKhachHangLinQ myForm = new FKhachHangLinQ();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(hd, myForm);
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage cthd = new TabPage("Chi Tiết Hợp Đồng");
            FChiTietHopDongLINQ myForm = new FChiTietHopDongLINQ();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(cthd, myForm);
        }

        private void côngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage cv = new TabPage("Công Việc");
            FCongViecLinQ myForm = new FCongViecLinQ();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(cv, myForm);
        }

        private void thợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage t = new TabPage("Thợ");
            FThoLinQ myForm = new FThoLinQ();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(t, myForm);
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void AddTab(TabPage tp, Form a)
        {
            tabControl.SelectedTab = tp;
            foreach (TabPage temp in tabControl.TabPages)
            {
                if (temp.Text == tp.Text)
                    return;
            }
            tabControl.TabPages.Add(tp);          
            a.TopLevel = false;
            tp.Controls.Clear();
            tp.Controls.Add(a);
            a.Show();
        }

        private void hahahahToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmThongTin_Click(object sender, EventArgs e)
        {
            FTinhNoLinQ myForm = new FTinhNoLinQ();
            myForm.ShowDialog();
        }

        private void tổngHợpPhiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabPage hdcd = new TabPage("Hợp Đồng Chưa Duyệt");
            FHopDongChuaDuyet myForm = new FHopDongChuaDuyet();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(hdcd, myForm);
        }

        private void ptb_Thoat_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == null)
                return;
            tabControl.SelectedTab.Dispose();
        }

        private void menuHopDongChuaDuyet_Click(object sender, EventArgs e)
        {

            TabPage rptl = new TabPage("Report tính lương");
            FLUONG myForm = new FLUONG();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(rptl, myForm);
        }

        private void menuHopDongChuaDuyet_Click_1(object sender, EventArgs e)
        {
            ReportDoanhThu myForm = new ReportDoanhThu();
            myForm.ShowDialog();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ReportHopDong myForm = new ReportHopDong();
            myForm.ShowDialog();
        }

        private void HợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage hdcd = new TabPage("Hợp Đồng");
            FHopDongLINQ myForm = new FHopDongLINQ();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(hdcd, myForm);
        }
    }
}
