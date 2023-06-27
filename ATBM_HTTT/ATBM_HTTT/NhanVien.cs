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
    public partial class NhanVien : Form
    {

        public string manv  { get;set;}
        public string hoTen { get; set; }
        public string phai { get; set; }
        public string ngaySinh { get; set; }
        public string Sdt { get; set; }
        public string Luong { get; set; }
        public string phucap { get; set; }
        public string phongBan { get; set; }
        public string diaChi { get; set; }

        public NhanVien()
        {
            InitializeComponent();
        }

        public NhanVien( string manv , string hoTen , string phai, string ngaySinh , string Sdt ,string Luong, string phucap, string phongBan, string diaChi)
        {
            this.manv = manv;
            this.hoTen = hoTen;
            this.phai = phai;
            this.ngaySinh = ngaySinh;
            this.Sdt = Sdt;
            this.Luong = Luong;
            this.phucap = phucap;
            this.phongBan = phongBan;
            this.diaChi = diaChi;
        }

        private void btn_pc_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_PB_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEM_THONGTIN_PHONGBAN";
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem thông tin phòng ban !");
            }
        }

        private void btn_deAn_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEM_THONGTIN_DEAN";
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem thông tin đề án !");
            }
        }

        private void btn_infor_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = @"select * from QLTGDA.VIEW_NHANVIEN_XEMTHONGTIN_CANHAN";
            OracleCommand command = new OracleCommand(query, conn);

            var reader = command.ExecuteReader();

            //MessageBox.Show(reader["MANV"].ToString());

           
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   NhanVien nv = new NhanVien(
                      reader["MANV"].ToString(),
                      reader["TENNV"].ToString(),
                      reader["PHAI"].ToString(),
                      reader["NGAYSINH"].ToString(),
                      reader["SODT"].ToString(),
                      reader["LUONG"].ToString(),
                      reader["PHUCAP"].ToString(),
                      reader["PHG"].ToString(),
                      reader["DIACHI"].ToString());

                    Form f = new ShowProfile(nv);
                    f.ShowDialog();
                }
               
            }

            conn.Close();
        }
        public static void refresh_Datagridview()
        {
           
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
