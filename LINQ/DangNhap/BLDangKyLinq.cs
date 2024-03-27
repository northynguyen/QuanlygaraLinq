using LINQ;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    internal class BLDangKyLinq
    {
        public bool ThemNguoiDung(string hoVaTen, string diaChi, string dienThoai, string TK, string MK)
        {
            QLGaraDataContext gr = new QLGaraDataContext();
                        var maxMaKH = gr.KHACHHANGs.Max(ma => ma.MaKH);
            NGUOIDUNG nd = new NGUOIDUNG();
            
            nd.TenNguoiDung = TK;
            nd.MatKhau = MK;
            nd.MaKH= maxMaKH+1;             
            

            KHACHHANG kh = new KHACHHANG();
            kh.TenKH = hoVaTen;
            kh.DiaChi = diaChi;
            kh.DienThoai = dienThoai;
            kh.MaKH = maxMaKH+1;
            gr.NGUOIDUNGs.InsertOnSubmit(nd);
            gr.KHACHHANGs.InsertOnSubmit(kh);
            gr.NGUOIDUNGs.Context.SubmitChanges();
            gr.KHACHHANGs.Context.SubmitChanges();
            return true;
        }
    }
}
