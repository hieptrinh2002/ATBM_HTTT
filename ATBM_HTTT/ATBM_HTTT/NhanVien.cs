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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btn_pc_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_PB_Click(object sender, EventArgs e)
        {

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }
        }

        private void btn_infor_Click(object sender, EventArgs e)
        {

        }
        public static void refresh_Datagridview()
        {
           
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
