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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if(txtNhanVien.Text.Trim().ToString() == "") 
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống!");
                return;
            }

            OracleConnection conn = ConnectionState.GetDBConnection();
            conn.Open();
            try
            {
                OracleCommand command = new OracleCommand("ATBM.USP_TAICHINH_UPDATE_LUONG_PHUCAP_NHANVIEN", conn);
                command.CommandType = CommandType.StoredProcedure;

                var nhanvien = new OracleParameter("@tennv", "");
                var luong = new OracleParameter("@luong", "");
                var phucap = new OracleParameter("@phucap", "");

                command.Parameters.Add(tennv);
                command.Parameters.Add(luong);
                command.Parameters.Add(phuCap);

                nhanvien.Value = txtNhanVien.Text.ToString();
                luong.Value = txtLuong.Text.ToString();
                phucap.Value = txtPhuCap.Text.ToString();

                command.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công.");

                txtNhanVien.Clear();
                txtLuong.Clear();
                txtPhuCap.Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
