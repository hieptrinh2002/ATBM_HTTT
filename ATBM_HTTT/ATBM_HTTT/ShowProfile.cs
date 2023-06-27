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
    public partial class ShowProfile : Form
    {

        public ShowProfile()
        {
            textBox_manv = new TextBox();
            textBox_hoten = new TextBox();
            comboBox_gt = new ComboBox();
            dateTimePicker_NgSinh = new DateTimePicker();
            textBox_diachi = new TextBox();
            textBox_sdt = new TextBox();
            textBox_Luong = new TextBox();
            textBox_PhuCap = new TextBox();
            textBox_PhongBan = new TextBox();
        }
        public ShowProfile(NhanVien nv)
        {

            InitializeComponent();
            if (nv != null)
            {

                this.textBox_manv.Text = nv.manv.ToString();
                this.textBox_hoten.Text = nv.hoTen.ToString();
                this.comboBox_gt.Text = nv.phai.ToString();
                this.dateTimePicker_NgSinh.Value = DateTime.Parse(nv.ngaySinh);
                this.textBox_diachi.Text = nv.diaChi.ToString();
                this.textBox_sdt.Text = nv.Sdt.ToString();
                this.textBox_Luong.Text = nv.Luong.ToString();
                this.textBox_PhuCap.Text = nv.phucap.ToString();
                this.textBox_PhongBan.Text = nv.phongBan.ToString();
                               
            }
            panel_Manv_Phai.Enabled = false;
            panel_PB_Luong_PhuCap.Enabled = false;

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            try
            {

                string query = @"QLTGDA.UPDATE_PROFILE";

                OracleCommand command = new OracleCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;

                var hoTen = new OracleParameter("@hoTen", "");
                var ngaySinh = new OracleParameter("@ngaySinh", DateTime.Now);
                var diaChi = new OracleParameter("@diaChi", "");
                var sdt = new OracleParameter("@sdt", "");
                var maNV = new OracleParameter("@maNV", "");
               

                command.Parameters.Add(hoTen);
                command.Parameters.Add(ngaySinh);
                command.Parameters.Add(diaChi);
                command.Parameters.Add(sdt);
                command.Parameters.Add(maNV);
              

                maNV.Value = textBox_manv.Text.ToString();
                hoTen.Value = textBox_hoten.Text.ToString();
                diaChi.Value = textBox_diachi.Text.ToString();
                sdt.Value = textBox_sdt.Text.ToString();
                ngaySinh.Value = (DateTime)dateTimePicker_NgSinh.Value;

                command.ExecuteNonQuery();

                MessageBox.Show("đã lưu !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi update thông tin:"+ ex.Message.ToString());
                
            }
            finally
            {
                conn.Close();
            }

        }

        private void ShowProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
