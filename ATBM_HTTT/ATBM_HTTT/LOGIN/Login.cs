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
                MessageBox.Show("connection login bi loi !!!");
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
                        MainForm m = new MainForm();
                        m.ShowDialog();
                        break;

                    case "NHANVIEN":
                        this.Hide();
                        NhanVien nv = new NhanVien();
                        nv.ShowDialog();
                        break;

                    case "QLTRUCTIEP":
                        this.Hide();
                        QL_TrucTiep ql = new QL_TrucTiep();
                        ql.ShowDialog();
                        break;
                    case "TRUONGPHONG":
                        this.Hide();
                        TruongPhong TP = new TruongPhong();
                        TP.ShowDialog();
                        break;

                    case "TAICHINH":
                        this.Hide();
                        TaiChinh TC = new TaiChinh();
                        TC.ShowDialog();
                        break;

                    case "NHANSU":
                        this.Hide();
                        NhanSu ns = new NhanSu();
                        ns.ShowDialog();
                        break;
                    case "TRUONGDA":
                        this.Hide();
                        TruongDeAn DA = new TruongDeAn();
                        DA.ShowDialog();
                        break;
                        //default:
                        //    MessageBox.Show(" Hệ thống hiện chưa hổ trợ UI cho giám đốc !");
                        //    break;

                }
                this.Show();
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
                }
            }
            return "GIAMDOC";
        }

    }
}
