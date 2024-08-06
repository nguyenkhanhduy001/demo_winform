using BUS;
using DTO;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        //khái báo biến thuộc BUS_CDBConnect tầng BUS
        BUS_CDBConnect cn = new BUS_CDBConnect();
        //khai báo biến thuộc GUI_EnableMenu tầng GUI
        GUI_CEnableMenu enbm = new GUI_CEnableMenu();
        // khai báo biến chứa thông tin đăng nhập
        public static string SV = string.Empty;
        public static string DB = string.Empty;
        public static string UI = string.Empty;
        public static string PW = string.Empty;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //1.gán thông tin đăng nhập
            SV = this.txtServername.Text.Trim();
            DB = this.txtDatabase.Text.Trim();
            UI = this.txtUserID.Text.Trim();
            PW = this.txtPassword.Text.Trim();
            //2.Gọi hàm khỏi tạo DTO_CBDConnect tầng DTO
            DTO_CDBConnect lg = new DTO_CDBConnect(SV,DB,UI,PW);
            //3.Gọi hàm khỏi tạo BUS_CBDConnect tầng BUS
            if (cn.DBConnect(lg) == true)
            {
                enbm.EnableMenu(true, false);
                this.Close();
            }
            
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
