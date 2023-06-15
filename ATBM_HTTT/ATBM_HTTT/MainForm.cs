using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_HTTT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_THH_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form f = new USERS_ROLES();
            f.Show();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form f = new Privileges();
            f.Show();
            this.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form f = new DatabaseManager();
            f.Show();
            this.Show();
        }
    }
}
