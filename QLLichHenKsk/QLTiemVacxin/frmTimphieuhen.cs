using BUS;
using DTO;
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

namespace QLTiemVacxin
{
    public partial class frmTimphieuhen : Form
    {
        public frmTimphieuhen()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMasoHD_CheckedChanged(object sender, EventArgs e)
        {
            
            if(this.rbMasoPH.Checked==true)
            {
                this.txtTenKH.Text = "";
                this.txtTenKH.Enabled = true;
                this.dateTimePiNgayhen.Enabled = false;
            }    
        }

        private void rbNgayHD_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNgayHen.Checked == true)
            {
                this.txtTenKH.Text = "";
                this.txtTenKH.Enabled = false;
                this.dateTimePiNgayhen.Enabled = true;
            }
        }
        BUS_CDB_PH bpt = new BUS_CDB_PH();
        DataTable myTable = new DataTable();
        private void btTim_Click(object sender, EventArgs e)
        {
            
            myTable = this.dataSetPH.Tables[0];
            myTable.Clear();
            bpt.getDataStotedProcedure(this.dataSetPH, "EXEC pr_TIMPH @TENKH='"+this.txtTenKH.Text.Trim()+
                                        "', @NGAYHEN='"+string.Format("{0:MM/dd/yyy}",this.dateTimePiNgayhen.Value)+"'",
                                        "DSPHIEUHEN");
            
        }

        private void frmTimphieutiem_Load(object sender, EventArgs e)
        {
            this.txtTenKH.Enabled = false;
            this.dateTimePiNgayhen.Enabled = false;
        }
        string c1, c2, c3, c4, c5, c6, c7, c8;
        private void dGridViewPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                c1 = dGridViewPH.Rows[numrow].Cells[0].Value.ToString();
                c2 = dGridViewPH.Rows[numrow].Cells[1].Value.ToString();
                c3 = dGridViewPH.Rows[numrow].Cells[2].Value.ToString();
                c4 = dGridViewPH.Rows[numrow].Cells[3].Value.ToString();
                c5 = dGridViewPH.Rows[numrow].Cells[4].Value.ToString();
                c6 = dGridViewPH.Rows[numrow].Cells[5].Value.ToString();
                c7 = dGridViewPH.Rows[numrow].Cells[6].Value.ToString();  
                c8 = dGridViewPH.Rows[numrow].Cells[7].Value.ToString();
            }
            catch
            {
                if (this.myTable.Rows.Count > 0)
                {
                    MessageBox.Show("Bàn Cần click chính xác dòng Thông phiếu tiêm cần chọn !!", "thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Bạn cần tìm Thông tin người tiêm!!", "thông báo", MessageBoxButtons.OK);
                }
            }
        }
        
        public delegate void truyendata2(string c1, string c2, string c3, string c4, string c5, string c6, string c7, string c8);
        
        public truyendata2 truyendl2;

        private void btChon_Click(object sender, EventArgs e)
        {
            if (c1 != "")
            {
                truyendl2(c1, c2, c3, c4, c5, c6, c7,c8);
                
            }
            else
            {
                MessageBox.Show("Bạn cần chọn dữ liệu trong bản!!", "Thông báo", MessageBoxButtons.OK);
            }
            this.Close();
        }
    }
}
