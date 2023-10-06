
namespace DoAnQLDiemSinhVien
{
    partial class DanhSachGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachGiangVien));
            this.GIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSGiangVien = new DoAnQLDiemSinhVien.DSGiangVien();
            this.GIANGVIENTableAdapter = new DoAnQLDiemSinhVien.DSGiangVienTableAdapters.GIANGVIENTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGiangVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GIANGVIENBindingSource
            // 
            this.GIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.GIANGVIENBindingSource.DataSource = this.DSGiangVien;
            // 
            // DSGiangVien
            // 
            this.DSGiangVien.DataSetName = "DSGiangVien";
            this.DSGiangVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GIANGVIENTableAdapter
            // 
            this.GIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.GIANGVIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnQLDiemSinhVien.RDSGV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(967, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(186, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH GIẢNG VIÊN";
            // 
            // DanhSachGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(999, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhSachGiangVien";
            this.Text = "DanhSachGiangVien";
            this.Load += new System.EventHandler(this.DanhSachGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSGiangVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource GIANGVIENBindingSource;
        private DSGiangVien DSGiangVien;
        private DSGiangVienTableAdapters.GIANGVIENTableAdapter GIANGVIENTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
    }
}