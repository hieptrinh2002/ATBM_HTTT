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
    public partial class TruongDeAn : Form
    {
        public TruongDeAn()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }
        }

        private void btn_ThongTinPB_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEM_THONGTIN_PHONGBAN";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }
        }

        private void btn_ThongTinPC_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.UV_NHANVIEN_XEM_DSPHANCONG";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }
        }

        private void btn_ThongTinDA_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEM_THONGTIN_DEAN";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem thông tin đề án !");
            }
        }

        private void btn_ThemDA_Click(object sender, EventArgs e)
        {
            ThemDeAn screen = new ThemDeAn();
            screen.Show();
        }

        private void btn_Xoa_Sua_Click(object sender, EventArgs e)
        {
            Xoa_SuaDeAn screen = new Xoa_SuaDeAn();
            screen.Show();
        }

        private void TruongDeAn_Load(object sender, EventArgs e)
        {

        }
    }
}