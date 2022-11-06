using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangDienThoai.Forms
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var tendangnhap = txt_LoginName.Text;
            var matkhau = txt_PassWord.Text;
            if (tendangnhap == "" || matkhau == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo");
            try
            {
                this.Hide();
                fStaffMain f = new fStaffMain();
                f.AutoSize = true;
                f.ShowDialog();
                this.Close();
                /*QuanLy f = new QuanLy();
                f.ShowDialog();*/
            }
            catch { }
        }

        private void flogin_Load(object sender, EventArgs e)
        {

        }
    }
}
