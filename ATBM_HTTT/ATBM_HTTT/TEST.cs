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
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void TEST_Load(object sender, EventArgs e)
        {

        }

        private void loadMaDA()
        {
            string query = "SELECT MADA FROM QLTGDA.VIEW_NHANVIEN_XEM_THONGTIN_DEAN";
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

            cmbMaDA.DataSource = data;
            cmbMaDA.DisplayMember = "MADA";
            cmbMaDA.ValueMember = "MADA";
        }

        private void cmbMaDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaDA = cmbMaDA.SelectedValue.ToString();

            try
            {
                using (OracleConnection conn = Connection.GetDBConnection())
                {
                    conn.Open();

                    string query = "SELECT TENDA, NGAYBD, PHONG FROM QLTGDA.VIEW_HIENTHI_ALL_DEAN WHERE MADA = @mada";

                    using (OracleCommand command = new OracleCommand(query, conn))
                    {
                        command.Parameters.Add(new OracleParameter("mada", selectedMaDA));

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display the retrieved information in TextBox controls
                                txtTenDA.Text = reader["TENDA"].ToString();
                                txtPhongBan.Text = reader["PHONG"].ToString();

                                if (DateTime.TryParse(reader["NGAYBD"].ToString(), out DateTime ngayBD))
                                {
                                    dtpNgayBD.Value = ngayBD;
                                }
                                else
                                {
                                    // Handle the case when the retrieved date is not valid
                                    dtpNgayBD.Value = DateTime.Now; // or set a default value
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }
        }

        private void btn_XoaDA_Click(object sender, EventArgs e)
        {
            panel_DEAN.Enabled = false;
            string selectedMaDA = cmbMaDA.SelectedValue.ToString();

            try
            {
                using (OracleConnection conn = Connection.GetDBConnection())
                {
                    conn.Open();


                    string query = "DELETE FROM QLTGDA.VIEW_HIENTHI_ALL_DEAN WHERE MADA = :mada";

                    using (OracleCommand command = new OracleCommand(query, conn))
                    {
                        command.Parameters.Add(new OracleParameter("mada", selectedMaDA));
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đề án với mã " + selectedMaDA + " đã được xóa");

                            // Clear the TextBox controls and refresh the ComboBox after deletion
                            txtTenDA.Text = string.Empty;
                            txtPhongBan.Text = string.Empty;
                            dtpNgayBD.Value = DateTime.Now;
                            loadMaDA(); // Refresh the ComboBox
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy đề án với mã " + selectedMaDA);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the deletion
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_SuaDA_Click(object sender, EventArgs e)
        {
            panel_DEAN.Enabled = true;
            string selectedMaDA = cmbMaDA.SelectedValue.ToString();
            string updatedTENDA = txtTenDA.Text;
            string updatedPHONG = txtPhongBan.Text;
            DateTime updatedNGAYBD = dtpNgayBD.Value;

            try
            {
                using (OracleConnection conn = Connection.GetDBConnection())
                {
                    conn.Open();


                    string query = "UPDATE QLTGDA.VIEW_HIENTHI_ALL_DEAN SET TENDA = :tenda, NGAYBD = :ngaybd, PHONG = :phong WHERE MADA = :mada";


                    using (OracleCommand command = new OracleCommand(query, conn))
                    {
                        command.Parameters.Add(new OracleParameter("tenda", updatedTENDA));
                        command.Parameters.Add(new OracleParameter("ngaybd", updatedNGAYBD));
                        command.Parameters.Add(new OracleParameter("phong", updatedPHONG));
                        command.Parameters.Add(new OracleParameter("mada", selectedMaDA));
                        int rowsAffected = command.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đề án với mã " + selectedMaDA + " đã được thay đổi");
                            loadMaDA();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy đề án với mã " + selectedMaDA);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Xoa_SuaDeAn_Load(object sender, EventArgs e)
        {

        }
    }
}
