using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangDienThoai.BS_Layer
{
    class BL_NCC
    {
        QLDTDataContext db = new QLDTDataContext();
        public string CHECKID_NCC()
        {
            int n = db.LAYNCC().Count() + 1;
            var query = db.LAYNCC();
            string ncc = "";
            int i = 1;
            foreach (var j in query)
            {
                if (i < 10)
                {
                    ncc = "NCC0" + i;
                }
                else { ncc = "NCC" + i; }

                if (string.Compare(ncc, j.maNCC) != 0)
                {
                    return ncc;
                }
                else { i += 1; continue; }
            }
            if (i < 10)
            {
                ncc = "NCC0" + i;
            }
            else { ncc = "NCC" + i; }
            return ncc;
        }
        public DataTable TimNCC(string thuoctinh, string yeucau)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã NCC");
            dt.Columns.Add("Tên NCC");
            if (thuoctinh != "All")
            {
                if (thuoctinh.CompareTo("Tên NCC") == 0)
                {
                    dt.Clear();
                    var query = db.TIMNCC_TENNCC(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maNCC,x.tenNCC);
                    }
                }

                else if (thuoctinh.CompareTo("Mã NCC") == 0)
                {
                    dt.Clear();
                    var query = db.TIMNCC_MANCC(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maNCC,x.tenNCC);
                    }
                }

            }
            else
            {
                dt.Clear();
                var query = db.LAYNCC();
                foreach (var x in query)
                {
                    dt.Rows.Add(x.maNCC,x.tenNCC);
                }
            }
            return dt;
        }
    }
}
