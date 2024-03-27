using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class BLCongViecLinQ
    {
        public System.Data.Linq.Table<CONGVIEC> LayCongViec()
        {
            QLGaraDataContext gr = new QLGaraDataContext();
            return gr.CONGVIECs;
        }

        public bool XoaCongViec(ref string err, string MaCV)
        {
            QLGaraDataContext gr = new QLGaraDataContext();
            var CVQuery = from CV in gr.CONGVIECs
                          where CV.MaCV == MaCV
                          select CV;
            gr.CONGVIECs.DeleteAllOnSubmit(CVQuery);
            gr.SubmitChanges();
            return true;
        }

        public bool ThemCongViec(string MaCV, string NoiDungCV, ref string err)
        {
            QLGaraDataContext gr = new QLGaraDataContext();
            CONGVIEC CV = new CONGVIEC();
            CV.MaCV = MaCV;
            CV.NoiDungVC = NoiDungCV;
            gr.CONGVIECs.InsertOnSubmit(CV);
            gr.CONGVIECs.Context.SubmitChanges();
            return true;
        }
        public bool CapNhatCongViec(string MaCV, string NoiDungCV, ref string err)
        {
            QLGaraDataContext gr = new QLGaraDataContext();
            var CVQuery = (from KH in gr.CONGVIECs
                           where KH.MaCV == MaCV
                           select KH).SingleOrDefault();
            if (CVQuery != null)
            {
                CVQuery.NoiDungVC = NoiDungCV;
                gr.SubmitChanges();
            }
            return true;
        }
        public CONGVIEC TimKhachHang(string MaCV, ref string err)
        {
            QLGaraDataContext gr = new QLGaraDataContext();
            var CVQuery = from KH in gr.CONGVIECs 
                          where KH.MaCV == MaCV
                          select KH;
            if (CVQuery != null)
                return CVQuery.SingleOrDefault();
            else
                return null;
        }
    }
}
