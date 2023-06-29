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
    public partial class ThemPhongBan : Form
    {
        public ThemPhongBan()
        {
            InitializeComponent();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if(textBox_maPB.Text.Trim().ToString()=="" || textBox_tenPB.Text.Trim().ToString() ==""  )
            {
                MessageBox.Show("mã phòng ban hoặc tên phòng ban không được để trống!!");
                return;
            }    
        
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            try
            {

                string query = @"QLTGDA.SP_NHANSU_THEM_PHONGBAN";

                OracleCommand command = new OracleCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;

                var maPB = new OracleParameter("@maPB", "");
                var tenPB = new OracleParameter("@tenPB", "");
                var maTP = new OracleParameter("@maTP", "");


                command.Parameters.Add(maPB);
                command.Parameters.Add(tenPB);
                command.Parameters.Add(maTP);



                maPB.Value = textBox_maPB.Text.ToString();
                tenPB.Value = textBox_tenPB.Text.ToString();
                maTP.Value = textBox_maTP.Text.ToString();
               
                command.ExecuteNonQuery();

                MessageBox.Show("thêm thành công !!");

                textBox_maPB.Clear();
                textBox_maTP.Clear();
                textBox_tenPB.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
