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
    public partial class UpdateRole : Form
    {
        public UpdateRole()
        {
            InitializeComponent();
        }


        private void handleUpdate(string roleName, string newpass)
        {
            string query = "SELECT count(*) FROM DBA_ROLES WHERE ROLE = '" + roleName + "'";
            ;

            if (Convert.ToInt32(Dataprovider.Instance.ExecuteScalar(query).ToString()) < 1)
            {
                label_notice_updaterole.Text = "NOTICE: ROLE " + roleName + "  không tồn tại !";
                label_notice_updaterole.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                try
                {
                    if (UpdateRole_newPwd(roleName, newpass))
                    {
                        label_notice_updaterole.Text = "";
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


        private void button_update_role_Click(object sender, EventArgs e)
        {
            string roleName = textBox_rolename_update.Text.ToString();
            string newpass = textBox_NewPassword.Text.ToString();
            if (roleName == "")
            {
                label_notice_updaterole.Text = "ROLE is empty !";
                label_notice_updaterole.ForeColor = System.Drawing.Color.Red;
                return;
            }
            handleUpdate(roleName, newpass);
        }

        public bool UpdateRole_newPwd(String roleName, String new_pwd)
        {
            bool status = false;
            if (new_pwd == "")
            {
                new_pwd = " ";
            }
            OracleConnection conn = Connection.GetDBConnection();

            conn.Open();
            try
            {
               
                OracleCommand oc = new OracleCommand("Proc_Update_RolePwd", conn);
                oc.CommandType = CommandType.StoredProcedure;
                oc.Parameters.Add(new OracleParameter("@Role_name", OracleDbType.Varchar2)).Value = roleName;
                oc.Parameters.Add(new OracleParameter("@new_Pwd", OracleDbType.Varchar2)).Value = new_pwd;
                oc.Parameters["@Role_name"].Direction = ParameterDirection.Input;
                oc.Parameters["@new_Pwd"].Direction = ParameterDirection.Input;


                oc.ExecuteNonQuery();
                status = true;
            }

            catch (Exception e)
            {
                MessageBox.Show("lỗi update password role :" + e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return status;
        }

        private void UpdateRole_Load(object sender, EventArgs e)
        {

        }
    }
}
