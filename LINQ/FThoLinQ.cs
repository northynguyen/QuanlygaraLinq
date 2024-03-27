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
    public partial class FThoLinQ : Form
    {
        string err;
        bool Them;
        BLThoLinQ dbt = new BLThoLinQ();
        public FThoLinQ()
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
                var data = dbt.LayTho()
                .Select(pt => new { pt.MaTho, pt.TenTho, pt.Nhom, pt.NhomTruong })
                .ToList();
                dgvTho.DataSource = data;
                this.txt_MaTho.Enabled = false;
                this.txt_TenTho.Enabled = false;
                this.txt_Nhom.Enabled = false;
                this.txt_NhomTruong.Enabled = false;
                this.txtMaTho.Enabled = false;
                this.txtTen.Enabled = false;
                this.txtNhom.Enabled = false;
                this.txtNhomTruong.Enabled = false;
                dgvTho_CellClick(null, null);
        }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table thợ. Lỗi rồi!!!");
            }


        }


        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvTho.CurrentCell.RowIndex;
                this.txt_MaTho.Text = dgvTho.Rows[r].Cells[0].Value.ToString();
                this.txt_TenTho.Text = dgvTho.Rows[r].Cells[1].Value.ToString();
                this.txt_Nhom.Text = dgvTho.Rows[r].Cells[2].Value.ToString();
                this.txt_NhomTruong.Text = dgvTho.Rows[r].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void FThoLinQ_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.txt_MaTho.ResetText();
            this.txt_TenTho.ResetText();
            this.txt_Nhom.ResetText();
            this.txt_NhomTruong.ResetText();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FThoLinQ.ActiveForm.Close();
        }


        private void btn_Tim_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           
            Them = true;
            this.txt_MaTho.ResetText();
            this.txt_TenTho.ResetText();
            this.txt_Nhom.ResetText();
            this.txt_NhomTruong.ResetText();
            this.txt_MaTho.Enabled = true;
            this.txt_TenTho.Enabled = true;
            this.txt_Nhom.Enabled = true;
            this.txt_NhomTruong.Enabled = true;

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.txt_MaTho.ResetText();
            this.txt_TenTho.ResetText();
            this.txt_Nhom.ResetText();
            this.txt_NhomTruong.ResetText();
            this.txt_MaTho.Enabled = true;
            this.txt_TenTho.Enabled = true;
            this.txt_Nhom.Enabled = true;
            this.txt_NhomTruong.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {

                    
                    dbt.ThemTho(int.Parse(this.txt_MaTho.Text), this.txt_TenTho.Text, int.Parse(this.txt_Nhom.Text), int.Parse(this.txt_NhomTruong.Text), ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
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
                   

                    dbt.CapNhatT(int.Parse(this.txt_MaTho.Text), this.txt_TenTho.Text, int.Parse(this.txt_Nhom.Text), int.Parse(this.txt_NhomTruong.Text), ref err);
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch
                {
                    MessageBox.Show("Không có hợp đồng này, lỗi rồi");
                }

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                int r = dgvTho.CurrentCell.RowIndex;
                string strsoPT =
                dgvTho.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbt.XoaT(ref err,int.Parse(strsoPT));
                    // Cập nhật lại DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            
            
            lb_tinh.Text ="Tổng số thợ " +(dgvTho.Rows.Count).ToString();
        }

      
    }
}
