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
        public ShowProfile(NhanVien nv)
        {
            textBox_manv.Text = nv.manv.ToString();
            textBox_hoten.Text = nv.hoTen.ToString();
            comboBox_gt.Text = nv.phai.ToString();
            dateTimePicker_NgSinh.Value = DateTime.ParseExact(nv.ngaySinh, "dd-mm-yyy",System.Globalization.CultureInfo.InvariantCulture);
            textBox_diachi.Text= nv.diaChi.ToString();
            textBox_sdt.Text = nv.Text.ToString();
            textBox_Luong.Text = nv.Luong.ToString();
            textBox_PhuCap.Text = nv.phucap.ToString();
            textBox_PhongBan.Text = nv.phongBan.ToString();

            panel_Manv_Phai.Enabled = false;
            panel_PB_Luong_PhuCap.Enabled = false;
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            try
            {

                string query = @"update QLTGDA.VIEW_NHANVIEN_XEMTHONGTIN_CANHAN 
                            set TENNV = @hoten,NGAYSINH = @ngaySinh,DIACHI = @diaChi,SODT = @sdt
                            where MANV = @MANV";

                OracleCommand command = new OracleCommand(query, conn);

                var maNV = new OracleParameter("@maNV", "");
                var hoTen = new OracleParameter("@hoTen", "");
                var ngaySinh = new OracleParameter("@ngaySinh", "");
                var diaChi = new OracleParameter("@diaChi", "");
                var sdt = new OracleParameter("@sdt", "");

                command.Parameters.Add(maNV);
                command.Parameters.Add(hoTen);
                command.Parameters.Add(ngaySinh);
                command.Parameters.Add(diaChi);
                command.Parameters.Add(sdt);

                maNV.Value = textBox_manv.Text.ToString();
                hoTen.Value = textBox_hoten.Text.ToString();
                diaChi.Value = textBox_diachi.Text.ToString();
                sdt.Value = textBox_sdt.Text.ToString();
                ngaySinh.Value = dateTimePicker_NgSinh.Value;

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi update thông tin !!");
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
