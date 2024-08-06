
namespace QLTiemVacxin
{
    partial class frmQuanly
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHT_Dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHT_HKnoi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHT_Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHT_Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM_Nguoitiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM_Vacxin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM_Nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieutiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLPT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTracuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TC_Khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TC_Vacxin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTC_Nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTC_Phieutiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC_InPT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC_LHTN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHethong,
            this.mnuDanhmuc,
            this.mnuPhieutiem,
            this.mnuTracuu,
            this.mnuBaocao,
            this.mnuTrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHethong
            // 
            this.mnuHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT_Dangnhap,
            this.toolStripSeparator1,
            this.mnuHT_HKnoi,
            this.toolStripSeparator2,
            this.mnuHT_Backup,
            this.toolStripSeparator3,
            this.mnuHT_Restore,
            this.toolStripSeparator4,
            this.thoátToolStripMenuItem});
            this.mnuHethong.Name = "mnuHethong";
            this.mnuHethong.Size = new System.Drawing.Size(88, 24);
            this.mnuHethong.Tag = "";
            this.mnuHethong.Text = "Hệ Thống";
            // 
            // mnuHT_Dangnhap
            // 
            this.mnuHT_Dangnhap.Name = "mnuHT_Dangnhap";
            this.mnuHT_Dangnhap.Size = new System.Drawing.Size(224, 26);
            this.mnuHT_Dangnhap.Text = "Đăng nhập";
            this.mnuHT_Dangnhap.Click += new System.EventHandler(this.mnuHT_Dangnhap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuHT_HKnoi
            // 
            this.mnuHT_HKnoi.Name = "mnuHT_HKnoi";
            this.mnuHT_HKnoi.Size = new System.Drawing.Size(224, 26);
            this.mnuHT_HKnoi.Text = "Đằng xuất";
            this.mnuHT_HKnoi.Click += new System.EventHandler(this.mnuHT_HKnoi_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuHT_Backup
            // 
            this.mnuHT_Backup.Name = "mnuHT_Backup";
            this.mnuHT_Backup.Size = new System.Drawing.Size(224, 26);
            this.mnuHT_Backup.Text = "Lưu dự phòng";
            this.mnuHT_Backup.Click += new System.EventHandler(this.mnuHT_BandR_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuHT_Restore
            // 
            this.mnuHT_Restore.Name = "mnuHT_Restore";
            this.mnuHT_Restore.Size = new System.Drawing.Size(224, 26);
            this.mnuHT_Restore.Text = "Khôi phục dữ liệu";
            this.mnuHT_Restore.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDM_Nguoitiem,
            this.mnuDM_Vacxin,
            this.mnuDM_Nhanvien});
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhmuc.Tag = "";
            this.mnuDanhmuc.Text = "Danh Mục";
            // 
            // mnuDM_Nguoitiem
            // 
            this.mnuDM_Nguoitiem.Name = "mnuDM_Nguoitiem";
            this.mnuDM_Nguoitiem.Size = new System.Drawing.Size(224, 26);
            this.mnuDM_Nguoitiem.Text = "Khách Hàng";
            this.mnuDM_Nguoitiem.Click += new System.EventHandler(this.mnuDM_Nguoitiem_Click);
            // 
            // mnuDM_Vacxin
            // 
            this.mnuDM_Vacxin.Name = "mnuDM_Vacxin";
            this.mnuDM_Vacxin.Size = new System.Drawing.Size(224, 26);
            this.mnuDM_Vacxin.Text = "Bác Sĩ";
            this.mnuDM_Vacxin.Click += new System.EventHandler(this.mnuDM_Vacxin_Click);
            // 
            // mnuDM_Nhanvien
            // 
            this.mnuDM_Nhanvien.Name = "mnuDM_Nhanvien";
            this.mnuDM_Nhanvien.Size = new System.Drawing.Size(224, 26);
            this.mnuDM_Nhanvien.Text = "Nhân viên";
            this.mnuDM_Nhanvien.Click += new System.EventHandler(this.mnuDM_Nhanvien_Click);
            // 
            // mnuPhieutiem
            // 
            this.mnuPhieutiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLPT});
            this.mnuPhieutiem.Name = "mnuPhieutiem";
            this.mnuPhieutiem.Size = new System.Drawing.Size(99, 24);
            this.mnuPhieutiem.Text = "QL Lịch hẹn";
            // 
            // mnuLPT
            // 
            this.mnuLPT.Name = "mnuLPT";
            this.mnuLPT.Size = new System.Drawing.Size(224, 26);
            this.mnuLPT.Text = "Lập Phiếu Hẹn";
            this.mnuLPT.Click += new System.EventHandler(this.mnuLPT_Click);
            // 
            // mnuTracuu
            // 
            this.mnuTracuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_TC_Khachhang,
            this.mnu_TC_Vacxin,
            this.mnuTC_Nhanvien,
            this.mnuTC_Phieutiem});
            this.mnuTracuu.Name = "mnuTracuu";
            this.mnuTracuu.Size = new System.Drawing.Size(73, 24);
            this.mnuTracuu.Tag = "";
            this.mnuTracuu.Text = "Tra Cứu";
            // 
            // mnu_TC_Khachhang
            // 
            this.mnu_TC_Khachhang.Name = "mnu_TC_Khachhang";
            this.mnu_TC_Khachhang.Size = new System.Drawing.Size(224, 26);
            this.mnu_TC_Khachhang.Text = "Khách Hàng";
            this.mnu_TC_Khachhang.Click += new System.EventHandler(this.mnu_TC_Khachhang_Click);
            // 
            // mnu_TC_Vacxin
            // 
            this.mnu_TC_Vacxin.Name = "mnu_TC_Vacxin";
            this.mnu_TC_Vacxin.Size = new System.Drawing.Size(224, 26);
            this.mnu_TC_Vacxin.Text = "Bác Sĩ";
            this.mnu_TC_Vacxin.Click += new System.EventHandler(this.mnu_TC_Vacxin_Click);
            // 
            // mnuTC_Nhanvien
            // 
            this.mnuTC_Nhanvien.Name = "mnuTC_Nhanvien";
            this.mnuTC_Nhanvien.Size = new System.Drawing.Size(224, 26);
            this.mnuTC_Nhanvien.Text = "Nhân viên";
            this.mnuTC_Nhanvien.Click += new System.EventHandler(this.mnuTC_Nhanvien_Click);
            // 
            // mnuTC_Phieutiem
            // 
            this.mnuTC_Phieutiem.Name = "mnuTC_Phieutiem";
            this.mnuTC_Phieutiem.Size = new System.Drawing.Size(224, 26);
            this.mnuTC_Phieutiem.Text = "Phiếu Hẹn";
            this.mnuTC_Phieutiem.Click += new System.EventHandler(this.mnuTC_Phieutiem_Click);
            // 
            // mnuBaocao
            // 
            this.mnuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBC_InPT,
            this.mnuBC_LHTN});
            this.mnuBaocao.Name = "mnuBaocao";
            this.mnuBaocao.Size = new System.Drawing.Size(79, 24);
            this.mnuBaocao.Tag = "";
            this.mnuBaocao.Text = "Báo Cáo";
            // 
            // mnuBC_InPT
            // 
            this.mnuBC_InPT.Name = "mnuBC_InPT";
            this.mnuBC_InPT.Size = new System.Drawing.Size(276, 26);
            this.mnuBC_InPT.Text = "In Phiếu Hẹn";
            this.mnuBC_InPT.Click += new System.EventHandler(this.mnuBC_InPT_Click);
            // 
            // mnuBC_LHTN
            // 
            this.mnuBC_LHTN.Name = "mnuBC_LHTN";
            this.mnuBC_LHTN.Size = new System.Drawing.Size(276, 26);
            this.mnuBC_LHTN.Text = "Thống Lịch Hẹn Trong Ngày";
            this.mnuBC_LHTN.Click += new System.EventHandler(this.mnuBC_LHTN_Click);
            // 
            // mnuTrogiup
            // 
            this.mnuTrogiup.Name = "mnuTrogiup";
            this.mnuTrogiup.Size = new System.Drawing.Size(79, 24);
            this.mnuTrogiup.Tag = "";
            this.mnuTrogiup.Text = "Trợ Giúp";
            // 
            // frmQuanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1081, 603);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanly";
            this.Text = "Quản Lý Lịch Hẹn Khám Sức khoẻ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanly_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem mnuHethong;
        public System.Windows.Forms.ToolStripMenuItem mnuHT_Dangnhap;
        public System.Windows.Forms.ToolStripMenuItem mnuHT_HKnoi;
        public System.Windows.Forms.ToolStripMenuItem mnuHT_Backup;
        public System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        public System.Windows.Forms.ToolStripMenuItem mnuDM_Nguoitiem;
        public System.Windows.Forms.ToolStripMenuItem mnuDM_Vacxin;
        public System.Windows.Forms.ToolStripMenuItem mnuDM_Nhanvien;
        public System.Windows.Forms.ToolStripMenuItem mnuTracuu;
        public System.Windows.Forms.ToolStripMenuItem mnu_TC_Khachhang;
        public System.Windows.Forms.ToolStripMenuItem mnu_TC_Vacxin;
        public System.Windows.Forms.ToolStripMenuItem mnuTC_Nhanvien;
        public System.Windows.Forms.ToolStripMenuItem mnuTC_Phieutiem;
        public System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        public System.Windows.Forms.ToolStripMenuItem mnuBC_InPT;
        public System.Windows.Forms.ToolStripMenuItem mnuTrogiup;
        public System.Windows.Forms.ToolStripMenuItem mnuPhieutiem;
        private System.Windows.Forms.ToolStripMenuItem mnuLPT;
        private System.Windows.Forms.ToolStripMenuItem mnuBC_LHTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripMenuItem mnuHT_Restore;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

