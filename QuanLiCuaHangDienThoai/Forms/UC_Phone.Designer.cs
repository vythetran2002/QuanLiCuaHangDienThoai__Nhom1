namespace QuanLiCuaHangDienThoai.Forms
{
    partial class UC_Phone
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.lb_TenSP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lb_Gia);
            this.panel1.Controls.Add(this.lb_TenSP);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 309);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Location = new System.Drawing.Point(8, 277);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(51, 20);
            this.lb_Gia.TabIndex = 9;
            this.lb_Gia.Text = "label2";
            // 
            // lb_TenSP
            // 
            this.lb_TenSP.AutoSize = true;
            this.lb_TenSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_TenSP.Location = new System.Drawing.Point(8, 237);
            this.lb_TenSP.Name = "lb_TenSP";
            this.lb_TenSP.Size = new System.Drawing.Size(51, 20);
            this.lb_TenSP.TabIndex = 8;
            this.lb_TenSP.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Phone";
            this.Size = new System.Drawing.Size(190, 315);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Gia;
        private System.Windows.Forms.Label lb_TenSP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
