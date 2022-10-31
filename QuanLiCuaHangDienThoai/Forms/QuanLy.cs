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
            Load_DateTimePicker_DoanhThu();
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            //LoadData();
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
                                                 SoLuong = u.soLuong,
                                                 //MaDM = u.maDM,
                                                 //MaNCC = u.maNCC
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
                                                 Ten = u.ten,
                                                 Password = u.mk,
                                                 Loai = u.loai,
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

            SanPhamBinding();
            DanhMucBinding();
            TaiKhoanBinding();
            
        }
        void SanPhamBinding()
        {
            textBox_MaSP.DataBindings.Add("Text", dataGridView_SP.DataSource, "MaSP", true, DataSourceUpdateMode.Never);
            textBox_TenSP.DataBindings.Add("Text", dataGridView_SP.DataSource, "TenSP", true, DataSourceUpdateMode.Never);
            textBox_Gia.DataBindings.Add("Value", dataGridView_SP.DataSource, "Gia", true, DataSourceUpdateMode.Never);
            textBox_SoLuong.DataBindings.Add("Value", dataGridView_SP.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);
        }

        void DanhMucBinding()
        {
            textBox_MaDM.DataBindings.Add("Text", dataGridView_DM.DataSource, "MaDM", true, DataSourceUpdateMode.Never);
            textBox_TenDM.DataBindings.Add("Text", dataGridView_DM.DataSource, "TenDM", true, DataSourceUpdateMode.Never);
        }

        void TaiKhoanBinding()
        {
            textBox_Username.DataBindings.Add("Text", dataGridView_SP.DataSource, "Username", true, DataSourceUpdateMode.Never);
            textBox_Ten.DataBindings.Add("Text", dataGridView_SP.DataSource, "Ten", true, DataSourceUpdateMode.Never);
            textBox_Password.DataBindings.Add("Text", dataGridView_SP.DataSource, "Password", true, DataSourceUpdateMode.Never);
            textBox_Loai.DataBindings.Add("Text", dataGridView_SP.DataSource, "Loai", true, DataSourceUpdateMode.Never);
            //textBox_NgayTao.DataBindings.Add("Text", dataGridView_SP.DataSource, "Ten", true, DataSourceUpdateMode.Never);
        }

        void Load_DateTimePicker_DoanhThu()
        {
            DateTime today = DateTime.Now;
            dateTimePicker_FromDate.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePicker_ToDate.Value = dateTimePicker_FromDate.Value.AddMonths(1).AddDays(-1);
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {

        }

        
    }
}
