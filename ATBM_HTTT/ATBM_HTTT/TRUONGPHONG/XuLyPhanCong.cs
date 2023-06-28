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
    public partial class XuLyPhanCong : Form
    {
        private string xl = "";
       
        public XuLyPhanCong(string handle, string header)
        {
            InitializeComponent();


            xl = handle.ToString();
            this.button_XuLy.Text = handle.ToString();
            this.Text = header.ToString();

        }

        private void XuLyPhanCong_Load(object sender, EventArgs e)
        { 
            
        }

        public void insertPC()
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            try
            {

                string query = @"QLTGDA.SP_TRUONGPHONG_THEM_PHANCONG";

                OracleCommand command = new OracleCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;

                var maNV = new OracleParameter("@maNV", "");
                var maDA = new OracleParameter("@maDA", "");
                var maNBD = new OracleParameter("@maNBD", DateTime.Now);



                command.Parameters.Add(maNV);
                command.Parameters.Add(maDA);
                command.Parameters.Add(maNBD);
              


                maNV.Value = textBox_manv.Text.ToString();
                maDA.Value = textBox_maDA.Text.ToString();
                maNBD.Value = (DateTime)dateTimePicker_tgbd.Value;


                command.ExecuteNonQuery();

                MessageBox.Show("Thêm phân công thành công !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi thêm phân công :" + ex.Message.ToString());

            }
            finally
            {
                conn.Close();
                this.Close();
            }
        }
        public void updatePC()
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            try
            {

                string query = @"QLTGDA.SP_TRUONGPHONG_CAPNHAT_PHANCONG";

                OracleCommand command = new OracleCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;

                var maNV = new OracleParameter("@maNV", "");
                var maDA = new OracleParameter("@maDA", "");
                var maNBD = new OracleParameter("@maNBD", DateTime.Now);



                command.Parameters.Add(maNV);
                command.Parameters.Add(maDA);
                command.Parameters.Add(maNBD);


                maNV.Value = textBox_manv.Text.ToString();
                maDA.Value = textBox_maDA.Text.ToString();
                maNBD.Value = (DateTime)dateTimePicker_tgbd.Value;


                command.ExecuteNonQuery();

                MessageBox.Show(" cập nhật phân công thành công !");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi cập nhật phân công:" + ex.Message.ToString());

            }
            finally
            {
                conn.Close(); 
                this.Close();

            }
        }
        public void dropPC()
        {
            dateTimePicker_tgbd.Enabled = false;
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            try
            {

                string query = @"QLTGDA.SP_TRUONGPHONG_XOA_PHANCONG";

                OracleCommand command = new OracleCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;

                var maNV = new OracleParameter("@maNV", "");
                var maDA = new OracleParameter("@maDA", "");
        

                command.Parameters.Add(maNV);
                command.Parameters.Add(maDA);
                

                maNV.Value = textBox_manv.Text.ToString();
                maDA.Value = textBox_maDA.Text.ToString();
               
                command.ExecuteNonQuery();

                MessageBox.Show(" xóa phân công thành công !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi xóa phân công:" + ex.Message.ToString());

            }
            finally
            {
                conn.Close();
                this.Close();

            }
        }

        private void textBox_manv_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_XuLy_Click(object sender, EventArgs e)
        {
            if(textBox_maDA.Text.Trim().ToString() == "" || textBox_manv.Text.Trim().ToString() =="")
            {
                MessageBox.Show("Mã nhân viên hoặc mã đề án không được null !!!");
                return;
            }    

            if(xl == "Thêm")
            {
                insertPC();
            }  
            else if (xl == "Cập Nhật")
            {
                updatePC();
            }   
            else
            {
                dateTimePicker_tgbd.Enabled = false;
                dateTimePicker_tgbd.Visible = false;
                dropPC();
            }    
        }
    }
}
