using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLDiemSinhVien.Model;
namespace DoAnQLDiemSinhVien
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangDiem nhapdiem = new BangDiem();
            nhapdiem.Show();
            

        }     

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Đóng form lại ==> kết thúc chương trình
            Application.Exit();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimDiemSinhVien timkiem = new TimDiemSinhVien();
            timkiem.Show();
           
        }

        private void mnuDSSV_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien dssv = new DanhSachSinhVien();
            dssv.Show();
            
        }

        private void mnuDSGV_Click(object sender, EventArgs e)
        {
            DanhSachGiangVien dsgv = new DanhSachGiangVien();
            dsgv.Show();
            
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }   
    }
}
