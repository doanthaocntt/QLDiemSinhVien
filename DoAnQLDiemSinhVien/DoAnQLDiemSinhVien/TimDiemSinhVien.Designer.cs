
namespace DoAnQLDiemSinhVien
{
    partial class TimDiemSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimDiemSinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tenCN = new System.Windows.Forms.ComboBox();
            this.cHUYENNGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_MH = new System.Windows.Forms.ComboBox();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridtimkiem = new System.Windows.Forms.DataGridView();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridtimkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(288, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(953, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin điểm sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_tenCN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cb_tenCN
            // 
            this.cb_tenCN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cHUYENNGANHBindingSource, "MSCN", true));
            this.cb_tenCN.DataSource = this.cHUYENNGANHBindingSource;
            this.cb_tenCN.DisplayMember = "TenCN";
            this.cb_tenCN.FormattingEnabled = true;
            this.cb_tenCN.Location = new System.Drawing.Point(205, 53);
            this.cb_tenCN.Name = "cb_tenCN";
            this.cb_tenCN.Size = new System.Drawing.Size(230, 33);
            this.cb_tenCN.TabIndex = 2;
            this.cb_tenCN.ValueMember = "MSCN";
            this.cb_tenCN.SelectedIndexChanged += new System.EventHandler(this.cb_tenCN_SelectedIndexChanged);
            // 
            // cHUYENNGANHBindingSource
            // 
            this.cHUYENNGANHBindingSource.DataSource = typeof(DoAnQLDiemSinhVien.Model.CHUYENNGANH);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chuyên ngành";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_MH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMSSV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 195);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // cb_MH
            // 
            this.cb_MH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mONBindingSource, "MaMon", true));
            this.cb_MH.DataSource = this.mONBindingSource;
            this.cb_MH.DisplayMember = "TenMon";
            this.cb_MH.FormattingEnabled = true;
            this.cb_MH.Location = new System.Drawing.Point(205, 114);
            this.cb_MH.Name = "cb_MH";
            this.cb_MH.Size = new System.Drawing.Size(230, 33);
            this.cb_MH.TabIndex = 6;
            this.cb_MH.ValueMember = "MaMon";
            this.cb_MH.SelectedIndexChanged += new System.EventHandler(this.cb_MH_SelectedIndexChanged);
            // 
            // mONBindingSource
            // 
            this.mONBindingSource.DataSource = typeof(DoAnQLDiemSinhVien.Model.MON);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Môn học";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(205, 50);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(230, 30);
            this.txtMSSV.TabIndex = 4;
            this.txtMSSV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMSSV_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "MSSV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridtimkiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(491, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(995, 334);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // gridtimkiem
            // 
            this.gridtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridtimkiem.Location = new System.Drawing.Point(3, 26);
            this.gridtimkiem.Name = "gridtimkiem";
            this.gridtimkiem.RowHeadersWidth = 51;
            this.gridtimkiem.RowTemplate.Height = 24;
            this.gridtimkiem.Size = new System.Drawing.Size(989, 305);
            this.gridtimkiem.TabIndex = 0;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataSource = typeof(DoAnQLDiemSinhVien.Model.SINHVIEN);
            // 
            // TimDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1491, 455);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimDiemSinhVien";
            this.Text = "TimDiemSinhVien";
            this.Load += new System.EventHandler(this.TimDiemSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridtimkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_tenCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridtimkiem;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private System.Windows.Forms.BindingSource cHUYENNGANHBindingSource;
        private System.Windows.Forms.ComboBox cb_MH;
        private System.Windows.Forms.BindingSource mONBindingSource;
    }
}