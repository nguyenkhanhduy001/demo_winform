using BUS;
using DTO;
using QLLichHen;
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
    public partial class frmPhieuHen : Form
    {
        public frmPhieuHen()
        {
            InitializeComponent();
        }
        //
        BUS_CDBCustomer cmd = new BUS_CDBCustomer();
        //khai báo 
        DataTable myTable = new DataTable();
        DataRow myRow = null;
        //
        BUS_CDBConnect cn = new BUS_CDBConnect();
        //
        public void xoatrang()
        {
            this.cbKhachHang.Text = "";
            this.cbNhanvien.Text = "";
            this.dateTPiNgayLph.Text = "";
            this.cbGioitinh.Text = "";
            this.txtDiachi.Text = "";
            this.txtDienthoai.Text = "";
            this.cbTenBS.Text = "";
            this.cbTG.SelectedIndex = 0;
            this.cbNDKham.SelectedIndex = 0;

        }
        public void AnHien(bool gr1, bool lpt, bool luu, bool kluu, bool tim, bool inn, bool thoat,bool sua,bool capnhat, bool xoa) 
        {
            this.cbKhachHang.Enabled = gr1;
            this.cbNhanvien.Enabled = gr1;
            this.btTnt.Enabled = gr1;
            this.dateTPiNgayLph.Enabled = gr1;
            this.cbTenBS.Enabled = gr1;
            this.cbTG.Enabled = gr1;
            this.cbNDKham.Enabled= gr1;
            this.dateTimePiNgayhen.Enabled = gr1;
            this.btLapPT.Enabled = lpt;
            this.btLuu.Enabled = luu;
            this.btKhongluu.Enabled = kluu;
            this.btTim.Enabled = tim;
            this.btIn.Enabled = inn;
            this.btThoat.Enabled = thoat;
            this.btnSua.Enabled = sua;
            this.btnCapNhat.Enabled = capnhat;  
            this.btnXoa.Enabled= xoa;
        }

        public void dsphieuhen()
        {
            SqlDataReader sdr = cmd.getDataStotedProcedure("pr_DSPH");
            //Lưới Danh sách khách hàng
            myTable = this.dataSetPH.Tables[0];
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
                myRow[7] = sdr.GetDateTime(6).ToString();
                myRow[8] = sdr.GetString(7).ToString();
                stt += 1;
                myTable.Rows.Add(myRow);
            }
            this.dGridViewPH.DataSource = myTable;
            sdr.Close();

        }

        public void ldt(string c1, string c2, string c3, string c4, string c5, string c6, string c7)
        {
            DataTable myDT = new DataTable();
            myDT = new DataTable();
            cn.GetDataTable(myDT, "SELECT MSKH,TENKH FROM KHACHHANG WHERE MSKH='"+c1+"'");
            this.cbKhachHang.DataSource = myDT;
            this.cbKhachHang.ValueMember = "MSKH";
            this.cbKhachHang.DisplayMember = "TENKH";
            this.cbKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbGioitinh.Text = c4;
            this.txtDienthoai.Text = c7;
            this.txtDiachi.Text = c6;
        }
        public void ldttim(string c1, string c2, string c3, string c4, string c5, string c6, string c7,string c8)
        {
            this.txtMaPH.Text = c1;
            
            DataTable myDT = new DataTable();
            myDT = new DataTable();
            cn.GetDataTable(myDT, "SELECT MSKH,TENKH,PHAI,DIENTHOAI,DIACHI FROM KHACHHANG WHERE TENKH =N'" + c3 + "'");
            this.cbKhachHang.DataSource = myDT;
            this.cbKhachHang.ValueMember = "MSKH";
            this.cbKhachHang.DisplayMember = "TENKH";
            this.cbKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbGioitinh.Text = "PHAI";
            this.txtDienthoai.Text ="DIENTHOAI";
            this.txtDiachi.Text = "DIACHI";
            //
            this.cbNhanvien.Text = c2;
            this.cbTenBS.Text = c4;
            this.cbNDKham.Text = c6;
            this.dateTPiNgayLph.Text = c5;
            this.cbTG.Text= c8;
            this.dateTimePiNgayhen.Text = c7;
            
        }
        BUS_CDBCustomer cm = new BUS_CDBCustomer();
        private void btLapPT_Click(object sender, EventArgs e)
        {
            try
            {
                    xoatrang();
                //gọi hàm đưa đữ liệu lên combobox nhân viền
                DataTable myDT = new DataTable();
                cn.GetDataTable(myDT, "SELECT MANV,TENNV FROM NHANVIEN");
                this.cbNhanvien.DataSource = myDT;
                this.cbNhanvien.ValueMember = "MANV";
                this.cbNhanvien.DisplayMember = "TENNV";
                this.cbNhanvien.DropDownStyle = ComboBoxStyle.DropDownList;
                //gọi hàm đưa đữ liệu lên combobox khách hàng
                myDT = new DataTable();
                cn.GetDataTable(myDT, "SELECT MSKH,TENKH FROM KHACHHANG");
                this.cbKhachHang.DataSource = myDT;
                this.cbKhachHang.ValueMember = "MSKH";
                this.cbKhachHang.DisplayMember = "TENKH";
                this.cbKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;

                //gọi hàm đưa đữ liệu lên combobox bác sĩ
                myDT = new DataTable();
                cn.GetDataTable(myDT, "SELECT MSBS,TENBS FROM BACSI");
                this.cbTenBS.DataSource = myDT;
                this.cbTenBS.ValueMember = "MSBS";
                this.cbTenBS.DisplayMember = "TENBS";
                this.cbTenBS.DropDownStyle = ComboBoxStyle.DropDownList;
                //load dl khách hàng
                myDT = new DataTable();
                cn.GetDataTable(myDT, "SELECT PHAI,DIENTHOAI,DIACHI FROM KHACHHANG WHERE MSKH='" +
                                this.cbKhachHang.SelectedValue.ToString() + "'");
                this.cbGioitinh.Text = myDT.Rows[0][0].ToString();
                this.txtDienthoai.Text = myDT.Rows[0][1].ToString();
                this.txtDiachi.Text = myDT.Rows[0][2].ToString();
                ////
         
                ///
                SqlDataReader sdr = cm.getDataStotedProcedure("pr_TAOMAPH");
                if (sdr.Read() == true)
                {
                    this.txtMaPH.Text = sdr.GetString(0).ToString();
                }
                sdr.Close();
                //
                AnHien(true, false, true, true, false, false, true,false,false,false);
                //
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!", MessageBoxButtons.OK);
            }
           
        }

        private void frmPhieutiem_Load(object sender, EventArgs e)
        {
            AnHien(false, true, false, false, true, true, true,false,false,false);
            dsphieuhen();
        }

        private void btKhongluu_Click(object sender, EventArgs e)
        {
           
            AnHien(false, true, false, false, true, true, true,false,false,false);
            xoatrang();
            this.cbTG.SelectedIndex = 0;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTnt_Click(object sender, EventArgs e)
        {
            frmTimKH frm = new frmTimKH();
            frm.truyendl = new frmTimKH.truyendata(ldt);
            frm.ShowDialog();
        }

        private void cbNguoitiem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //load dl khách hàng
                DataTable myDT = new DataTable();
                cn.GetDataTable(myDT, "SELECT PHAI,DIENTHOAI,DIACHI FROM KHACHHANG WHERE MSKH='" +
                                this.cbKhachHang.SelectedValue.ToString() + "'");
                this.cbGioitinh.Text = myDT.Rows[0][0].ToString();
                this.txtDienthoai.Text = myDT.Rows[0][1].ToString();
                this.txtDiachi.Text = myDT.Rows[0][2].ToString();
                this.cbTG.SelectedIndex = 0;
                //
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!", MessageBoxButtons.OK);
            }
        }
        private void btLuu_Click(object sender, EventArgs e)
        {      
            BUS_CDB_PH bpt = new BUS_CDB_PH();

            //Gọi hàm tạo dữ liệu khách hàng
            DTO_CDB_PH dpt = new DTO_CDB_PH(this.txtMaPH.Text.Trim().ToString(),
                                            this.cbNhanvien.SelectedValue.ToString(),
                                            this.cbTenBS.SelectedValue.ToString(),
                                            this.cbKhachHang.SelectedValue.ToString(),
                                            string.Format("{0:dd/MM/yyyy}", this.dateTPiNgayLph.Value),
                                            this.cbNDKham.Text.Trim().ToString(),
                                            string.Format("{0:dd/MM/yyyy}", this.dateTimePiNgayhen.Value),
                                            this.cbTG.Text.Trim().ToString());

            //Gọi hàm thêm khách hàng
            try {
                bpt.pr_THEMPH(dpt);
                //--Gọi hàm Ẩn hiện
                AnHien(false, true, false, false, true, true, true,false,false,false);
                //goi hàm danh sach khách hàng
                dsphieuhen();
                //
                xoatrang();
            }
            catch(Exception x)
            {
                MessageBox.Show("!!!!", "Thông báo !", MessageBoxButtons.OK);
            }
               
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            frmTimphieuhen frm = new frmTimphieuhen();
            frm.truyendl2 = new frmTimphieuhen.truyendata2(ldttim);
            frm.ShowDialog();
            AnHien(false, true, false, false, true, true, true, true, false, true);
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            frmInPH frm = new frmInPH();
            frm.Show();
        }

        private void dGridViewPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //gọi hàm đưa đữ liệu lên combobox nhân viền
            DataTable myDT = new DataTable();
            cn.GetDataTable(myDT, "SELECT MANV,TENNV FROM NHANVIEN");
            this.cbNhanvien.DataSource = myDT;
            this.cbNhanvien.ValueMember = "MANV";
            this.cbNhanvien.DisplayMember = "TENNV";
            this.cbNhanvien.DropDownStyle = ComboBoxStyle.DropDownList;
            //gọi hàm đưa đữ liệu lên combobox khách hàng
            myDT = new DataTable();
            cn.GetDataTable(myDT, "SELECT MSKH,TENKH FROM KHACHHANG");
            this.cbKhachHang.DataSource = myDT;
            this.cbKhachHang.ValueMember = "MSKH";
            this.cbKhachHang.DisplayMember = "TENKH";
            this.cbKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;

            //gọi hàm đưa đữ liệu lên combobox bác sĩ
            myDT = new DataTable();
            cn.GetDataTable(myDT, "SELECT MSBS,TENBS FROM BACSI");
            this.cbTenBS.DataSource = myDT;
            this.cbTenBS.ValueMember = "MSBS";
            this.cbTenBS.DisplayMember = "TENBS";
            this.cbTenBS.DropDownStyle = ComboBoxStyle.DropDownList;
            //load dl khách hàng
            myDT = new DataTable();
            cn.GetDataTable(myDT, "SELECT PHAI,DIENTHOAI,DIACHI FROM KHACHHANG WHERE MSKH='" +
                            this.cbKhachHang.SelectedValue.ToString() + "'");
            this.cbGioitinh.Text = myDT.Rows[0][0].ToString();
            this.txtDienthoai.Text = myDT.Rows[0][1].ToString();
            this.txtDiachi.Text = myDT.Rows[0][2].ToString();
            // 
            int numrow;
                numrow = e.RowIndex;
                txtMaPH.Text = dGridViewPH.Rows[numrow].Cells[1].Value.ToString();         
                cbNhanvien.Text = dGridViewPH.Rows[numrow].Cells[2].Value.ToString();
                cbTenBS.Text = dGridViewPH.Rows[numrow].Cells[3].Value.ToString();          
                cbKhachHang.Text = dGridViewPH.Rows[numrow].Cells[4].Value.ToString();
            //
            
                myDT = new DataTable();
                cn.GetDataTable(myDT, "SELECT PHAI,DIENTHOAI,DIACHI FROM KHACHHANG WHERE MSKH='" +
                                this.cbKhachHang.SelectedValue.ToString() + "'");
                this.cbGioitinh.Text = myDT.Rows[0][0].ToString();
                this.txtDienthoai.Text = myDT.Rows[0][1].ToString();
                this.txtDiachi.Text = myDT.Rows[0][2].ToString();
                //
                dateTPiNgayLph.Text = dGridViewPH.Rows[numrow].Cells[5].Value.ToString();
                cbNDKham.Text = dGridViewPH.Rows[numrow].Cells[6].Value.ToString();
                dateTimePiNgayhen.Text = dGridViewPH.Rows[numrow].Cells[7].Value.ToString();
                cbTG.Text = dGridViewPH.Rows[numrow].Cells[8].Value.ToString();
            AnHien(false,true,false,false,true,true,true,true,false,true);
    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            AnHien(true,false,false,true,false,false,true,false,true,false);

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BUS_CDB_PH bpt = new BUS_CDB_PH();

            //Gọi hàm tạo dữ liệu khách hàng
            DTO_CDB_PH dpt = new DTO_CDB_PH(this.txtMaPH.Text.Trim().ToString(),
                                            this.cbNhanvien.SelectedValue.ToString(),
                                            this.cbTenBS.SelectedValue.ToString(),
                                            this.cbKhachHang.SelectedValue.ToString(),
                                            string.Format("{0:dd/MM/yyyy}", this.dateTPiNgayLph.Value),
                                            this.cbNDKham.Text.Trim().ToString(),
                                            string.Format("{0:dd/MM/yyyy}", this.dateTimePiNgayhen.Value),
                                            this.cbTG.Text.Trim().ToString());

            //Gọi hàm cập nhật khách hàng
            try
            {
                bpt.pr_CAPNHATPH(dpt);
                //--Gọi hàm Ẩn hiện
                AnHien(false, true, false, false, true, true, true, false, false, false);
                //goi hàm danh sach khách hàng
                dsphieuhen();
                //
                xoatrang();
            }
            catch (Exception x)
            {
                MessageBox.Show("!!!!", "Thông báo !", MessageBoxButtons.OK);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_CDB_PH bph = new BUS_CDB_PH();

            //Gọi hàm tạo dữ liệu phiếu hẹn
            DTO_CDB_PH xph = new DTO_CDB_PH(this.txtMaPH.Text.Trim().ToString());
            //goi hàm xoá

            bph.pr_XOAPH(xph);
            //goi hàm danh sach phiếu hẹn
            
            dsphieuhen();
            //
            AnHien(false, true, false, false, true, true, true, false, false, false);
            xoatrang();
        }
    }
    }

