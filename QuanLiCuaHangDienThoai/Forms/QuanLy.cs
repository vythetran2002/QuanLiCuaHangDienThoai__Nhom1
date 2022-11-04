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
        BindingSource listSanPham = new BindingSource();
        BindingSource listDanhMuc = new BindingSource();
        BindingSource listNhaCC = new BindingSource();
        BindingSource listTaiKhoan = new BindingSource();

        public QuanLy()
        {
            InitializeComponent();
            Load_DateTimePicker_DoanhThu(); //Load 2 thanh thời gian ngày bắt đầu và ngày kết thúc để thống kê doanh thu 
                                            //trong khoảng tgian đó
            LoadData();
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            //LoadData();
        }
        void LoadData()
        {
            QLDTDataContext db = new QLDTDataContext();

            dataGridView_SP.DataSource = listSanPham;
            dataGridView_DM.DataSource = listDanhMuc;
            dataGridView_NhaCC.DataSource = listNhaCC;
            dataGridView_TK.DataSource = listTaiKhoan;

            //Load dữ liệu lên datagridview
            LoadDoanhThu_byDate();  //sửa: thêm ngày bđ và kt
            LoadSanPham();
            LoadDanhMuc();
            LoadNhaCC();
            LoadTaiKhoan();
            

            //Khi chọn 1 hàng nào đó bên datagridview thì sẽ hiện lên bên textbox
            SanPhamBinding();
            DanhMucBinding();
            TaiKhoanBinding();
            NhaCCBinding();
        }

        void LoadSanPham()
        {
            QLDTDataContext db = new QLDTDataContext();
            listSanPham.DataSource = from u in db.SANPHAMs
                                         select new
                                         {
                                             MaSP = u.maSP,
                                             TenSP = u.tenSP,
                                             Gia = u.gia,
                                             SoLuong = u.soLuong,
                                             //MaDM = u.maDM,
                                             //MaNCC = u.maNCC
                                         };
            comboBox_MaDM.DataSource = from u in db.DANHMUCs
                                       select u.tenDM;
            comboBox_MaDM.DisplayMember = "TenDM";
            comboBox_MaNCC.DataSource = from u in db.NHACUNGCAPs
                                        select u.tenNCC;
            comboBox_MaNCC.DisplayMember = "TenNCC";
        }
        void LoadDanhMuc()
        {
            QLDTDataContext db = new QLDTDataContext();
            listDanhMuc.DataSource = from u in db.DANHMUCs
                                         select new
                                         {
                                             MaDM = u.maDM,
                                             TenDM = u.tenDM
                                         };
        }
        void LoadNhaCC()
        {
            QLDTDataContext db = new QLDTDataContext();
            listNhaCC.DataSource = from u in db.NHACUNGCAPs
                                            select new
                                            {
                                                MaNCC = u.maNCC,
                                                TenNCC = u.tenNCC,
                                            };
        }
        void LoadTaiKhoan()
        {
            QLDTDataContext db = new QLDTDataContext();
            listTaiKhoan.DataSource = from u in db.TAIKHOANs
                                         select new
                                         {
                                             Username = u.username,
                                             Ten = u.ten,
                                             Password = u.mk,
                                             Loai = u.loai,
                                             NgayTao = u.ngayTao
                                         };
        }
        void LoadDoanhThu_byDate()
        {
            QLDTDataContext db = new QLDTDataContext();
            dataGridView_DT.DataSource = from u in db.HOADONs
                                         select new
                                         {
                                             MaHD = u.maHD,
                                             Username = u.username,
                                             TenKH = u.tenKH,
                                             TongTien = u.tongTien,
                                             NgayTao = u.ngayTao
                                         }
                                         ;
        }//!sửa
        void SanPhamBinding()
        {
            try
            {
                textBox_MaSP.DataBindings.Add("Text", dataGridView_SP.DataSource, "MaSP", true, DataSourceUpdateMode.Never);
                textBox_TenSP.DataBindings.Add("Text", dataGridView_SP.DataSource, "TenSP", true, DataSourceUpdateMode.Never);
                textBox_Gia.DataBindings.Add("Text", dataGridView_SP.DataSource, "Gia", true, DataSourceUpdateMode.Never);
                textBox_SoLuong.DataBindings.Add("Text", dataGridView_SP.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);
            }
            catch { }
        }
        void DanhMucBinding()
        {
            try
            {
                textBox_MaDM.DataBindings.Add("Text", dataGridView_DM.DataSource, "MaDM", true, DataSourceUpdateMode.Never);
                textBox_TenDM.DataBindings.Add("Text", dataGridView_DM.DataSource, "TenDM", true, DataSourceUpdateMode.Never);
            }
            catch { }
        }
        void NhaCCBinding()
        {
            try
            {
                textBox_MaNCC.DataBindings.Add("Text", dataGridView_NhaCC.DataSource, "MaNCC", true, DataSourceUpdateMode.Never);
                textBox_TenNCC.DataBindings.Add("Text", dataGridView_NhaCC.DataSource, "TenNCC", true, DataSourceUpdateMode.Never);
            }
            catch { }
        }
        void TaiKhoanBinding()
        {
            try
            {
                textBox_Username.DataBindings.Add("Text", dataGridView_TK.DataSource, "Username", true, DataSourceUpdateMode.Never);
                textBox_Ten.DataBindings.Add("Text", dataGridView_TK.DataSource, "Ten", true, DataSourceUpdateMode.Never);
                textBox_Password.DataBindings.Add("Text", dataGridView_TK.DataSource, "Password", true, DataSourceUpdateMode.Never);
                textBox_Loai.DataBindings.Add("Text", dataGridView_TK.DataSource, "Loai", true, DataSourceUpdateMode.Never);
                textBox_NgayTao.DataBindings.Add("Text", dataGridView_TK.DataSource, "NgayTao", true, DataSourceUpdateMode.Never);
            }
            catch 
            {
                MessageBox.Show("Ko binding đc");
            }
        }
        void Load_DateTimePicker_DoanhThu()
        {
            DateTime today = DateTime.Now;
            dateTimePicker_FromDate.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePicker_ToDate.Value = dateTimePicker_FromDate.Value.AddMonths(1).AddDays(-1);
        }
        string Tim_ID_DM_Theo_Ten(string ten, string database)
        {
            QLDTDataContext db = new QLDTDataContext();
            string id = (from u in db.DANHMUCs
                         where u.tenDM == ten
                         select u.maDM).FirstOrDefault();
            return id;
        }
        string Tim_ID_NCC_Theo_Ten(string ten, string database)
        {
            QLDTDataContext db = new QLDTDataContext();
            string id = (from u in db.NHACUNGCAPs
                         where u.tenNCC == ten
                         select u.maNCC).SingleOrDefault();
            return id;
        }
        bool Thêm_Sản_Phẩm(string maSP, string tenSP, int gia, string hinhAnh, string soLuong, string maDM, string maNCC)
        {
            QLDTDataContext db = new QLDTDataContext();
            try
            {
                db.THEMSP(maSP, tenSP, gia, hinhAnh, soLuong, maDM, maNCC);

            }
            catch { return false; }
            return true;
        }
        bool Xóa_Sản_Phẩm(string maSP)
        {
            QLDTDataContext db = new QLDTDataContext();
            try
            {
                db.XOASP(maSP);

            }
            catch { return false; }
            return true;
        }
        bool Sửa_Sản_Phẩm(string maSP, string tenSP,int gia,string hinhAnh,string soLuong,string maDM,string maNCC)
        {
            QLDTDataContext db = new QLDTDataContext();
            try
            {
                db.CAPNHATSP(maSP, tenSP, gia, hinhAnh, soLuong, maDM, maNCC);
            }
            catch { return false; }
            return true;
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (Xóa_Sản_Phẩm(textBox_MaSP.Text))
            {
                MessageBox.Show("Xóa sản phẩm thành công!");
                LoadSanPham();
                //if (xóa_SP != null)
                //    xóa_SP(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Sản phẩm không thể xóa!");
            }    
        }
        private void button_ThemSP_Click(object sender, EventArgs e)
        {
            string maSP = textBox_MaSP.Text;
            int gia = Convert.ToInt32(textBox_Gia.Text);
            //int soLuong = Convert.ToInt32(textBox_SoLuong);
            string soLuong = textBox_SoLuong.Text;
            string tenSP = textBox_TenSP.Text;
            string maDM = Tim_ID_DM_Theo_Ten(comboBox_MaDM.SelectedItem.ToString(), "DANHMUCs");
            string maNCC = Tim_ID_NCC_Theo_Ten(comboBox_MaNCC.SelectedItem.ToString(), "NHACUNGCAPs");
            string hinhAnh = textBox_LinkPicture.Text;

            if (Thêm_Sản_Phẩm(maSP, tenSP, gia, hinhAnh, soLuong, maDM, maNCC))
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadSanPham();
                //if (thêm_SP != null)
                //    thêm_SP(this, new EventArgs());
            }
            else
                MessageBox.Show("Sản phẩm không thể thêm!");
        }
        private void button_SuaSP_Click(object sender, EventArgs e)
        {
            string maSP = textBox_MaSP.Text;
            int gia = Convert.ToInt32(textBox_Gia.Text);
            //int soLuong = Convert.ToInt32(textBox_SoLuong);
            string soLuong = textBox_SoLuong.Text;
            string tenSP = textBox_TenSP.Text;
            string maDM = Tim_ID_DM_Theo_Ten(comboBox_MaDM.SelectedItem.ToString(), "DANHMUCs");
            string maNCC = Tim_ID_NCC_Theo_Ten(comboBox_MaNCC.SelectedItem.ToString(), "NHACUNGCAPs");
            string hinhAnh = textBox_LinkPicture.Text;

            if (Sửa_Sản_Phẩm(maSP, tenSP, gia, hinhAnh, soLuong, maDM, maNCC))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                LoadSanPham();
                //if (thêm_SP != null)
                //    thêm_SP(this, new EventArgs());
            }
            else
                MessageBox.Show("Không thể cập nhật sản phẩm!" +
                    "Vui lòng kiểm tra lại thông tin.");
        }
        private void button_ChenAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Choose picture";
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox_LinkPicture.Text = openFile.FileName;
            }
        }

        private void dataGridView_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_ReloadSP_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }


        //private event EventHandler thêm_SP;
        //public event EventHandler Thêm_SP
        //{
        //    add { thêm_SP += value; }
        //    remove { thêm_SP -= value; }
        //}
        //private event EventHandler xóa_SP;
        //public event EventHandler Xóa_SP
        //{
        //    add { xóa_SP += value; }
        //    remove { xóa_SP -= value; }
        //}


    }
}
