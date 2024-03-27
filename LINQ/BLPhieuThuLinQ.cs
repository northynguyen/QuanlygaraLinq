using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class BLPhieuThuLinQ
    {
        public System.Data.Linq.Table<PHIEUTHU> LayPhieuThu()
        {
            DataSet ds = new DataSet();
            QLGaraDataContext qlgr = new QLGaraDataContext();
            return qlgr.PHIEUTHUs;
        }
        public List<PHIEUTHU> Lay1SoHD(string soHD)
        {
            QLGaraDataContext qlgr = new QLGaraDataContext();

            var TPQuery = (from p in qlgr.PHIEUTHUs
                           where p.SoHD == int.Parse(soHD) 
                               select p).ToList();

            return TPQuery;
        }
        public List<PHIEUTHU> Lay1Mapt(string mapt)
        {
            QLGaraDataContext qlgr = new QLGaraDataContext();

            var TPQuery = (from p in qlgr.PHIEUTHUs
                           where p.SoPT == (mapt)
                           select p).ToList();

            return TPQuery;
        }
        public List<PHIEUTHU> Lay1MaKH(string makh)
        {
            QLGaraDataContext qlgr = new QLGaraDataContext();

            var TPQuery = (from p in qlgr.PHIEUTHUs
                           where p.MaKH== int.Parse(makh)
                           select p).ToList();

            return TPQuery;
        }
        public PHIEUTHU TimSoPT(string soPT, ref string err)
        {
            QLGaraDataContext pt = new QLGaraDataContext();
            var TPQuery = from PT in pt.PHIEUTHUs
                          where PT.SoPT == soPT
                          select PT;
            if (TPQuery != null)
                return TPQuery.SingleOrDefault();
            else
                return null;
        }
        public Dictionary<int,int> TinhTien( ref string err)
        {
            QLGaraDataContext pt = new QLGaraDataContext();
            var TPQuery =( from PT in pt.PHIEUTHUs
                          group PT by PT.SoHD into soHDgroup
                          select new
                          {
                              SoHD = soHDgroup.Key,
                              total= soHDgroup.Sum(p => p.SoTienThu)
                          }).ToDictionary(x=>x.SoHD,x=>x.total.Value);
            if (TPQuery != null)
                return TPQuery;
            else
                return null;
        }
        public bool ThemPT(string SoPT,DateTime NgayLap, int SoHD, int SoTienThu,int MaKH,string HoTen, ref string err)
        {
            QLGaraDataContext qlpt = new QLGaraDataContext();
            PHIEUTHU pt = new PHIEUTHU();
            pt.SoPT= SoPT;
            pt.NgayLapPT = NgayLap;
            pt.SoHD = SoHD;
            pt.MaKH = MaKH;
            pt.HoTen = HoTen;
            pt.SoTienThu = SoTienThu;
            
            qlpt.PHIEUTHUs.InsertOnSubmit(pt);
            qlpt.PHIEUTHUs.Context.SubmitChanges();
            
            return true;

        }
        public bool XoaPT(ref string err, string soPT)
        {
            QLGaraDataContext qlpt = new QLGaraDataContext();
            var tpQuery = from PT in qlpt.PHIEUTHUs
                          where PT.SoPT == soPT
                          select PT;
            qlpt.PHIEUTHUs.DeleteAllOnSubmit(tpQuery);
            qlpt.SubmitChanges();
            return true;
        }
        public bool CapNhatPT(string SoPT, DateTime NgayLapPT, int SoHD, int MaKH, string HoTen, int SoTienThu, ref string err)
        {
            QLGaraDataContext qlpt = new QLGaraDataContext();
            var tpQuery =( from PT in qlpt.PHIEUTHUs
                          where PT.SoPT == SoPT
                          select PT).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.SoPT = SoPT;
                tpQuery.NgayLapPT = NgayLapPT;
                tpQuery.SoHD = SoHD;
                tpQuery.MaKH = MaKH;
                tpQuery.HoTen = HoTen;
                tpQuery.SoTienThu = SoTienThu;
                qlpt.SubmitChanges();
            }
            return true;
        }
    }
}
