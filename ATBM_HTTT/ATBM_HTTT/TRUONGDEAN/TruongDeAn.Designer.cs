namespace ATBM_HTTT
{
    partial class TruongDeAn
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
            this.btn_ThemDA = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ThongTinDA = new System.Windows.Forms.Button();
            this.btn_ThongTinPC = new System.Windows.Forms.Button();
            this.btn_ThongTinPB = new System.Windows.Forms.Button();
            this.btn_ThongTin = new System.Windows.Forms.Button();
            this.btn_Xoa_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemDA
            // 
            this.btn_ThemDA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ThemDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDA.Location = new System.Drawing.Point(21, 552);
            this.btn_ThemDA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThemDA.Name = "btn_ThemDA";
            this.btn_ThemDA.Size = new System.Drawing.Size(230, 76);
            this.btn_ThemDA.TabIndex = 13;
            this.btn_ThemDA.Text = "Thêm đề án";
            this.btn_ThemDA.UseVisualStyleBackColor = false;
            this.btn_ThemDA.Click += new System.EventHandler(this.btn_ThemDA_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Logout.Location = new System.Drawing.Point(1234, 781);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(147, 58);
            this.btn_Logout.TabIndex = 12;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 712);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_ThongTinDA
            // 
            this.btn_ThongTinDA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ThongTinDA.FlatAppearance.BorderSize = 0;
            this.btn_ThongTinDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTinDA.Location = new System.Drawing.Point(21, 425);
            this.btn_ThongTinDA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThongTinDA.Name = "btn_ThongTinDA";
            this.btn_ThongTinDA.Size = new System.Drawing.Size(230, 76);
            this.btn_ThongTinDA.TabIndex = 6;
            this.btn_ThongTinDA.Text = "Thông tin đề án";
            this.btn_ThongTinDA.UseVisualStyleBackColor = false;
            this.btn_ThongTinDA.Click += new System.EventHandler(this.btn_ThongTinDA_Click);
            // 
            // btn_ThongTinPC
            // 
            this.btn_ThongTinPC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ThongTinPC.FlatAppearance.BorderSize = 0;
            this.btn_ThongTinPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTinPC.Location = new System.Drawing.Point(21, 291);
            this.btn_ThongTinPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThongTinPC.Name = "btn_ThongTinPC";
            this.btn_ThongTinPC.Size = new System.Drawing.Size(230, 76);
            this.btn_ThongTinPC.TabIndex = 7;
            this.btn_ThongTinPC.Text = "Thông tin phân công";
            this.btn_ThongTinPC.UseVisualStyleBackColor = false;
            this.btn_ThongTinPC.Click += new System.EventHandler(this.btn_ThongTinPC_Click);
            // 
            // btn_ThongTinPB
            // 
            this.btn_ThongTinPB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ThongTinPB.FlatAppearance.BorderSize = 0;
            this.btn_ThongTinPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTinPB.Location = new System.Drawing.Point(21, 165);
            this.btn_ThongTinPB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThongTinPB.Name = "btn_ThongTinPB";
            this.btn_ThongTinPB.Size = new System.Drawing.Size(230, 76);
            this.btn_ThongTinPB.TabIndex = 8;
            this.btn_ThongTinPB.Text = "Thông tin phòng ban";
            this.btn_ThongTinPB.UseVisualStyleBackColor = false;
            this.btn_ThongTinPB.Click += new System.EventHandler(this.btn_ThongTinPB_Click);
            // 
            // btn_ThongTin
            // 
            this.btn_ThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ThongTin.FlatAppearance.BorderSize = 0;
            this.btn_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTin.Location = new System.Drawing.Point(21, 45);
            this.btn_ThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThongTin.Name = "btn_ThongTin";
            this.btn_ThongTin.Size = new System.Drawing.Size(230, 76);
            this.btn_ThongTin.TabIndex = 10;
            this.btn_ThongTin.Text = "Thông tin cá nhân ";
            this.btn_ThongTin.UseVisualStyleBackColor = false;
            this.btn_ThongTin.Click += new System.EventHandler(this.btn_ThongTin_Click);
            // 
            // btn_Xoa_Sua
            // 
            this.btn_Xoa_Sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Xoa_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_Sua.Location = new System.Drawing.Point(21, 681);
            this.btn_Xoa_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa_Sua.Name = "btn_Xoa_Sua";
            this.btn_Xoa_Sua.Size = new System.Drawing.Size(230, 76);
            this.btn_Xoa_Sua.TabIndex = 14;
            this.btn_Xoa_Sua.Text = "Xóa/Sửa đề án";
            this.btn_Xoa_Sua.UseVisualStyleBackColor = false;
            this.btn_Xoa_Sua.Click += new System.EventHandler(this.btn_Xoa_Sua_Click);
            // 
            // TruongDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 854);
            this.Controls.Add(this.btn_Xoa_Sua);
            this.Controls.Add(this.btn_ThemDA);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ThongTinDA);
            this.Controls.Add(this.btn_ThongTinPC);
            this.Controls.Add(this.btn_ThongTinPB);
            this.Controls.Add(this.btn_ThongTin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1438, 910);
            this.MinimumSize = new System.Drawing.Size(1438, 910);
            this.Name = "TruongDeAn";
            this.Text = "TruongDeAn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TruongDeAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ThemDA;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ThongTinDA;
        private System.Windows.Forms.Button btn_ThongTinPC;
        private System.Windows.Forms.Button btn_ThongTinPB;
        private System.Windows.Forms.Button btn_ThongTin;
        private System.Windows.Forms.Button btn_Xoa_Sua;
    }
}
