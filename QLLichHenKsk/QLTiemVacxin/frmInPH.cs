using CrystalDecisions.Shared;
using System;
using QLTiemVacxin;
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
    public partial class frmInPH : Form
    {
        public frmInPH()
        {
            InitializeComponent();
        }

        private void btInPH_Click(object sender, EventArgs e)
        {
            //-----1.khai báo Crystall Report
            cryINPH rp = new cryINPH();
            //-----2.cung cấp thông tin đăng nhập cho Crystall Report
            ConnectionInfo myconn = new ConnectionInfo();
            myconn.ServerName = frmDangNhap.SV;
            myconn.DatabaseName = frmDangNhap.DB;
            myconn.UserID = frmDangNhap.UI;
            myconn.Password = frmDangNhap.PW;
            TableLogOnInfo mytable = new TableLogOnInfo();
            mytable.ConnectionInfo = myconn;
            rp.Database.Tables[0].ApplyLogOnInfo(mytable);
            //-----3.khai báo biên kêt nói tham số voi Crystall Report
            CrystalDecisions.Shared.ParameterValues myVL = new CrystalDecisions.Shared.ParameterValues();
            CrystalDecisions.Shared.ParameterDiscreteValue pdvMSPT = new CrystalDecisions.Shared.ParameterDiscreteValue();
            //-----4.truyền tham số MSPT vào
            pdvMSPT.Value = txtMSPH.Text.Trim().ToString();
            myVL.Add(pdvMSPT);
            rp.DataDefinition.ParameterFields["@MSPH"].ApplyCurrentValues(myVL);
            //----5.gán Crystall Report vào CrReportViewerInPT
            this.crystalReportViewerPH.ReportSource = rp;
        }
        public void ldt(string c1, string c2, string c3, string c4, string c5, string c6, string c7, string c8)
        {
            this.txtMSPH.Text = c1;

        }

        private void btTimPH_Click(object sender, EventArgs e)
        {
            frmTimphieuhen frm = new frmTimphieuhen();
            frm.truyendl2 = new frmTimphieuhen.truyendata2(ldt);
            frm.ShowDialog();
            frm.btChon.Enabled = true;
        }
    }
}
