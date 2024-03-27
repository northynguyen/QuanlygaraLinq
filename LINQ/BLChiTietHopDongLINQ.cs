using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class BLChiTietHopDongLINQ
    {
        public System.Data.Linq.Table<CHITIET_HD> LayChiTietHD()
        {
            QLGaraDataContext cthd = new QLGaraDataContext();
            return cthd.CHITIET_HDs;
        }
        public bool ThemChiTietHD(int SoHD, string MaCV, int TriGiaCV, int MaTho, int KhoanTho, ref string err)
        {
            QLGaraDataContext ctHD = new QLGaraDataContext();
            CHITIET_HD cthd = new CHITIET_HD();
            cthd.SoHD = SoHD; ;
            cthd.MaCV = MaCV;
            cthd.TriGiaCV = TriGiaCV;
            cthd.MaTho = MaTho;
            cthd.KhoanTho = KhoanTho;
            ctHD.CHITIET_HDs.InsertOnSubmit(cthd);
            ctHD.CHITIET_HDs.Context.SubmitChanges();
            return true;
        }
        public bool XoaChiTietHD(ref string err, int SoHD)
        {
            QLGaraDataContext ctHD = new QLGaraDataContext(); var hdQuery = from cthd in ctHD.CHITIET_HDs
                                                                            where cthd.SoHD == SoHD
                                                                            select cthd;
            ctHD.CHITIET_HDs.DeleteAllOnSubmit(hdQuery);
            ctHD.SubmitChanges();
            return true;
        }
        public bool CapNhatChiTietHD(int SoHD, string MaCV, int TriGiaCV, int MaTho, int KhoanTho, ref string err)
        {
            QLGaraDataContext ctHD = new QLGaraDataContext();
            var cthdQuery = (from cthd in ctHD.CHITIET_HDs
                             where cthd.SoHD == SoHD
                             select cthd).SingleOrDefault();
            if (cthdQuery != null)
            {
                cthdQuery.MaCV = MaCV;
                cthdQuery.TriGiaCV = TriGiaCV;
                cthdQuery.MaTho = MaTho;
                cthdQuery.KhoanTho = KhoanTho;
                ctHD.SubmitChanges();
            }
            return true;
        }
        public CHITIET_HD TimChiTietHD(int SoHD, ref string err)
        {
            QLGaraDataContext gr = new QLGaraDataContext();
            var cthdQuery = from cthd in gr.CHITIET_HDs
                            where cthd.SoHD == SoHD
                            select cthd;
            if (cthdQuery != null)
                return cthdQuery.SingleOrDefault();
            else
                return null;
        }
        public string[] TimThongTinChiTietHD(string SoHD, ref string err)
        {
            string[] strings = new string[4];
            QLGaraDataContext gr = new QLGaraDataContext();
            int sohd = Convert.ToInt32(SoHD);
            var hdQuery = (from hd in gr.CHITIET_HDs
                           where hd.SoHD == sohd
                           select hd).SingleOrDefault();
            strings[0] = hdQuery.MaCV.ToString();
            strings[1] = hdQuery.TriGiaCV.ToString();
            strings[2] = hdQuery.MaTho.ToString();
            strings[3] = hdQuery.KhoanTho.ToString();

            return strings;
        }
    }
}
