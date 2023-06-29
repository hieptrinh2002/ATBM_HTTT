using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu
{
    public partial class TaiChinh : Form
    {
        public TaiChinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Update up = new Update();
            up.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void buttonXem_Click(object sender, EventArgs e)
        {
            OracleConnection conn = ConnectionState.GetDBConnection();
            conn.open();
            OracleCommand command = new OracleCommand("select * from ATBM.UV_XEMDS_NHANVIEN", conn);

            var reader = command.ExecuteReader();

            while(reader.Read())
            {
                NhanVien nhanvien = new NhanVien(
                    reader["MANV"].ToString(),
                    reader["TENNV"].ToString(),
                    reader["PHAI"].ToString(),
                    reader["NGAYSINH"].ToString(),
                    reader["SODT"].ToString(),
                    reader["LUONG"].ToString(),
                    reader["PHUCAP"].ToString(),
                    reader["PHG"].ToString(),
                    reader["DIACHI"].ToString());

                Form f = new ShowProfile(nhanvien);
                f.ShowDialog();
            }

            conn.Close();
        }

        private void buttonXemPhanCong_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery("select * from ATBM.UV_NHANVIEN_XEM_DSPHANCONG");
            conn.Close();
        }
    }
}
