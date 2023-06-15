using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Oracle.DataAccess.Client;
using System.Configuration;


namespace ATBM_HTTT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        public void runMainForm(object obj)
        {
            Application.Run(new MainForm());// có thể truyền tham số 
        }

        private bool check_login()
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
               
           

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            txtWarning.Text = "";
            string username = textBox_username.Text.ToString();
            string password = textBox_password.Text.ToString();
            Connection.username = username;
            Connection.password = password;
            if (string.IsNullOrEmpty(username))
            {
                txtWarning.Text = "Bạn chưa nhập tên đăng nhập";
                txtWarning.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                txtWarning.Text = "Bạn chưa nhập mật khẩu";
                txtWarning.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (check_login())
            {
                MessageBox.Show(" đăng nhập thành công !");
                this.Hide();
                Thread t;
                t = new Thread(runMainForm);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else
            {
                txtWarning.Text = "username or password is invalid !";
                txtWarning.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}
