using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CDBConnect
    {
        //tạo các properties
        private string _Servername;
        private string _Database;
        private string _UserId;
        private string _Password;

        public string Servername { get => _Servername; set => _Servername = value; }
        public string Database { get => _Database; set => _Database = value; }
        public string UserId { get => _UserId; set => _UserId = value; }
        public string Password { get => _Password; set => _Password = value; }

        //hàm khởi tạo constructor không có tham số
        public DTO_CDBConnect() { }

        //hàm khởi tạo constructor có tham số
        public DTO_CDBConnect(string sv, string db, string id, string pw)
        {
            this.Servername = sv;
            this.Database = db;
            this.UserId = id;
            this.Password = pw;
        }

    }
}
