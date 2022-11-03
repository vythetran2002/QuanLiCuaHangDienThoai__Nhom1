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

            //pictureBox1.image=;
        }
    }
   
}
