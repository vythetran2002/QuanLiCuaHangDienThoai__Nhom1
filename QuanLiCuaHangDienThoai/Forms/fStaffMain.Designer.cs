namespace QuanLiCuaHangDienThoai.Forms
{
    partial class fStaffMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_SL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.lb_MaSP = new System.Windows.Forms.Label();
            this.btn_AddHDCT = new System.Windows.Forms.Button();
            this.lb_DM = new System.Windows.Forms.Label();
            this.lb_TenSP = new System.Windows.Forms.Label();
            this.lb_NCC = new System.Windows.Forms.Label();
            this.flp_Phone = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_NewHD = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flp_HDCT = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_LoadHDCT = new System.Windows.Forms.Button();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.dgv_sp = new System.Windows.Forms.DataGridView();
            this.cbb_ChonHD = new System.Windows.Forms.ComboBox();
            this.btnXoaHDCT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_SL);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_Gia);
            this.panel1.Controls.Add(this.lb_MaSP);
            this.panel1.Controls.Add(this.btn_AddHDCT);
            this.panel1.Controls.Add(this.lb_DM);
            this.panel1.Controls.Add(this.lb_TenSP);
            this.panel1.Controls.Add(this.lb_NCC);
            this.panel1.Location = new System.Drawing.Point(714, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 129);
            this.panel1.TabIndex = 13;
            // 
            // lb_SL
            // 
            this.lb_SL.AutoSize = true;
            this.lb_SL.Location = new System.Drawing.Point(241, 81);
            this.lb_SL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SL.Name = "lb_SL";
            this.lb_SL.Size = new System.Drawing.Size(47, 13);
            this.lb_SL.TabIndex = 11;
            this.lb_SL.Text = "Tồn kho";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(5, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Location = new System.Drawing.Point(79, 103);
            this.lb_Gia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(23, 13);
            this.lb_Gia.TabIndex = 9;
            this.lb_Gia.Text = "Giá";
            // 
            // lb_MaSP
            // 
            this.lb_MaSP.AutoSize = true;
            this.lb_MaSP.Location = new System.Drawing.Point(79, 8);
            this.lb_MaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaSP.Name = "lb_MaSP";
            this.lb_MaSP.Size = new System.Drawing.Size(22, 13);
            this.lb_MaSP.TabIndex = 8;
            this.lb_MaSP.Text = "Mã";
            // 
            // btn_AddHDCT
            // 
            this.btn_AddHDCT.Location = new System.Drawing.Point(208, 103);
            this.btn_AddHDCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddHDCT.Name = "btn_AddHDCT";
            this.btn_AddHDCT.Size = new System.Drawing.Size(126, 25);
            this.btn_AddHDCT.TabIndex = 7;
            this.btn_AddHDCT.Text = "Thêm SP vào HĐ";
            this.btn_AddHDCT.UseVisualStyleBackColor = true;
            this.btn_AddHDCT.Click += new System.EventHandler(this.btn_AddHDCT_Click);
            // 
            // lb_DM
            // 
            this.lb_DM.AutoSize = true;
            this.lb_DM.Location = new System.Drawing.Point(79, 56);
            this.lb_DM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_DM.Name = "lb_DM";
            this.lb_DM.Size = new System.Drawing.Size(29, 13);
            this.lb_DM.TabIndex = 2;
            this.lb_DM.Text = "NCC";
            // 
            // lb_TenSP
            // 
            this.lb_TenSP.AutoSize = true;
            this.lb_TenSP.Location = new System.Drawing.Point(79, 33);
            this.lb_TenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TenSP.Name = "lb_TenSP";
            this.lb_TenSP.Size = new System.Drawing.Size(26, 13);
            this.lb_TenSP.TabIndex = 1;
            this.lb_TenSP.Text = "Tên";
            // 
            // lb_NCC
            // 
            this.lb_NCC.AutoSize = true;
            this.lb_NCC.Location = new System.Drawing.Point(79, 81);
            this.lb_NCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NCC.Name = "lb_NCC";
            this.lb_NCC.Size = new System.Drawing.Size(24, 13);
            this.lb_NCC.TabIndex = 0;
            this.lb_NCC.Text = "DM";
            // 
            // flp_Phone
            // 
            this.flp_Phone.AutoScroll = true;
            this.flp_Phone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_Phone.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flp_Phone.Location = new System.Drawing.Point(25, 45);
            this.flp_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.flp_Phone.Name = "flp_Phone";
            this.flp_Phone.Size = new System.Drawing.Size(685, 420);
            this.flp_Phone.TabIndex = 10;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(957, 191);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(89, 31);
            this.btn_ThanhToan.TabIndex = 18;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_NewHD
            // 
            this.btn_NewHD.Location = new System.Drawing.Point(714, 191);
            this.btn_NewHD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NewHD.Name = "btn_NewHD";
            this.btn_NewHD.Size = new System.Drawing.Size(85, 31);
            this.btn_NewHD.TabIndex = 17;
            this.btn_NewHD.Text = "HĐ mới";
            this.btn_NewHD.UseVisualStyleBackColor = true;
            this.btn_NewHD.Click += new System.EventHandler(this.btn_NewHD_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(738, 19);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // flp_HDCT
            // 
            this.flp_HDCT.AutoScroll = true;
            this.flp_HDCT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_HDCT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flp_HDCT.Location = new System.Drawing.Point(714, 260);
            this.flp_HDCT.Margin = new System.Windows.Forms.Padding(2);
            this.flp_HDCT.Name = "flp_HDCT";
            this.flp_HDCT.Size = new System.Drawing.Size(337, 207);
            this.flp_HDCT.TabIndex = 15;
            // 
            // btn_LoadHDCT
            // 
            this.btn_LoadHDCT.Location = new System.Drawing.Point(973, 226);
            this.btn_LoadHDCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LoadHDCT.Name = "btn_LoadHDCT";
            this.btn_LoadHDCT.Size = new System.Drawing.Size(73, 30);
            this.btn_LoadHDCT.TabIndex = 14;
            this.btn_LoadHDCT.Text = "Load HĐCT";
            this.btn_LoadHDCT.UseVisualStyleBackColor = true;
            this.btn_LoadHDCT.Click += new System.EventHandler(this.btn_LoadHDCT_Click);
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.Location = new System.Drawing.Point(717, 235);
            this.lb_MaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(41, 13);
            this.lb_MaHD.TabIndex = 10;
            this.lb_MaHD.Text = "Mã HD";
            // 
            // dgv_sp
            // 
            this.dgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sp.Location = new System.Drawing.Point(27, 46);
            this.dgv_sp.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.RowHeadersWidth = 62;
            this.dgv_sp.RowTemplate.Height = 28;
            this.dgv_sp.Size = new System.Drawing.Size(13, 16);
            this.dgv_sp.TabIndex = 19;
            // 
            // cbb_ChonHD
            // 
            this.cbb_ChonHD.FormattingEnabled = true;
            this.cbb_ChonHD.Location = new System.Drawing.Point(760, 233);
            this.cbb_ChonHD.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_ChonHD.Name = "cbb_ChonHD";
            this.cbb_ChonHD.Size = new System.Drawing.Size(82, 21);
            this.cbb_ChonHD.TabIndex = 20;
            this.cbb_ChonHD.SelectedIndexChanged += new System.EventHandler(this.cbb_ChonHD_SelectedIndexChanged);
            // 
            // btnXoaHDCT
            // 
            this.btnXoaHDCT.Location = new System.Drawing.Point(896, 227);
            this.btnXoaHDCT.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaHDCT.Name = "btnXoaHDCT";
            this.btnXoaHDCT.Size = new System.Drawing.Size(73, 30);
            this.btnXoaHDCT.TabIndex = 21;
            this.btnXoaHDCT.Text = "Xoá HĐCT";
            this.btnXoaHDCT.UseVisualStyleBackColor = true;
            this.btnXoaHDCT.Click += new System.EventHandler(this.btnXoaHDCT_Click);
            // 
            // fStaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 473);
            this.Controls.Add(this.btnXoaHDCT);
            this.Controls.Add(this.cbb_ChonHD);
            this.Controls.Add(this.lb_MaHD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flp_Phone);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_NewHD);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.flp_HDCT);
            this.Controls.Add(this.btn_LoadHDCT);
            this.Controls.Add(this.dgv_sp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fStaffMain";
            this.Text = "fStaffMain";
            this.Load += new System.EventHandler(this.fStaffMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Gia;
        private System.Windows.Forms.Label lb_MaSP;
        private System.Windows.Forms.Button btn_AddHDCT;
        private System.Windows.Forms.Label lb_DM;
        private System.Windows.Forms.Label lb_TenSP;
        private System.Windows.Forms.Label lb_NCC;
        private System.Windows.Forms.FlowLayoutPanel flp_Phone;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_NewHD;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flp_HDCT;
        private System.Windows.Forms.Button btn_LoadHDCT;
        private System.Windows.Forms.Label lb_MaHD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_sp;
        private System.Windows.Forms.Label lb_SL;
        private System.Windows.Forms.ComboBox cbb_ChonHD;
        private System.Windows.Forms.Button btnXoaHDCT;
    }
}