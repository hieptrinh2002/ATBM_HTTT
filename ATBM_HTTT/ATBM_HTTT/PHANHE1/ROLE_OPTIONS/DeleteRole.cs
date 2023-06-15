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
    public partial class DeleteRole : Form
    {
        public DeleteRole()
        {
            InitializeComponent();
        }

        private void DeleteRole_Load(object sender, EventArgs e)
        {

        }

        private void handleDropRole(string RoleName)
        {
            string query = "SELECT count(*) FROM DBA_ROLES WHERE ROLE = '" + RoleName + "'";

            if (Convert.ToInt32(Dataprovider.Instance.ExecuteScalar(query).ToString()) < 1)
            {
                label_notice_deleteRole.Text = "notice: Role " + RoleName + "  không tồn tại !";
                label_notice_deleteRole.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                try
                {
                    if (DropRole(RoleName))
                    {
                        label_notice_deleteRole.Text = "";
                        MessageBox.Show("drop thành công !");
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("drop không thành công !");
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi xóa User : " + ex.ToString());
                }
            }
        }

        private void button_deleteRole_Click(object sender, EventArgs e)
        {
            label_notice_deleteRole.Text = "";

            string roleName = textBox_RoleName.Text.ToString();
            if (roleName == "")
            {
                label_notice_deleteRole.Text = "roleName is empty !";
                label_notice_deleteRole.ForeColor = System.Drawing.Color.Red;
                return;
            }

            handleDropRole(roleName);
        }
        public bool DropRole(String RoleName)
        {

            bool status = false;
            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = Connection.GetDBConnection();

            conn.Open();
            try
            {
                //OracleCommand oc = new OracleCommand("Proc_Drop_Role", conn);
                //oc.CommandType = CommandType.StoredProcedure;
                //oc.Parameters.Add(new OracleParameter("@Role_name", OracleDbType.Varchar2)).Value = RoleName;
                //oc.Parameters["@Role_name"].Direction = ParameterDirection.Input;
                //oc.ExecuteNonQuery();
                //status = true;

                OracleCommand command = new OracleCommand("Proc_Drop_Role", conn);
                command.CommandType = CommandType.StoredProcedure;
                var Role_name = new OracleParameter("@Role_name", "");//"" khowir tao cho parameter @Role_name
                command.Parameters.Add(Role_name);
                Role_name.Value = RoleName;
                //command.ExecuteNonQuery();


                status = true;
                return status;
            }
            catch (Exception e)
            {
                MessageBox.Show("lỗi delete role :" + e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return status;

        }

        public static void ADO_NET_TEST()
        {
            OracleConnection conn = Connection.GetDBConnection();
            OracleCommand command = new OracleCommand("Proc_Drop_Role", conn);
            command.CommandType = CommandType.StoredProcedure;
            var Role_name = new OracleParameter("@Role_name", "");//"" khowir tao cho parameter @Role_name
            command.Parameters.Add(Role_name);
            
        }
    }
}
