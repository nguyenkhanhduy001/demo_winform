using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTiemVacxin
{
    public class GUI_CEnableMenu
    {
        // khai báo biến thuộc frmQuanly 
        private static frmQuanly frmQL = new frmQuanly();
        //viết hàm Main cho tầng GUI
        [STAThread]
        private static void Main() 
        {
            Application.Run(frmQL);
        }
        //Hàm Ẩn hiên Menu
        public void EnableMenu(bool d1, bool d2) 
        {
            //Đăng nhập thành công
            frmQL.mnuHT_HKnoi.Enabled = d1;
            frmQL.mnuHT_Backup.Enabled = d1;

            frmQL.mnuDanhmuc.Enabled = d1;

            frmQL.mnuPhieutiem.Enabled = d1;

            frmQL.mnuTracuu.Enabled = d1;

            frmQL.mnuBaocao.Enabled = d1;
            //Chưa đăng nhập
            frmQL.mnuHT_Dangnhap.Enabled = d2;
            frmQL.mnuHT_Restore.Enabled = d2;

        }
    }
}
