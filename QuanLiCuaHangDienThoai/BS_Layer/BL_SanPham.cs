using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Linq;

namespace QuanLiCuaHangDienThoai.BS_Layer
{
    internal class BL_SanPham
    {
        public System.Data.Linq.Table<SANPHAM> DSSanPham()
        {
            QLDTDataContext q = new QLDTDataContext();
            return q.SANPHAMs;
        }
    }
}
