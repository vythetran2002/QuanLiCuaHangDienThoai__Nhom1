using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangDienThoai.BS_Layer
{
    class BL_HDCT
    {
        QLDTDataContext db = new QLDTDataContext();
       
        public void XoaDHCT(String maHD)
        {
            if (maHD != null || maHD != "")
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa hoá đơn này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    var query = from item in db.HOADONCHITIETs
                                where item.maHD.ToString() == maHD
                                select item;
                    foreach (var item in query)
                    {
                        db.XOAHDCT(item.maHD, item.maSP);
                    }
                    db.XOAHD(Convert.ToInt32(maHD));
                    MessageBox.Show("Xóa thành công!");


                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
        }
    }
}
