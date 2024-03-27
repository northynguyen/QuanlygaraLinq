using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class BLHopDongLINQ
    {
        public System.Data.Linq.Table<HOPDONG> LayHopDong()
        {
            QLGaraDataContext cthd = new QLGaraDataContext();
            return cthd.HOPDONGs;
        }
        public List<HOPDONG> Lay1MaKH(string makh)
        {
            QLGaraDataContext qlgr = new QLGaraDataContext();
           
            var TPQuery = (from p in qlgr.HOPDONGs
                           where p.MaKH == int.Parse(makh)
                           select p).ToList();
            
            return TPQuery;
        }
        public List<HOPDONG> Lay1HopDong(string sohd)
        {
            QLGaraDataContext qlgr = new QLGaraDataContext();
            var TPQuery = (from p in qlgr.HOPDONGs
                           where p.SoHD == int.Parse(sohd)
                           select p).ToList();

            return TPQuery;
        }
        public bool ThemHopDong(int SoHD, DateTime NgayHD, int MaKH, string SoXe, int TriGiaHD, DateTime NgayGiao, DateTime NgayThu, ref string err)
        {
            QLGaraDataContext ctHD = new QLGaraDataContext();
            HOPDONG cthd = new HOPDONG();
            cthd.SoHD = SoHD; ;
            cthd.NgayHD = NgayHD;
            cthd.MaKH = MaKH;
            cthd.SoXe = SoXe;
            cthd.TriGiaHD = TriGiaHD;
            cthd.NgayGiaoDK = NgayGiao;
            cthd.NgayNgThu = NgayThu;
            ctHD.HOPDONGs.InsertOnSubmit(cthd);
            ctHD.HOPDONGs.Context.SubmitChanges();
            return true;
        }
        public bool XoaHopDong(ref string err, int SoHD)
        {
            QLGaraDataContext hd = new QLGaraDataContext(); var hdQuery = from hD in hd.HOPDONGs
                                                                          where hD.SoHD == SoHD
                                                                          select hD;
            hd.HOPDONGs.DeleteAllOnSubmit(hdQuery);
            hd.SubmitChanges();
            return true;
        }
        public bool CapNhatHopDong(int SoHD, DateTime NgayHD, int MaKH, string SoXe, int TriGiaHD, DateTime NgayGiao, DateTime NgayThu, ref string err)
        {
            QLGaraDataContext HD = new QLGaraDataContext();
            var hdQuery = (from hd in HD.HOPDONGs
                           where hd.SoHD == SoHD
                           select hd).SingleOrDefault();
            if (hdQuery != null)
            {
                hdQuery.NgayHD = NgayHD;
                hdQuery.MaKH = MaKH;
                hdQuery.SoXe = SoXe;
                hdQuery.TriGiaHD = TriGiaHD;
                hdQuery.NgayGiaoDK = NgayGiao;
                hdQuery.NgayNgThu = NgayThu;
                HD.SubmitChanges();
            }
            return true;
        }
        public HOPDONG TimHopDong(int SoHD, ref string err)
        {
            QLGaraDataContext gr = new QLGaraDataContext();
            var hdQuery = from hd in gr.HOPDONGs
                          where hd.SoHD == SoHD
                          select hd;
            if (hdQuery != null)
                return hdQuery.SingleOrDefault();
            else
                return null;
        }
        public int TimSoHDLonNhat(ref string err)
        {
            QLGaraDataContext gr = new QLGaraDataContext();
            var maxSoHD = gr.HOPDONGs.Max(ma => ma.SoHD);
            return Convert.ToInt32(maxSoHD.ToString());
        }
        public string[] TimTenThongTinHD(string SoHD, ref string err)
        {
            string[] strings = new string[3];
            QLGaraDataContext gr = new QLGaraDataContext();
            int sohd = Convert.ToInt32(SoHD);
            var hdQuery = (from hd in gr.HOPDONGs
                          where hd.SoHD == sohd
                          select hd).SingleOrDefault();
            strings[0] = hdQuery.NgayHD.ToString();
            strings[1] = hdQuery.SoXe.ToString();
            strings[2] = hdQuery.NgayGiaoDK.ToString();

            return strings;
        }
        public string[] TimThongTinHD(string SoHD, ref string err)
        {
            string[] strings = new string[3];
            QLGaraDataContext gr = new QLGaraDataContext();
            int sohd = Convert.ToInt32(SoHD);
            var hdQuery = (from hd in gr.HOPDONGs
                           where hd.SoHD == sohd
                           select hd).SingleOrDefault();
            strings[0] = hdQuery.MaKH.ToString();
            strings[1] = hdQuery.SoXe.ToString();
            strings[2] = hdQuery.TriGiaHD.ToString();

            return strings;
        }

    }
}
