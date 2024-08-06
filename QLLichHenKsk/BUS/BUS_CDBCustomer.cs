using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CDBCustomer
    {
        //khai báo biến thuôc DAL_CDBCustomer của tầng DAL
        DAL_CDBCustomer cm = new DAL_CDBCustomer();
        //Viết hàm gọi Stoted Procedure tạo MSKH 
        public SqlDataReader getDataStotedProcedure(string sql)
        {
            return cm.getDataStotedProcedure(sql);
        }
        //Viết hàm gọi Stoted Procedure Thêm Người tiêm
        public void pr_THEMKH(DTO_CDBCustomer dcm)
        {
            cm.pr_THEMKH(dcm);
        }
        //hàm tiêm người tiêm
        public SqlDataReader getDataStotedProcedure(string sql, DTO_CDBCustomer dcm)
        {
            return cm.getDataStotedProcedure(sql, dcm);
        }
        //Viết hàm gọi hàm xoá
        public void pr_XOAKH(DTO_CDBCustomer dcm)
        {
            cm.pr_XOAKH(dcm);
        }
        //Viết hàm cập nhật người tiêm
        public void pr_CAPNHATKH(DTO_CDBCustomer dcm)
        {
            cm.pr_CAPNHATKH(dcm);
        }
    }
}
