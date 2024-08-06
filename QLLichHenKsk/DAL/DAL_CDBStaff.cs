using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_CDBStaff
    {
        //Viết hàm gọi Stoted Procedure thêm nhân viên
        public void pr_THEMNV(DTO_CDBStaff sff)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_THEMNV", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 15).Value = sff.MANV;
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 50).Value = sff.TENNV;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NVarChar, 5).Value = sff.PHAI;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = sff.NGAYSINH;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = sff.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = sff.DIENTHOAI;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
            }
        }
        //Viết hàm gọi Stoted Procedure  có tham sô truyền vào
        public SqlDataReader getDataStotedProcedure(string sql, DTO_CDBStaff sff)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 50).Value = sff.TENNV;
                SqlDataReader sdr = cmd.ExecuteReader();
                return sdr;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo", MessageBoxButtons.OK);
                return null;
            }
        }
        //Viết hàm gọi Stoted Procedure xoá nhân viên
        public void pr_XOANV(DTO_CDBStaff sff)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XOANV", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 15).Value = sff.MANV;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
            }
        }
        //Viết hàm gọi Stoted Procedure cập nhật Nhân viên
        public void pr_CAPNHATNV(DTO_CDBStaff sff)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_CAPNHATNV", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 15).Value = sff.MANV;
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 50).Value = sff.TENNV;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NVarChar, 5).Value = sff.PHAI;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = sff.NGAYSINH;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = sff.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = sff.DIENTHOAI;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
            }

        }
    }
}
