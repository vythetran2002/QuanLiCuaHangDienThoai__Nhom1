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
        BL_SanPham db = new BL_SanPham();
        public fStaffMain()
        {
            InitializeComponent();
            LoadData_SP();
            LoadData_HD_ChuaThanhToan();
            btn_AddHDCT.Enabled = false;
        }

        void LoadData_SP()
        {
            int i;
            flp_Phone.Controls.Clear();
            
            dgv_sp.DataSource = db.DSSanPham();

            for(i=0;i<dgv_sp.Rows.Count-1;i++)
            {
                DataGridViewRow row = dgv_sp.Rows[i];
                string masp = row.Cells[0].Value.ToString();
                UC_Phone ph = new UC_Phone(masp);
                ph.AutoSize = false;
                flp_Phone.Controls.Add(ph);

                ph.Click += new System.EventHandler(this.Click_Phone);

            }   
        }

        void LoadData_HD_ChuaThanhToan()
        {
            QLDTDataContext q = new QLDTDataContext();
            var query = from item in q.HOADONs
                        where item.status == 0
                        select item.maHD;

            cbb_ChonHD.DataSource = query;
        }
        void Click_Phone(object sender, EventArgs e)
        {
            UC_Phone sp = (UC_Phone)sender;
            QLDTDataContext q = new QLDTDataContext();
            lb_MaSP.Text= sp.MaSanPham;
            var query = (from item in q.SANPHAMs
                         where item.maSP == lb_MaSP.Text
                         select item).SingleOrDefault();

            lb_TenSP.Text = query.tenSP.ToString() ;
            lb_NCC.Text = query.maNCC.ToString();
            lb_DM.Text = query.maDM.ToString();
            lb_Gia.Text = query.gia.ToString();
            lb_SL.Text = "Tồn kho: " + query.soLuong.ToString();

            btn_AddHDCT.Enabled = true;

            //pictureBox1.image=;

        }
        void Load_HDCT()
        {
            
            flp_HDCT.Controls.Clear();

            QLDTDataContext q = new QLDTDataContext();
            var query = from item in q.HOADONCHITIETs
                        where item.maHD.ToString() == cbb_ChonHD.Text
                        select item;

            foreach(var item in query)
            {

                UC_PhoneOrder po = new UC_PhoneOrder(item.maHD.ToString(),item.maSP);
                po.AutoSize = true;
                flp_HDCT.Controls.Add(po);
            }

        }
        bool CheckSpInHd(string maHD, string maSP)
        {
            QLDTDataContext q = new QLDTDataContext();

            var query = from item in q.HOADONCHITIETs
                        where maHD == item.maHD.ToString() && maSP == item.maSP
                        select item;

            if (query.Count() == 0) return false;
            else
            {
                MessageBox.Show("Sản phẩm đã có trong hđ");
                return true;
            }
        }
        private void btn_AddHDCT_Click(object sender, EventArgs e)
        {
            
            QLDTDataContext q = new QLDTDataContext();
            if(CheckSpInHd(cbb_ChonHD.Text,lb_MaSP.Text)==false)
            {
                q.THEMHDCT(cbb_ChonHD.Text, lb_MaSP.Text, 0, 1, 0);
                MessageBox.Show("add success");
                LoadData_HD_ChuaThanhToan();
            }
            else
            {

            }

        }

        private void btn_NewHD_Click(object sender, EventArgs e)
        {
            QLDTDataContext q = new QLDTDataContext();
            q.THEMHD("duynhut", "abc", " ",dateTimePicker1.Value, 0, 0);
            MessageBox.Show("success");
        }

        private void btn_LoadHDCT_Click(object sender, EventArgs e)
        {
            Load_HDCT();
        }

        private void cbb_ChonHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_HDCT();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            fBill f = new fBill(cbb_ChonHD.Text);
            f.ShowDialog();
        }
    }
}
