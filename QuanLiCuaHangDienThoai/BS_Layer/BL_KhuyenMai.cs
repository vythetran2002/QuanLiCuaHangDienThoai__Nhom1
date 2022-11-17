using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLiCuaHangDienThoai.BS_Layer
{
    class BL_KhuyenMai
    {
        QLDTDataContext db = new QLDTDataContext();
        public string CHECKID_KM()
        {
            int n = db.LAYKM().Count() + 1;
            var query = db.LAYKM();
            string dm = "";
            int i = 1;
            foreach (var j in query)
            {
                if (i < 10)
                {
                    dm = "KM0" + i;
                }
                else { dm = "KM" + i; }

                if (string.Compare(dm, j.maKM) != 0)
                {
                    return dm;
                }
                else { i += 1; continue; }
            }
            if (i < 10)
            {
                dm = "KM0" + i;
            }
            else { dm = "KM" + i; }
            return dm;
        }
        public DataTable TimKM(string thuoctinh, string yeucau)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Khuyến Mãi");
            dt.Columns.Add("Mã Sản Phẩm");
            dt.Columns.Add("Mức Giảm");
            if (thuoctinh != "All")
            {
                if (thuoctinh.CompareTo("Mã Khuyến Mãi") == 0)
                {
                    dt.Clear();
                    var query = db.TIMKM_MaKM(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maKM,x.maSP,x.mucgiam);
                    }
                }

                else if (thuoctinh.CompareTo("Mã Sản Phẩm") == 0)
                {
                    dt.Clear();
                    var query = db.TIMKM_MaSP(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maKM, x.maSP, x.mucgiam);
                    }
                }
                else if (thuoctinh.CompareTo("Mức Giảm") == 0)
                {
                    dt.Clear();
                    var query = db.TIMKM_MucGiam(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maKM, x.maSP, x.mucgiam);
                    }
                }

            }
            else
            {
                dt.Clear();
                var query = db.LAYKM();
                foreach (var x in query)
                {
                    dt.Rows.Add(x.maKM, x.maSP, x.mucgiam);
                }
            }
            return dt;
        }
        public void XoaKM(string maKM)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    db.DELETE_KHUYENMAI(maKM);
                    
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }
    }
}
