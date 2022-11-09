using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLiCuaHangDienThoai.BS_Layer;
//using System.Data.SqlClient;
//using QuanLiCuaHangDienThoai.BS_Layer;

namespace QuanLiCuaHangDienThoai.Forms
{
    public partial class QuanLy : Form
    {
        bool themSP,themDM,themNCC,themTK;
        BL_SanPham blSP = new BL_SanPham();
        BL_DanhMuc blDM = new BL_DanhMuc();
        BL_TaiKhoan blTK = new BL_TaiKhoan();
        BL_NCC blNCC = new BL_NCC();
        QLDTDataContext db = new QLDTDataContext();

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
            listSanPham.DataSource = db.LAYSP();
            //comboBox_MaDM.DataSource = db.TB_TENDM();
            comboBox_MaDM.DataSource = from i in db.DANHMUCs
                                       select i.tenDM;
            comboBox_MaDM.DisplayMember = "TenDM";
            comboBox_MaNCC.DataSource = from u in db.NHACUNGCAPs
                                        select u.tenNCC;
            //comboBox_MaNCC.DataSource = db.TB_TENNCC();
            comboBox_MaNCC.DisplayMember = "TenNCC";
            button_ThemSP.Enabled = true;
            button_XoaSP.Enabled = true;
            button_LuuSP.Enabled = false;
            btnHuy.Enabled = false;
            button_SuaSP.Enabled = true;
            panel2.Enabled = false;
        }
        void LoadDanhMuc()
        {
            
            listDanhMuc.DataSource = db.LayDM();
            button_ThemDM.Enabled = true;
            button_XoaDM.Enabled = true;
            button_SuaDM.Enabled = true;
            button_LuuDM.Enabled = false;
            btnHuyDM.Enabled = false;
            panel12.Enabled = false;
        }
        void LoadNhaCC()
        {
            listNhaCC.DataSource = db.LAYNCC();
            button_ThemNCC.Enabled = true;
            butto_XoaNCC.Enabled = true;
            button_SuaNCC.Enabled = true;
            button_LuuNCC.Enabled = false;
            btnHuyNCC.Enabled = false;
            panel10.Enabled = false;
        }
        void LoadTaiKhoan()
        {
            listTaiKhoan.DataSource = db.LAYTK();
            button_ThemTK.Enabled = true;
            button_XoaTK.Enabled = true;
            button_SuaTK.Enabled = true;
            button_LuuTK.Enabled = false;
            btnHuyTK.Enabled = false;
            panel7.Enabled = false;
        }
        void LoadDoanhThu_byDate()
        {
            //dataGridView_DT.DataSource = db.DOANH_THU_THEO_NGAY(dateTimePicker_FromDate.Value.Date, dateTimePicker_ToDate.Value.Date);
            textBox1.Text = dateTimePicker_FromDate.Value.Day.ToString();
            textBox2.Text = dateTimePicker_ToDate.Value.Date.ToString();

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
                textBox_Username.DataBindings.Add("Text", dataGridView_TK.DataSource, "username", true, DataSourceUpdateMode.Never);
                textBox_Ten.DataBindings.Add("Text", dataGridView_TK.DataSource, "ten", true, DataSourceUpdateMode.Never);
                textBox_Password.DataBindings.Add("Text", dataGridView_TK.DataSource, "mk", true, DataSourceUpdateMode.Never);
                textBox_Email.DataBindings.Add("Text", dataGridView_TK.DataSource, "email", true, DataSourceUpdateMode.Never);
                textBox_Sdt.DataBindings.Add("Text", dataGridView_TK.DataSource, "sdt", true, DataSourceUpdateMode.Never);
                textBox_NgaySinh.DataBindings.Add("Text", dataGridView_TK.DataSource, "ngaySinh", true, DataSourceUpdateMode.Never);
                textBox_Loai.DataBindings.Add("Text", dataGridView_TK.DataSource, "loai", true, DataSourceUpdateMode.Never);
                textBox_NgayTao.DataBindings.Add("Text", dataGridView_TK.DataSource, "ngayTao", true, DataSourceUpdateMode.Never);
               
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
        void Thong_Ke_Doanh_Thu_Theo_Ngay(DateTime checkIn,DateTime checkOut)
        {
            dataGridView_TK.DataSource = db.DOANH_THU_THEO_NGAY(checkIn, checkOut);
        }
        /*
        //string Tim_ID_DM_Theo_Ten(string ten, string database)
        //{

        //    //string id = (from u in db.DANHMUCs
        //    //             where u.tenDM == ten
        //    //             select u.maDM).FirstOrDefault();
        //    String id = db.ID_MADM_TEN(ten);
        //    return id;
        //}
        //string Tim_ID_NCC_Theo_Ten(string ten, string database)
        //{
        //    //QLDTDataContext db = new QLDTDataContext();
        //    //string id = (from u in db.NHACUNGCAPs
        //    //             where u.tenNCC == ten
        //    //             select u.maNCC).SingleOrDefault();
        //    String id = db.ID_NCC_TEN(ten);
        //    return id;
        //}
        bool Thêm_Sản_Phẩm(string maSP, string tenSP, int gia, string hinhAnh, string soLuong, string maDM, string maNCC)
        {
            try
            {
                db.THEMSP(maSP, tenSP, gia, hinhAnh, soLuong, maDM, maNCC);
            }
            catch { return false; }
            return true;
        }
        //bool Xóa_Sản_Phẩm(string maSP)
        //{
        //    try
        //    {
        //        db.XOASP(maSP);

        //    }
        //    catch { return false; }
        //    return true;
        //}
        bool Sửa_Sản_Phẩm(string maSP, string tenSP,int gia,string hinhAnh,string soLuong,string maDM,string maNCC)
        {
            try
            {
                db.CAPNHATSP(maSP, tenSP, gia, hinhAnh, soLuong, maDM, maNCC);
            }
            catch { return false; }
            return true;
        }
        //bool Xoa_DM(string maDM)
        //{
        //    try
        //    {
        //        db.XoaDM(maDM);
        //    }
        //    catch { return false; }
        //    return true;
        //}*/
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    db.XOASP(textBox_MaSP.Text);
                    LoadSanPham();
                    MessageBox.Show("Xóa sản phẩm thành công!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }

              
        }
        
        
       
        private void button_ThemSP_Click(object sender, EventArgs e)
        {
            themSP = true;
            panel2.Enabled = true;
            textBox_MaSP.Enabled = false;
            string maSP = blSP.CHECKID_SP();
            this.textBox_MaSP.Text = maSP;
            textBox_TenSP.ResetText();
            textBox_Gia.ResetText();
            textBox_SoLuong.ResetText();
            comboBox_MaDM.ResetText();
            comboBox_MaNCC.ResetText();
            button_ThemSP.Enabled = false;
            button_SuaSP.Enabled = false;
            button_XoaSP.Enabled = false;
            button_LuuSP.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void button_SuaSP_Click(object sender, EventArgs e)
        {
            themSP = false;
            panel2.Enabled = true;
            button_ThemSP.Enabled = false;
            button_SuaSP.Enabled = false;
            button_XoaSP.Enabled = false;
            button_LuuSP.Enabled = true;
            btnHuy.Enabled = true;

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

            if(themSP)
            {
                /*  string maSP = textBox_MaSP.Text;
                  int gia = Convert.ToInt32(textBox_Gia.Text);
                  //int soLuong = Convert.ToInt32(textBox_SoLuong);
                  string soLuong = textBox_SoLuong.Text;
                  string tenSP = textBox_TenSP.Text;
                  //string maDM = Tim_ID_DM_Theo_Ten(comboBox_MaDM.SelectedItem.ToString(), "DANHMUCs");
                  String maDM = db.ID_MADM_TEN(comboBox_MaDM.SelectedItem.ToString());
                  //string maNCC = Tim_ID_NCC_Theo_Ten(comboBox_MaNCC.SelectedItem.ToString(), "NHACUNGCAPs");
                  Console.WriteLine(maDM);
                  String maNCC = db.ID_NCC_TEN(comboBox_MaNCC.SelectedItem.ToString());
                  string hinhAnh = textBox_LinkPicture.Text;

                  if (Thêm_Sản_Phẩm(maSP, tenSP, gia, hinhAnh, soLuong, maDM, maNCC))
                  {
                      MessageBox.Show("Thêm sản phẩm thành công!");
                      LoadSanPham();
                      //if (thêm_SP != null)
                      //    thêm_SP(this, new EventArgs());
                  }
                  else
                      MessageBox.Show("Sản phẩm không thể thêm!");*/
                try
                {
                    
                    String maDM = db.ID_MADM_TEN(comboBox_MaDM.SelectedItem.ToString());
                    String maNCC = db.ID_NCC_TEN(comboBox_MaNCC.SelectedItem.ToString());
                    db.THEMSP(this.textBox_MaSP.Text, this.textBox_TenSP.Text, Convert.ToInt32(this.textBox_Gia.Text), this.textBox_LinkPicture.Text, this.textBox_SoLuong.Text, maDM, maNCC);
                    LoadSanPham();
                    MessageBox.Show("Thêm thành công");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không thêm được, lỗi rồi !");
                }
            }
            else
            {
                /*string maSP = textBox_MaSP.Text;
                int gia = Convert.ToInt32(textBox_Gia.Text);
                //int soLuong = Convert.ToInt32(textBox_SoLuong);
                string soLuong = textBox_SoLuong.Text;
                string tenSP = textBox_TenSP.Text;
                //string maDM = Tim_ID_DM_Theo_Ten(comboBox_MaDM.SelectedItem.ToString(), "DANHMUCs");
                string maDM = db.ID_MADM_TEN(comboBox_MaDM.SelectedItem.ToString());
                //string maNCC = Tim_ID_NCC_Theo_Ten(comboBox_MaNCC.SelectedItem.ToString(), "NHACUNGCAPs");
              
                string maNCC = db.ID_NCC_TEN(comboBox_MaNCC.SelectedItem.ToString());
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
                        "Vui lòng kiểm tra lại thông tin.");*/
                try
                {
                    string maDM = db.ID_MADM_TEN(comboBox_MaDM.SelectedItem.ToString());
                    string maNCC = db.ID_NCC_TEN(comboBox_MaNCC.SelectedItem.ToString());
                    db.CAPNHATSP(this.textBox_MaSP.Text, this.textBox_TenSP.Text, Convert.ToInt32(this.textBox_Gia.Text), this.textBox_LinkPicture.Text, this.textBox_SoLuong.Text, maDM, maNCC);
                    LoadSanPham();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không sửa được!!");
                }
                
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void button_SuaDM_Click(object sender, EventArgs e)
        {
            themDM = false;
            button_ThemDM.Enabled = false;
            button_XoaDM.Enabled = false;
            button_SuaDM.Enabled = false;
            button_LuuDM.Enabled = true;
            btnHuyDM.Enabled = true;
            panel12.Enabled = true;
        }

        private void button_XoaDM_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    db.XoaDM(textBox_MaDM.Text);
                    LoadDanhMuc();
                    MessageBox.Show("Xóa thành công!");                               
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnHuyDM_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }

        private void button_ThemNCC_Click(object sender, EventArgs e)
        {
            textBox_MaNCC.Enabled=false;
            string ncc = blNCC.CHECKID_NCC();
            textBox_MaNCC.Text = ncc;
            textBox_TenNCC.ResetText();
            themNCC = true;
            button_ThemNCC.Enabled = false;
            butto_XoaNCC.Enabled = false;
            button_SuaNCC.Enabled = false;
            button_LuuNCC.Enabled = true;
            btnHuyNCC.Enabled = true;
            panel10.Enabled = true;
        }

        private void button_SuaNCC_Click(object sender, EventArgs e)
        {
            themNCC = false;
            button_ThemNCC.Enabled = false;
            butto_XoaNCC.Enabled = false;
            button_SuaNCC.Enabled = false;
            button_LuuNCC.Enabled = true;
            btnHuyNCC.Enabled = true;
            panel10.Enabled = true;
        }

        private void butto_XoaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    db.XOANCC(textBox_MaNCC.Text);
                    LoadNhaCC();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnHuyNCC_Click(object sender, EventArgs e)
        {
            LoadNhaCC();
        }

        private void button_ThemTK_Click(object sender, EventArgs e)
        {
            themTK = true;
            textBox_Username.ResetText();
            textBox_Ten.ResetText();
            textBox_Password.ResetText();
            textBox_Email.ResetText();
            textBox_Sdt.ResetText();
            textBox_NgaySinh.ResetText();
            textBox_Loai.ResetText();
            textBox_NgayTao.ResetText();
            button_ThemTK.Enabled = false;
            button_XoaTK.Enabled = false;
            button_SuaTK.Enabled = false;
            button_LuuTK.Enabled = true;
            btnHuyTK.Enabled = true;
            panel7.Enabled = true;
        }

        private void button_SuaTK_Click(object sender, EventArgs e)
        {
            themTK = false;
            button_ThemTK.Enabled = false;
            button_XoaTK.Enabled = false;
            button_SuaTK.Enabled = false;
            button_LuuTK.Enabled = true;
            btnHuyTK.Enabled = true;
            panel7.Enabled = true;
        }

        private void button_XoaTK_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    db.XOATK(textBox_Username.Text);
                    LoadTaiKhoan();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnHuyTK_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void button_LuuTK_Click(object sender, EventArgs e)
        {
            if (themTK)
            {
                try
                {
                    db.THEMTK(this.textBox_Username.Text, this.textBox_Password.Text, this.textBox_Email.Text, this.textBox_Ten.Text,
                        Convert.ToDateTime(this.textBox_NgaySinh.Text), this.textBox_Sdt.Text, this.textBox_Loai.Text, Convert.ToDateTime(this.textBox_NgayTao.Text));
                    LoadTaiKhoan();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không thêm được, lỗi rồi !");
                }
            }
            else
            {
                try
                {
                    db.CAPNHATTK(this.textBox_Username.Text, this.textBox_Password.Text, this.textBox_Email.Text, this.textBox_Ten.Text,
                        Convert.ToDateTime(this.textBox_NgaySinh.Text), this.textBox_Sdt.Text, this.textBox_Loai.Text, Convert.ToDateTime(this.textBox_NgayTao.Text));
                    LoadTaiKhoan();
                    MessageBox.Show("CẬP NHẬT THÀNH CÔNG");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không cập nhật được,Lỗi Rồi!");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            dataGridView_SP.DataSource = blSP.TimSP(this.cbxTTSP.Text.Trim(),this.txtycSP.Text.Trim());
        }

        private void btnTimDM_Click(object sender, EventArgs e)
        {
            dataGridView_DM.DataSource = blDM.TimDM(this.cbbTTDM.Text.Trim(), this.txtYCDM.Text.Trim());
        }

        private void btnTIMNCC_Click(object sender, EventArgs e)
        {
            dataGridView_NhaCC.DataSource = blNCC.TimNCC(this.cbbTTNCC.Text.Trim(), this.txtYCNCC.Text.Trim());
        }

        private void btnTIMTK_Click(object sender, EventArgs e)
        {
            dataGridView_TK.DataSource = blTK.TimTK(this.cbbTTTK.Text.Trim(), this.txtYCTK.Text.Trim());
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            //LoadDoanhThu_byDate();
            dataGridView_DT.DataSource = db.DOANH_THU_THEO_NGAY(dateTimePicker_FromDate.Value.Date, dateTimePicker_ToDate.Value.Date);

        }

        private void button_LuuNCC_Click(object sender, EventArgs e)
        {
            if(themNCC)
            {
                try
                {
                    db.THEMNCC(this.textBox_MaNCC.Text, this.textBox_TenNCC.Text);
                    LoadNhaCC();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không thể thêm");
                }
            }
            else
            {
                try
                {
                    db.CAPNHATNCC(this.textBox_MaNCC.Text, this.textBox_TenNCC.Text);
                    LoadNhaCC();
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được, lỗi rồi! ");
                }
            }
        }

        private void button_LuuDM_Click(object sender, EventArgs e)
        {
            if (themDM)
            {
                try
                {
                    db.ThemDM(this.textBox_MaDM.Text, this.textBox_TenDM.Text);
                    LoadDanhMuc();
                    MessageBox.Show("Thêm Thành Công");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không Thêm được, Lỗi rồi!");
                }
            }
            else
            {
                try
                {
                    db.CAPNHATDM(this.textBox_MaDM.Text, this.textBox_TenDM.Text);
                    LoadDanhMuc();
                    MessageBox.Show("Sửa Thành Công");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được, Lỗi rồi!");
                }
            
            }
            
        }

        private void button_ThemDM_Click(object sender, EventArgs e)
        {
            themDM = true;
            textBox_MaDM.Enabled = false;
            string maDM = blDM.CHECKID_DM();
            textBox_MaDM.Text=maDM;
            textBox_TenDM.ResetText();
            button_ThemDM.Enabled = false;
            button_XoaDM.Enabled = false;
            button_SuaDM.Enabled = false;
            button_LuuDM.Enabled = true;
            btnHuyDM.Enabled = true;
            panel12.Enabled = true;
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
