namespace QuanLiCuaHangDienThoai.Forms
{
    partial class XuatBill
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hDCTMaHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiCuaHangDienThoaiDataSet = new QuanLiCuaHangDienThoai.QuanLiCuaHangDienThoaiDataSet();
            this.timHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnDong = new System.Windows.Forms.Button();
            this.hDCTMaHDTableAdapter = new QuanLiCuaHangDienThoai.QuanLiCuaHangDienThoaiDataSetTableAdapters.HDCTMaHDTableAdapter();
            this.timHDTableAdapter = new QuanLiCuaHangDienThoai.QuanLiCuaHangDienThoaiDataSetTableAdapters.timHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hDCTMaHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiCuaHangDienThoaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hDCTMaHDBindingSource
            // 
            this.hDCTMaHDBindingSource.DataMember = "HDCTMaHD";
            this.hDCTMaHDBindingSource.DataSource = this.quanLiCuaHangDienThoaiDataSet;
            // 
            // quanLiCuaHangDienThoaiDataSet
            // 
            this.quanLiCuaHangDienThoaiDataSet.DataSetName = "QuanLiCuaHangDienThoaiDataSet";
            this.quanLiCuaHangDienThoaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timHDBindingSource
            // 
            this.timHDBindingSource.DataMember = "timHD";
            this.timHDBindingSource.DataSource = this.quanLiCuaHangDienThoaiDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "NDBill";
            reportDataSource3.Value = this.hDCTMaHDBindingSource;
            reportDataSource4.Name = "NDBillKH";
            reportDataSource4.Value = this.timHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLiCuaHangDienThoai.Forms.XuatBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 362);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(344, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(122, 44);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // hDCTMaHDTableAdapter
            // 
            this.hDCTMaHDTableAdapter.ClearBeforeFill = true;
            // 
            // timHDTableAdapter
            // 
            this.timHDTableAdapter.ClearBeforeFill = true;
            // 
            // XuatBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.reportViewer1);
            this.Name = "XuatBill";
            this.Text = "XuatBill";
            this.Load += new System.EventHandler(this.XuatBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hDCTMaHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiCuaHangDienThoaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.BindingSource hDCTMaHDBindingSource;
        private QuanLiCuaHangDienThoaiDataSet quanLiCuaHangDienThoaiDataSet;
        private System.Windows.Forms.BindingSource timHDBindingSource;
        private QuanLiCuaHangDienThoaiDataSetTableAdapters.HDCTMaHDTableAdapter hDCTMaHDTableAdapter;
        private QuanLiCuaHangDienThoaiDataSetTableAdapters.timHDTableAdapter timHDTableAdapter;
    }
}