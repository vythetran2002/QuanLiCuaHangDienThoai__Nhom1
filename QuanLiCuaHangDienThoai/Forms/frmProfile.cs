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
    public partial class frmProfile : Form
    {
        QLDTDataContext db = new QLDTDataContext();
        public string usename;
        public frmProfile()
        {
            InitializeComponent();
            
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtUsername.Text = usename;
            txtUsername.Enabled = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string pass = txtNewPass.Text;
            string repass = txtReEnterPass.Text;
            
            if (pass.CompareTo(repass)==0)
            {
                db.DOI_PASS(txtUsername.Text, txtNewPass.Text);
                MessageBox.Show("Đổi Mật Khẩu Thành Công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật Khẩu không trùng khớp");
                txtNewPass.ResetText();
                txtReEnterPass.ResetText();
                txtNewPass.Focus();
            }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
