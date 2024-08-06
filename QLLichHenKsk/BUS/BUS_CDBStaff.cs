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
    public class BUS_CDBStaff
    {
        DAL_CDBCustomer cmd = new DAL_CDBCustomer();
        DAL_CDBStaff staff = new DAL_CDBStaff();
        //Viết hàm gọi Stoted Procedure tạo MSNV 
        public SqlDataReader getDataStotedProcedure(string sql)
        {
            return cmd.getDataStotedProcedure(sql);
        }
        //Viết hàm gọi Stoted Procedure thêm nhân viên
        public void pr_THEMNV(DTO_CDBStaff sff)
        {
            staff.pr_THEMNV(sff);
        }
        //hàm xoá nhân viên
        public void pr_XOANV(DTO_CDBStaff sff)
        {
            staff.pr_XOANV(sff);
        }
        //hàm cập nhật thông tin nhân viên
        public void pr_CAPNHATNV(DTO_CDBStaff sff)
        {
            staff.pr_CAPNHATNV(sff);
        }
        //Viết hàm gọi Stoted Procedure tim nhan vien
        public SqlDataReader getDataStotedProcedure(string sql, DTO_CDBStaff sff)
        {
            return staff.getDataStotedProcedure(sql, sff);
        }
    }
}
