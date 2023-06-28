using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ATBM_HTTT
{
    public partial class CapNhatThongTin : Form
    {
        public CapNhatThongTin()
        {
            InitializeComponent();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string ngaySinh = dtpNgaySinh.Text.Split(' ')[0].Replace('/', '-').ToString();
            string diaChi = txtDiaChi.Text.Trim().ToString();
            string sodt = txtSDT.Text.Trim().ToString();
            if (diaChi == "")
            {
                MessageBox.Show("Vui lòng điền thông tin địa chỉ !", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (sodt == "")
            {
                MessageBox.Show("Vui lòng điền thông tin số điện thoại !", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = "UPDATE QLTGDA.VIEW_NHANVIEN_XEMTHONGTIN_CANHAN SET NGAYSINH = to_date(:dateParam, 'MM-DD-YYYY'), DIACHI = :addressParam, SODT = :phoneParam";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("dateParam", ngaySinh));
                    cmd.Parameters.Add(new OracleParameter("addressParam", diaChi));
                    cmd.Parameters.Add(new OracleParameter("phoneParam", sodt));

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật thông tin người dùng thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
                return;
            }
        }
    }
}
