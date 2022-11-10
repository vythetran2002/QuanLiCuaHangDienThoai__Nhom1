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
    public partial class flogin : Form
    {
        BL_Login bllogin = new BL_Login();
   
        public flogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string tendangnhap = txt_LoginName.Text;
            string matkhau = txt_PassWord.Text;
            if (tendangnhap == "" || matkhau == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo");
            else
            {
                if (bllogin.Search(tendangnhap, matkhau))
                {
                    if (bllogin.Check_Admin(tendangnhap,matkhau))
                    {
                        QuanLy admin = new QuanLy();
                        this.Hide();
                        admin.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        fStaffMain staff = new fStaffMain();

                        staff.username= tendangnhap;
                        this.Hide();
                        staff.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
                    txt_LoginName.Focus();
                }
            }
        }


        private void flogin_Load(object sender, EventArgs e)
        {

        }
    }
}
