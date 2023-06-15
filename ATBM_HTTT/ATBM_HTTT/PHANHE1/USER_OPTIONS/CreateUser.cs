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
using System.Data.Common;

//https://github.com/fithcmus-lnminh/ATBM_PhanHe1/blob/b97338dfcdb8e856049642640b22158976fd161d/Business%20Logic%20Layer/BLL.cs#L55
    //https://github.com/hduylam31/ATBM-trong-HTTT/blob/main/PhanHe1/Tao_User_Role.sql

namespace ATBM_HTTT
{
    public partial class CreateUser : Form
    {
        private string query = "";

        public CreateUser()
        {
            InitializeComponent();
        }

        private void Handle_USERS_options_Load(object sender, EventArgs e)
        {

        }

        private void createUSer_username_password(string username , string password)
        {

            // MessageBox.Show("TB: " + Dataprovider.Instance.ExecuteScalar("SELECT count(*) FROM ALL_USERS WHERE USERNAME = '" + username + "'"));
            query = "SELECT count(*) FROM ALL_USERS WHERE USERNAME = '" + username + "'";

            if (Convert.ToInt32(Dataprovider.Instance.ExecuteScalar(query).ToString()) > 0)
            {
                label_invalidUsername.Text = "NOTE : user " + username + "  đã tồn tại !";
                label_invalidUsername.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

                if (createUserInDatabase(username, password))
                {
                    MessageBox.Show("tạo user thành công!");
                }
                else
                {
                    MessageBox.Show("tạo user không thành công !");
                }
                this.Hide();
            }
        }

        private void button_Create_user_Click(object sender, EventArgs e)
        {
            label_invalidUsername.Text = "";
            string username = textBox_Username.Text.ToString();
            string password = textBox_Password.Text.ToString();

            if (username == "")
            {
                label_invalidUsername.Text = "username is empty !";
                label_invalidUsername.ForeColor = System.Drawing.Color.Red;
                return;
            }
            createUSer_username_password(username, password);
        }


        public bool createUserInDatabase(String username, String pwd)
        {
            bool status = false;
            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = Connection.GetDBConnection();

            conn.Open();
            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand( "proc_CREATE_NewUser", conn);
                oc.CommandType = CommandType.StoredProcedure;
                // Thêm tham số @user_name kiểu Varchar2.
                oc.Parameters.Add(new OracleParameter("@User_name", OracleDbType.Varchar2)).Value = username;
                oc.Parameters.Add(new OracleParameter("@Pass_Word", OracleDbType.Varchar2)).Value = pwd;

                // Đăng ký tham số @user_name là INPUT.
                oc.Parameters["@User_name"].Direction = ParameterDirection.Input;
                oc.Parameters["@Pass_Word"].Direction = ParameterDirection.Input;

                // Thực thi thủ tục.

                oc.ExecuteNonQuery();
                status = true;
                //conn.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show("lỗi tạo user :" + e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return status;
        }
    }
}
