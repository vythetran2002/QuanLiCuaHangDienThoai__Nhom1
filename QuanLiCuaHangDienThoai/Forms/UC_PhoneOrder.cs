using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangDienThoai.Forms
{
    public partial class UC_PhoneOrder : UserControl
    {
        public UC_PhoneOrder()
        {
            InitializeComponent();
        }

        public UC_PhoneOrder(string maHD, string maSP)
        {
            QLDTDataContext q = new QLDTDataContext();
            var query = (from item in q.HOADONCHITIETs
                         join item2 in q.SANPHAMs on item.maSP equals item2.maSP
                         where item.maHD == maHD && item.maSP == maSP
                         select new
                         {
                             maSP=item.maSP,
                             maHD=item.maHD,
                             tenSP=item2.tenSP,
                             gia=item2.gia,
                             sl=item.soLuong,
                             anh=item2.hinhAnh
                         }).SingleOrDefault();

            lb_TenSP.Text = query.tenSP;
            numericUpDown1.Value = int.Parse(query.sl.ToString());
            lb_ThanhTien.Text=(int.Parse(query.gia.ToString())* int.Parse(query.sl.ToString())).ToString();

            //pictureBox1.Image=
        }    
    }
}
