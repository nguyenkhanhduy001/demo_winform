using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CDB_PH
    {
        DAL_CDB_PH dpt = new DAL_CDB_PH();
        public DataSet getDataStotedProcedure(DataSet DSet, string sql, string tablename)
        {
            return dpt.getDataStotedProcedure(DSet,sql,tablename);
        }

        public void pr_THEMPH(DTO_CDB_PH pt) 
        {
            dpt.pr_THEMPH(pt);
        }
        public void pr_CAPNHATPH(DTO_CDB_PH pt)
        {
            dpt.pr_CAPNHATKH(pt);
        }
        public void pr_XOAPH(DTO_CDB_PH pt)
        {
            dpt.pr_XOAPH(pt);
        }
    }
}
