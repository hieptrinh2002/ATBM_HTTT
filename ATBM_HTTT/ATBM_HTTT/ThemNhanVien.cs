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
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            panel_PB_Luong_PhuCap.Enabled = false;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if(textBox_manv.Text.Trim().ToString() == ""|| textBox_hoten.Text.Trim().ToString() =="")
            {
                MessageBox.Show("mã nhân viên và tên nhân viên trống !!");
                return;
            }    
            else
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                try
                {

                    string query = @"QLTGDA.SP_NHANSU_THEMNHANVIEN";

                    OracleCommand command = new OracleCommand(query, conn);
                    command.CommandType = CommandType.StoredProcedure;

                    var maNV = new OracleParameter("@hoTen", "");
                    var hoTen = new OracleParameter("@hoTen", "");
                    var phai = new OracleParameter("@phai", "");
                    var ngaySinh = new OracleParameter("@ngaySinh", DateTime.Now);
                    var diaChi = new OracleParameter("@diaChi", "");
                    var sdt = new OracleParameter("@sdt", "");
                    var maNQL = new OracleParameter("@maNQL", "");
                    var PHG = new OracleParameter("@PHG", "");

                    command.Parameters.Add(maNV);
                    command.Parameters.Add(hoTen);
                    command.Parameters.Add(phai);
                    command.Parameters.Add(ngaySinh);
                    command.Parameters.Add(diaChi);
                    command.Parameters.Add(sdt);
                    command.Parameters.Add(maNQL);
                    command.Parameters.Add(PHG);


                    maNV.Value = textBox_manv.Text.ToString();
                    hoTen.Value = textBox_hoten.Text.ToString();
                    phai.Value = comboBox_gt.Text.ToString();
                    ngaySinh.Value = (DateTime)dateTimePicker_NgSinh.Value;
                    diaChi.Value = textBox_diachi.Text.ToString();
                    sdt.Value = textBox_sdt.Text.ToString();
                    maNQL.Value = textBox_MaQL.Text.ToString();
                    PHG.Value = textBox_PhongBan.Text.ToString();

                    command.ExecuteNonQuery();

                    MessageBox.Show("đã lưu !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi update thêm nhân viên :" + ex.Message.ToString());

                }
                finally
                {
                    conn.Close();
                }

            }    
        }
        
    }
}
