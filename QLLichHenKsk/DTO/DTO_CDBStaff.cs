using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CDBStaff
    {
        string _MANV;
        string _TENNV;
        string _PHAI;
        string _NGAYSINH;
        string _DIACHI;
        string _DIENTHOAI;

        public string MANV { get => _MANV; set => _MANV = value; }
        public string TENNV { get => _TENNV; set => _TENNV = value; }
        public string PHAI { get => _PHAI; set => _PHAI = value; }
        public string NGAYSINH { get => _NGAYSINH; set => _NGAYSINH = value; }
        public string DIACHI { get => _DIACHI; set => _DIACHI = value; }
        public string DIENTHOAI { get => _DIENTHOAI; set => _DIENTHOAI = value; }

        public DTO_CDBStaff() { }
        public DTO_CDBStaff(string hoten)
        {
            this.TENNV = hoten;
        }
        public DTO_CDBStaff(string ms, string ten, string phai, string ngaysinh, string diachi, string dt)
        {
            this.MANV = ms;
            this.TENNV = ten;
            this.PHAI = phai;
            this.NGAYSINH = ngaysinh;
            this.DIACHI = diachi;
            this.DIENTHOAI = dt;
        }
    }
}
