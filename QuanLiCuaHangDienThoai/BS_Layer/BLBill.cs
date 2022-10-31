using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLiCuaHangDienThoai.BS_Layer
{
    internal class BLBill
    {
        public System.Data.Linq.Table<HOADON> LayHoaDon()
        {
            QLDTDataContext q = new QLDTDataContext();
            return q.HOADONs;
        }


    }
}
