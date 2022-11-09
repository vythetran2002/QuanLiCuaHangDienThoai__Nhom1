using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangDienThoai.BS_Layer
{
    class BL_Login
    {
        QLDTDataContext db = new QLDTDataContext();
        public bool Search(string tendangnhap, string matkhau)
        {

            var query = db.TK_DN(tendangnhap, matkhau).SingleOrDefault();
            //DataTable result =   ImportData(query).Tables[0];
            if (query == null)
            {
                return false;
            }
            return true;
        }
        public bool Check_Admin(string tendangnhap, string matkhau)
        {
            string loaitk = db.LOAI_TK(tendangnhap, matkhau);
            if(loaitk.CompareTo("Admin")==0)
            {
                return true;
            }
            return false;
        }
      
    }
}
