using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_CDBConnect
    {
        //1. khai báo biến thuộc lớp DAL_CDBConnect của tầng DAL
        DAL_CDBConnect conn = new DAL_CDBConnect();
        //2. Gọi hàm Kết nối 
        public bool DBConnect(DTO_CDBConnect lg)
        {
            return conn.DBConnect(lg);
        }
        //3.Giọi hàm huy kết nối
        public bool DisDBConnect()
        {
            return conn.DisDBConnect();
        }
        //4.Viết hàm đưa dữ liệu vào  tra ra Datatable
        public DataTable GetDataTable(DataTable dt, string sql)
        {
            return conn.GetDataTable(dt, sql);
        }
        //5.Viết hàm stored procedue Backup dữ liệu
        public void pr_Backup(string pr, string databasename, string filename)
        {
            conn.pr_Backup(pr, databasename, filename);
        }
        //5.Viết hàm stored procedue Restore dữ liệu
        public void Restore_DB(DTO_CDBConnect lg, string filename)
        {
            conn.Restore_DB(lg, filename);
        }
    }
}
