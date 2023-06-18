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
    public partial class USERS_ROLES : Form
    {
        private string query = "";
        public USERS_ROLES()
        {

            InitializeComponent();
            refresh_dataGridView_listUser();
            refresh_dataGridView_listROLES();
        }
        private void USERS_ROLES_Load(object sender, EventArgs e)
        {
           
        }
        private void dataGridView_listUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        public void refresh_dataGridView_listUser()
        {
            query = "select USERNAME, USER_ID, ACCOUNT_STATUS , EXPIRY_DATE , CREATED from DBA_USERS";
            dataGridView_listUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_listUser.DataSource = Dataprovider.Instance.ExecuteQuery(query);
        }
        private void button_xemDS_tabUSERS_Click(object sender, EventArgs e)
        {
            try
            {
                refresh_dataGridView_listUser();

            }
            catch (Exception error)
            {
                MessageBox.Show("lỗi hiển thị danh sách USERS: " + error.ToString());
            }
        }

        private void button_TaoUSER_tabUSER_Click(object sender, EventArgs e)
        {
            Form f = new CreateUser();
            f.ShowDialog();
        }

        private void button_xoaUser_tabUSER_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new DeleteUser();
                f.ShowDialog();
                
            }
            catch (Exception error)
            {
                MessageBox.Show("lỗi xóa USER: " + error.ToString());
            }
        }

        private void button_CapNhatUser_tabUSER_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new UpdateUser();
                f.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show("lỗi cập nhật USER: " + error.ToString());
            }
        }

        private void dataGridView_listUser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        //========================================= ROLE ==========================================

        public void refresh_dataGridView_listROLES()
        {
            query = "select ROLE , ROLE_ID , PASSWORD_REQUIRED , COMMON from DBA_ROLES";
            dataGridView_listROLES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_listROLES.DataSource = Dataprovider.Instance.ExecuteQuery(query);
        }
        private void button_XemDS_TabROLES_Click(object sender, EventArgs e)
        {
            try
            {

                refresh_dataGridView_listROLES();

            }
            catch (Exception error)
            {
                MessageBox.Show("lỗi hiển thị danh sách USERS: " + error.ToString());
            }
        }

        private void button_TaoROLE_tabROLES_Click(object sender, EventArgs e)
        {
            Form f = new CreateRole();
            f.ShowDialog();
        }

        private void button_XoaRole_tabROLES_Click(object sender, EventArgs e)
        {
            Form f = new DeleteRole();
            f.ShowDialog();
        }

        private void button_CapNhatROLE_TabROLES_Click(object sender, EventArgs e)
        {

            Form f = new UpdateRole();
            f.ShowDialog();
        }
    }
}



