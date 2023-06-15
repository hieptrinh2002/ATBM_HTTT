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
    public partial class CreateRole : Form
    {

        private string query = "";
        public CreateRole()
        {
            InitializeComponent();
        }

        private void CreateRole_Load(object sender, EventArgs e)
        {

        }

        private void Handle_createRole(string roleName, string password)
        {

            // MessageBox.Show("TB: " + Dataprovider.Instance.ExecuteScalar("SELECT count(*) FROM ALL_USERS WHERE USERNAME = '" + username + "'"));
            query = "SELECT count(*) FROM DBA_ROLES WHERE ROLE = '" + roleName + "'";

            if (Convert.ToInt32(Dataprovider.Instance.ExecuteScalar(query).ToString()) > 0)
            {
                label_invalid_Role.Text = " role " + roleName + " đã tồn tại !";
                label_invalid_Role.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

                if (createRole(roleName, password))
                {
                    MessageBox.Show("tạo role thành công!");
                }
                else
                {
                    MessageBox.Show("tạo role không thành công !");
                }
                this.Hide();
            }
        }

        private void button_createRole_Click(object sender, EventArgs e)
        {
            label_invalid_Role.Text = "";
            string roleName = textBox_roleName.Text.ToString();
            string pwd = textBox_pass_role.Text.ToString();
            if (roleName == "")
            {
                label_invalid_Role.Text = "RoleName is empty !";
                label_invalid_Role.ForeColor = System.Drawing.Color.Red;
                return;
            }
            Handle_createRole(roleName, pwd);

        }
        public bool createRole(String roleName, String pwd)
        {
            bool status = false;
            if(pwd == "")
            {
                pwd = " ";
            }    
            OracleConnection conn = Connection.GetDBConnection();

            conn.Open();
            try
            {
                OracleCommand oc = new OracleCommand("Proc_Create_NewRole", conn);
                oc.CommandType = CommandType.StoredProcedure;
                oc.Parameters.Add(new OracleParameter("@Role_name", OracleDbType.Varchar2)).Value = roleName;
                oc.Parameters.Add(new OracleParameter("@Pass_Word", OracleDbType.Varchar2)).Value = pwd;
                oc.Parameters["@Role_name"].Direction = ParameterDirection.Input;
                oc.Parameters["@Pass_Word"].Direction = ParameterDirection.Input;

                //Thực thi thủ tục.
                oc.ExecuteNonQuery();   
                status = true;
               
            }

            catch (Exception e)
            {
                MessageBox.Show("lỗi tạo role :" + e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return status;
        }


    }
}
