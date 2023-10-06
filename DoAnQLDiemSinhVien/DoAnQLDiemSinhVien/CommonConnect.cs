using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnQLDiemSinhVien
{
    internal class CommonConnect
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlCommand cmd1;
        private SqlDataReader reader1;
        private SqlCommand cmd2;
        private SqlDataReader reader2;
        // Trả về đối tượng kết nối
        public SqlConnection Connected()
        {
            string conect = SystemInformation.UserDomainName.ToString();
            string source = @"Data Source=AZDOAN\AZDOAN;Initial Catalog=Quanlydiem;Integrated Security=True";
            conn = new SqlConnection(source);
            conn.Open();
            return conn;
        }
    }
}