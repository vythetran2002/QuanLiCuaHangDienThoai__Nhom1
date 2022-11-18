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
            this.label3 = new System.Windows.Forms.Label();
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
            this.cbb_ChonHD = new System.Windows.Forms.ComboBox();
            this.btnXoaHDCT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_sp = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLiCuaHangDienThoai.Properties.Resources.nenInfoSP;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_SL);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_Gia);
            this.panel1.Controls.Add(this.lb_MaSP);
            this.panel1.Controls.Add(this.btn_AddHDCT);
            this.panel1.Controls.Add(this.lb_DM);
            this.panel1.Controls.Add(this.lb_TenSP);
            this.panel1.Controls.Add(this.lb_NCC);
            this.panel1.Location = new System.Drawing.Point(1059, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 198);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(240, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "VNĐ";
            // 
            // lb_SL
            // 
            this.lb_SL.AutoSize = true;
            this.lb_SL.BackColor = System.Drawing.Color.Transparent;
            this.lb_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_SL.Location = new System.Drawing.Point(362, 125);
            this.lb_SL.Name = "lb_SL";
            this.lb_SL.Size = new System.Drawing.Size(83, 22);
            this.lb_SL.TabIndex = 11;
            this.lb_SL.Text = "Tồn kho";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.BackColor = System.Drawing.Color.Transparent;
            this.lb_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Gia.Location = new System.Drawing.Point(118, 158);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(41, 22);
            this.lb_Gia.TabIndex = 9;
            this.lb_Gia.Text = "Giá";
            // 
            // lb_MaSP
            // 
            this.lb_MaSP.AutoSize = true;
            this.lb_MaSP.BackColor = System.Drawing.Color.Transparent;
            this.lb_MaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaSP.Location = new System.Drawing.Point(118, 12);
            this.lb_MaSP.Name = "lb_MaSP";
            this.lb_MaSP.Size = new System.Drawing.Size(36, 22);
            this.lb_MaSP.TabIndex = 8;
            this.lb_MaSP.Text = "Mã";
            // 
            // btn_AddHDCT
            // 
            this.btn_AddHDCT.BackColor = System.Drawing.Color.Lime;
            this.btn_AddHDCT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddHDCT.Location = new System.Drawing.Point(312, 158);
            this.btn_AddHDCT.Name = "btn_AddHDCT";
            this.btn_AddHDCT.Size = new System.Drawing.Size(189, 38);
            this.btn_AddHDCT.TabIndex = 7;
            this.btn_AddHDCT.Text = "Thêm SP vào HĐ";
            this.btn_AddHDCT.UseVisualStyleBackColor = false;
            this.btn_AddHDCT.Click += new System.EventHandler(this.btn_AddHDCT_Click);
            // 
            // lb_DM
            // 
            this.lb_DM.AutoSize = true;
            this.lb_DM.BackColor = System.Drawing.Color.Transparent;
            this.lb_DM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_DM.Location = new System.Drawing.Point(118, 86);
            this.lb_DM.Name = "lb_DM";
            this.lb_DM.Size = new System.Drawing.Size(52, 22);
            this.lb_DM.TabIndex = 2;
            this.lb_DM.Text = "NCC";
            // 
            // lb_TenSP
            // 
            this.lb_TenSP.AutoSize = true;
            this.lb_TenSP.BackColor = System.Drawing.Color.Transparent;
            this.lb_TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenSP.Location = new System.Drawing.Point(118, 51);
            this.lb_TenSP.Name = "lb_TenSP";
            this.lb_TenSP.Size = new System.Drawing.Size(45, 22);
            this.lb_TenSP.TabIndex = 1;
            this.lb_TenSP.Text = "Tên";
            // 
            // lb_NCC
            // 
            this.lb_NCC.AutoSize = true;
            this.lb_NCC.BackColor = System.Drawing.Color.Transparent;
            this.lb_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NCC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_NCC.Location = new System.Drawing.Point(118, 125);
            this.lb_NCC.Name = "lb_NCC";
            this.lb_NCC.Size = new System.Drawing.Size(39, 22);
            this.lb_NCC.TabIndex = 0;
            this.lb_NCC.Text = "DM";
            // 
            // flp_Phone
            // 
            this.flp_Phone.AutoScroll = true;
            this.flp_Phone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_Phone.BackColor = System.Drawing.Color.LightSkyBlue;
            this.flp_Phone.Location = new System.Drawing.Point(12, 92);
            this.flp_Phone.Name = "flp_Phone";
            this.flp_Phone.Size = new System.Drawing.Size(1028, 625);
            this.flp_Phone.TabIndex = 10;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(1424, 311);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(134, 48);
            this.btn_ThanhToan.TabIndex = 18;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_NewHD
            // 
            this.btn_NewHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_NewHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewHD.Location = new System.Drawing.Point(1059, 311);
            this.btn_NewHD.Name = "btn_NewHD";
            this.btn_NewHD.Size = new System.Drawing.Size(128, 48);
            this.btn_NewHD.TabIndex = 17;
            this.btn_NewHD.Text = "HĐ mới";
            this.btn_NewHD.UseVisualStyleBackColor = false;
            this.btn_NewHD.Click += new System.EventHandler(this.btn_NewHD_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1276, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 26);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // flp_HDCT
            // 
            this.flp_HDCT.AutoScroll = true;
            this.flp_HDCT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_HDCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flp_HDCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_HDCT.Location = new System.Drawing.Point(1059, 422);
            this.flp_HDCT.Name = "flp_HDCT";
            this.flp_HDCT.Size = new System.Drawing.Size(506, 295);
            this.flp_HDCT.TabIndex = 15;
            // 
            // btn_LoadHDCT
            // 
            this.btn_LoadHDCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_LoadHDCT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LoadHDCT.Location = new System.Drawing.Point(1448, 365);
            this.btn_LoadHDCT.Name = "btn_LoadHDCT";
            this.btn_LoadHDCT.Size = new System.Drawing.Size(110, 46);
            this.btn_LoadHDCT.TabIndex = 14;
            this.btn_LoadHDCT.Text = "Load HĐCT";
            this.btn_LoadHDCT.UseVisualStyleBackColor = false;
            this.btn_LoadHDCT.Click += new System.EventHandler(this.btn_LoadHDCT_Click);
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.BackColor = System.Drawing.Color.Transparent;
            this.lb_MaHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_MaHD.Location = new System.Drawing.Point(1064, 378);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(59, 20);
            this.lb_MaHD.TabIndex = 10;
            this.lb_MaHD.Text = "Mã HD";
            // 
            // cbb_ChonHD
            // 
            this.cbb_ChonHD.FormattingEnabled = true;
            this.cbb_ChonHD.Location = new System.Drawing.Point(1128, 375);
            this.cbb_ChonHD.Name = "cbb_ChonHD";
            this.cbb_ChonHD.Size = new System.Drawing.Size(121, 28);
            this.cbb_ChonHD.TabIndex = 20;
            this.cbb_ChonHD.SelectedIndexChanged += new System.EventHandler(this.cbb_ChonHD_SelectedIndexChanged);
            // 
            // btnXoaHDCT
            // 
            this.btnXoaHDCT.BackColor = System.Drawing.Color.Red;
            this.btnXoaHDCT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaHDCT.Location = new System.Drawing.Point(1332, 366);
            this.btnXoaHDCT.Name = "btnXoaHDCT";
            this.btnXoaHDCT.Size = new System.Drawing.Size(110, 46);
            this.btnXoaHDCT.TabIndex = 21;
            this.btnXoaHDCT.Text = "Xoá HĐ";
            this.btnXoaHDCT.UseVisualStyleBackColor = false;
            this.btnXoaHDCT.Click += new System.EventHandler(this.btnXoaHDCT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1424, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1220, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhân Viên:";
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.BackColor = System.Drawing.Color.Transparent;
            this.lbtennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtennv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtennv.Location = new System.Drawing.Point(1336, 54);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(72, 25);
            this.lbtennv.TabIndex = 23;
            this.lbtennv.Text = "tên NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(666, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 75);
            this.label2.TabIndex = 24;
            this.label2.Text = "MOBILE STORE";
            // 
            // dgv_sp
            // 
            this.dgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sp.Location = new System.Drawing.Point(40, 100);
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.RowHeadersWidth = 62;
            this.dgv_sp.RowTemplate.Height = 28;
            this.dgv_sp.Size = new System.Drawing.Size(20, 25);
            this.dgv_sp.TabIndex = 19;
            // 
            // fStaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::QuanLiCuaHangDienThoai.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(1584, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtennv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Label lb_SL;
        private System.Windows.Forms.ComboBox cbb_ChonHD;
        private System.Windows.Forms.Button btnXoaHDCT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_sp;
        private System.Windows.Forms.Label label3;
    }
}