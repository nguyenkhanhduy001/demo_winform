using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CDBDoctor
    {
        string _MABS;
        string _TENBS;
        string _PHAI;
        string _NGAYSINH;
        string _DIACHI;
        string _DIENTHOAI;
        string _TRINHDO;
        string _KHOA;
        string _CHUCVU;


        public string MABS { get => _MABS; set => _MABS = value; }
        public string TENBS { get => _TENBS; set => _TENBS = value; }
        public string PHAI { get => _PHAI; set => _PHAI = value; }
        public string NGAYSINH { get => _NGAYSINH; set => _NGAYSINH = value; }
        public string DIACHI { get => _DIACHI; set => _DIACHI = value; }
        public string DIENTHOAI { get => _DIENTHOAI; set => _DIENTHOAI = value; }
        public string TRINHDO { get => _TRINHDO; set => _TRINHDO = value; }
        public string KHOA { get => _KHOA; set => _KHOA = value; }
        public string CHUCVU { get => _CHUCVU; set => _CHUCVU = value; }

        public DTO_CDBDoctor() { }
        public DTO_CDBDoctor(string ten)
        {
            this.TENBS = ten;
        }
        public DTO_CDBDoctor(string ms, string ten, string phai, string ns, string diachi, string dt,
                             string trinhdo, string khoa, string chucvu)
        {
            this.MABS = ms;
            this.TENBS = ten;
            this.PHAI = phai;
            this.NGAYSINH = ns;
            this.DIACHI = diachi;
            this.DIENTHOAI = dt;
            this.TRINHDO = trinhdo;
            this.KHOA = khoa;
            this.CHUCVU = chucvu;
        }
     
    }
}
