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

        string masp;
        string mahd;
        string gia;

        public UC_PhoneOrder(string maHD, string maSP)
        {
            InitializeComponent();
            QLDTDataContext q = new QLDTDataContext();
            var query = (from item in q.HOADONCHITIETs
                         join item2 in q.SANPHAMs on item.maSP equals item2.maSP
                         where item.maHD.ToString() == maHD && item.maSP == maSP
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
            this.mahd = query.maHD.ToString();
            this.masp = query.maSP;
            this.gia = query.gia.ToString();
            //pictureBox1.Image=
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            QLDTDataContext q = new QLDTDataContext();
            var query = (from item in q.HOADONCHITIETs
                         where item.maHD.ToString() == mahd && item.maSP == masp
                         select item).SingleOrDefault();
            if(query!=null)
            {
                query.soLuong = Convert.ToInt32(numericUpDown1.Value);
                q.SubmitChanges();
            }    

        }
    }
}
