using BUS;
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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }
        //khai báo biến tang BUS
        BUS_CDBConnect cn = new BUS_CDBConnect();

        private void btChon_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.InitialDirectory = @"c:\";
            this.saveFileDialog1.Filter = "Files (*.bak)|*.bak|(*.dat)|*.dat";
            if(this.saveFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilename.Text = this.saveFileDialog1.FileName.ToString().Trim();
            }    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            try
            {
                    cn.pr_Backup(   "pr_BACKUPDATA",
                                    this.txtDatabase.Text.ToString(),
                                    this.txtFilename.Text.ToString());
                    this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!!", MessageBoxButtons.OK);
            }
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {

        }
    }
}
