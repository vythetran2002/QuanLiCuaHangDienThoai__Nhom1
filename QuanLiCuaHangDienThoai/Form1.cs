using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCuaHangDienThoai.Forms;
using System.Collections.Generic;
using System.Linq;
using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace QuanLiCuaHangDienThoai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            cnn();
            
        }
        void cnn()
        {
            string q = new ConnectionSQL("nhanvien1", "123").ConnString();
            var db = new QLDTDataContext(q);
            dataGridView1.DataSource = db.NHACUNGCAPs;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
