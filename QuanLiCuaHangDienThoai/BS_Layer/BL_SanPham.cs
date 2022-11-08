using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Linq;
using System.Windows.Forms;
namespace QuanLiCuaHangDienThoai.BS_Layer
{
    internal class BL_SanPham
    {
        QLDTDataContext db = new QLDTDataContext();
        public string CHECKID_SP()
        {
            int n = db.LAYSP().Count() + 1;
            var query = db.LAYSP();
            string sp = "";
            int i = 1;
            foreach (var j in query)
            {
                if (i < 10)
                {
                    sp = "SP0" + i;
                }
                else { sp = "SP" + i; }

                if (string.Compare(sp, j.maSP) != 0)
                {
                    return sp;
                }
                else { i += 1; continue; }
            }
            if (i < 10)
            {
                sp = "SP0" + i;
            }
            else
            { sp = "SP" + i; }
            return sp;
        }
        public bool CheckSpInHd(string maHD, string maSP)
        {
            /*   QLDTDataContext q = new QLDTDataContext();

               var query = from item in q.HOADONCHITIETs
                           where maHD == item.maHD.ToString() && maSP == item.maSP
                           select item;*/

            if (db.CHECK_SP_HD(maHD, maSP).Count() == 0) return false;
            else
            {
                MessageBox.Show("Sản phẩm đã có trong hđ");
                return true;
            }
        }
        public string HinhAnh(string maSP)
        {
            string hinhanh;
            if (String.IsNullOrEmpty(db.HinhAnh(maSP)))
            {
                hinhanh = "PhoneNull.jpg";
            }
            else
            {
                hinhanh = db.HinhAnh(maSP);
            }
            return hinhanh;

        }
        public DataTable TimSP(string thuoctinh, string yeucau)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã SP");
            dt.Columns.Add("Tên SP");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Hình Ảnh");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Mã Danh Mục");
            dt.Columns.Add("Mã NCC");
            if (thuoctinh != "All")
            {
                if (thuoctinh.CompareTo("Tên SP") == 0)
                {
                    dt.Clear();
                    var query = db.TIMSP_TEN(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maSP, x.tenSP, x.gia, x.hinhAnh, x.soLuong, x.maDM, x.maNCC);
                    }
                }

                else if (thuoctinh.CompareTo("Mã SP") == 0)
                {
                    dt.Clear();
                    var query = db.TIMSP_MASP(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maSP, x.tenSP, x.gia, x.hinhAnh, x.soLuong, x.maDM, x.maNCC);
                    }
                }
                else if (thuoctinh.CompareTo("Mã DM") == 0)
                {
                    dt.Clear();
                    var query = db.TIMSP_MADM(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maSP, x.tenSP, x.gia, x.hinhAnh, x.soLuong, x.maDM, x.maNCC);
                    }
                }
                else if (thuoctinh.CompareTo("Mã NCC") == 0)
                {
                    dt.Clear();
                    var query = db.TIMSP_MANCC(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maSP, x.tenSP, x.gia, x.hinhAnh, x.soLuong, x.maDM, x.maNCC);
                    }
                }
            }
            else
            {
                dt.Clear();
                var query = db.LAYSP();
                foreach (var x in query)
                {
                    dt.Rows.Add(x.maSP, x.tenSP, x.gia, x.hinhAnh, x.soLuong, x.maDM, x.maNCC);
                }
            }
            return dt;
        } 
    }
}
