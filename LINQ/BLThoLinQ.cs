using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class BLThoLinQ
    {
        public System.Data.Linq.Table<THO> LayTho()
        {
            DataSet ds = new DataSet();
            QLGaraDataContext qlgr = new QLGaraDataContext();
            return qlgr.THOs;
        }
        public THO TimSoPT(string MaTho, ref string err)
        {
            QLGaraDataContext t = new QLGaraDataContext();
            var TPQuery = from T in t.THOs
                          where T.MaTho == int.Parse(MaTho)
                          select T;
            if (TPQuery != null)
                return TPQuery.SingleOrDefault();
            else
                return null;
        }
        public bool ThemTho(int MaTho,string TenTho, int Nhom , int NhomTruong, ref string err)
        {
            QLGaraDataContext qlt = new QLGaraDataContext();
            THO t = new THO();
            t.MaTho = MaTho;
            t.TenTho = TenTho;
            t.Nhom = Nhom;
            t.NhomTruong = NhomTruong;
            
            qlt.THOs.InsertOnSubmit(t);
            qlt.THOs.Context.SubmitChanges();

            return true;

        }
        public bool XoaT(ref string err, int MaTho)
        {
            QLGaraDataContext qlt = new QLGaraDataContext();
            var tpQuery = from T in qlt.THOs
                          where T.MaTho == MaTho
                          select T;
            qlt.THOs.DeleteAllOnSubmit(tpQuery);
            qlt.SubmitChanges();
            return true;
        }
        public bool CapNhatT(int MaTho, string TenTho, int Nhom, int NhomTruong, ref string err)
        {
            QLGaraDataContext qlt = new QLGaraDataContext();
            var tpQuery = (from T in qlt.THOs
                           where T.MaTho == MaTho
                           select T).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.MaTho = MaTho;
                tpQuery.TenTho = TenTho;
                tpQuery.Nhom = Nhom;
                tpQuery.NhomTruong= NhomTruong;
                qlt.SubmitChanges();
            }
            return true;
        }
        public string[] TimDanhSachThoRanh(ref string err)
        {
            string[] DanhSachThoRanh = new string[50];
            QLGaraDataContext t = new QLGaraDataContext();
            var result = from tho in t.THOs
                         join ngay in (from hd in t.HOPDONGs
                                       join ct in t.CHITIET_HDs on hd.SoHD equals ct.SoHD
                                       group ct by ct.MaTho into grp
                                       where grp.Max(ct => ct.HOPDONG.NgayGiaoDK) < DateTime.Now.Date
                                       select new { MaTho = grp.Key, NgayDK = grp.Max(ct => ct.HOPDONG.NgayGiaoDK) })
                         on tho.MaTho equals ngay.MaTho
                         select new { tho.MaTho, tho.TenTho };
            int i = 0;
            bool check = true;
            foreach (var a in result)
            {
                DanhSachThoRanh[i] = a.MaTho.ToString();
                i++;
                DanhSachThoRanh[i] = a.TenTho.ToString();
                i++;                
            }
            return DanhSachThoRanh;
        }
    }
}
