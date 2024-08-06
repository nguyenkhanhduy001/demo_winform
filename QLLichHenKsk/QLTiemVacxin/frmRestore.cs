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
    public partial class frmRestore : Form
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = @"c:\";
            this.openFileDialog1.Filter = "Files (*.bak)|*.bak|(*.dat)|*.dat";
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilename.Text = this.openFileDialog1.FileName.ToString().Trim();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //khái báo biến thuộc BUS_CDBConnect tầng BUS
        BUS_CDBConnect cnn = new BUS_CDBConnect();
        BUS_CDBConnect cn = new BUS_CDBConnect();
        // khai báo biến chứa thông tin kt noi
        public static string rSV = string.Empty;
        public static string rDB = string.Empty;
        public static string rUI = string.Empty;
        public static string rPW = string.Empty;
        private void frmRestore_Load(object sender, EventArgs e)
        {

        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            //1.gán thông tin đăng nhập
            rSV = this.txtServername.Text.Trim();
            rUI = this.txtUserID.Text.Trim();
            rPW = this.txtPassword.Text.Trim();
            //
            rDB = this.txtDatabase.Text.Trim();
            //2.Gọi hàm khỏi tạo DTO_CBDConnect tầng DTO
            DTO_CDBConnect lg = new DTO_CDBConnect(rSV, rDB, rUI, rPW);
            //3.Gọi hàm Restort tầng BUS

                cnn.Restore_DB(lg, this.txtFilename.Text.ToString());

                
 
        }
    }
}
