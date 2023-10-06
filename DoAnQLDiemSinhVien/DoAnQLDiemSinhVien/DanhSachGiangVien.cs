using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLDiemSinhVien
{
    public partial class DanhSachGiangVien : Form
    {
        public DanhSachGiangVien()
        {
            InitializeComponent();
        }

        private void DanhSachGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSGiangVien.GIANGVIEN' table. You can move, or remove it, as needed.
            this.GIANGVIENTableAdapter.Fill(this.DSGiangVien.GIANGVIEN);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachGiangVien f = new DanhSachGiangVien();
            f.MdiParent = this;
            f.Show();
        }
    }
}
