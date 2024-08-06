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
    
    public partial class frmNhanvien : Form
    {
        BUS_CDBStaff sff = new BUS_CDBStaff();
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            AnHien(false, true, false, false, true, false, false, false);
            dsnhanvien();
        }
        public void AnHien(bool txt, bool them, bool luu, bool khongluu, bool tim, bool sua, bool capnhat, bool xoa)
        {
            //Ẩn hiện TextBox và ComboBox
            this.txtHoten.Enabled = txt;
            this.txtDiachi.Enabled = txt;
            this.dateTimePickerNS.Enabled = txt;
            this.cboGioitinh.Enabled = txt;
            this.txtSodienthoai.Enabled = txt;
            //Ẩn hiện Button
            this.btThem.Enabled = them;
            this.btTim.Enabled = tim;
            this.btLuu.Enabled = luu;
            this.btKhongluu.Enabled = khongluu;
            this.btnSua.Enabled = sua;
            this.btnCapNhat.Enabled = capnhat;
            this.btnXoa.Enabled = xoa;
        }
        //hàm xoá trắng
        public void xoatrang()
        {
            this.txtMasoNV.Text = "";
            this.txtHoten.Text = "";
            this.txtDiachi.Text = "";
            this.cboGioitinh.Text = "";
            this.dateTimePickerNS.Text = "";
            this.txtSodienthoai.Text = "";
            this.cboGioitinh.SelectedIndex = 0;
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
        //hàm load Danh sách Người tiêm
        public void dsnhanvien()
        {
            BUS_CDBCustomer cmd = new BUS_CDBCustomer();
            SqlDataReader sdr = cmd.getDataStotedProcedure("pr_DSNV");
            //Lưới Danh sách người tiêm
            myTable = this.dataSetNV.Tables[0];
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
                stt += 1;
                myTable.Rows.Add(myRow);
            }
            this.dGridViewNV.DataSource = myTable;
            sdr.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            AnHien(true, false, true, true, true, false, false, false);
            //hàm xoá trắng
            xoatrang();
            //--Giọi hàm tạo mã số người tiêm
            SqlDataReader sdr = sff.getDataStotedProcedure("pr_MANV");
            if (sdr.Read() == true)
            {
                this.txtMasoNV.Text = sdr.GetString(0).ToString();
            }
            sdr.Close();
            dsnhanvien();

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //khai báo table
        DataTable myTable = new DataTable();
        DataRow myRow = null;
        private void btLuu_Click(object sender, EventArgs e)
        {
            //Gọi hàm tạo dữ liệu nhân viên
            DTO_CDBStaff dsff = new DTO_CDBStaff(this.txtMasoNV.Text.Trim().ToString(),
                                                 this.txtHoten.Text.Trim().ToString(),
                                                 this.cboGioitinh.Text.Trim().ToString(),
                                                 string.Format("{0:dd/MM/yyyy}", this.dateTimePickerNS.Value),
                                                 this.txtDiachi.Text.Trim().ToString(),
                                                 this.txtSodienthoai.Text.Trim().ToString());
            //gọi hàm thêm nhân viên
            if (kiemtra_nhap() != "")
            {
                MessageBox.Show(kiemtra_nhap(), "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
                sff.pr_THEMNV(dsff);

            //--Gọi hàm Ẩn hiện
            AnHien(false, true, false, false, true, false, false, false);
            //goi hàm danh sach người tiêm
            dsnhanvien();
            //
            xoatrang();
            //
            AnHien(false, true, false, false, true, false, false, false);
        }

        private void dGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMasoNV.Text = dGridViewNV.Rows[numrow].Cells[1].Value.ToString();
            txtHoten.Text = dGridViewNV.Rows[numrow].Cells[2].Value.ToString();
            //
            if (dGridViewNV.Rows[numrow].Cells[4].Value.ToString().Trim() == "Nam")
            {
                //MessageBox.Show("Nam", "Thông báo", MessageBoxButtons.OK);
                cboGioitinh.SelectedIndex = 0;
            }
            else if (dGridViewNV.Rows[numrow].Cells[4].Value.ToString().Trim() == "Nữ")
            {
                //MessageBox.Show("Nữ", "Thông báo", MessageBoxButtons.OK);
                cboGioitinh.SelectedIndex = 1;
            }
            //
            dateTimePickerNS.Text = dGridViewNV.Rows[numrow].Cells[4].Value.ToString();
            txtDiachi.Text = dGridViewNV.Rows[numrow].Cells[5].Value.ToString();
            txtSodienthoai.Text = dGridViewNV.Rows[numrow].Cells[6].Value.ToString();
            AnHien(false, true, false, false, true, true, false, true);
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            //khai báo dto tạo dữ liệu
            DTO_CDBStaff staff = new DTO_CDBStaff(this.txtT_Hoten.Text.Trim().ToString());
            //
            SqlDataReader sdr = sff.getDataStotedProcedure("pr_TIMNV", staff);
            //Lưới Danh sách người tiêm
            myTable = this.dataSetNV.Tables[0];
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
                stt += 1;
                myTable.Rows.Add(myRow);
            }
            this.dGridViewNV.DataSource = myTable;
            sdr.Close();
            AnHien(false, true, false, false, true, false, false, false);
        }

        private void btKhongluu_Click(object sender, EventArgs e)
        {
            AnHien(false, true, false, false, true, false, false, false);
            dsnhanvien();
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
                DTO_CDBStaff dsff = new DTO_CDBStaff(this.txtMasoNV.Text.Trim().ToString(),
                                                     this.txtHoten.Text.Trim().ToString(),
                                                     this.cboGioitinh.Text.Trim().ToString(),
                                                     string.Format("{0:dd/MM/yyyy}", this.dateTimePickerNS.Value),
                                                     this.txtDiachi.Text.Trim().ToString(),
                                                     this.txtSodienthoai.Text.Trim().ToString());
                sff.pr_CAPNHATNV(dsff);
            }
            dsnhanvien();
            AnHien(false, true, false, false, true, false, false, false);
            xoatrang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            //Gọi hàm tạo dữ liệu người tiêm
            DTO_CDBStaff dsff = new DTO_CDBStaff(this.txtMasoNV.Text.Trim().ToString(),
                                                     this.txtHoten.Text.Trim().ToString(),
                                                     this.cboGioitinh.Text.Trim().ToString(),
                                                     string.Format("{0:dd/MM/yyyy}", this.dateTimePickerNS.Value),
                                                     this.txtDiachi.Text.Trim().ToString(),
                                                     this.txtSodienthoai.Text.Trim().ToString());
            //goi hàm xoá

            sff.pr_XOANV(dsff);
            //goi hàm danh sach người tiêm
            dsnhanvien();
            AnHien(false, true, false, false, true, false, false, false);
        }
    }
}
