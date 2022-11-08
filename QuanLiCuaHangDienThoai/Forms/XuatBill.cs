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
    public partial class XuatBill : Form
    {
        int maHD;
        public XuatBill(string maHD)
        {
            InitializeComponent();
            this.maHD = int.Parse(maHD);
        }

        private void XuatBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiCuaHangDienThoaiDataSet.HDCTMaHD' table. You can move, or remove it, as needed.
            this.hDCTMaHDTableAdapter.Fill(this.quanLiCuaHangDienThoaiDataSet.HDCTMaHD,maHD);
            // TODO: This line of code loads data into the 'quanLiCuaHangDienThoaiDataSet.timHD' table. You can move, or remove it, as needed.
            this.timHDTableAdapter.Fill(this.quanLiCuaHangDienThoaiDataSet.timHD,maHD);


            this.reportViewer1.RefreshReport();
          
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
