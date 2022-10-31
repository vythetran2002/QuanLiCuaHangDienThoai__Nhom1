
namespace QuanLiCuaHangDienThoai.Forms
{
    partial class flogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LoginName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(135)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(619, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thông tin đăng nhập";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(124)))));
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(183, 560);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 41);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address: 1A Street, District, City";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(124)))));
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(203, 540);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact: 0123-456-789";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.Brown;
            this.btn_Login.Location = new System.Drawing.Point(740, 521);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(113, 49);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "log in";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_PassWord.Location = new System.Drawing.Point(603, 446);
            this.txt_PassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PassWord.Multiline = true;
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.PasswordChar = '*';
            this.txt_PassWord.Size = new System.Drawing.Size(469, 41);
            this.txt_PassWord.TabIndex = 2;
            this.txt_PassWord.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(596, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginName.Location = new System.Drawing.Point(603, 278);
            this.txt_LoginName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LoginName.Multiline = true;
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Size = new System.Drawing.Size(469, 42);
            this.txt_LoginName.TabIndex = 1;
            this.txt_LoginName.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(156)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(596, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLiCuaHangDienThoai.Properties.Resources.bg_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1212, 645);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_LoginName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "flogin";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LoginName;
        private System.Windows.Forms.Label label1;
    }
}