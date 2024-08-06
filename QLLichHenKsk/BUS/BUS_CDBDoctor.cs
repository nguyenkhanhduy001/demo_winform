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
    public class BUS_CDBDoctor
    {
        //khai báo biến thuôc DAL_CDBDoctor của tầng DAL
        DAL_CDBDoctor dtr = new DAL_CDBDoctor();
        public SqlDataReader getDataStotedProcedure(string sql, DTO_CDBDoctor drr)
        {
            return dtr.getDataStotedProcedure(sql, drr);
        }
        //Viết hàm gọi Stoted Procedure tạo MSBS 
        public SqlDataReader getDataStotedProcedure(string sql)
        {
            return dtr.getDataStotedProcedure(sql);
        }
        //Viết hàm gọi Stoted Procedure Thêm bác sĩ
        public void pr_THEMBS(DTO_CDBDoctor dtrr)
        {
            dtr.pr_THEMBS(dtrr);
        }
        //hàm tìm người bác sĩ

        //Viết hàm gọi hàm xoá
        public void pr_XOABS(DTO_CDBDoctor dtrr)
        {
            dtr.pr_XOABS(dtrr);
        }
        //Viết hàm cập nhật người tiêm
        public void pr_CAPNHATBS(DTO_CDBDoctor dtrr)
        {
            dtr.pr_CAPNHATBS(dtrr);
        }
    }
}