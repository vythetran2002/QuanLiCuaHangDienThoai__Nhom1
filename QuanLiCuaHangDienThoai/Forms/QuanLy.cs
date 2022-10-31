using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
//using QuanLiCuaHangDienThoai.BS_Layer;

namespace QuanLiCuaHangDienThoai.Forms
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
            
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            QLDTDataContext db = new QLDTDataContext();
            try
            {
                dataGridView_SP.DataSource = from u in db.SANPHAMs
                                             select new
                                             {
                                                 MaSP = u.maSP,
                                                 TenSP = u.tenSP,
                                                 Gia = u.gia,
                                                 //GiaKM = u.GiaKM,
                                                 SoLuong = u.soLuong,
                                                 MaDM = u.maDM,
                                                 MaNCC = u.maNCC
                                             };
                dataGridView_DM.DataSource = from u in db.DANHMUCs
                                             select new
                                             {
                                                 MaDM = u.maDM,
                                                 TenDM = u.tenDM
                                             };
                dataGridView_TK.DataSource = from u in db.TAIKHOANs
                                             select new
                                             {
                                                 Username = u.username,
                                                 Password = u.mk,
                                                 NgayTao = u.ngayTao
                                             };
            }
            catch
            {
                MessageBox.Show("Việc load dữ liệu gặp lỗi rồi!!!");
            }

            dataGridView_DT.AutoResizeColumns();
            dataGridView_SP.AutoResizeColumns();
            dataGridView_DM.AutoResizeColumns();
            dataGridView_TK.AutoResizeColumns();
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {

        }

        
    }
}
