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
    public partial class ThongBao : Form
    {
        public int MaKH;public int[] soHD = new int[50];
        public string TenKH;
        string err;
        public ThongBao(string Ten,string MK)
        {
            InitializeComponent();
            this.MaKH = int.Parse(MK);
            this.TenKH = Ten;
        }
        public void ThayDoi(HOPDONG temp,int id)
        {
            BLPhieuThuLinQ pt = new BLPhieuThuLinQ();
            Dictionary<int, int> dic = pt.TinhTien(ref err);
            dv_thongbao.Rows.Add();
            int index = temp.SoHD;
            dv_thongbao.Rows[id].Cells[0].Value = index.ToString();
            int tiendatra = 0;
            try
            {
                tiendatra = dic[index];
                if (tiendatra >= temp.TriGiaHD)
                {

                    dv_thongbao.Rows[id].Cells[1].Value = "Hoàn thành";
                    dv_thongbao.Rows[id].Cells[2].Value = "0";
                    dv_thongbao.Rows[id].Cells[3].Value = "0";
                    dv_thongbao.Rows[id].Cells[4].Value = "0";
                }
                else
                {
                    dv_thongbao.Rows[id].Cells[1].Value = "Chưa hoàn thành";

                    TimeSpan time = DateTime.Parse(temp.NgayNgThu.ToString()) - DateTime.Now;
                    dv_thongbao.Rows[id].Cells[2].Value = time.Days.ToString();
                    int temp1 = Math.Abs(int.Parse(time.Days.ToString()));

                    if (temp1 < 30)
                    {
                        dv_thongbao.Rows[id].Cells[3].Value = "0";
                        dv_thongbao.Rows[id].Cells[4].Value = (temp.TriGiaHD - tiendatra).ToString();
                    }
                    else
                    {
                        dv_thongbao.Rows[id].Cells[3].Value = (double.Parse(temp.TriGiaHD.ToString()) * (0.02)).ToString();
                        if (temp1 > 60)
                            this.lbl_thongbao.Text = "KHÁCH HÀNG ĐÃ QUÁ HẠN NỘP PHẠT MỘT SỐ HỢP ĐỒNG";
                        dv_thongbao.Rows[id].Cells[4].Value = (double.Parse(temp.TriGiaHD.ToString()) - tiendatra + (double.Parse(temp.TriGiaHD.ToString()) * (0.02))).ToString();

                    }




                }
            }    
            catch
            {
                dv_thongbao.Rows[id].Cells[1].Value = "Chưa có phiếu thu";
            }
             
        }
          


            
        
        private void ThongBao_Load(object sender, EventArgs e)
        {
           
            BLHopDongLINQ dbhd = new BLHopDongLINQ();
            var data = dbhd.LayHopDong().ToList();
            int count = 0;
            for (int i = 0; i < data.Count(); i++)
            {
                if (data[i].MaKH.ToString() == MaKH.ToString())
                {
                    soHD[count] = data[i].SoHD;
                    count++;
                }
            }
            int j = 0;
            while (soHD[j]!=0)
            {
                HOPDONG temp = new HOPDONG();
                temp= dbhd.TimHopDong(soHD[j], ref err);
                
                ThayDoi(temp, j);
                j++;
            }    
          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
