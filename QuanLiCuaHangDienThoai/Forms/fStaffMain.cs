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
using System.IO;
namespace QuanLiCuaHangDienThoai.Forms
{
    public partial class fStaffMain : Form
    {
       
        BL_SanPham blSP = new BL_SanPham();
        BL_HDCT blHDCT = new BL_HDCT();
        public string username;
        public string mk;
        QLDTDataContext db;
        public fStaffMain(string username, string mk)
        {
            InitializeComponent();
            this.username = username;
            this.mk = mk;
            db = new QLDTDataContext(new ConnectionSQL(username, mk).ConnString());
            LoadData_SP();
            LoadData_HD_ChuaThanhToan();
            btn_AddHDCT.Visible = false;
        }
        
        void LoadData_SP()
        {
            int i;
            flp_Phone.Controls.Clear();
            
            dgv_sp.DataSource = db.LAYSP();

            for(i=0;i<dgv_sp.Rows.Count-1;i++)
            {
                DataGridViewRow row = dgv_sp.Rows[i];
                string masp = row.Cells[0].Value.ToString();
                UC_Phone ph = new UC_Phone(masp,username,mk);
                ph.AutoSize = false;
                flp_Phone.Controls.Add(ph);

                ph.Click += new System.EventHandler(this.Click_Phone);

            }   
        }
        void LoadData_HD_ChuaThanhToan()
        {
           
            var query = from item in db.HOADONs
                        where item.status == 0
                        select item.maHD;
            if (query.Count() != 0)
            {
                cbb_ChonHD.DataSource = query;
            }
            else
            {
                cbb_ChonHD.Text = "";
            }    

        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        void Click_Phone(object sender, EventArgs e)
        {
            UC_Phone sp = (UC_Phone)sender;

            btn_AddHDCT.Enabled = true;

            //pictureBox1.image=;*/
            lb_MaSP.Text = sp.MaSanPham;
            string maSP = sp.MaSanPham;
            lb_TenSP.Text = db.TenSP(maSP);
            lb_NCC.Text = db.MaNCC_SP(maSP);
            lb_DM.Text = db.MaDM_SP(maSP);
            lb_Gia.Text = db.Gia_SP(maSP);
            lb_SL.Text = db.SL_SP(maSP);     
            try
            {
                pictureBox1.Image = ByteToImg(db.Lay_Chuoi_Byte_Hinh_Anh(maSP));
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
               
            }
            catch { }
            
            if( int.Parse(lb_SL.Text) <= 0)
            {
                btn_AddHDCT.Visible = false;
            }
            else btn_AddHDCT.Visible = true;
        }
        void Load_HDCT()
        {

            flp_HDCT.Controls.Clear();
            
            var query = from item in db.HOADONCHITIETs
                        where item.maHD.ToString() == cbb_ChonHD.Text
                        select item;       
                foreach (var item in query)
                {

                    UC_PhoneOrder po = new UC_PhoneOrder(item.maHD.ToString(), item.maSP,username,mk);
                    po.AutoSize = true;
                    flp_HDCT.Controls.Add(po);
                }

        }
        
        private void btn_AddHDCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (blSP.CheckSpInHd(cbb_ChonHD.Text, lb_MaSP.Text) == false)
                {
                    db.THEMHDCT(Convert.ToInt32(cbb_ChonHD.Text), lb_MaSP.Text, 1);
                    MessageBox.Show("add success");
                    //LoadData_HD_ChuaThanhToan();
                    Load_HDCT();
                }
                else
                {

                }
            }
            catch { }
            
        }
        
        private void btn_NewHD_Click(object sender, EventArgs e)
        {
            string tenNV = db.LAY_TENNV(username);
            db.THEMHD(username, " ", " ",dateTimePicker1.Value);
            MessageBox.Show("success");
            
            LoadData_HD_ChuaThanhToan();
            cbb_ChonHD.Text = db.LAYHD().LastOrDefault().maHD.ToString();
            flp_HDCT.Controls.Clear();
        }

        private void btn_LoadHDCT_Click(object sender, EventArgs e)
        {
            Load_HDCT();

            LoadData_HD_ChuaThanhToan();
        }

        private void cbb_ChonHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_HDCT();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if(cbb_ChonHD.Text!="")
            {
                fBill f = new fBill(cbb_ChonHD.Text,username,mk);
                f.ShowDialog();
            }
        }

        private void btnXoaHDCT_Click(object sender, EventArgs e)
        {
            if (cbb_ChonHD.Text != "")
            {
                blHDCT.XoaDHCT(cbb_ChonHD.Text);
                LoadData_HD_ChuaThanhToan();
            }
            else { }
        }

        private void fStaffMain_Load(object sender, EventArgs e)
        {
            lbtennv.Text = db.LAY_TENNV(username);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProfile fr = new frmProfile();
            fr.usename = username;
            fr.ShowDialog();
        }
    }
}
