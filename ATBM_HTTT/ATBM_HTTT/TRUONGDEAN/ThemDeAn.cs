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
    public partial class ThemDeAn : Form
    {
        public ThemDeAn()
        {
            InitializeComponent();

            string query = "SELECT PHONG FROM QLTGDA.VIEW_NHANVIEN_XEM_THONGTIN_DEAN";
            DataTable data = new DataTable();

            using (OracleConnection conn = Connection.GetDBConnection())
            {
                conn.Open();

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Load the data into the DataTable
                        data.Load(reader);
                    }
                }
            }

            cmbPhongBan.DataSource = data;
            cmbPhongBan.DisplayMember = "PHONG";
            cmbPhongBan.ValueMember = "PHONG";
        }

        private void btn_ThemDA_Click(object sender, EventArgs e)
        {
            string maDA = txtMaDA.Text.Trim().ToString();
            string tenDA = txtTenDA.Text.Trim().ToString();
            DateTime ngayBD = dtpNgayBD.Value;
            string phongBan = cmbPhongBan.Text.Trim().ToString();

            if (maDA == "")
            {
                MessageBox.Show("Vui lòng điền thông tin mã đề án !", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tenDA == "")
            {
                MessageBox.Show("Vui lòng điền thông tin tên đề án !", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (phongBan == "")
            {
                MessageBox.Show("Vui lòng điền thông tin phòng ban !", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (OracleConnection conn = Connection.GetDBConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO QLTGDA.VIEW_HIENTHI_ALL_DEAN (MADA, TENDA, NGAYBD, PHONG) VALUES (:maDAParam, :tenDAParam, :dateParam, :phongParam)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("maDAParam", maDA));
                        cmd.Parameters.Add(new OracleParameter("tenDAParam", tenDA));
                        cmd.Parameters.Add(new OracleParameter("dateParam", ngayBD));
                        cmd.Parameters.Add(new OracleParameter("phongParam", phongBan));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm thông tin đề án thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("đề án đã tồn tại: " + ex.ToString());
                return;
            }
        }
    }
}
