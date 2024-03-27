
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
    public partial class FPhieuThuLinQ : Form
    {
        string err;
        bool Them;
        BLPhieuThuLinQ dbpt = new BLPhieuThuLinQ();
        public FPhieuThuLinQ()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }
        private void LoadData()
        {
            try
            {
                var data = dbpt.LayPhieuThu()
                .Select(pt => new { pt.SoPT, pt.NgayLapPT, pt.SoHD, pt.MaKH, pt.HoTen, pt.SoTienThu })
                .ToList();
                dgvPhieuThu.DataSource = data;
                this.txt_MaPT.Enabled = false;
                this.txt_TenKH.Enabled = false;
                this.txt_MaHD.Enabled = false;
                this.txt_MaKH.Enabled = false;
                this.dt_LapPhieu.Enabled = false;
                this.txt_Tien.Enabled = false;
                this.txtSoPT.Enabled = false;
                this.txtHoTen.Enabled = false;
                this.txtMaHD.Enabled = false;
                this.txtMaKH.Enabled = false;
                this.txtDate.Enabled = false;
                this.txtTien.Enabled = false;

                dgvPhieuThu_CellClick(null, null);
            }
            catch {
                MessageBox.Show("Không lấy được nội dung trong table Phiếu thu. Lỗi rồi!!!");
            }
            

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FPhieuThuLinQ.ActiveForm.Close();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvPhieuThu.CurrentCell.RowIndex;
                this.txt_MaPT.Text = dgvPhieuThu.Rows[r].Cells[0].Value.ToString();
                this.dt_LapPhieu.Text = dgvPhieuThu.Rows[r].Cells[1].Value.ToString();
                this.txt_MaHD.Text = dgvPhieuThu.Rows[r].Cells[2].Value.ToString();
                this.txt_MaKH.Text = dgvPhieuThu.Rows[r].Cells[3].Value.ToString();
                this.txt_TenKH.Text = dgvPhieuThu.Rows[r].Cells[4].Value.ToString();
                this.txt_Tien.Text = dgvPhieuThu.Rows[r].Cells[5].Value.ToString();
            }
            catch {
                
            }
            
        }

        private void FPhieuThuLinQ_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {

            var data = dbpt.Lay1Mapt(txt_tim.Text)
                    .Select(pt => new { pt.SoPT, pt.NgayLapPT, pt.SoHD, pt.MaKH, pt.HoTen, pt.SoTienThu })
                    .ToList();
            dgvPhieuThu.DataSource = data;
            BLPhieuThuLinQ blpt = new BLPhieuThuLinQ();
                PHIEUTHU a = new PHIEUTHU();
                a = blpt.TimSoPT(txt_tim.Text, ref err);
                if (a != null)
                {
                    this.txtSoPT.Text = a.SoPT;
                    this.txtHoTen.Text = a.HoTen;
                    this.txtMaHD.Text = a.SoHD.ToString();
                    this.txtMaKH.Text = a.MaKH.ToString();
                    this.txtDate.Text = a.NgayLapPT.ToString();
                    this.txtTien.Text = a.SoTienThu.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                    this.txtSoPT.ResetText();
                    this.txtHoTen.ResetText();
                    this.txtMaHD.ResetText();
                    this.txtMaKH.ResetText();
                    this.txtDate.ResetText();
                    this.txtTien.ResetText();
            }
            }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLPhieuThuLinQ pt = new BLPhieuThuLinQ();
                    Dictionary<int, int> dic = pt.TinhTien(ref err);
                    BLHopDongLINQ hd= new BLHopDongLINQ();
                    HOPDONG timhd = hd.TimHopDong(int.Parse(this.txt_MaHD.Text), ref err);
             
                    if (dic[int.Parse(this.txt_MaHD.Text)]>= timhd.TriGiaHD)
                    {
                        MessageBox.Show("Hơp đồng đã được thanh toán đầy đủ, xin kiểm tra lại");
                    }
                    else
                    {
                        BLPhieuThuLinQ dbpt = new BLPhieuThuLinQ();
                        dbpt.ThemPT(this.txt_MaPT.Text, this.dt_LapPhieu.Value, int.Parse(this.txt_MaHD.Text), int.Parse(this.txt_Tien.Text),int.Parse(this.txt_MaKH.Text),this.txt_TenKH.Text, ref err);
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo 
                        MessageBox.Show("Đã thêm xong!");
                    }

                    
                }
                catch
                {
                    MessageBox.Show("Không có hợp đồng này, lỗi rồi");
                }
            }
            else
            {
                try
                {
                    BLPhieuThuLinQ dbpt = new BLPhieuThuLinQ();
                    dbpt.CapNhatPT(this.txt_MaPT.Text, this.dt_LapPhieu.Value, int.Parse(this.txt_MaHD.Text), int.Parse(this.txt_MaKH.Text), this.txt_TenKH.Text, int.Parse(this.txt_Tien.Text), ref err);
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch
                {
                    MessageBox.Show("Không có hợp đồng này, lỗi rồi");
                }
               
            }
            // Đóng kết nối 
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txt_MaPT.Enabled = true;
            this.txt_TenKH.Enabled = true;
            this.txt_MaHD.Enabled = true;
            this.txt_MaKH.Enabled = true;
            this.dt_LapPhieu.Enabled = true;
            this.txt_Tien.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                int r = dgvPhieuThu.CurrentCell.RowIndex;
                string strsoPT =
                dgvPhieuThu.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbpt.XoaPT(ref err, strsoPT);
                    // Cập nhật lại DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvPhieuThu_CellClick(null, null);
            this.txt_MaPT.Enabled = true;
            this.txt_TenKH.Enabled = true;
            this.txt_MaHD.Enabled = true;
            this.txt_MaKH.Enabled = true;
            this.dt_LapPhieu.Enabled = true;
            this.txt_Tien.Enabled = true;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.txt_MaPT.ResetText();
            this.txt_TenKH.ResetText();
            this.txt_MaHD.ResetText();
            this.txt_MaKH.ResetText();
            this.dt_LapPhieu.ResetText();
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            if(cb_Loc.SelectedIndex==0)
            {
                try
                {
                    var data = dbpt.Lay1SoHD(txt_loc.Text)
                    .Select(pt => new { pt.SoPT, pt.NgayLapPT, pt.SoHD, pt.MaKH, pt.HoTen, pt.SoTienThu })
                    .ToList();
                    dgvPhieuThu.DataSource = data;
                    this.txt_MaPT.Enabled = false;
                    this.txt_TenKH.Enabled = false;
                    this.txt_MaHD.Enabled = false;
                    this.txt_MaKH.Enabled = false;
                    this.dt_LapPhieu.Enabled = false;
                    this.txt_Tien.Enabled = false;
                    this.txtSoPT.Enabled = false;
                    this.txtHoTen.Enabled = false;
                    this.txtMaHD.Enabled = false;
                    this.txtMaKH.Enabled = false;
                    this.txtDate.Enabled = false;
                    this.txtTien.Enabled = false;

                    dgvPhieuThu_CellClick(null, null);
                }
                catch
                {
                    MessageBox.Show("Không lấy được nội dung trong table Phiếu thu. Lỗi rồi!!!");
                }
            }
            else if(cb_Loc.SelectedIndex == 1)
            {
                try
                {
                    var data = dbpt.Lay1MaKH(txt_loc.Text)
                    .Select(pt => new { pt.SoPT, pt.NgayLapPT, pt.SoHD, pt.MaKH, pt.HoTen, pt.SoTienThu })
                    .ToList();
                    dgvPhieuThu.DataSource = data;
                    this.txt_MaPT.Enabled = false;
                    this.txt_TenKH.Enabled = false;
                    this.txt_MaHD.Enabled = false;
                    this.txt_MaKH.Enabled = false;
                    this.dt_LapPhieu.Enabled = false;
                    this.txt_Tien.Enabled = false;
                    this.txtSoPT.Enabled = false;
                    this.txtHoTen.Enabled = false;
                    this.txtMaHD.Enabled = false;
                    this.txtMaKH.Enabled = false;
                    this.txtDate.Enabled = false;
                    this.txtTien.Enabled = false;

                    dgvPhieuThu_CellClick(null, null);
                }
                catch
                {
                    MessageBox.Show("Không lấy được nội dung trong table Phiếu thu. Lỗi rồi!!!");
                }
            }
            else
            {
                LoadData();
            }
        }
    }
}
