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
    public partial class TaiChinh : Form
    {
        string vaitro = "Nhân viên";
        public TaiChinh()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        public void refreshDSNV()
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.NHANVIEN";
                dataGridViewDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDSNV.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem danh sách nhan vien thuộc phòng ban _"+ex.Message.ToString()+"");
            }
        }
        private void TaiChinh_Load(object sender, EventArgs e)
        {
            refreshDSNV();
        }

        private void btn_pc_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.UV_NHANVIEN_XEM_DSPHANCONG";
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem thông tin phân công !");
            }
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
            string query = @"select * from QLTGDA.UV_XEMDS_NHANVIEN";////////////////////// CHANGE
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


        private void dataGridViewDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewDSNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewDSNV.CurrentRow.Selected = true;
                textBox_manv.Text = dataGridViewDSNV.Rows[e.RowIndex].Cells["MANV"].FormattedValue.ToString();
                textBox_hoten.Text = dataGridViewDSNV.Rows[e.RowIndex].Cells["TENNV"].FormattedValue.ToString();
                textBox_sdt.Text = dataGridViewDSNV.Rows[e.RowIndex].Cells["SODT"].FormattedValue.ToString();
                textBox_Luong.Text = dataGridViewDSNV.Rows[e.RowIndex].Cells["LUONG"].FormattedValue.ToString();
                textBox_PhuCap.Text = dataGridViewDSNV.Rows[e.RowIndex].Cells["PHUCAP"].FormattedValue.ToString();
                vaitro = dataGridViewDSNV.Rows[e.RowIndex].Cells["VAITRO"].FormattedValue.ToString();
            }    
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {

            if( vaitro == "Ban giám đốc")
            {
                MessageBox.Show("bạn không có quyền update lương giám đốc !!");
                return;
            }    
            if (textBox_Luong.Text.Trim().ToString() == "")
            {
                MessageBox.Show("luong is not null plss !!");
                return;
            }


            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();

                string query = @"QLTGDA.SP_TAICHINH_UPDATE_LUONG_PHUCAP_NHANVIEN";
                OracleCommand command = new OracleCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;


                var manv = new OracleParameter("@manv", "");
                var luong = new OracleParameter("@luong", "");
                var phuCap = new OracleParameter("@phuCap", "");
                

                command.Parameters.Add(manv);
                command.Parameters.Add(luong);
                command.Parameters.Add(phuCap);

                manv.Value = textBox_manv.Text.ToString();
                luong.Value = textBox_Luong.Text.ToString();
                phuCap.Value = textBox_PhuCap.Text.ToString();
                

                command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công !");
                refreshDSNV();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi cập nhật lương !", ex.Message.ToString());
                refreshDSNV();
            }

        }

        private void button_dangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
