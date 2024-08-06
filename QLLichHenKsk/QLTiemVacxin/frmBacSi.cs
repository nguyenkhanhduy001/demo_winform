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
    public partial class frmBacSi : Form
    {
        public frmBacSi()
        {
            InitializeComponent();

        }
        //khai báo 
        DataTable myTable = new DataTable();
        DataRow myRow = null;
        //Khai báo biến thuộc BUS_CDBDoctor tầng BUS
        BUS_CDBDoctor dtr = new BUS_CDBDoctor();
        //hàm ẩn hiện
        public void AnHien(bool txt, bool them, bool luu, bool khongluu, bool tim, bool sua, bool capnhat, bool xoa)
        {
            //Ẩn hiện TextBox và ComboBox
            this.txtHoten.Enabled = txt;
            this.txtDiachi.Enabled = txt;
            this.dateTimePickerNS.Enabled = txt;
            this.cboGioitinh.Enabled = txt;
            this.cbKhoa.Enabled = txt;
            this.cbTrinhDo.Enabled = txt;
            this.cbChucVu.Enabled = txt;
            this.txtSodienthoai.Enabled = txt;
            //Ẩn hiện Button
            this.btnThem.Enabled = them;
            this.btnTim.Enabled = tim;
            this.btnLuu.Enabled = luu;
            this.btKhongluu.Enabled = khongluu;
            this.btnSua.Enabled = sua;
            this.btnCapNhat.Enabled = capnhat;
            this.btnXoa.Enabled = xoa;
        }
        //hàm xoá trắng
        public void xoatrang()
        {
            this.txtMasoBS.Text = "";
            this.txtHoten.Text = "";
            this.txtDiachi.Text = "";
            this.cboGioitinh.Text = "";
            this.cbKhoa.Text = "";
            this.cbTrinhDo.Text = "";
            this.cbChucVu.Text = "";
            this.dateTimePickerNS.Text = "";
            this.txtSodienthoai.Text = "";
            this.cboGioitinh.SelectedIndex = 0;
            this.cbTrinhDo.SelectedIndex = 0;
            this.cbChucVu.SelectedIndex = 0;
        }
        private string kiemtra_nhap()
        {
            string thongbao = string.Empty;
            if (this.txtHoten.Text.Trim() == "")
                thongbao += "[ Họ và tên ] ";
            if (this.txtSodienthoai.Text.Trim() == "")
                thongbao += "[ Điên Thoại ] ";
            if (this.txtDiachi.Text.Trim() == "")
                thongbao += "[ Địa chỉ ] ";
            if (thongbao != "")
            {
                thongbao += " ->Không thể để trống!!";
            }
            else
            {
                thongbao = "";
            }
            return thongbao;
        }
        //hàm load Danh sách bác sĩ
        public void dsbacsi()
        {
            BUS_CDBDoctor cmd = new BUS_CDBDoctor();
            SqlDataReader sdr = cmd.getDataStotedProcedure("pr_DSBS");
                myTable = this.dataSetBS.Tables[0];
                myTable.Clear();
                int stt = 1;
                while (sdr.Read() == true)
               {
                    myRow = myTable.NewRow();                   
                    myRow[0] = stt;
                    myRow[1] = sdr.GetString(0).ToString();
                    myRow[2] = sdr.GetString(1).ToString();
                    myRow[3] = sdr.GetString(4).ToString();
                    myRow[4] = sdr.GetDateTime(3).ToString();
                    myRow[5] = sdr.GetString(5).ToString();
                    myRow[6] = sdr.GetString(2).ToString();
                    myRow[7] = sdr.GetString(6).ToString();
                    myRow[8] = sdr.GetString(7).ToString();
                    myRow[9] = sdr.GetString(8).ToString();

                    stt += 1;
                    myTable.Rows.Add(myRow);
                }
                this.dGridViewBS.DataSource = myTable;
                sdr.Close();
    
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dsbacsi();
        }

        private void frmVacxin_Load(object sender, EventArgs e)
        {
            AnHien(false, true, false, false, true, true, false, false);
            dsbacsi();
        }

  

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //khai báo dto tạo dữ liệu
            DTO_CDBDoctor dtrr = new DTO_CDBDoctor(this.txtT_Hoten.Text.Trim().ToString());
            //
            SqlDataReader sdr = dtr.getDataStotedProcedure("pr_TIMBS", dtrr);
            //Lưới Danh sách người tiêm
            myTable = this.dataSetBS.Tables[0];
            myTable.Clear();
            int stt = 1;
            while (sdr.Read() == true)
            {
                myRow = myTable.NewRow();
                myRow[0] = stt;
                myRow[1] = sdr.GetString(0).ToString();
                myRow[2] = sdr.GetString(1).ToString();
                myRow[3] = sdr.GetString(4).ToString();
                myRow[4] = sdr.GetDateTime(3).ToString();
                myRow[5] = sdr.GetString(5).ToString();
                myRow[6] = sdr.GetString(2).ToString();
                myRow[7] = sdr.GetString(6).ToString();
                myRow[6] = sdr.GetString(7).ToString();
                myRow[9] = sdr.GetString(8).ToString();

                stt += 1;
                myTable.Rows.Add(myRow);
            }
            this.dGridViewBS.DataSource = myTable;
            sdr.Close();
            //try 
            //{

            //}
            //catch (Exception x) 
            //{
            //    MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
            //}
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AnHien(true, false, true, true, true, false, false, false);
            //hàm xoá trắng
            xoatrang();
            //--Giọi hàm tạo mã số bác sĩ
            SqlDataReader sdr = dtr.getDataStotedProcedure("pr_MSBS");
            if (sdr.Read() == true)
            {
                this.txtMasoBS.Text = sdr.GetString(0).ToString();
            }
            sdr.Close();
            dsbacsi();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_CDBDoctor dtrr = new DTO_CDBDoctor(this.txtMasoBS.Text.Trim().ToString(),
                                                  this.txtHoten.Text.Trim().ToString(),
                                                  this.cboGioitinh.Text.Trim().ToString(),
                                                  string.Format("{0:dd/MM/yyyy}", this.dateTimePickerNS.Value),
                                                  this.txtDiachi.Text.Trim().ToString(),
                                                  this.txtSodienthoai.Text.Trim().ToString(),
                                                  this.cbKhoa.Text.Trim().ToString(),
                                                  this.cbTrinhDo.Text.Trim().ToString(),
                                                  this.cbChucVu.Text.Trim().ToString());
            //gọi hàm thêm nhân viên
            if (kiemtra_nhap() != "")
            {
                MessageBox.Show(kiemtra_nhap(), "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
                dtr.pr_THEMBS(dtrr);

            //--Gọi hàm Ẩn hiện
            AnHien(false, true, false, false, true, false, false, false);
            //goi hàm danh sach bác sĩ
            dsbacsi();
            //
            xoatrang();
            //
            AnHien(false, true, false, false, true, false, false, false);
        }

        private void dGridViewBS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMasoBS.Text = dGridViewBS.Rows[numrow].Cells[1].Value.ToString();
            txtHoten.Text = dGridViewBS.Rows[numrow].Cells[2].Value.ToString();

            //
            if (dGridViewBS.Rows[numrow].Cells[3].Value.ToString().Trim() == "Nam")
            {
                
                cboGioitinh.SelectedIndex = 0;
            }
            else if (dGridViewBS.Rows[numrow].Cells[3].Value.ToString().Trim() == "Nữ")
            {
                
                cboGioitinh.SelectedIndex = 1;
            }
            //
         
        

            dateTimePickerNS.Text = dGridViewBS.Rows[numrow].Cells[4].Value.ToString();
            txtDiachi.Text = dGridViewBS.Rows[numrow].Cells[5].Value.ToString();
            txtSodienthoai.Text = dGridViewBS.Rows[numrow].Cells[6].Value.ToString();

            ////trình độ

                if (dGridViewBS.Rows[numrow].Cells[7].Value.ToString().Trim() == "Đại Học")
                {

                    cbTrinhDo.SelectedIndex = 0;
                }
                else if (dGridViewBS.Rows[numrow].Cells[7].Value.ToString().Trim() == "Thac Sĩ")
                {

                    cbTrinhDo.SelectedIndex = 1;
                }
                else if (dGridViewBS.Rows[numrow].Cells[7].Value.ToString().Trim() == "Tiến Sĩ")
                {
                    cbTrinhDo.SelectedIndex = 2;
                }
                else if (dGridViewBS.Rows[numrow].Cells[7].Value.ToString().Trim() == "Giáo Sư")
                {
                    cbTrinhDo.SelectedIndex = 3;
                }
            ////khoa
                if (dGridViewBS.Rows[numrow].Cells[8].Value.ToString().Trim() == "Sức Khoẻ TH")
                {

                    cbKhoa.SelectedIndex = 0;
                }
                else if (dGridViewBS.Rows[numrow].Cells[8].Value.ToString().Trim() == "Mắt")
                {

                    cbKhoa.SelectedIndex = 1;
                }
                else if (dGridViewBS.Rows[numrow].Cells[8].Value.ToString().Trim() == "Tim Mạch")
                {
                    cbKhoa.SelectedIndex = 2;
                }
            // chức vụ gg
            if (dGridViewBS.Rows[numrow].Cells[9].Value.ToString().Trim() == "Bác sĩ")
            {

                cbChucVu.SelectedIndex = 0;
            }
            else if (dGridViewBS.Rows[numrow].Cells[9].Value.ToString().Trim() == "Dược sĩ")
            {

                cbChucVu.SelectedIndex = 1;
            }
            else if (dGridViewBS.Rows[numrow].Cells[9].Value.ToString().Trim() == "Y tá")
            {
                cbChucVu.SelectedIndex = 2;
            }
            //

            AnHien(false, true, false, false, true, true, false, true);
        }

        private void btKhongluu_Click(object sender, EventArgs e)
        {
            AnHien(false, true, false, false, true, false, false, false);
            dsbacsi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AnHien(true, false, false, false, true, false, true, true);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kiemtra_nhap() != "")
            {
                MessageBox.Show(kiemtra_nhap(), "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                //Gọi hàm tạo dữ liệu nhân viên
                DTO_CDBDoctor dtrr = new DTO_CDBDoctor(this.txtMasoBS.Text.Trim().ToString(),
                                               this.txtHoten.Text.Trim().ToString(),
                                               this.cboGioitinh.Text.Trim().ToString(),
                                               string.Format("{0:dd/MM/yyyy}", this.dateTimePickerNS.Value),
                                               this.txtDiachi.Text.Trim().ToString(),
                                               this.txtSodienthoai.Text.Trim().ToString(),
                                               this.cbKhoa.Text.Trim().ToString(),
                                               this.cbTrinhDo.Text.Trim().ToString(),
                                               this.cbChucVu.Text.Trim().ToString());
                dtr.pr_CAPNHATBS(dtrr);
            }
            dsbacsi();
            AnHien(false, true, false, false, true, false, false, false);
            xoatrang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Gọi hàm tạo dữ liệu bác sĩ
            DTO_CDBDoctor dtrr = new DTO_CDBDoctor(this.txtMasoBS.Text.Trim().ToString(),
                                           this.txtHoten.Text.Trim().ToString(),
                                           this.cboGioitinh.Text.Trim().ToString(),
                                           string.Format("{0:dd/MM/yyyy}", this.dateTimePickerNS.Value),
                                           this.txtDiachi.Text.Trim().ToString(),
                                           this.txtSodienthoai.Text.Trim().ToString(),
                                           this.cbKhoa.Text.Trim().ToString(),
                                           this.cbTrinhDo.Text.Trim().ToString(),
                                           this.cbChucVu.Text.Trim().ToString());
            //goi hàm xoá

            dtr.pr_XOABS(dtrr);
            //goi hàm danh sach bác sĩ
            dsbacsi();
            AnHien(false, true, false, false, true, false, false, false);
        }
    }
}
