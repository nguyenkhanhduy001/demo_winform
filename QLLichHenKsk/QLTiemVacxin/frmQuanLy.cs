using BUS;
using QLLichHen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTiemVacxin
{
    public partial class frmQuanly : Form
    {
        public frmQuanly()
        {
            InitializeComponent();
        }
        //khai báo biến tầng BUS
        BUS_CDBConnect cn = new BUS_CDBConnect();
        //khai báo biến lơp GUI_CEnableMenu tầng GUI
        GUI_CEnableMenu enbm = new GUI_CEnableMenu();
        private void frmQuanly_Load(object sender, EventArgs e)
        {   
            //ẩn hiện Menu
            enbm.EnableMenu(false, true);
            this.IsMdiContainer = true;
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.MdiParent = this;
            frmDN.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuHT_Dangnhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.ShowDialog();
        }

        private void mnuHT_HKnoi_Click(object sender, EventArgs e)
        {
            if (cn.DisDBConnect() == true) 
            {
                enbm.EnableMenu(false, true);
            }

        }

        private void mnuDM_Nguoitiem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void mnu_TC_Khachhang_Click(object sender, EventArgs e)
        {
            frmTimKH frm = new frmTimKH();
            frm.Show();
            frm.btChon.Enabled = false;
        }

        private void mnu_TC_Vacxin_Click(object sender, EventArgs e)
        {
            frmBacSi frm = new frmBacSi();
           frm.Show();
        }

        private void mnuTC_Nhanvien_Click(object sender, EventArgs e)
        {
            frmNhanvien frm = new frmNhanvien();
            frm.Show();
        }

        private void mnuDM_Vacxin_Click(object sender, EventArgs e)
        {
            frmBacSi frm = new frmBacSi();
            frm.Show();
        }

        private void mnuDM_Nhanvien_Click(object sender, EventArgs e)
        {
            frmNhanvien frm = new frmNhanvien();
            frm.Show();
        }

        private void mnuTC_Phieutiem_Click(object sender, EventArgs e)
        {
            frmTimphieuhen frm = new frmTimphieuhen();
            frm.btChon.Enabled =false;
            frm.Show();
        }
        private void mnuLPT_Click(object sender, EventArgs e)
        {
            frmPhieuHen frm = new frmPhieuHen();
            frm.Show();
        }

        private void mnuBC_InPT_Click(object sender, EventArgs e)
        {
            frmInPH frm = new frmInPH();
            frm.Show();
        }

        private void mnuHT_BandR_Click(object sender, EventArgs e)
        {
            frmBackup frm = new frmBackup();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRestore frm = new frmRestore();
            frm.Show();
        }

        private void mnuBC_LHTN_Click(object sender, EventArgs e)
        {
            frmLichTN frm =new frmLichTN();
            frm.Show();
        }
    }
}
