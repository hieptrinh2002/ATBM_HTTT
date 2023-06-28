
namespace ATBM_HTTT
{
    partial class CapNhatNhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapNhatNhanvien));
            this.label8 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_MaQL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_PhongBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Manv = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_manv = new System.Windows.Forms.TextBox();
            this.panel_PB_Luong_PhuCap = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Luong = new System.Windows.Forms.TextBox();
            this.textBox_PhuCap = new System.Windows.Forms.TextBox();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker_NgSinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_diachi = new System.Windows.Forms.TextBox();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_gt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Manv.SuspendLayout();
            this.panel_PB_Luong_PhuCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cập Nhật Nhân Viên";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(496, 538);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(323, 45);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.comboBox_gt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_role);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox_MaQL);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox_PhongBan);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel_Manv);
            this.panel1.Controls.Add(this.panel_PB_Luong_PhuCap);
            this.panel1.Controls.Add(this.textBox_sdt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePicker_NgSinh);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_diachi);
            this.panel1.Controls.Add(this.textBox_hoten);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(309, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 510);
            this.panel1.TabIndex = 22;
            // 
            // comboBox_role
            // 
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "Nhân viên",
            "QL trực tiếp",
            "Trưởng phòng",
            "Nhân sự",
            "Tài chính",
            "trưởng đề án",
            "Ban giám đốc"});
            this.comboBox_role.Location = new System.Drawing.Point(157, 329);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(495, 28);
            this.comboBox_role.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Vai Trò:";
            // 
            // textBox_MaQL
            // 
            this.textBox_MaQL.Location = new System.Drawing.Point(516, 382);
            this.textBox_MaQL.Name = "textBox_MaQL";
            this.textBox_MaQL.Size = new System.Drawing.Size(137, 26);
            this.textBox_MaQL.TabIndex = 23;
            this.textBox_MaQL.Text = "NV031";
            this.textBox_MaQL.TextChanged += new System.EventHandler(this.textBox_MaQL_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mã Quản lý :";
            // 
            // textBox_PhongBan
            // 
            this.textBox_PhongBan.Location = new System.Drawing.Point(158, 382);
            this.textBox_PhongBan.Name = "textBox_PhongBan";
            this.textBox_PhongBan.Size = new System.Drawing.Size(159, 26);
            this.textBox_PhongBan.TabIndex = 17;
            this.textBox_PhongBan.Text = "PB0001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã Phòng Ban :";
            // 
            // panel_Manv
            // 
            this.panel_Manv.Controls.Add(this.label1);
            this.panel_Manv.Controls.Add(this.textBox_manv);
            this.panel_Manv.Location = new System.Drawing.Point(3, 3);
            this.panel_Manv.Name = "panel_Manv";
            this.panel_Manv.Size = new System.Drawing.Size(337, 76);
            this.panel_Manv.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã Số : ";
            // 
            // textBox_manv
            // 
            this.textBox_manv.Location = new System.Drawing.Point(154, 27);
            this.textBox_manv.Name = "textBox_manv";
            this.textBox_manv.Size = new System.Drawing.Size(154, 26);
            this.textBox_manv.TabIndex = 17;
            // 
            // panel_PB_Luong_PhuCap
            // 
            this.panel_PB_Luong_PhuCap.Controls.Add(this.label6);
            this.panel_PB_Luong_PhuCap.Controls.Add(this.label2);
            this.panel_PB_Luong_PhuCap.Controls.Add(this.textBox_Luong);
            this.panel_PB_Luong_PhuCap.Controls.Add(this.textBox_PhuCap);
            this.panel_PB_Luong_PhuCap.Location = new System.Drawing.Point(3, 437);
            this.panel_PB_Luong_PhuCap.Name = "panel_PB_Luong_PhuCap";
            this.panel_PB_Luong_PhuCap.Size = new System.Drawing.Size(681, 70);
            this.panel_PB_Luong_PhuCap.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phụ Cấp :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lương :";
            // 
            // textBox_Luong
            // 
            this.textBox_Luong.Location = new System.Drawing.Point(154, 13);
            this.textBox_Luong.Name = "textBox_Luong";
            this.textBox_Luong.Size = new System.Drawing.Size(160, 26);
            this.textBox_Luong.TabIndex = 15;
            // 
            // textBox_PhuCap
            // 
            this.textBox_PhuCap.Location = new System.Drawing.Point(513, 13);
            this.textBox_PhuCap.Name = "textBox_PhuCap";
            this.textBox_PhuCap.Size = new System.Drawing.Size(137, 26);
            this.textBox_PhuCap.TabIndex = 16;
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Location = new System.Drawing.Point(158, 273);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(495, 26);
            this.textBox_sdt.TabIndex = 20;
            this.textBox_sdt.Text = "09783232323";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Số điện thoại :";
            // 
            // dateTimePicker_NgSinh
            // 
            this.dateTimePicker_NgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgSinh.Location = new System.Drawing.Point(158, 218);
            this.dateTimePicker_NgSinh.Name = "dateTimePicker_NgSinh";
            this.dateTimePicker_NgSinh.Size = new System.Drawing.Size(495, 26);
            this.dateTimePicker_NgSinh.TabIndex = 18;
            this.dateTimePicker_NgSinh.Value = new System.DateTime(2002, 6, 27, 9, 29, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ngày Sinh :";
            // 
            // textBox_diachi
            // 
            this.textBox_diachi.Location = new System.Drawing.Point(158, 162);
            this.textBox_diachi.Name = "textBox_diachi";
            this.textBox_diachi.Size = new System.Drawing.Size(495, 26);
            this.textBox_diachi.TabIndex = 8;
            this.textBox_diachi.Text = "Quận Tân Bình, tp.Hồ Chí Minh";
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Location = new System.Drawing.Point(158, 100);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(495, 26);
            this.textBox_hoten.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ Tên :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ATBM_HTTT.Properties.Resources.profile;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_gt
            // 
            this.comboBox_gt.FormattingEnabled = true;
            this.comboBox_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_gt.Location = new System.Drawing.Point(515, 33);
            this.comboBox_gt.Name = "comboBox_gt";
            this.comboBox_gt.Size = new System.Drawing.Size(137, 28);
            this.comboBox_gt.TabIndex = 28;
            this.comboBox_gt.Text = "Nam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giới Tính :";
            // 
            // CapNhatNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 604);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1051, 660);
            this.MinimumSize = new System.Drawing.Size(1051, 660);
            this.Name = "CapNhatNhanvien";
            this.Text = "Cập Nhật Nhân Viên";
            this.Load += new System.EventHandler(this.CapNhatNhanvien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Manv.ResumeLayout(false);
            this.panel_Manv.PerformLayout();
            this.panel_PB_Luong_PhuCap.ResumeLayout(false);
            this.panel_PB_Luong_PhuCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_MaQL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_PhongBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_Manv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_manv;
        private System.Windows.Forms.Panel panel_PB_Luong_PhuCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Luong;
        private System.Windows.Forms.TextBox textBox_PhuCap;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgSinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_diachi;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_gt;
        private System.Windows.Forms.Label label4;
    }
}