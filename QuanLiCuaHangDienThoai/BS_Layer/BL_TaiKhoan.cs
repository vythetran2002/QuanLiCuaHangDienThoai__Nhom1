using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangDienThoai.BS_Layer
{
    class BL_TaiKhoan
    {
        QLDTDataContext db = new QLDTDataContext();
        public DataTable TimTK(string thuoctinh, string yeucau)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tài khoản");
            dt.Columns.Add("Tên hiển thị");
            dt.Columns.Add("Mật khẩu");
            dt.Columns.Add("Email");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Ngày Sinh");
            dt.Columns.Add("Loại");
            dt.Columns.Add("Ngày Tạo");
            if (thuoctinh != "All")
            {
                if (thuoctinh.CompareTo("Tài khoản") == 0)
                {
                    dt.Clear();
                    var query = db.TIMTK_TK(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.username, x.mk, x.email, x.ten, x.ngaySinh, x.sdt, x.loai, x.ngayTao);
                    }
                }

                else if (thuoctinh.CompareTo("Email") == 0)
                {
                    dt.Clear();
                    var query = db.TIMTK_EMAIL(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.username, x.mk, x.email, x.ten, x.ngaySinh, x.sdt, x.loai, x.ngayTao);
                    }
                }
                else if (thuoctinh.CompareTo("SĐT") == 0)
                {
                    dt.Clear();
                    var query = db.TIMTK_SDT(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.username, x.mk, x.email, x.ten, x.ngaySinh, x.sdt, x.loai, x.ngayTao);
                    }
                }
                else if (thuoctinh.CompareTo("Loại") == 0)
                {
                    dt.Clear();
                    var query = db.TIMTK_LOAI(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.username, x.mk, x.email, x.ten, x.ngaySinh, x.sdt, x.loai, x.ngayTao);
                    }
                }
            }
            else
            {
                dt.Clear();
                var query = db.LAYTK();
                foreach (var x in query)
                {
                    dt.Rows.Add(x.username, x.mk, x.email, x.ten, x.ngaySinh, x.sdt, x.loai, x.ngayTao);
                }
            }
            return dt;
        }
    }
}
