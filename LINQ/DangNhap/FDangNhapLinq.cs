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
    public partial class FDangNhapLinq : Form
    {
        bool dangKy=false;
        bool IsLogin = false;
        public string Ten;
        string err;
        BLDangNhapLinq dn=new BLDangNhapLinq();
        
        public FDangNhapLinq()
        {
            InitializeComponent();
            
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_dangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangKy = true;
            txt_tenDangNhap.Focus();
            if (dangKy)
            {
                if (rb_admin.Checked)
                {
                    MessageBox.Show("Chỉ người sử dụng mới được đăng ký tài khoản", "Thông báo!");
                }
                else
                {
                    FDangKyLinq dk = new FDangKyLinq();
                    dk.ShowDialog();
                }
            }
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            dangKy = false;
            Ten = txt_tenDangNhap.Text.ToString();
            if (rb_admin.Checked)
            {
                if (dn.LayAdmin(txt_tenDangNhap.Text, txt_matKhau.Text))
                {
                    this.Hide();
                    IsLogin = true;
                    //FAdminENTITY admin = new FAdminENTITY(Ten);
                    //admin.ShowDialog();
                    FAdmin admin= new FAdmin(Ten);
                    admin.ShowDialog();
                    this.Show();
                }
                else lbl_messenger2.Text = "Tên tài khoản hoặc mật khẩu không chính xác!";
            } 
            else
            {
                if (dn.LayNguoiDung(txt_tenDangNhap.Text, txt_matKhau.Text))
                {
                    this.Hide();
                    IsLogin = true;
                    BLDangNhapLinq dn = new BLDangNhapLinq();
                    string ma = dn.TimTK(ref err, true, Ten);
                    FNguoiDung nd = new FNguoiDung(Ten,ma);
                    nd.ShowDialog();
                    this.Show();

                }
                else lbl_messenger2.Text = "Tên tài khoản hoặc mật khẩu không chính xác!";
            }
        }

        private void lbl_quenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BLDangNhapLinq dn = new BLDangNhapLinq();
            if (dn.LayMatKhau(txt_tenDangNhap.Text) != null)
            {
                lbl_messenger2.Text =dn.LayMatKhau(txt_tenDangNhap.Text);
            }            
            else
            {
                lbl_messenger2.Text = dn.LayMatKhau(txt_tenDangNhap.Text);
            }              
        }
        private void txt_tenDangNhap_TextChanged(object sender, EventArgs e)
        {
            lbl_messenger2.Text = "";
        }
    }
}
