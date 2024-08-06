using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_CDB_PH
    {
        
        //Viết hàm gọi Stoted Procedure  tra ra dataset
        public DataSet getDataStotedProcedure(DataSet DSet, string sql, string tablename)
        {
            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter(sql, DAL_CDBConnect.myconn);
                sqlDA.Fill(DSet, tablename);
                return DSet;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
                return null;
            }
          
        }
        //Viết hàm gọi Stoted Procedure thêm Phiếu tiêm
        public void pr_THEMPH(DTO_CDB_PH pt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_THEMPH", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSPH", System.Data.SqlDbType.Char, 15).Value = pt.MSPH;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 15).Value = pt.MANV;
                cmd.Parameters.Add("@MSBS", System.Data.SqlDbType.Char, 15).Value = pt.MSBS;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 15).Value = pt.MSKH;
                cmd.Parameters.Add("@NGAYLPH", System.Data.SqlDbType.DateTime).Value = pt.NGAYLPH;
                cmd.Parameters.Add("@NOIDUNGKHAM", System.Data.SqlDbType.NVarChar, 50).Value = pt.NOIDUNGKKHAM;
                cmd.Parameters.Add("@NGAYHEN", System.Data.SqlDbType.DateTime).Value = pt.NGAYHEN;
                cmd.Parameters.Add("@TG", System.Data.SqlDbType.NVarChar, 20).Value = pt.TG;
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
            }
        }
        //
        //Viết hàm gọi Stoted Procedure xoá phiếu hẹn
        public void pr_XOAPH(DTO_CDB_PH pt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XOAPH", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSPH", System.Data.SqlDbType.Char, 15).Value = pt.MSPH;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo", MessageBoxButtons.OK);
            }
        }
        //Viết hàm gọi Stoted Procedure cập nhật phiếu hẹn
        public void pr_CAPNHATKH(DTO_CDB_PH pt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_CAPNHATPH", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSPH", System.Data.SqlDbType.Char, 15).Value = pt.MSPH;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 15).Value = pt.MANV;
                cmd.Parameters.Add("@MSBS", System.Data.SqlDbType.Char, 15).Value = pt.MSBS;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 15).Value = pt.MSKH;
                cmd.Parameters.Add("@NGAYLPH", System.Data.SqlDbType.DateTime).Value = pt.NGAYLPH;
                cmd.Parameters.Add("@NOIDUNGKHAM", System.Data.SqlDbType.NVarChar, 50).Value = pt.NOIDUNGKKHAM;
                cmd.Parameters.Add("@NGAYHEN", System.Data.SqlDbType.DateTime).Value = pt.NGAYHEN;
                cmd.Parameters.Add("@TG", System.Data.SqlDbType.NVarChar, 20).Value = pt.TG;

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
