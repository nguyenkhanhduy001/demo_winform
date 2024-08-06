using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_CDBConnect
    {
        //1.Viết biến thuộc lơp SqlConnection để kết nối CSDL
        public static SqlConnection myconn = null;
        //2.Viết hàm Kết nối CSDL
        public bool DBConnect(DTO_CDBConnect lg)
        {
            try
            {
                myconn = new SqlConnection("Data Source =" + lg.Servername +
                                           "; Initial Catalog =" + lg.Database +
                                           "; User ID =" + lg.UserId +
                                           "; Password =" + lg.Password);
                myconn.Open();
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!", MessageBoxButtons.OK);
                return false;
            }
        }
        //3.Viết hàm Huỷ kết nối CSDL
        public bool DisDBConnect()
        {
            try
            {
                if (myconn.State == System.Data.ConnectionState.Open)
                    myconn.Close();
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Thông báo!", MessageBoxButtons.OK);
                return false;
            }
        }
        //4.Viết hàm đưa dữ liệu vào  tra ra Datatable
        public DataTable GetDataTable(DataTable dt, string sql)
        {
            try
            {
                SqlDataAdapter sqlAD = new SqlDataAdapter(sql, DAL_CDBConnect.myconn);
                sqlAD.Fill(dt);
                return dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo !", MessageBoxButtons.OK);
                return null;
            }
        }
        // 5.Viết hàm stored procedue Backup  dữ liệu
        public void pr_Backup(string pr, string databasename, string filename)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.CommandText = "USE QLLichHen";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = DAL_CDBConnect.myconn;
                cmd.ExecuteNonQuery();

                //
                cmd = new SqlCommand(pr, DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TEN_DATABASE", SqlDbType.NVarChar, 30).Value = databasename;
                cmd.Parameters.Add("@TEN_TAPTIN", SqlDbType.NVarChar, 200).Value = filename;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "Thông báo!!", MessageBoxButtons.OK);

            }
        }
        // 5.Viết hàm stored procedue Restore  dữ liệu
        public void Restore_DB(DTO_CDBConnect lg, string filename)
        {
            try
            {
                myconn = new SqlConnection("Data Source =" + lg.Servername +
                                           "; Initial Catalog = MASTER" +
                                           "; User ID =" + lg.UserId +
                                           "; Password =" + lg.Password);
                myconn.Open();
                //
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.CommandText = "USE MASTER";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = DAL_CDBConnect.myconn;
                cmd.ExecuteNonQuery();

                //
                cmd = new SqlCommand();
                cmd.Parameters.Clear();
                cmd.Connection = DAL_CDBConnect.myconn;
                cmd.CommandText = "IF EXISTS(SELECT NAME FROM SYSDATABASES WHERE NAME= 'QLLichHen') " +
                                  "GO" + " DROP DATABASE QLLichHen";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                //
                cmd = new SqlCommand("GO"+"pr_RESTORE", DAL_CDBConnect.myconn);
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TEN_DATABASE", SqlDbType.NVarChar, 30).Value = lg.Database;
                cmd.Parameters.Add("@TEN_TAPTIN", SqlDbType.NVarChar, 200).Value = filename;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                myconn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString()+"aaaaa", "Thông báo!", MessageBoxButtons.OK);

            }
        }
    }
}
