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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnDong = new System.Windows.Forms.Button();
            this.timHDTableAdapter = new QuanLiCuaHangDienThoai.QuanLiCuaHangDienThoaiDataSetTableAdapters.timHDTableAdapter();
            this.quanLiCuaHangDienThoaiDataSet = new QuanLiCuaHangDienThoai.QuanLiCuaHangDienThoaiDataSet();
            this.hDCTMaHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDCTMaHDTableAdapter = new QuanLiCuaHangDienThoai.QuanLiCuaHangDienThoaiDataSetTableAdapters.HDCTMaHDTableAdapter();
            this.timHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quanLiCuaHangDienThoaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDCTMaHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hDCTMaHDBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.timHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
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
            // timHDTableAdapter
            // 
            this.timHDTableAdapter.ClearBeforeFill = true;
            // 
            // quanLiCuaHangDienThoaiDataSet
            // 
            this.quanLiCuaHangDienThoaiDataSet.DataSetName = "QuanLiCuaHangDienThoaiDataSet";
            this.quanLiCuaHangDienThoaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hDCTMaHDBindingSource
            // 
            this.hDCTMaHDBindingSource.DataMember = "HDCTMaHD";
            this.hDCTMaHDBindingSource.DataSource = this.quanLiCuaHangDienThoaiDataSet;
            // 
            // hDCTMaHDTableAdapter
            // 
            this.hDCTMaHDTableAdapter.ClearBeforeFill = true;
            // 
            // timHDBindingSource
            // 
            this.timHDBindingSource.DataMember = "timHD";
            this.timHDBindingSource.DataSource = this.quanLiCuaHangDienThoaiDataSet;
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
            ((System.ComponentModel.ISupportInitialize)(this.quanLiCuaHangDienThoaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDCTMaHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnDong;
        private QuanLiCuaHangDienThoaiDataSetTableAdapters.timHDTableAdapter timHDTableAdapter;
        private System.Windows.Forms.BindingSource hDCTMaHDBindingSource;
        private QuanLiCuaHangDienThoaiDataSet quanLiCuaHangDienThoaiDataSet;
        private System.Windows.Forms.BindingSource timHDBindingSource;
        private QuanLiCuaHangDienThoaiDataSetTableAdapters.HDCTMaHDTableAdapter hDCTMaHDTableAdapter;
    }
}