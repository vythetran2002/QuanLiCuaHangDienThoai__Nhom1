using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangDienThoai.BS_Layer
{
    class BL_HDCT
    {
        QLDTDataContext db = new QLDTDataContext();
        public int CheckID_HDCT()
        {
            int n = db.LAYHD().Count();
            var query = db.LAYHD();
            int i = 1;
            foreach (var j in query)
            {
                if (j.maHD != i)
                {
                    return i;
                }
                else { i += 1; continue; }
            }

            return n + 1;
        }
    }
}
