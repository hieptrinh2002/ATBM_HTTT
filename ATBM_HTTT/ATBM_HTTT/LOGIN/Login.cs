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
        public void runNhanVienform(object obj)
        {
            Application.Run(new NhanVien());// có thể truyền tham số 
        }
        public void runQuanLyTTForm(object obj)
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

                Thread t;

                switch (getRoleOfUser())
                {
                    case "SYSADMIN":
                        this.Hide();
                        t = new Thread(runMainForm);
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                        break;
                    case "NHANVIEN":
                        this.Hide();
                        t = new Thread(runNhanVienform);
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                        break;
                    case "QLTRUCTIEP":
                        this.Hide();
                        t = new Thread(runQuanLyTTForm);
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                        break;
                    //case "TRUONGPHONG":
                    //    this.Hide();
                    //    //t = new Thread(run_TruongPhong_Form);
                    //    t.SetApartmentState(ApartmentState.STA);
                    //    t.Start();
                    //    break;
                    //case "TAICHINH":
                    //    this.Hide();
                    //    //t = new Thread(run_TaiChinh_Form);
                    //    t.SetApartmentState(ApartmentState.STA);
                    //    t.Start();
                    //    break;
                    //case "NHANSU":
                    //    this.Hide();
                    //    //t = new Thread(run_NhanSu_Form);
                    //    t.SetApartmentState(ApartmentState.STA);
                    //    t.Start();
                    //    break;
                    //case "TRUONGDA":
                    //    this.Hide();
                    //    //t = new Thread(run_TruongDeAn_Form);
                    //    t.SetApartmentState(ApartmentState.STA);
                    //    t.Start();
                    //    break;


                    //default:
                    //    MessageBox.Show(" Hệ thống hiện chưa hổ trợ UI cho giám đốc !");
                    //    break;

                }
                MessageBox.Show(" đăng nhập thành công !");
            }
            else
            {
                txtWarning.Text = "username or password is invalid !";
                txtWarning.ForeColor = System.Drawing.Color.Red;
            }
        }

        public static string getRoleOfUser()
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            String SQL = @"SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE =  '" + Connection.username + "'";
            OracleCommand command = new OracleCommand(SQL, conn);
            //command.CommandType = CommandType.Text;
            //var username = new OracleParameter("@username", "");
            //command.Parameters.Add(username);
            //username.Value = Connection.username;


            var reader = command.ExecuteReader();

            string[] defaultRole = new string[] { "NHANVIEN", "QLTRUCTIEP", "TRUONGPHONG", "TAICHINH", "NHANSU", "TRUONGDA" };

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if ("SYSADMIN" == reader["GRANTED_ROLE"].ToString().ToUpper())
                        return "SYSADMIN";


                }
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    foreach (var item in defaultRole)
                    {
                        if (item.ToString() == reader["GRANTED_ROLE"].ToString())
                            return item.ToString();
                    }
                    foreach (var item in defaultRole)
                    {
                        if (item.ToString() == reader.Read().ToString())
                            return item.ToString();
                    }
                }
            }
            return "GIAMDOC";
        }

    }
}
