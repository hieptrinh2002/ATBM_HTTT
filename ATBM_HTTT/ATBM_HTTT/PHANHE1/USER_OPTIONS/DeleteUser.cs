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
    public partial class DeleteUser : Form
    {

        private string query = "";
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void handleDelete_User(string username)
        {
            query = "SELECT count(*) FROM ALL_USERS WHERE USERNAME = '" + username + "'";

            if (Convert.ToInt32(Dataprovider.Instance.ExecuteScalar(query).ToString()) < 1)
            {
                label_invalid_username_deleteform.Text = "NOTE : user " + username + "  không tồn tại !";
                label_invalid_username_deleteform.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {   
                try
                {
                    if(DeleteUserInDatabase(username))
                    {
                        label_invalid_username_deleteform.Text = "";
                        MessageBox.Show("xóa thành công !");
                        this.Hide();
                       
                    }    
                    else
                    {
                        MessageBox.Show("xóa không thành công !");
                        this.Hide();
                    }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi xóa User : " + ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_invalid_username_deleteform.Text = "";

            string username = textBox_username_deleteUser.Text.ToString();
            if (username == "" )
            {
                label_invalid_username_deleteform.Text = "username is empty !";
                label_invalid_username_deleteform.ForeColor = System.Drawing.Color.Red;
                return;
            }

            handleDelete_User(username);
        }


        public bool DeleteUserInDatabase(String username)
        {

            bool status = false;
            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = Connection.GetDBConnection();

            conn.Open();
            try
            {
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                if (checkBox_cascade_dropUser.Checked == true)
                {
                    oc.CommandText = "Proc_DROP_User_CASCADE ";
                }
                else
                {
                    oc.CommandText = "Proc_DROP_User ";
                }
                oc.CommandType = CommandType.StoredProcedure;
                oc.Parameters.Add(new OracleParameter("@User_name", OracleDbType.Varchar2)).Value = username;
                oc.Parameters["@User_name"].Direction = ParameterDirection.Input;
                oc.ExecuteNonQuery();
                status = true;

                return status;
            }
            catch(Exception e)
            {
                MessageBox.Show("lỗi xóa user :" + e.ToString());
            }
            finally
            {
                conn.Close(); 
            }
            return status;
           
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {

        }
    }
}
