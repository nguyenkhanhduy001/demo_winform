using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CDB_PH
    {
        string _MSPH;
        string _MANV;
        string _MSBS;
        string _MSKH;
        string _NGAYLPH;
        string _NOIDUNGKKHAM;
        string _NGAYHEN;
        string _TG;
        public string MSPH { get => _MSPH; set => _MSPH = value; }
        public string MANV { get => _MANV; set => _MANV = value; }
        public string MSBS { get => _MSBS; set => _MSBS = value; }
        public string MSKH { get => _MSKH; set => _MSKH = value; }
        public string NGAYLPH { get => _NGAYLPH; set => _NGAYLPH = value; }
        public string NOIDUNGKKHAM { get => _NOIDUNGKKHAM; set => _NOIDUNGKKHAM = value; }
        public string NGAYHEN { get => _NGAYHEN; set => _NGAYHEN = value; }
        public string TG { get => _TG; set => _TG = value; }


        public  DTO_CDB_PH(){}
        public DTO_CDB_PH(string mph) {
            this.MSPH = mph;
        }
        public DTO_CDB_PH(string mph,string mnv,string mbs,string mkh,string nlph,string ndk,string ngayhen,string tg)
        {
            this.MSPH = mph;
            this.MANV = mnv;
            this.MSBS= mbs;
            this.MSKH = mkh;
            this.NGAYLPH = nlph;
            this.NOIDUNGKKHAM = ndk;
            this.NGAYHEN = ngayhen;
            this.TG = tg;

           
        }

     
    }
}
