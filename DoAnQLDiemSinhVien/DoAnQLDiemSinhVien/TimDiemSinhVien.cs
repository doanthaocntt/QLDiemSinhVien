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
    public partial class TimDiemSinhVien : Form
    {
        public TimDiemSinhVien()
        {
            InitializeComponent();
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

        private void TimDiemSinhVien_Load(object sender, EventArgs e)
        {
            QLDiemSVNTTEntities timkiemdiem = new QLDiemSVNTTEntities();
            gridtimkiem.DataSource = timkiemdiem.thongtindiemsinhviens.ToList();
            gridtimkiem.Columns[0].HeaderText = "Mã Sinh Viên";
            gridtimkiem.Columns[1].HeaderText = "Họ & Tên";
            gridtimkiem.Columns[2].HeaderText = "Tên Lớp";
            gridtimkiem.Columns[3].HeaderText = "Tên Môn";
            gridtimkiem.Columns[4].HeaderText = "Điểm thường kì";
            gridtimkiem.Columns[5].HeaderText = "Điểm giữa kì";
            gridtimkiem.Columns[6].HeaderText = "Điểm thực hành";
            gridtimkiem.Columns[7].HeaderText = "Điểm thi";
            gridtimkiem.Columns[8].HeaderText = "Điểm tổng kết";
            gridtimkiem.Columns[9].HeaderText = "Thang điểm 4";
            cb_tenCN.DataSource = timkiemdiem.CHUYENNGANHs.ToList();
            cb_MH.DataSource = timkiemdiem.MONs.ToList();

        }             
        private void cb_MH_SelectedIndexChanged(object sender, EventArgs e)
        {
            MON monhoc = cb_MH.SelectedItem as MON;
            QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
            gridtimkiem.DataSource = db.TIMKIEM(null, monhoc.MaMon, null );
        }

        private void cb_tenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            CHUYENNGANH typeItem = cb_tenCN.SelectedItem as CHUYENNGANH;
            QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
            gridtimkiem.DataSource = db.TIMKIEM(null,null, typeItem.MSCN);
        }

        private void txtMSSV_KeyUp(object sender, KeyEventArgs e)
        {
            var mssv = txtMSSV.Text;
            QLDiemSVNTTEntities db = new QLDiemSVNTTEntities();
            gridtimkiem.DataSource = db.TIMKIEM(mssv, null, null);
        }

        
    }
}
