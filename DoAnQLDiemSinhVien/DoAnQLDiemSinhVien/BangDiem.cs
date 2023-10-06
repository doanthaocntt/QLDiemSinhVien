using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLDiemSinhVien.Model;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Excel = Microsoft.Office.Interop.Excel;

namespace DoAnQLDiemSinhVien
{
    public partial class BangDiem : Form
    {
        private int Index;
        public BangDiem()
        {
            InitializeComponent();            
        }   

        private void reset()
        {
            QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
            txtdiemthuongki.Text = "";
            txtdiemthuchanh.Text = "";
            txtDiemtongket.Text = "";
            txtDiemThi.Text = "";
            txtdiemgiuaki.Text = "";
            txtGhiChu.Text = "";
            txtHocKi.Text = "";
            txtTh4.Text = "";
            txtGhiChu.Text = "";
            grid_dsSinhVien.DataSource = db.thongtindiemsinhviens.ToList();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form lại ==> kết thúc chương trình
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn muốn thoát hay không ?", "Thông Báo",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        private void BangDiem_Load(object sender, EventArgs e)
        {
            QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
            grid_dsSinhVien.DataSource = db.thongtindiemsinhviens.ToList();  
            var mon = db.MONs.ToList();
            cb_MonHoc.DataSource = mon;
            var lop = db.LOPs.ToList();
            cb_lop.DataSource = lop;
            var sinhvien = db.SINHVIENs.ToList();
            cb_SV.DataSource = sinhvien;
            List<string> hanhKiem = new List<string>();
            hanhKiem.Add("Tốt"); 
            hanhKiem.Add("Khá");
            hanhKiem.Add("Trung bình");
            hanhKiem.Add("Kém");
            cbHanhKiem.DataSource = hanhKiem;
            grid_dsSinhVien.Columns[0].HeaderText = "Mã Sinh Viên";
            grid_dsSinhVien.Columns[1].HeaderText = "Họ & Tên";
            grid_dsSinhVien.Columns[2].HeaderText = "Tên Lớp";
            grid_dsSinhVien.Columns[3].HeaderText = "Tên Môn";
            grid_dsSinhVien.Columns[4].HeaderText = "Điểm thường kì";
            grid_dsSinhVien.Columns[5].HeaderText = "Điểm giữa kì";
            grid_dsSinhVien.Columns[6].HeaderText = "Điểm thực hành";
            grid_dsSinhVien.Columns[7].HeaderText = "Điểm thi"; 
            grid_dsSinhVien.Columns[8].HeaderText = "Điểm tổng kết";
            grid_dsSinhVien.Columns[9].HeaderText = "Hạnh kiểm";
            grid_dsSinhVien.Columns[10].HeaderText = "Học kì";
            grid_dsSinhVien.Columns[11].HeaderText = "Thang điểm 4";
            grid_dsSinhVien.Columns[12].HeaderText = "Ghi chú";
        }

        
        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOP lop = cb_lop.SelectedItem as LOP;
            QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
        }

        private void cb_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MON monhoc = cb_MonHoc.SelectedItem as MON;
            QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cb_SV.Text == "" )
                {
                    errorProvider1.SetError(cb_SV, "Sinh viên không để trống!");
                    cb_SV.Focus();
                }
                else if (cb_lop.Text == "")
                {
                    errorProvider1.SetError(cb_lop, "Lớp không để trống!");
                    cb_lop.Focus();
                }
                else if (cbHanhKiem.Text == "")
                {
                    errorProvider1.SetError(cbHanhKiem, "Hạnh kiểm không để trống!");
                    cbHanhKiem.Focus();
                }
                else if (cb_MonHoc.Text == "")
                {
                    errorProvider1.SetError(cb_MonHoc, "Môn không để trống!");
                    cb_MonHoc.Focus(); 
                }
                else if (txtHocKi.Text == "" )
                {
                    errorProvider1.SetError(txtHocKi, "Học kì không để trống!");
                    cb_MonHoc.Focus();
                }
                else if (txtdiemthuongki.Text == ""  )
                {
                    errorProvider1.SetError(txtdiemthuongki, "Điểm không để trống!");
                    cb_MonHoc.Focus();
                }
                else if (txtdiemthuchanh.Text == "")
                {
                    errorProvider1.SetError(txtdiemthuchanh, "Điểm không để trống!");
                    cb_MonHoc.Focus();
                }
                else if (txtdiemgiuaki.Text == "")
                {
                    errorProvider1.SetError(txtdiemgiuaki, "Điểm không để trống!");
                    cb_MonHoc.Focus();
                }
                else if (txtDiemThi.Text == "")
                {
                    errorProvider1.SetError(txtDiemThi, "Điểm không để trống!");
                    cb_MonHoc.Focus();
                }
                else
                {
                    QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
                    MON mh = cb_MonHoc.SelectedItem as MON;
                    string MaMonHoc = mh.MaMon;
                    SINHVIEN sv = cb_SV.SelectedItem as SINHVIEN;
                    DIEM diem = new DIEM();
                    diem.MaMon = MaMonHoc;
                    diem.MaSV = sv.MaSV;
                    diem.GhiChu = txtGhiChu.Text;
                    diem.DiemThuongKi = double.Parse(this.txtdiemthuongki.Text);
                    diem.DiemThucHanh = double.Parse(this.txtdiemthuchanh.Text);
                    diem.DiemThi = double.Parse(this.txtDiemThi.Text);
                    diem.DiemGiuaKi = double.Parse(this.txtdiemgiuaki.Text);
                    diem.HocKi = Int32.Parse(this.txtHocKi.Text);
                    diem.DiemTongKet = double.Parse(this.txtDiemtongket.Text);
                    diem.HanhKiem = cbHanhKiem.Text;
                    db.DIEMs.Add(diem);
                    db.SaveChanges();
                    grid_dsSinhVien.DataSource = db.thongtindiemsinhviens.ToList();
                    reset();
                }
                
            }
            catch (DbUpdateException ex)
            {
                SqlException Ex = ex.GetBaseException() as SqlException;
                if (Ex?.Number == 2627)
                {
                    MessageBox.Show("Sinh viên đã có điểm môn học này");
                }
                else
                {
                    throw;
                }
            }                  
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
                List<thongtindiemsinhvien> dIEMs = grid_dsSinhVien.DataSource as List<thongtindiemsinhvien>;
                thongtindiemsinhvien thongtindiemsinhvien = dIEMs[Index];
                MON mON = db.MONs.Where(x => x.TenMon == thongtindiemsinhvien.TenMon).First();
                DIEM dIEM = db.DIEMs.Where(x => x.MaSV == thongtindiemsinhvien.MaSV && x.MaMon == mON.MaMon).First();
                db.DIEMs.Remove(dIEM);
                db.SaveChanges();
                reset();
            }
            
        }

        private void txtDiemtongket_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_SV_SelectedIndexChanged(object sender, EventArgs e)
        {
            SINHVIEN sinhvien = cb_SV.SelectedItem as SINHVIEN;
            
        }

        private void txtTh4_TextChanged(object sender, EventArgs e)
        {
            double th4;
            th4 = double.Parse(this.txtDiemtongket.Text);
            if (th4 >= 8)
            {
                this.txtTh4.Text = Convert.ToString("A");
            }
            else if (th4 >= 6.5)
            {
                this.txtTh4.Text = Convert.ToString("B");
            }
            else if (th4 >= 5)
            {
                this.txtTh4.Text = Convert.ToString("C");
            }
            else if (th4 >= 4)
            {
                this.txtTh4.Text = Convert.ToString("D");
            }
            else
            {
                this.txtTh4.Text = Convert.ToString("F");
            }
        }

        private void tinh_Click(object sender, EventArgs e)
        {
            double DIEMTHI, DIEMTB, DIEMTK;
            double diemthk, diemgk, diemth;
            diemthk = double.Parse(this.txtdiemthuongki.Text);
            diemgk = double.Parse(this.txtdiemgiuaki.Text);
            diemth = double.Parse(this.txtdiemthuchanh.Text);
            DIEMTB = (diemthk + diemth + diemgk) / 3;
            if (txtDiemThi.Text == "")
            {
                this.txtDiemThi.Text = "0";
                //Tính điểm TK
                DIEMTK = (0.3 * DIEMTB + 0.7 * 0);
                this.txtDiemtongket.Text = Convert.ToString(DIEMTK);
            }

            else
            {
                DIEMTHI = double.Parse(this.txtDiemThi.Text);
                //Tính điểm TK
                DIEMTK = (0.3 * DIEMTB + 0.7 * DIEMTHI);
                this.txtDiemtongket.Text = Convert.ToString(DIEMTK);              
            }
            if (DIEMTK < 4 )
            {
                this.txtGhiChu.Text = Convert.ToString("Thi lại");
            }
            else
            {
                this.txtGhiChu.Text = Convert.ToString("");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void grid_dsSinhVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
        }

        private void grid_dsSinhVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
            List<thongtindiemsinhvien> thongtindiemsinhviens = grid_dsSinhVien.DataSource as List<thongtindiemsinhvien>;
            thongtindiemsinhvien thongtindiemsinhvien = thongtindiemsinhviens[Index];
            MON mON = db.MONs.Where(x => x.TenMon == thongtindiemsinhvien.TenMon).First();
            DIEM dIEM = db.DIEMs.Where(x => x.MaSV == thongtindiemsinhvien.MaSV && x.MaMon == mON.MaMon).First();
            dIEM.DiemGiuaKi = thongtindiemsinhvien.DiemGiuaKi;
            dIEM.DiemThuongKi = thongtindiemsinhvien.DiemThuongKi;
            dIEM.DiemThucHanh = thongtindiemsinhvien.DiemThucHanh;
            dIEM.DiemThi = thongtindiemsinhvien.DiemThi;
            dIEM.HanhKiem = thongtindiemsinhvien.HanhKiem;
            dIEM.HocKi = thongtindiemsinhvien.HocKi;
            dIEM.GhiChu = thongtindiemsinhvien.GhiChu;
            db.SaveChanges();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

            try
            {
                string pathSource = Path.GetFullPath("./Excel/DanhSachDiemSinhVien.xlsx");
                string gui = Guid.NewGuid().ToString();
                string pathRp = Path.GetFullPath($"./BangDiem/{gui}_danh_sach_diem_sv.xlsx");
                // Copy file
                File.Copy(pathSource, pathRp);        
                
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(pathRp);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                try
                {
                    List<thongtindiemsinhvien> thongtindiemsinhviens = grid_dsSinhVien.DataSource as List<thongtindiemsinhvien>;
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    for (int i = 0; i < thongtindiemsinhviens.Count; i++)
                    {
                        xlRange[i + 3, "A"] = (i+1).ToString();
                        xlRange[i + 3, "B"] = thongtindiemsinhviens[i].MaSV;
                        xlRange[i + 3, "C"] = thongtindiemsinhviens[i].HoTenSV;
                        xlRange[i + 3, "D"] = thongtindiemsinhviens[i].TenLop;
                        xlRange[i + 3, "E"] = thongtindiemsinhviens[i].TenMon;
                        xlRange[i + 3, "F"] = thongtindiemsinhviens[i].HocKi;
                        xlRange[i + 3, "G"] = thongtindiemsinhviens[i].DiemThuongKi;
                        xlRange[i + 3, "H"] = thongtindiemsinhviens[i].DiemGiuaKi;
                        xlRange[i + 3, "I"] = thongtindiemsinhviens[i].DiemThucHanh;
                        xlRange[i + 3, "J"] = thongtindiemsinhviens[i].DiemThi;
                        xlRange[i + 3, "K"] = thongtindiemsinhviens[i].DiemTongKet;
                        xlRange[i + 3, "L"] = thongtindiemsinhviens[i].THANGDIEM4;
                        xlRange[i + 3, "M"] = thongtindiemsinhviens[i].HanhKiem;                        
                    }
                    xlWorkbook.Save();                  
                    MessageBox.Show("Lưu thành công tại " + pathRp);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    xlWorkbook.Close();
                    Marshal.ReleaseComObject(xlWorkbook);
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
