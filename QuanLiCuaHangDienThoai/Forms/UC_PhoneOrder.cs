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
    public partial class UC_PhoneOrder : UserControl
    {
        QLDTDataContext db = new QLDTDataContext();
        BL_SanPham blSP = new BL_SanPham();
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
            /*  QLDTDataContext q = new QLDTDataContext();
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
                           }).SingleOrDefault();*/
            var query = db.JOIN_SP_HDCT(maHD, maSP).SingleOrDefault();
            lb_TenSP.Text = query.tenSP;
            numericUpDown1.Value = int.Parse(query.soLuong.ToString());
            lb_ThanhTien.Text=(int.Parse(query.gia.ToString())* int.Parse(query.soLuong.ToString())).ToString();
            this.mahd = query.maHD.ToString();
            this.masp = query.maSP;
            this.gia = query.gia.ToString();
            string hinhanh = blSP.HinhAnh(maSP);
            try
            {
                pictureBox1.Image = ByteToImg(db.Lay_Chuoi_Byte_Hinh_Anh(maSP));
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch { }
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            /* QLDTDataContext q = new QLDTDataContext();
             var query = (from item in q.HOADONCHITIETs
                          where item.maHD.ToString() == mahd && item.maSP == masp
                          select item).SingleOrDefault();
             if(query!=null)
             {
                 query.soLuong = Convert.ToInt32(numericUpDown1.Value);
                 q.SubmitChanges();
             }    */
            
            var query = db.CHECK_SP_HD(mahd, masp).SingleOrDefault();
            if (query != null)
            {
                //query.soLuong = Convert.ToInt32(numericUpDown1.Value);
                if (numericUpDown1.Value!=0)
                {
                    db.CAPNHATHDCT(Convert.ToInt32(mahd), masp, Convert.ToInt32(numericUpDown1.Value));
                }
                else
                {
                    db.XOAHDCT(Convert.ToInt32(mahd),masp);
                }
            }
        }

        private void UC_PhoneOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
