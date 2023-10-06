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
    public partial class DanhSachSinhVien : Form
    {
        public DanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSSinhVien.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Fill(this.DSSinhVien.SINHVIEN);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachSinhVien f = new DanhSachSinhVien();
            f.MdiParent = this;
            f.Show();
        }
    }
}
