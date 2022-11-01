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
        BL_SanPham db = new BL_SanPham();
        public UC_Phone()
        {
            InitializeComponent();
        }
        string msp;
        public UC_Phone(string maSP)
        {
            InitializeComponent();
            QLDTDataContext q = new QLDTDataContext();
            var query = (from item in q.SANPHAMs
                         where item.maSP == maSP.Trim()
                         select item).SingleOrDefault();

            lb_TenSP.Text = query.tenSP.ToString();
            lb_Gia.Text = query.gia.ToString();
            this.msp = maSP;
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
        
    }
}
