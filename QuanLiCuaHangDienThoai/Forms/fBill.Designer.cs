namespace QuanLiCuaHangDienThoai.Forms
{
    partial class fBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbox_TenKH = new System.Windows.Forms.TextBox();
            this.txtbox_SDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_maHD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ngayTaoHD = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.SANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_TenKH
            // 
            this.txtbox_TenKH.Location = new System.Drawing.Point(162, 179);
            this.txtbox_TenKH.Name = "txtbox_TenKH";
            this.txtbox_TenKH.Size = new System.Drawing.Size(136, 26);
            this.txtbox_TenKH.TabIndex = 0;
            this.txtbox_TenKH.TextChanged += new System.EventHandler(this.txtbox_TenKH_TextChanged);
            // 
            // txtbox_SDT
            // 
            this.txtbox_SDT.Location = new System.Drawing.Point(162, 218);
            this.txtbox_SDT.Name = "txtbox_SDT";
            this.txtbox_SDT.Size = new System.Drawing.Size(136, 26);
            this.txtbox_SDT.TabIndex = 1;
            this.txtbox_SDT.TextChanged += new System.EventHandler(this.txtbox_SDT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện thoại";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_TongTien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lb_ngayTaoHD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lb_user);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lb_maHD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtbox_TenKH);
            this.panel1.Controls.Add(this.txtbox_SDT);
            this.panel1.Location = new System.Drawing.Point(39, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 561);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn hàng";
            // 
            // lb_maHD
            // 
            this.lb_maHD.AutoSize = true;
            this.lb_maHD.Location = new System.Drawing.Point(162, 15);
            this.lb_maHD.Name = "lb_maHD";
            this.lb_maHD.Size = new System.Drawing.Size(51, 20);
            this.lb_maHD.TabIndex = 8;
            this.lb_maHD.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "NVBH";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(162, 45);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(51, 20);
            this.lb_user.TabIndex = 10;
            this.lb_user.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thông tin khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày giao dịch";
            // 
            // lb_ngayTaoHD
            // 
            this.lb_ngayTaoHD.AutoSize = true;
            this.lb_ngayTaoHD.Location = new System.Drawing.Point(162, 77);
            this.lb_ngayTaoHD.Name = "lb_ngayTaoHD";
            this.lb_ngayTaoHD.Size = new System.Drawing.Size(51, 20);
            this.lb_ngayTaoHD.TabIndex = 13;
            this.lb_ngayTaoHD.Text = "label7";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SANPHAM,
            this.GIA,
            this.SL,
            this.THANHTIEN});
            this.dataGridView1.Location = new System.Drawing.Point(42, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(586, 213);
            this.dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 639);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(431, 639);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(119, 38);
            this.btn_ThanhToan.TabIndex = 10;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // SANPHAM
            // 
            this.SANPHAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SANPHAM.DataPropertyName = "tenSP";
            this.SANPHAM.HeaderText = "Sản phẩm";
            this.SANPHAM.MinimumWidth = 8;
            this.SANPHAM.Name = "SANPHAM";
            // 
            // GIA
            // 
            this.GIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIA.DataPropertyName = "giaSP";
            this.GIA.HeaderText = "Giá bán";
            this.GIA.MinimumWidth = 8;
            this.GIA.Name = "GIA";
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.DataPropertyName = "sl";
            this.SL.HeaderText = "SL";
            this.SL.MinimumWidth = 8;
            this.SL.Name = "SL";
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THANHTIEN.DataPropertyName = "thanhtien";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 8;
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tổng hóa đơn";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Location = new System.Drawing.Point(525, 521);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(51, 20);
            this.lb_TongTien.TabIndex = 16;
            this.lb_TongTien.Text = "label9";
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 692);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "fBill";
            this.Text = "fBill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_TenKH;
        private System.Windows.Forms.TextBox txtbox_SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_maHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_ngayTaoHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label label7;
    }
}