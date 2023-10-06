using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQLDiemSinhVien.Model;
namespace DoAnQLDiemSinhVien
{
    public partial class Login : Form
    {
        QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
        //Khai báo đối tượng Commonconnect
       

        //public static bool kt1, kt2;
        public Login()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form lại ==> kết thúc chương trình
            //DialogResult thongbao;
            //thongbao = (MessageBox.Show("Bạn muốn thoát hay không ?", "Thông Báo",
            //                            MessageBoxButtons.YesNo,
            //                            MessageBoxIcon.Warning));
            //if (thongbao == DialogResult.Yes)
            //    this.Close();
            this.Close(); 
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var Tendangnhap = txtusername.Text;
            var Matkhau = txtpassword.Text;
            GIANGVIEN lg = db.GIANGVIENs.SingleOrDefault(n => n.Username == Tendangnhap && n.Password == Matkhau);
            if (lg != null)
            {
                MainMenu menu = new MainMenu();
                menu.Show();              
                this.Hide();

            }
            else
                 MessageBox.Show("Sai Username hoặc password ");
        }
    
        private void Login_Load(object sender, EventArgs e)
        {

           
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đóng form lại ==> kết thúc chương trình
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn muốn thoát hay không ?", "Thông Báo",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning));
            if (thongbao != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}

