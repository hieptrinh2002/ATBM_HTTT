using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Oracle.ManagedDataAccess.Client; // Oracle Client Library

namespace ATBM_HTTT
{
    public partial class DatabaseManager : Form
    {
       // string connectionString = Connection.connectionString(Connection.username, Connection.password);//"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + "localhost" + ")(PORT = " + "1521" + ")))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME =  " + "xe" + ")));DBA Privilege=SYSDBA;User Id=sys;Password=123;";
        public DatabaseManager()
        {
            InitializeComponent();
            //checkOracleConnection();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn muốn thoát ?", "thông báo", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes || result == DialogResult.OK)
            {
                this.Close();
               
            }
           
        }

        private void DatabaseManager_Load(object sender, EventArgs e)
        {
            string txtRole_User = cmb_User_Role.Text;
            if (txtRole_User == "User")
            {
                LoadUserNameToListBox();
            }
            else if (txtRole_User == "Role")
            {
                LoadRoleNameToListBox();
            }

        }
        private void btn_ThongTinQuyen_Click_1(object sender, EventArgs e)
        {
            panel_ThongTinQuyen.Visible = true;
        }

        private void LoadDataPrivilege()
        {
            string user = txt_User_Role.Text;
            //string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + "localhost" + ")(PORT = " + "1521" + ")))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME =  " + "xe" + ")));DBA Privilege=SYSDBA;User Id=sys;Password=123;";
            try
            {
                using (OracleConnection connection = new OracleConnection(Connection.getConnString()))
                {
                    connection.Open();
                    string sql = @"
                    SELECT r.GRANTEE ""User/Granted Role"",
                       tp.TABLE_NAME ""Table Name"",
                       tp.GRANTOR ""Grantor"",
                       tp.PRIVILEGE ""Privilege"",
                       CASE 
                           WHEN r.ADMIN_OPTION = 'YES' THEN 'ADMIN'
                           ELSE 'NORMAL'
                       END ""Type""
                    FROM DBA_TAB_PRIVS tp
                    JOIN DBA_ROLE_PRIVS r ON tp.GRANTEE = r.GRANTED_ROLE
                    WHERE r.GRANTEE = '" + user + "' ";
                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_XemThongTin_Click(object sender, EventArgs e)
        {
            LoadDataPrivilege();

        }


        // ==========================GET AND LOAD USERNAME INTO COMBO BOX=======================================
        private List<string> GetColumnUserName(string columnName, string tableName)
        {
           
            string sql_user = "SELECT USERNAME FROM DBA_USERS";

            List<string> values = new List<string>();

            using (OracleConnection connection = new OracleConnection(Connection.getConnString()))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(sql_user, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            values.Add(reader[columnName].ToString());
                        }
                    }
                }
            }
            return values;
        }
        private void LoadUserNameToListBox()
        {
            List<string> values = GetColumnUserName("USERNAME", "DBA_USERS");
            txt_User_Role.DataSource = values;
        }

        // ==========================GET AND LOAD ROLENAME INTO COMBO BOX=======================================
        private List<string> GetColumnRoleName(string columnName, string tableName)
        {
            //string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + "localhost" + ")(PORT = " + "1521" + ")))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME =  " + "xe" + ")));DBA Privilege=SYSDBA;User Id=sys;Password=123;";
            string sql_user = "SELECT ROLE FROM DBA_ROLES";

            List<string> values = new List<string>();

            using (OracleConnection connection = new OracleConnection(Connection.getConnString()))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(sql_user, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            values.Add(reader[columnName].ToString());
                        }
                    }
                }
            }
            return values;
        }
        private void LoadRoleNameToListBox()
        {
            List<string> values = GetColumnRoleName("ROLE", "DBA_ROLES");
            txt_User_Role.DataSource = values;
        }
        // ==================================================================================================
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string GranteeValue = row.Cells["User/Granted Role"].Value.ToString();
                txtGrantee.Text = GranteeValue;

                string PrivValue = row.Cells["Privilege"].Value.ToString();
                txtPriv.Text = PrivValue;

                string TabValue = row.Cells["Table Name"].Value.ToString();
                txtTable.Text = TabValue;

            }
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string grantee = txtGrantee.Text;
            string privilege = txtPriv.Text;
            string table = txtTable.Text;

            // Get the index of the currently selected row in the DataGridView
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            // Find the index of the "Privilege" column in the DataGridView
            int privilegeColumnIndex = dataGridView1.Columns["Privilege"].Index;

            // Update the value of the "Privilege" cell in the selected row with the value from the TextBox
            dataGridView1.Rows[selectedRowIndex].Cells[privilegeColumnIndex].Value = txtPriv.Text;
            try
            {
                // Display a message to the user
                MessageBox.Show("Privilege updated successfully.");
            }
            catch (OracleException ex)
            {
                // Handle the exception as required
                MessageBox.Show("Error updating privilege: " + ex.Message);
            }
        }


    }
}
