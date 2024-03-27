using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class FHopDongLINQ : Form
    {
        bool Them;
        string err;
        BLHopDongLINQ dbhd = new BLHopDongLINQ();
        public FHopDongLINQ()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

        }
        void LoadData()
        {
            try
            {
                var data = dbhd.LayHopDong()
                    .Select(hd => new { hd.SoHD, hd.NgayHD, hd.MaKH, hd.SoXe, hd.TriGiaHD, hd.NgayGiaoDK, hd.NgayNgThu })
                    .ToList();
                dgv_hopDong.DataSource = data;
                // Thay đổi độ rộng cột
                dgv_hopDong.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txt_soHD.ResetText();
                this.txt_maKH.ResetText();
                this.txt_soXe.ResetText();
                this.txt_triGiaHD.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.btn_luu.Enabled = false;
                this.btn_huy.Enabled = false;
                this.pn_attribute.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btn_them.Enabled = true;
                this.btn_sua.Enabled = true;
                this.btn_xoa.Enabled = true;
                this.btn_reload.Enabled = true;
                //
                dgv_hopDong_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HOPDONG. Lỗi rồi!!!");
            }

        }



        private void dgv_hopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgv_hopDong.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txt_soHD.Text = dgv_hopDong.Rows[r].Cells[0].Value.ToString();
            dtp_ngayHD.Text = dgv_hopDong.Rows[r].Cells[1].Value.ToString();
            txt_maKH.Text = dgv_hopDong.Rows[r].Cells[2].Value.ToString();
            txt_soXe.Text = dgv_hopDong.Rows[r].Cells[3].Value.ToString();
            txt_triGiaHD.Text = dgv_hopDong.Rows[r].Cells[4].Value.ToString();
            dtp_ngayGiao.Text = dgv_hopDong.Rows[r].Cells[5].Value.ToString();
            dtp_ngayThu.Text = dgv_hopDong.Rows[r].Cells[6].Value.ToString();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int soHD = int.Parse(this.txt_soHD.Text);
            int triGiaHD = int.Parse(this.txt_triGiaHD.Text);
            int maKH = int.Parse(this.txt_maKH.Text);
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLHopDongLINQ blHD = new BLHopDongLINQ();

                    blHD.ThemHopDong(soHD, dtp_ngayHD.Value, maKH, txt_soXe.Text, triGiaHD, dtp_ngayGiao.Value, dtp_ngayThu.Value, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLHopDongLINQ blHD = new BLHopDongLINQ();
                blHD.CapNhatHopDong(soHD, this.dtp_ngayHD.Value, maKH, txt_soXe.Text, triGiaHD, dtp_ngayGiao.Value, dtp_ngayThu.Value, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }



        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            txt_soHD.Enabled = true;
            // Xóa trống các đối tượng trong Panel
            this.txt_soHD.ResetText();
            this.txt_maKH.ResetText();
            this.txt_soXe.ResetText();
            this.txt_triGiaHD.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            pn_attribute.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            txt_soHD.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;

            // Cho phép thao tác trên Panel
            pn_attribute.Enabled = true;
            dgv_hopDong_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            pn_attribute.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

            // Đưa con trỏ đến TextField txtTenCty
            txt_soHD.Enabled = false;
            txt_soHD.Focus();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgv_hopDong.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strHopDong =
                dgv_hopDong.Rows[r].Cells[0].Value.ToString();
                int MaCV = int.Parse(strHopDong);
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbhd.XoaHopDong(ref err, MaCV);
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
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txt_soHD.ResetText();
            this.txt_maKH.ResetText();
            this.txt_soXe.ResetText();
            this.txt_triGiaHD.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            pn_attribute.Enabled = false;
            dgv_hopDong_CellClick(null, null);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }

        private void FHopDongLINQ_Load(object sender, EventArgs e)
        {
            dtp_ngayGiao.CustomFormat = "dd/MM/yyyy";
            dtp_ngayHD.CustomFormat = "dd/MM/yyyy";
            dtp_ngayThu.CustomFormat = "dd/MM/yyyy";
            LoadData();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            var data = dbhd.Lay1HopDong(txt_timKiem.Text)
                   .Select(hd => new { hd.SoHD, hd.NgayHD, hd.MaKH, hd.SoXe, hd.TriGiaHD, hd.NgayGiaoDK, hd.NgayNgThu })
                    .ToList();
            dgv_hopDong.DataSource = data;
            BLHopDongLINQ blhd = new BLHopDongLINQ();
            HOPDONG a = new HOPDONG();
            int soHD = int.Parse(txt_timKiem.Text);
            a = blhd.TimHopDong(soHD, ref err);
            if (a != null)
            {
                txt_tkSoHD.Text = a.SoHD.ToString();
                txt_tkNgayHD.Text = a.NgayHD.ToString();
                txt_tkMaKH.Text = a.MaKH.ToString();
                txt_tkTriGiaHD.Text = a.TriGiaHD.ToString();
                txt_tkNgayGiao.Text = a.NgayGiaoDK.ToString();
                txt_tkNgayThu.Text = a.NgayNgThu.ToString();
                txt_tkSoXe.Text = a.SoXe.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
                txt_tkSoHD.ResetText();
                txt_tkNgayHD.ResetText();
                txt_tkMaKH.ResetText();
                txt_tkTriGiaHD.ResetText();
                txt_tkNgayGiao.ResetText();
                txt_tkNgayThu.ResetText();
            }
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            if(cb_Loc.SelectedIndex== 0)
            {
                try
                {
                    var data = dbhd.Lay1MaKH(txt_loc.Text)
                        .Select(hd => new { hd.SoHD, hd.NgayHD, hd.MaKH, hd.SoXe, hd.TriGiaHD, hd.NgayGiaoDK, hd.NgayNgThu })
                        .ToList();
                    dgv_hopDong.DataSource = data;
                    // Thay đổi độ rộng cột
                    dgv_hopDong.AutoResizeColumns();
                    // Xóa trống các đối tượng trong Panel
                    this.txt_soHD.ResetText();
                    this.txt_maKH.ResetText();
                    this.txt_soXe.ResetText();
                    this.txt_triGiaHD.ResetText();

                    // Không cho thao tác trên các nút Lưu / Hủy
                    this.btn_luu.Enabled = false;
                    this.btn_huy.Enabled = false;
                    this.pn_attribute.Enabled = false;
                    // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                    this.btn_them.Enabled = true;
                    this.btn_sua.Enabled = true;
                    this.btn_xoa.Enabled = true;
                    this.btn_reload.Enabled = true;
                    //
                    dgv_hopDong_CellClick(null, null);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung trong table HOPDONG. Lỗi rồi!!!");
                }
            }
            else
            {
                LoadData();
            }    
        }
    }
}
