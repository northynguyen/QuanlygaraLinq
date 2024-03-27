using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class BLKhachHangLinQ
    {
        public System.Data.Linq.Table<KHACHHANG> LayKhachHang()
        {
            QLGaraDataContext kh = new QLGaraDataContext();
            return kh.KHACHHANGs;
        }

        public bool XoaKhachHang(ref string err, string MaKH)
        {
            QLGaraDataContext kh = new QLGaraDataContext();
            var TPQuery = from KH in kh.KHACHHANGs
                          where KH.MaKH == Convert.ToInt32(MaKH)
                          select KH;
            kh.KHACHHANGs.DeleteAllOnSubmit(TPQuery);
            kh.SubmitChanges();
            return true;
        }

        public bool ThemKhachHang(string MaKH, string TenKH, string DiaChi, string Sdt, ref string err)
        {
            QLGaraDataContext kh = new QLGaraDataContext();
            KHACHHANG KH = new KHACHHANG();
            KH.MaKH = Convert.ToInt32(MaKH);
            KH.TenKH = TenKH;
            KH.DiaChi = DiaChi;
            KH.DienThoai = Sdt;
            kh.KHACHHANGs.InsertOnSubmit(KH);
            kh.KHACHHANGs.Context.SubmitChanges();
            return true;
        }
        public bool CapNhatKhachHang(string MaKH, string TenKH, string DiaChi, string Sdt, ref string err)
        {
            QLGaraDataContext kh = new QLGaraDataContext();
            var KHQuery = (from KH in kh.KHACHHANGs
                           where KH.MaKH == Convert.ToInt32(MaKH)
                           select KH).SingleOrDefault();
            if (KHQuery != null)
            {
                KHQuery.TenKH = TenKH;
                KHQuery.DiaChi = DiaChi;
                KHQuery.DienThoai = Sdt;
                kh.SubmitChanges();
            }
            return true;
        }
        public KHACHHANG TimKhachHang(string MaKH, ref string err)
        {
            QLGaraDataContext kh = new QLGaraDataContext();
            var TPQuery = from KH in kh.KHACHHANGs
                          where KH.MaKH == int.Parse(MaKH)
                          select KH;
            if (TPQuery != null)
                return TPQuery.SingleOrDefault();
            else
                return null;
        }

    }
}
