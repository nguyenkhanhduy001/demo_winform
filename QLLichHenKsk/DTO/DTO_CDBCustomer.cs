using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CDBCustomer
    {
        string _MSKH;
        string _TENKH;
        string _CMT;
        string _PHAI;
        string _NGAYSINH;
        string _DIACHI;
        string _DIENTHOAI;

        public string MSKH { get => _MSKH; set => _MSKH = value; }
        public string TENKH { get => _TENKH; set => _TENKH = value; }
        public string CMT { get => _CMT; set => _CMT = value; }
        public string PHAI { get => _PHAI; set => _PHAI = value; }
        public string NGAYSINH { get => _NGAYSINH; set => _NGAYSINH = value; }
        public string DIACHI { get => _DIACHI; set => _DIACHI = value; }
        public string DIENTHOAI { get => _DIENTHOAI; set => _DIENTHOAI = value; }
        public DTO_CDBCustomer() { }
        public DTO_CDBCustomer(string ms, string ten, string cmt, string phai, string ngaysinh, string diachi, string dt)
        {
            this.MSKH = ms;
            this.TENKH = ten;
            this.CMT = cmt;
            this.PHAI = phai;
            this.NGAYSINH = ngaysinh;
            this.DIACHI = diachi;
            this.DIENTHOAI = dt;
        }
        public DTO_CDBCustomer(string ms, string ten, string cmt, string diachi, string dt)
        {
            this.MSKH = ms;
            this.TENKH = ten;
            this.CMT = cmt;
            this.DIACHI = diachi;
            this.DIENTHOAI = dt;
        }
        public DTO_CDBCustomer(string ms)
        {
            this.MSKH = ms;
        }
    }
}
