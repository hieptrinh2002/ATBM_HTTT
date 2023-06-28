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
    public partial class TruongPhong : Form
    {
        public TruongPhong()
        {
            InitializeComponent();
        }

        private void button_DSPC_TC_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.VIEW_TRUONGPHONG_THONGTIN_PHANCONG";
                dataGridViewQLPC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewQLPC.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem thông tin phân công !");
            }
        }

        private void button_DSDA_TC_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEM_THONGTIN_DEAN";
                dataGridView_TC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_TC.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem thông tin đề án !");
            }
        }

        private void button_TTCN_TC_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEMTHONGTIN_CANHAN";////////////////////// CHANGE
            OracleCommand command = new OracleCommand(query, conn);

            var reader = command.ExecuteReader();

            //MessageBox.Show(reader["MANV"].ToString());


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

        private void button_DX_TC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_insertPC_Click(object sender, EventArgs e)
        {
            XuLyPhanCong xl = new XuLyPhanCong("Thêm","Thêm Phân Công");
            xl.ShowDialog();
        }

        private void button_updatePC_Click(object sender, EventArgs e)
        {
            XuLyPhanCong xl = new XuLyPhanCong("Cập Nhật","cập Nhật Phân Công");
            xl.ShowDialog();
        }

        private void button_deletePC_Click(object sender, EventArgs e)
        {
            XuLyPhanCong xl = new XuLyPhanCong(" Xóa","Xóa Phân Công");
            xl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEM_THONGTIN_PHONGBAN";
                dataGridView_TC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_TC.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem thông tin phòng ban !");
            }
        }

        private void button_DSNV_QLNV_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.UV_TRUONGPHONG_XEM_DS_NHANVIEN";
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView3.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem danh sách nhan vien thuộc phòng ban !");
            }
        }

        private void button_DX_QLNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TruongPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
