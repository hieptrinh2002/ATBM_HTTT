namespace ATBM_HTTT
{
    partial class Xoa_SuaDeAn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XoaDA = new System.Windows.Forms.Button();
            this.btn_SuaDA = new System.Windows.Forms.Button();
            this.cmbMaDA = new System.Windows.Forms.ComboBox();
            this.txtPhongBan = new System.Windows.Forms.TextBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã đề án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thông tin đề án";
            // 
            // btn_XoaDA
            // 
            this.btn_XoaDA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_XoaDA.Location = new System.Drawing.Point(34, 411);
            this.btn_XoaDA.Name = "btn_XoaDA";
            this.btn_XoaDA.Size = new System.Drawing.Size(143, 58);
            this.btn_XoaDA.TabIndex = 31;
            this.btn_XoaDA.Text = "Xóa đề án";
            this.btn_XoaDA.UseVisualStyleBackColor = false;
            this.btn_XoaDA.Click += new System.EventHandler(this.btn_XoaDA_Click);
            // 
            // btn_SuaDA
            // 
            this.btn_SuaDA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SuaDA.Location = new System.Drawing.Point(315, 411);
            this.btn_SuaDA.Name = "btn_SuaDA";
            this.btn_SuaDA.Size = new System.Drawing.Size(143, 58);
            this.btn_SuaDA.TabIndex = 31;
            this.btn_SuaDA.Text = "Sửa đề án";
            this.btn_SuaDA.UseVisualStyleBackColor = false;
            this.btn_SuaDA.Click += new System.EventHandler(this.btn_SuaDA_Click);
            // 
            // cmbMaDA
            // 
            this.cmbMaDA.FormattingEnabled = true;
            this.cmbMaDA.Location = new System.Drawing.Point(212, 101);
            this.cmbMaDA.Name = "cmbMaDA";
            this.cmbMaDA.Size = new System.Drawing.Size(281, 24);
            this.cmbMaDA.TabIndex = 32;
            this.cmbMaDA.SelectedIndexChanged += new System.EventHandler(this.cmbMaDA_SelectedIndexChanged);
            // 
            // txtPhongBan
            // 
            this.txtPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongBan.Location = new System.Drawing.Point(212, 324);
            this.txtPhongBan.Name = "txtPhongBan";
            this.txtPhongBan.Size = new System.Drawing.Size(281, 24);
            this.txtPhongBan.TabIndex = 45;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(212, 245);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(281, 27);
            this.dtpNgayBD.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Phòng ban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // txtTenDA
            // 
            this.txtTenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDA.Location = new System.Drawing.Point(212, 167);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(281, 27);
            this.txtTenDA.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tên đề án";
            // 
            // Xoa_SuaDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 515);
            this.Controls.Add(this.txtPhongBan);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMaDA);
            this.Controls.Add(this.btn_SuaDA);
            this.Controls.Add(this.btn_XoaDA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Xoa_SuaDeAn";
            this.Text = "Xoa_SuaDeAn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_XoaDA;
        private System.Windows.Forms.Button btn_SuaDA;
        private System.Windows.Forms.ComboBox cmbMaDA;
        private System.Windows.Forms.TextBox txtPhongBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.Label label3;
    }
}
