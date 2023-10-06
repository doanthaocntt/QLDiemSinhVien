
namespace DoAnQLDiemSinhVien
{
    partial class BangDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangDiem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_MonHoc = new System.Windows.Forms.ComboBox();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cHUYENNGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbHanhKiem = new System.Windows.Forms.ComboBox();
            this.cb_SV = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.tinh = new System.Windows.Forms.Button();
            this.txtDiemtongket = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTh4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdiemthuchanh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdiemgiuaki = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdiemthuongki = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHocKi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grid_dsSinhVien = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cHUYENNGANHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_MonHoc);
            this.groupBox1.Controls.Add(this.cb_lop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cb_MonHoc
            // 
            this.cb_MonHoc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mONBindingSource, "MaMon", true));
            this.cb_MonHoc.DataSource = this.mONBindingSource;
            this.cb_MonHoc.DisplayMember = "TenMon";
            this.cb_MonHoc.FormattingEnabled = true;
            this.cb_MonHoc.Location = new System.Drawing.Point(196, 123);
            this.cb_MonHoc.Name = "cb_MonHoc";
            this.cb_MonHoc.Size = new System.Drawing.Size(286, 33);
            this.cb_MonHoc.TabIndex = 5;
            this.cb_MonHoc.ValueMember = "MaMon";
            this.cb_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cb_MonHoc_SelectedIndexChanged);
            // 
            // mONBindingSource
            // 
            this.mONBindingSource.DataSource = typeof(DoAnQLDiemSinhVien.Model.MON);
            // 
            // cb_lop
            // 
            this.cb_lop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOPBindingSource, "MaLop", true));
            this.cb_lop.DataSource = this.lOPBindingSource;
            this.cb_lop.DisplayMember = "TenLop";
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(196, 53);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(286, 33);
            this.cb_lop.TabIndex = 4;
            this.cb_lop.ValueMember = "MaLop";
            this.cb_lop.SelectedIndexChanged += new System.EventHandler(this.cb_lop_SelectedIndexChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataSource = typeof(DoAnQLDiemSinhVien.Model.LOP);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lớp";
            // 
            // cHUYENNGANHBindingSource
            // 
            this.cHUYENNGANHBindingSource.DataSource = typeof(DoAnQLDiemSinhVien.Model.CHUYENNGANH);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(562, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(3, 26);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(561, 181);
            this.txtGhiChu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Điểm Sinh Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbHanhKiem);
            this.groupBox3.Controls.Add(this.cb_SV);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tinh);
            this.groupBox3.Controls.Add(this.txtDiemtongket);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTh4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtdiemthuchanh);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtdiemgiuaki);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtdiemthuongki);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtHocKi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtDiemThi);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(18, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1114, 187);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết";
            // 
            // cbHanhKiem
            // 
            this.cbHanhKiem.FormattingEnabled = true;
            this.cbHanhKiem.Location = new System.Drawing.Point(175, 125);
            this.cbHanhKiem.Name = "cbHanhKiem";
            this.cbHanhKiem.Size = new System.Drawing.Size(167, 33);
            this.cbHanhKiem.TabIndex = 25;
            // 
            // cb_SV
            // 
            this.cb_SV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sINHVIENBindingSource, "MaSV", true));
            this.cb_SV.DataSource = this.sINHVIENBindingSource;
            this.cb_SV.DisplayMember = "HoTenSV";
            this.cb_SV.FormattingEnabled = true;
            this.cb_SV.Location = new System.Drawing.Point(175, 33);
            this.cb_SV.Name = "cb_SV";
            this.cb_SV.Size = new System.Drawing.Size(325, 33);
            this.cb_SV.TabIndex = 24;
            this.cb_SV.ValueMember = "MaSV";
            this.cb_SV.SelectedIndexChanged += new System.EventHandler(this.cb_SV_SelectedIndexChanged);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataSource = typeof(DoAnQLDiemSinhVien.Model.SINHVIEN);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "Hạnh kiểm";
            // 
            // tinh
            // 
            this.tinh.Location = new System.Drawing.Point(806, 138);
            this.tinh.Name = "tinh";
            this.tinh.Size = new System.Drawing.Size(41, 30);
            this.tinh.TabIndex = 21;
            this.tinh.Text = "...";
            this.tinh.UseVisualStyleBackColor = true;
            this.tinh.Click += new System.EventHandler(this.tinh_Click);
            // 
            // txtDiemtongket
            // 
            this.txtDiemtongket.Enabled = false;
            this.txtDiemtongket.Location = new System.Drawing.Point(741, 138);
            this.txtDiemtongket.Name = "txtDiemtongket";
            this.txtDiemtongket.Size = new System.Drawing.Size(59, 30);
            this.txtDiemtongket.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(870, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "Thang điểm 4";
            // 
            // txtTh4
            // 
            this.txtTh4.Enabled = false;
            this.txtTh4.Location = new System.Drawing.Point(1008, 136);
            this.txtTh4.Name = "txtTh4";
            this.txtTh4.Size = new System.Drawing.Size(58, 30);
            this.txtTh4.TabIndex = 16;
            this.txtTh4.TextChanged += new System.EventHandler(this.txtTh4_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Điểm tổng kết";
            // 
            // txtdiemthuchanh
            // 
            this.txtdiemthuchanh.Location = new System.Drawing.Point(742, 86);
            this.txtdiemthuchanh.Name = "txtdiemthuchanh";
            this.txtdiemthuchanh.Size = new System.Drawing.Size(58, 30);
            this.txtdiemthuchanh.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(545, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Điểm thực hành";
            // 
            // txtdiemgiuaki
            // 
            this.txtdiemgiuaki.Location = new System.Drawing.Point(1008, 30);
            this.txtdiemgiuaki.Name = "txtdiemgiuaki";
            this.txtdiemgiuaki.Size = new System.Drawing.Size(59, 30);
            this.txtdiemgiuaki.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(871, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Điểm giữa kì";
            // 
            // txtdiemthuongki
            // 
            this.txtdiemthuongki.Location = new System.Drawing.Point(742, 33);
            this.txtdiemthuongki.Name = "txtdiemthuongki";
            this.txtdiemthuongki.Size = new System.Drawing.Size(59, 30);
            this.txtdiemthuongki.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(545, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Điểm thường kì";
            // 
            // txtHocKi
            // 
            this.txtHocKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHocKi.Location = new System.Drawing.Point(175, 82);
            this.txtHocKi.Name = "txtHocKi";
            this.txtHocKi.Size = new System.Drawing.Size(76, 30);
            this.txtHocKi.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(18, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Học Kì";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiemThi.Location = new System.Drawing.Point(1008, 86);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(58, 26);
            this.txtDiemThi.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(871, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Điểm thi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(18, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sinh viên";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grid_dsSinhVien);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(15, 498);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1256, 339);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // grid_dsSinhVien
            // 
            this.grid_dsSinhVien.AllowUserToOrderColumns = true;
            this.grid_dsSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dsSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_dsSinhVien.Location = new System.Drawing.Point(3, 26);
            this.grid_dsSinhVien.Name = "grid_dsSinhVien";
            this.grid_dsSinhVien.RowHeadersWidth = 51;
            this.grid_dsSinhVien.RowTemplate.Height = 24;
            this.grid_dsSinhVien.Size = new System.Drawing.Size(1250, 310);
            this.grid_dsSinhVien.TabIndex = 0;
            this.grid_dsSinhVien.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsSinhVien_CellEndEdit);
            this.grid_dsSinhVien.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsSinhVien_CellEnter);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Cyan;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnSua.Location = new System.Drawing.Point(1150, 171);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 42);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnXoa.Location = new System.Drawing.Point(1153, 374);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 41);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnThoat.Location = new System.Drawing.Point(1153, 446);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 42);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnThem.Location = new System.Drawing.Point(1150, 99);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cHUYENNGANHBindingSource1
            // 
            this.cHUYENNGANHBindingSource1.DataSource = typeof(DoAnQLDiemSinhVien.Model.CHUYENNGANH);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.Yellow;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnXuatExcel.Location = new System.Drawing.Point(1153, 276);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(118, 42);
            this.btnXuatExcel.TabIndex = 9;
            this.btnXuatExcel.Text = "XUẤT";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1280, 834);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BangDiem";
            this.Text = "BangDiem";
            this.Load += new System.EventHandler(this.BangDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_MonHoc;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtHocKi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grid_dsSinhVien;
        private System.Windows.Forms.TextBox txtdiemgiuaki;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdiemthuongki;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdiemthuchanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private System.Windows.Forms.BindingSource cHUYENNGANHBindingSource;
        private System.Windows.Forms.BindingSource cHUYENNGANHBindingSource1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTh4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiemtongket;
        private System.Windows.Forms.Button tinh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_SV;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private System.Windows.Forms.ComboBox cbHanhKiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnXuatExcel;
    }
}