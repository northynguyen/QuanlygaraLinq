namespace LINQ
{
    partial class FAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_Thoat = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHopDongChuaDuyet = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Thoat)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMIN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptb_Thoat);
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(10, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1844, 938);
            this.panel1.TabIndex = 2;
            // 
            // ptb_Thoat
            // 
            this.ptb_Thoat.Image = global::LINQ.Properties.Resources.Cancel;
            this.ptb_Thoat.Location = new System.Drawing.Point(1800, 1);
            this.ptb_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_Thoat.Name = "ptb_Thoat";
            this.ptb_Thoat.Size = new System.Drawing.Size(44, 49);
            this.ptb_Thoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Thoat.TabIndex = 7;
            this.ptb_Thoat.TabStop = false;
            this.ptb_Thoat.Click += new System.EventHandler(this.ptb_Thoat_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuanLy,
            this.tsmThongTin,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.menuHopDongChuaDuyet});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1844, 49);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // tsmQuanLy
            // 
            this.tsmQuanLy.AutoSize = false;
            this.tsmQuanLy.BackColor = System.Drawing.Color.Transparent;
            this.tsmQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.HợpĐồngToolStripMenuItem,
            this.chiTiếtHợpĐồngToolStripMenuItem,
            this.phiếuThuToolStripMenuItem,
            this.côngViệcToolStripMenuItem,
            this.thợToolStripMenuItem});
            this.tsmQuanLy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmQuanLy.Name = "tsmQuanLy";
            this.tsmQuanLy.Size = new System.Drawing.Size(182, 35);
            this.tsmQuanLy.Text = "Quản Lý";
            this.tsmQuanLy.Click += new System.EventHandler(this.hahahahToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(329, 40);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // HợpĐồngToolStripMenuItem
            // 
            this.HợpĐồngToolStripMenuItem.Name = "HợpĐồngToolStripMenuItem";
            this.HợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(329, 40);
            this.HợpĐồngToolStripMenuItem.Text = "Hợp Đồng";
            this.HợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.HợpĐồngToolStripMenuItem_Click);
            // 
            // chiTiếtHợpĐồngToolStripMenuItem
            // 
            this.chiTiếtHợpĐồngToolStripMenuItem.Name = "chiTiếtHợpĐồngToolStripMenuItem";
            this.chiTiếtHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(329, 40);
            this.chiTiếtHợpĐồngToolStripMenuItem.Text = "Chi Tiết Hợp Đồng";
            this.chiTiếtHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtHóaĐơnToolStripMenuItem_Click);
            // 
            // phiếuThuToolStripMenuItem
            // 
            this.phiếuThuToolStripMenuItem.Name = "phiếuThuToolStripMenuItem";
            this.phiếuThuToolStripMenuItem.Size = new System.Drawing.Size(329, 40);
            this.phiếuThuToolStripMenuItem.Text = "Phiếu Thu";
            this.phiếuThuToolStripMenuItem.Click += new System.EventHandler(this.phiếuThuToolStripMenuItem_Click);
            // 
            // côngViệcToolStripMenuItem
            // 
            this.côngViệcToolStripMenuItem.Name = "côngViệcToolStripMenuItem";
            this.côngViệcToolStripMenuItem.Size = new System.Drawing.Size(329, 40);
            this.côngViệcToolStripMenuItem.Text = "Công Việc";
            this.côngViệcToolStripMenuItem.Click += new System.EventHandler(this.côngViệcToolStripMenuItem_Click);
            // 
            // thợToolStripMenuItem
            // 
            this.thợToolStripMenuItem.Name = "thợToolStripMenuItem";
            this.thợToolStripMenuItem.Size = new System.Drawing.Size(329, 40);
            this.thợToolStripMenuItem.Text = "Thợ";
            this.thợToolStripMenuItem.Click += new System.EventHandler(this.thợToolStripMenuItem_Click);
            // 
            // tsmThongTin
            // 
            this.tsmThongTin.AutoSize = false;
            this.tsmThongTin.BackColor = System.Drawing.Color.Transparent;
            this.tsmThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmThongTin.Name = "tsmThongTin";
            this.tsmThongTin.Size = new System.Drawing.Size(230, 35);
            this.tsmThongTin.Text = "Thông Tin Hợp Đồng";
            this.tsmThongTin.Click += new System.EventHandler(this.tsmThongTin_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 35);
            this.toolStripMenuItem1.Text = "Hợp Đồng Chưa Duyệt";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 35);
            this.toolStripMenuItem2.Text = "Lương thợ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.menuHopDongChuaDuyet_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(230, 35);
            this.toolStripMenuItem3.Text = "Report hợp đồng";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // menuHopDongChuaDuyet
            // 
            this.menuHopDongChuaDuyet.AutoSize = false;
            this.menuHopDongChuaDuyet.BackColor = System.Drawing.Color.Transparent;
            this.menuHopDongChuaDuyet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHopDongChuaDuyet.Name = "menuHopDongChuaDuyet";
            this.menuHopDongChuaDuyet.Size = new System.Drawing.Size(182, 35);
            this.menuHopDongChuaDuyet.Text = "Report doanh thu";
            this.menuHopDongChuaDuyet.Click += new System.EventHandler(this.menuHopDongChuaDuyet_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Location = new System.Drawing.Point(-4, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1848, 875);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(200, 25);
            this.tabControl.Location = new System.Drawing.Point(-4, 5);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1863, 875);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1404, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài khoản:";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.Location = new System.Drawing.Point(1617, 30);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(82, 32);
            this.lblTenNguoiDung.TabIndex = 6;
            this.lblTenNguoiDung.Text = "None";
            this.lblTenNguoiDung.Click += new System.EventHandler(this.lblTenNguoiDung_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LINQ.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(1794, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1899, 946);
            this.Controls.Add(this.lblTenNguoiDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.FNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Thoat)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsmThongTin;
        private System.Windows.Forms.ToolStripMenuItem menuHopDongChuaDuyet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thợToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptb_Thoat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}