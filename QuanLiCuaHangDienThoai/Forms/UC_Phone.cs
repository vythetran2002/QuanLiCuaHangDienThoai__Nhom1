using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCuaHangDienThoai.BS_Layer;

namespace QuanLiCuaHangDienThoai.Forms
{
    public partial class UC_Phone : UserControl
    {

        public UC_Phone()
        {
            InitializeComponent();
        }
        string msp;
        public UC_Phone(string maSP)
        {
            InitializeComponent();
            QLDTDataContext q = new QLDTDataContext();
           /* var query = (from item in q.SANPHAMs
                         where item.maSP == maSP.Trim()
                         select item).SingleOrDefault();

            lb_TenSP.Text = query.tenSP.ToString();
            lb_Gia.Text = query.gia.ToString();*/
            this.msp = maSP;
            lb_TenSP.Text = q.TenSP(maSP);
            lb_Gia.Text = q.Gia_SP(maSP);
            pictureBox1.Image = Image.FromFile(@"..\..\image\" + q.HinhAnh(maSP));
            //load picture
            //pictureBox1.Image==
            panel1.Enabled = false;
        }

        [Category("Custom Props")]
        public string MaSanPham
        {
            get { return msp; }
            set { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
