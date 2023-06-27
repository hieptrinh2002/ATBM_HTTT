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
    public partial class QL_TrucTiep : Form
    {
        public QL_TrucTiep()
        {
            InitializeComponent();
        }
        private void btn_pc_Click(object sender, EventArgs e)
        {

        }

        private void btn_PB_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEM_THONGTIN_PHONGBAN";
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem thông tin phòng ban !");
            }
        }

        private void btn_deAn_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEM_THONGTIN_DEAN";
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem thông tin đề án !");
            }
        }

        private void btn_infor_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEMTHONGTIN_CANHAN";
            OracleCommand command = new OracleCommand(query, conn);

            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    NhanVien nv = new NhanVien(
                       reader["MANV"].ToString(),
                       reader["TENNV"].ToString(),
                       reader["PHAI"].ToString(),
                       reader["NGAYSINH"].ToString(),
                       reader["SODT"].ToString(),
                       reader["LUONG"].ToString(),
                       reader["PHUCAP"].ToString(),
                       reader["PHG"].ToString(),
                       reader["DIACHI"].ToString());

                    Form f = new ShowProfile(nv);
                    f.ShowDialog();
                }

            }

            conn.Close();
        }

        private void btn_dsNV_Click(object sender, EventArgs e)
        {

        }
    }
}
