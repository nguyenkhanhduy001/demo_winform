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
    public partial class frmKhachHang : Form
    {
        //Khai báo biến thuộc BUS_CDBCustomer tầng BUS
        BUS_CDBCustomer cm = new BUS_CDBCustomer();
        //khai báo 
        DataTable myTable = new DataTable();
        DataRow myRow = null;
        //hàm ẩn hiện
        public void AnHien(bool txt_btn, bool them, bool xoa, bool sua, bool k_capnhat, bool tim, bool luu, bool khongluu)
        {
            //Ẩn hiện TextBox và ComboBox
            this.txtHoten.Enabled = txt_btn;
            this.txtDiachi.Enabled = txt_btn;
            this.txtCMT.Enabled = txt_btn;
            this.dateTimePickerNS.Enabled = txt_btn;
            this.cboGioitinh.Enabled = txt_btn;
            this.txtSodienthoai.Enabled = txt_btn;
            //Ẩn hiện Button
            this.btThem.Enabled = them;
            this.btXoa.Enabled = xoa;
            this.btSua.Enabled = sua;
            this.btCapnhat.Enabled = k_capnhat;
            this.btTim.Enabled = tim;
            this.btLuu.Enabled = luu;
            this.btKhongluu.Enabled = khongluu;
            this.btKcapnhat.Enabled = k_capnhat;
        }
        //hàm xoá trắng
        public void xoatrang()
        {
            this.txtMasoKH.Text = "";
            this.txtHoten.Text = "";
            this.txtDiachi.Text = "";
            this.txtCMT.Text = "";
            this.cboGioitinh.Text = "";
            this.dateTimePickerNS.Text = "";
            this.txtSodienthoai.Text = "";
            this.cboGioitinh.SelectedIndex = 0;
        }
        //hàm kt trong tin nhập
        private string kiemtra_nhap()
        {
            string thongbao = string.Empty;
            if (this.txtHoten.Text.Trim() == "")
                thongbao += "[ Họ và tên ] ";
            if (this.txtCMT.Text.Trim() == "")
                thongbao += "[ CMT ] ";
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

        //hàm load Danh sách khách hàng
        public void dskhachhang()
        {
            BUS_CDBCustomer cmd = new BUS_CDBCustomer();
            SqlDataReader sdr = cmd.getDataStotedProcedure("pr_DSKH");
            //Lưới Danh sách khách hàng
            myTable = this.dataSetKH.Tables[0];
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
        }
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void ldt(string c1, string c2, string c3, string c4, string c5, string c6, string c7)
        {
            xoatrang();
            this.txtMasoKH.Text = c1;
            this.txtHoten.Text = c2;
            this.txtCMT.Text = c3;
            this.cboGioitinh.Text = c4;
            this.dateTimePickerNS.Text = c5;
            this.txtDiachi.Text = c6;
            this.txtSodienthoai.Text = c7;

        }
        private void btTim_Click(object sender, EventArgs e)
        {
            frmTimKH frm = new frmTimKH();
            frm.truyendl = new frmTimKH.truyendata(ldt);
            frm.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmNguoitiem_Load(object sender, EventArgs e)
        {
            this.cboGioitinh.SelectedIndex = 0;
            //--Gọi hàm Ẩn hiện
            AnHien(false, true, true, true, false, true, false, false);
            //goi hàm danh sach khách hàng
            dskhachhang();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Gọi hàm ẩn hiện
            AnHien(true, false, false, false, false, true, true, true);
            //hàm xoá trắng
            xoatrang();
            //--Giọi hàm tạo mã số khách hàng
            SqlDataReader sdr = cm.getDataStotedProcedure("pr_TAOMSKH");
            if (sdr.Read() == true)
            {
                this.txtMasoKH.Text = sdr.GetString(0).ToString();
            }
            sdr.Close();

        }

        private void btKhongluu_Click(object sender, EventArgs e)
        {
            //--Gọi hàm Ẩn hiện
            AnHien(false, true, true, true, false, true, false, false);
            //Gọi hàm xoatrang
            xoatrang();
        }


        private void btLuu_Click(object sender, EventArgs e)
        {
            if (kiemtra_nhap() != "")
            {
                MessageBox.Show(kiemtra_nhap(), "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                BUS_CDBCustomer cmd = new BUS_CDBCustomer();

                //Gọi hàm tạo dữ liệu khách hàng
                DTO_CDBCustomer dcm = new DTO_CDBCustomer(this.txtMasoKH.Text.Trim().ToString(),
                                                         this.txtHoten.Text.Trim().ToString(),
                                                         this.txtCMT.Text.Trim().ToString(),
                                                         this.cboGioitinh.Text.ToString(),
                                                         string.Format("{0:dd/MM/yyyy}", this.dateTimePickerNS.Value),
                                                         this.txtDiachi.Text.Trim().ToString(),
                                                         this.txtSodienthoai.Text.Trim().ToString());
                //Gọi hàm thêm khách hàng
                cmd.pr_THEMKH(dcm);
                //--Gọi hàm Ẩn hiện
                AnHien(false, true, true, true, false, true, false, false);
                //goi hàm danh sach khách hàng
                dskhachhang();
                //
                xoatrang();
            }

        }

        private void dGridViewNT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                txtMasoKH.Text = dGridViewNT.Rows[numrow].Cells[1].Value.ToString();
                txtHoten.Text = dGridViewNT.Rows[numrow].Cells[2].Value.ToString();
                txtCMT.Text = dGridViewNT.Rows[numrow].Cells[3].Value.ToString();
                //
                if (dGridViewNT.Rows[numrow].Cells[4].Value.ToString().Trim()=="Nam")            
                {
                    //MessageBox.Show("Nam", "Thông báo", MessageBoxButtons.OK);
                    cboGioitinh.SelectedIndex = 0;
                }
                else if(dGridViewNT.Rows[numrow].Cells[4].Value.ToString().Trim() == "Nữ")
                {
                    //MessageBox.Show("Nữ", "Thông báo", MessageBoxButtons.OK);
                    cboGioitinh.SelectedIndex = 1;
                }                
                //
                dateTimePickerNS.Text = dGridViewNT.Rows[numrow].Cells[5].Value.ToString();
                txtDiachi.Text = dGridViewNT.Rows[numrow].Cells[6].Value.ToString();
                txtSodienthoai.Text = dGridViewNT.Rows[numrow].Cells[7].Value.ToString();
                AnHien(false, true, true, true, false, true, false, false);
            }
            catch
            {
                //MessageBox.Show("Bàn Cần click chính xác dòng thông tin khách hàng cần chọn  !!", "thông báo", MessageBoxButtons.OK);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            AnHien(true, false, false, false, true, false, false, false);
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (kiemtra_nhap() != "")
            {
                MessageBox.Show(kiemtra_nhap(), "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                BUS_CDBCustomer cmd = new BUS_CDBCustomer();

                //Gọi hàm tạo dữ liệu khách hàng
                DTO_CDBCustomer dcm = new DTO_CDBCustomer(this.txtMasoKH.Text.Trim().ToString(),
                                                         this.txtHoten.Text.Trim().ToString(),
                                                         this.txtCMT.Text.Trim().Trim().ToString(),
                                                         this.cboGioitinh.Text.ToString(),
                                                         string.Format("{0:dd/MM/yyyy}", this.dateTimePickerNS.Value),
                                                         this.txtDiachi.Text.Trim().ToString(),
                                                         this.txtSodienthoai.Text.Trim().ToString());
                //Gọi hàm thêm khách hàng
                cmd.pr_CAPNHATKH(dcm);
                AnHien(false, true, true, true, false, true, false, false);
                //
                //goi hàm danh sach khách hàng
                dskhachhang();
            }
        }

        private void btKcapnhat_Click(object sender, EventArgs e)
        {
            AnHien(false, true, true, true, false, true, false, false);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            BUS_CDBCustomer bmd = new BUS_CDBCustomer();

            //Gọi hàm tạo dữ liệu khách hàng
            DTO_CDBCustomer dcm = new DTO_CDBCustomer(this.txtMasoKH.Text.Trim().ToString());
            //goi hàm xoá

            bmd.pr_XOAKH(dcm);
            //goi hàm danh sach khách hàng
            dskhachhang();
        }
    }
}


