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
    public class DAL_CDBCustomer
    {
        //Viết hàm gọi Stoted Procedure không có tham sô truyền vào
        public SqlDataReader getDataStotedProcedure(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();
                return sdr;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
                return null;
            }
        }
        //Viết hàm gọi Stoted Procedure thêm khách hàng
        public void pr_THEMKH(DTO_CDBCustomer cm)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_THEMKH", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 15).Value = cm.MSKH;
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 50).Value = cm.TENKH;
                cmd.Parameters.Add("@CMT", System.Data.SqlDbType.VarChar, 10).Value = cm.CMT;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NVarChar, 5).Value = cm.PHAI;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = cm.NGAYSINH;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = cm.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = cm.DIENTHOAI;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
            }
        }
        //Viết hàm gọi Stoted Procedure  có tham sô truyền vào
        public SqlDataReader getDataStotedProcedure(string sql, DTO_CDBCustomer dcm)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 15).Value = dcm.MSKH;
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 50).Value = dcm.TENKH;
                cmd.Parameters.Add("@CMT", System.Data.SqlDbType.VarChar, 10).Value = dcm.CMT;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = dcm.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = dcm.DIENTHOAI;
                SqlDataReader sdr = cmd.ExecuteReader();
                return sdr;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo", MessageBoxButtons.OK);
                return null;
            }
        }
        //Viết hàm gọi Stoted Procedure xoá khách hàng
        public void pr_XOAKH(DTO_CDBCustomer cm)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XOAKH", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 15).Value = cm.MSKH;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
            }
        }
        //Viết hàm gọi Stoted Procedure cập nhật khách hàng
        public void pr_CAPNHATKH(DTO_CDBCustomer cm)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_CAPNHATKH", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 15).Value = cm.MSKH;
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 50).Value = cm.TENKH;
                cmd.Parameters.Add("@CMT", System.Data.SqlDbType.VarChar, 10).Value = cm.CMT;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NVarChar, 5).Value = cm.PHAI;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = cm.NGAYSINH;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = cm.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = cm.DIENTHOAI;
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
