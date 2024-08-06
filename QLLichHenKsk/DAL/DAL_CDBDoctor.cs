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
    public class DAL_CDBDoctor
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

        //Viết hàm gọi Stoted Procedure  có tham sô truyền vào
        public SqlDataReader getDataStotedProcedure(string sql, DTO_CDBDoctor dtr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;              
                cmd.Parameters.Add("@TENBS", System.Data.SqlDbType.NVarChar, 50).Value = dtr.TENBS;              
                SqlDataReader sdr = cmd.ExecuteReader();
                return sdr;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo", MessageBoxButtons.OK);
                return null;
            }
        }
        //Viết hàm gọi Stoted Procedure thêm bác sĩ
        public void pr_THEMBS(DTO_CDBDoctor dtr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_THEMBS", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSBS", System.Data.SqlDbType.Char, 15).Value = dtr.MABS;
                cmd.Parameters.Add("@TENBS", System.Data.SqlDbType.NVarChar, 50).Value = dtr.TENBS;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NVarChar, 5).Value = dtr.PHAI;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = dtr.NGAYSINH;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = dtr.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = dtr.DIENTHOAI;
                cmd.Parameters.Add("@TRINHDO", System.Data.SqlDbType.NVarChar, 50).Value = dtr.TRINHDO;
                cmd.Parameters.Add("@KHOA", System.Data.SqlDbType.NVarChar, 50).Value = dtr.KHOA;
                cmd.Parameters.Add("@CHUCVU", System.Data.SqlDbType.NVarChar, 50).Value = dtr.CHUCVU;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
            }
        }
        
        //Viết hàm gọi Stoted Procedure xoá bác sĩ
        public void pr_XOABS(DTO_CDBDoctor dtr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XOABS", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSBS", System.Data.SqlDbType.Char, 15).Value = dtr.MABS;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
            }
        }
        //Viết hàm gọi Stoted Procedure cập nhật bác sĩ
        public void pr_CAPNHATBS(DTO_CDBDoctor dtr)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_CAPNHATBS", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSBS", System.Data.SqlDbType.Char, 15).Value = dtr.MABS;
                cmd.Parameters.Add("@TENBS", System.Data.SqlDbType.NVarChar, 50).Value = dtr.TENBS;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NVarChar, 5).Value = dtr.PHAI;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = dtr.NGAYSINH;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = dtr.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = dtr.DIENTHOAI;
                cmd.Parameters.Add("@TRINHDO", System.Data.SqlDbType.NVarChar, 50).Value = dtr.TRINHDO;
                cmd.Parameters.Add("@KHOA", System.Data.SqlDbType.NVarChar, 50).Value = dtr.KHOA;
                cmd.Parameters.Add("@CHUCVU", System.Data.SqlDbType.NVarChar, 50).Value = dtr.CHUCVU;
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
