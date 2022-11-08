using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangDienThoai.BS_Layer
{
    class BL_DanhMuc
    {
        QLDTDataContext db = new QLDTDataContext();
         public string CHECKID_DM()
        {
            int n = db.LayDM().Count() + 1;
            var query = db.LayDM();
            string dm = "";
            int i = 1;
            foreach (var j in query)
            {
                if (i < 10)
                {
                    dm = "DM0" + i;
                }
                else { dm = "DM" + i; }

                if (string.Compare(dm, j.maDM) != 0)
                {
                    return dm;
                }
                else { i += 1; continue; }
            }
            if (i < 10)
            {
                dm = "DM0" + i;
            }
            else { dm = "DM" + i; }
            return dm;
        }
        public DataTable TimDM(string thuoctinh, string yeucau)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã DM");
            dt.Columns.Add("Tên DM");
            if (thuoctinh != "All")
            {
                if (thuoctinh.CompareTo("Tên DM") == 0)
                {
                    dt.Clear();
                    var query = db.TIMDM_TENDM(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maDM,x.tenDM);
                    }
                }

                else if (thuoctinh.CompareTo("Mã DM") == 0)
                {
                    dt.Clear();
                    var query = db.TIMDM_MADM(yeucau);
                    foreach (var x in query)
                    {
                        dt.Rows.Add(x.maDM, x.tenDM);
                    }
                }
                
            }
            else
            {
                dt.Clear();
                var query = db.LayDM();
                foreach (var x in query)
                {
                    dt.Rows.Add(x.maDM, x.tenDM);
                }
            }
            return dt;
        }
    }
}
