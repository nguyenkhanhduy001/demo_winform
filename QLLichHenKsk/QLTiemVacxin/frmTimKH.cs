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
    public partial class frmTimKH : Form
    {
        public string c1, c2, c3, c4, c5, c6, c7;
        public frmTimKH()
        {
            InitializeComponent();
        }
        //khia báo biến lớp BUS_CDBCustomer tầng BUS
        BUS_CDBCustomer bcus = new BUS_CDBCustomer();
        //khai báo 
        DataTable myTable = new DataTable();
        DataRow myRow = null;

        private void frmTimNT_Load(object sender, EventArgs e)
        {
            this.btChon.Enabled = false;
        }
        private string kt_nhap()
        {
            string thongbao="";
            if (this.txtMaso.Text.Trim() == "" && this.txtHoten.Text.Trim() == ""&&
                this.txtCMT.Text.Trim() == "" && this.txtSodienthoai.Text.Trim() == ""&&
                this.txtDiachi.Text.Trim() == "")
                thongbao = "Bạn cần nhập thông tin để kiếm !";

            return thongbao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.Show();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (kt_nhap() != "")
            {
                MessageBox.Show(kt_nhap(), "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DTO_CDBCustomer dcus = new DTO_CDBCustomer(this.txtMaso.Text.Trim().ToString(),
                                                     this.txtHoten.Text.Trim().ToString(),
                                                     this.txtCMT.Text.Trim().Trim().ToString(),
                                                     this.txtDiachi.Text.Trim().ToString(),
                                                     this.txtSodienthoai.Text.Trim().ToString());
                SqlDataReader sdr = bcus.getDataStotedProcedure("pr_TIMKH", dcus);
                //Lưới Danh sách người tiêm
                myTable = this.dataSetNT.Tables[0];
                myTable.Clear();
                int stt = 1;
                while (sdr.Read() == true)
                {
                    myRow = myTable.NewRow();
                    myRow[0] = stt;
                    myRow[1] = sdr.GetString(0).ToString();
                    myRow[2] = sdr.GetString(1).ToString();
                    myRow[3] = sdr.GetString(2).ToString();
                    myRow[4] = sdr.GetString(3).ToString();
                    myRow[5] = sdr.GetDateTime(4).ToString();
                    myRow[6] = sdr.GetString(5).ToString();
                    myRow[7] = sdr.GetString(6).ToString();
                    stt += 1;
                    myTable.Rows.Add(myRow);
                }
                this.dGridViewNT.DataSource = myTable;
                sdr.Close();
                if (this.myTable.Rows.Count > 0)
                {
                    this.btChon.Enabled = true;
                }
                else
                {
                    this.btChon.Enabled = false;
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public delegate void truyendata(string c1, string c2, string c3, string c4, string c5, string c6, string c7);
        public truyendata truyendl;
        private void btChon_Click(object sender, EventArgs e)
        {
            try {
                if (c1 != "")
                {

                    truyendl(c1, c2, c3, c4, c5, c6, c7);
                    MessageBox.Show("Bạn đã chọn " + c1.Trim().ToString() + "(^0^)", "Thông báo !", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn dữ liệu trong bản!!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch 
            {
                MessageBox.Show("Bạn cần mở Danh Mục Người Tiêm hoặc Lập Phiếu Tiêm trước!!! /n" +
                                " Để có thể sử dụng chức năng này!", "Thông báo", MessageBoxButtons.OK);
            }
            

        }
        
        private void dGridViewNT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                int numrow;
                numrow = e.RowIndex;
                c1 = dGridViewNT.Rows[numrow].Cells[1].Value.ToString();
                c2 = dGridViewNT.Rows[numrow].Cells[2].Value.ToString();
                c3 = dGridViewNT.Rows[numrow].Cells[3].Value.ToString();
                c4 = dGridViewNT.Rows[numrow].Cells[4].Value.ToString();
                c5 = dGridViewNT.Rows[numrow].Cells[5].Value.ToString();
                c6 = dGridViewNT.Rows[numrow].Cells[6].Value.ToString();
                c7 = dGridViewNT.Rows[numrow].Cells[7].Value.ToString();
            }
            catch 
            {
                if (this.myTable.Rows.Count > 0) 
                {
                    MessageBox.Show("Bàn Cần click chính xác dòng thông tin người tiêm cần chọn  !!", "thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Bạn cần tìm Thông tin người tiêm!!", "thông báo", MessageBoxButtons.OK);
                }    
            }
        }
    }
}
