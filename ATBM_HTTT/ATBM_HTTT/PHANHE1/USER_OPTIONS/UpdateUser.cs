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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void handleUpdate( string username , string newpass)
        {
            string query = "SELECT count(*) FROM ALL_USERS WHERE USERNAME = '" + username + "'";

            if (Convert.ToInt32(Dataprovider.Instance.ExecuteScalar(query).ToString()) < 1)
            {
                label_notice.Text = "NOTICE: user " + username + "  không tồn tại !";
                label_notice.ForeColor = System.Drawing.Color.Red;
            }
            else
            { 
                try
                {
                    if (UpdateUser_newPwd(username, newpass))
                    {
                        label_notice.Text = "";
                        MessageBox.Show("update thành công !");
                    }
                    else
                    {
                        MessageBox.Show("update không thành công !");
                    }
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi xóa User : " + ex.ToString());
                }
            }
        }

        private void button_update_user_Click(object sender, EventArgs e)
        {

            string username = textBox_Username_update.Text.ToString();
            string newpass = textBox_NewPassword.Text.ToString();
            if (username == "" || newpass == "")
            {
                label_notice.Text = "username or new pass is empty !";
                label_notice.ForeColor = System.Drawing.Color.Red;
                return;
            }
            handleUpdate(username, newpass);

        }

        public bool UpdateUser_newPwd(String username, String new_pwd)
        {
            bool status = false;
            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand("proc_Change_UserPassword", conn);
                oc.CommandType = CommandType.StoredProcedure;
                // Thêm tham số @user_name kiểu Varchar2.
                oc.Parameters.Add(new OracleParameter("@User_name", OracleDbType.Varchar2)).Value = username;
                oc.Parameters.Add(new OracleParameter("@New_PassWord", OracleDbType.Varchar2)).Value = new_pwd;

                // Đăng ký tham số @user_name là INPUT.
                oc.Parameters["@User_name"].Direction = ParameterDirection.Input;
                oc.Parameters["@New_PassWord"].Direction = ParameterDirection.Input;

                // Thực thi thủ tục.

                oc.ExecuteNonQuery();
                status = true;
                //conn.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show("lỗi update password user :" + e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return status;
        }
    }
}
