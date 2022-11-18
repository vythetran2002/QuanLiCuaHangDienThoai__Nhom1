using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        QLDTDataContext q;
        public UC_Phone(string maSP, string username, string mk)
        {
            InitializeComponent();
            q = new QLDTDataContext(new ConnectionSQL(username, mk).ConnString());
            BL_SanPham blSP = new BL_SanPham();
            /* var query = (from item in q.SANPHAMs
                          where item.maSP == maSP.Trim()
                          select item).SingleOrDefault();

             lb_TenSP.Text = query.tenSP.ToString();
             lb_Gia.Text = query.gia.ToString();*/
            this.msp = maSP;
            lb_TenSP.Text = q.TenSP(maSP);
            string giakm = q.TIMSP_MASP(maSP).SingleOrDefault().GiaKM.ToString();
            if (giakm.ToString() != "")
            {
                lb_Gia.Text = giakm;
            }
            else
            {
                lb_Gia.Text = q.Gia_SP(maSP);
            }
            string hinhanh = blSP.HinhAnh(maSP);
            try
            {
                pictureBox1.Image = ByteToImg(q.Lay_Chuoi_Byte_Hinh_Anh(maSP));
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch { }
            //load picture
            //pictureBox1.Image==
            panel1.Enabled = false;
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        [Category("Custom Props")]
        public string MaSanPham
        {
            get { return msp; }
            set { }
        }
    }
}
