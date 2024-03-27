﻿using System;
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
    public partial class FNguoiDung : Form
    {            
        public int MaKH;
        public string TenKH;
        public FNguoiDung(string Ten, string Ma)
        {
            InitializeComponent();
            lblTenNguoiDung.Text = Ten;
            lblMaKH.Text = Ma.ToString();
            MaKH = int.Parse(Ma);
            TenKH = Ten;
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
            TabPage dk = new TabPage("Đăng Ký Sửa Xe");
            FDangKyLich myForm = new FDangKyLich(MaKH);
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(dk, myForm);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabPage ThongBao = new TabPage("Thông báo");
            ThongBao myForm = new ThongBao(this.TenKH,this.MaKH.ToString());
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(ThongBao, myForm);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TabPage hd = new TabPage("Hợp Đồng");
            FHopDongNguoiDung myForm = new FHopDongNguoiDung(TenKH, MaKH);
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(hd, myForm);
        }

        private void ptb_Thoat_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == null)
                return;
            tabControl.SelectedTab.Dispose();
        }
    }
}
