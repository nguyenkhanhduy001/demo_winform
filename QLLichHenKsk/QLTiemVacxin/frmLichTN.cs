using CrystalDecisions.Shared;
using QLTiemVacxin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLichHen
{
    public partial class frmLichTN : Form
    {
        public frmLichTN()
        {
            InitializeComponent();
        }

        private void frmLichTN_Load(object sender, EventArgs e)
        {
            //-----1.khai báo Crystall Report
            cryLichHenTN rp = new cryLichHenTN();
            //-----2.cung cấp thông tin đăng nhập cho Crystall Report
            ConnectionInfo myconn = new ConnectionInfo();
            myconn.ServerName = frmDangNhap.SV;
            myconn.DatabaseName = frmDangNhap.DB;
            myconn.UserID = frmDangNhap.UI;
            myconn.Password = frmDangNhap.PW;
            TableLogOnInfo mytable = new TableLogOnInfo();
            mytable.ConnectionInfo = myconn;
            rp.Database.Tables[0].ApplyLogOnInfo(mytable);          
            //----2.gán Crystall Report vào CrReportViewerInPT
            this.crystalReportViewerLHTN.ReportSource = rp;
        }
    }
}
