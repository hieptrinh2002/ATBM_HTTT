
namespace ATBM_HTTT
{
    partial class DatabaseManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_ThongTinQuyen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_XemThongTin = new System.Windows.Forms.Button();
            this.panel_ThongTinQuyen = new System.Windows.Forms.Panel();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPriv = new System.Windows.Forms.TextBox();
            this.txtGrantee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.txt_User_Role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_ThongTinQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_ThongTinQuyen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 754);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(84, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 314);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(-3, 486);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(281, 55);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_ThongTinQuyen
            // 
            this.btn_ThongTinQuyen.FlatAppearance.BorderSize = 0;
            this.btn_ThongTinQuyen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ThongTinQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongTinQuyen.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTinQuyen.Location = new System.Drawing.Point(0, 343);
            this.btn_ThongTinQuyen.Name = "btn_ThongTinQuyen";
            this.btn_ThongTinQuyen.Size = new System.Drawing.Size(281, 55);
            this.btn_ThongTinQuyen.TabIndex = 0;
            this.btn_ThongTinQuyen.Text = "Thông tin quyền";
            this.btn_ThongTinQuyen.UseVisualStyleBackColor = true;
            this.btn_ThongTinQuyen.Click += new System.EventHandler(this.btn_ThongTinQuyen_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(701, 286);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên User/Role";
            // 
            // btn_XemThongTin
            // 
            this.btn_XemThongTin.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemThongTin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_XemThongTin.Location = new System.Drawing.Point(545, 36);
            this.btn_XemThongTin.Name = "btn_XemThongTin";
            this.btn_XemThongTin.Size = new System.Drawing.Size(203, 53);
            this.btn_XemThongTin.TabIndex = 4;
            this.btn_XemThongTin.Text = "Xem thông tin";
            this.btn_XemThongTin.UseVisualStyleBackColor = true;
            this.btn_XemThongTin.Click += new System.EventHandler(this.btn_XemThongTin_Click);
            // 
            // panel_ThongTinQuyen
            // 
            this.panel_ThongTinQuyen.Controls.Add(this.btn_CapNhat);
            this.panel_ThongTinQuyen.Controls.Add(this.label7);
            this.panel_ThongTinQuyen.Controls.Add(this.txtPriv);
            this.panel_ThongTinQuyen.Controls.Add(this.txtTable);
            this.panel_ThongTinQuyen.Controls.Add(this.label5);
            this.panel_ThongTinQuyen.Controls.Add(this.txtGrantee);
            this.panel_ThongTinQuyen.Controls.Add(this.label4);
            this.panel_ThongTinQuyen.Controls.Add(this.cmb_User_Role);
            this.panel_ThongTinQuyen.Controls.Add(this.txt_User_Role);
            this.panel_ThongTinQuyen.Controls.Add(this.label3);
            this.panel_ThongTinQuyen.Controls.Add(this.label2);
            this.panel_ThongTinQuyen.Controls.Add(this.dataGridView1);
            this.panel_ThongTinQuyen.Controls.Add(this.btn_XemThongTin);
            this.panel_ThongTinQuyen.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_ThongTinQuyen.Location = new System.Drawing.Point(287, 12);
            this.panel_ThongTinQuyen.Name = "panel_ThongTinQuyen";
            this.panel_ThongTinQuyen.Size = new System.Drawing.Size(872, 742);
            this.panel_ThongTinQuyen.TabIndex = 5;
            this.panel_ThongTinQuyen.Visible = false;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_CapNhat.Location = new System.Drawing.Point(627, 624);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(121, 47);
            this.btn_CapNhat.TabIndex = 9;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "PRIVILEGE";
            // 
            // txtPriv
            // 
            this.txtPriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriv.Location = new System.Drawing.Point(494, 435);
            this.txtPriv.Name = "txtPriv";
            this.txtPriv.Size = new System.Drawing.Size(233, 27);
            this.txtPriv.TabIndex = 7;
            // 
            // txtGrantee
            // 
            this.txtGrantee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrantee.Location = new System.Drawing.Point(151, 439);
            this.txtGrantee.Name = "txtGrantee";
            this.txtGrantee.Size = new System.Drawing.Size(147, 27);
            this.txtGrantee.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "GRANTEE";
            // 
            // cmb_User_Role
            // 
            this.cmb_User_Role.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_User_Role.FormattingEnabled = true;
            this.cmb_User_Role.Items.AddRange(new object[] {
            "User",
            "Role"});
            this.cmb_User_Role.Location = new System.Drawing.Point(217, 18);
            this.cmb_User_Role.Name = "cmb_User_Role";
            this.cmb_User_Role.Size = new System.Drawing.Size(291, 28);
            this.cmb_User_Role.TabIndex = 5;
            this.cmb_User_Role.SelectedIndexChanged += new System.EventHandler(this.DatabaseManager_Load);
            // 
            // txt_User_Role
            // 
            this.txt_User_Role.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User_Role.FormattingEnabled = true;
            this.txt_User_Role.Location = new System.Drawing.Point(217, 78);
            this.txt_User_Role.Name = "txt_User_Role";
            this.txt_User_Role.Size = new System.Drawing.Size(291, 28);
            this.txt_User_Role.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "User/Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "TABLE/VIEW";
            // 
            // txtTable
            // 
            this.txtTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTable.Location = new System.Drawing.Point(151, 502);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(147, 27);
            this.txtTable.TabIndex = 7;
            // 
            // DatabaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1179, 754);
            this.Controls.Add(this.panel_ThongTinQuyen);
            this.Controls.Add(this.panel1);
            this.Name = "DatabaseManager";
            this.Text = "DataManagement";
            this.Load += new System.EventHandler(this.DatabaseManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_ThongTinQuyen.ResumeLayout(false);
            this.panel_ThongTinQuyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ThongTinQuyen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XemThongTin;
        private System.Windows.Forms.Panel panel_ThongTinQuyen;
        private System.Windows.Forms.ComboBox txt_User_Role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPriv;
        private System.Windows.Forms.TextBox txtGrantee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label label5;
    }
}

