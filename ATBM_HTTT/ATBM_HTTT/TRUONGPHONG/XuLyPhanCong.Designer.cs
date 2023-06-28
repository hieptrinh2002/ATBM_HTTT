
namespace ATBM_HTTT
{
    partial class XuLyPhanCong
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_maDA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_manv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_XuLy = new System.Windows.Forms.Button();
            this.dateTimePicker_tgbd = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_maDA);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 69);
            this.panel2.TabIndex = 6;
            // 
            // textBox_maDA
            // 
            this.textBox_maDA.Location = new System.Drawing.Point(204, 23);
            this.textBox_maDA.Name = "textBox_maDA";
            this.textBox_maDA.Size = new System.Drawing.Size(352, 26);
            this.textBox_maDA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đề Án :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker_tgbd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(7, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 69);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời Gian Bắt Đầu :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_manv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 69);
            this.panel1.TabIndex = 5;
            // 
            // textBox_manv
            // 
            this.textBox_manv.Location = new System.Drawing.Point(204, 23);
            this.textBox_manv.Name = "textBox_manv";
            this.textBox_manv.Size = new System.Drawing.Size(352, 26);
            this.textBox_manv.TabIndex = 2;
            this.textBox_manv.TextChanged += new System.EventHandler(this.textBox_manv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên :";
            // 
            // button_XuLy
            // 
            this.button_XuLy.Location = new System.Drawing.Point(227, 263);
            this.button_XuLy.Name = "button_XuLy";
            this.button_XuLy.Size = new System.Drawing.Size(156, 42);
            this.button_XuLy.TabIndex = 4;
            this.button_XuLy.Text = "Xử Lý";
            this.button_XuLy.UseVisualStyleBackColor = true;
            this.button_XuLy.Click += new System.EventHandler(this.button_XuLy_Click);
            // 
            // dateTimePicker_tgbd
            // 
            this.dateTimePicker_tgbd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_tgbd.Location = new System.Drawing.Point(204, 21);
            this.dateTimePicker_tgbd.Name = "dateTimePicker_tgbd";
            this.dateTimePicker_tgbd.Size = new System.Drawing.Size(350, 26);
            this.dateTimePicker_tgbd.TabIndex = 19;
            this.dateTimePicker_tgbd.Value = new System.DateTime(2023, 6, 27, 9, 29, 59, 0);
            // 
            // XuLyPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 326);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_XuLy);
            this.MaximumSize = new System.Drawing.Size(648, 382);
            this.MinimumSize = new System.Drawing.Size(648, 382);
            this.Name = "XuLyPhanCong";
            this.Text = "XuLyPhanCong";
            this.Load += new System.EventHandler(this.XuLyPhanCong_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_maDA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_manv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_XuLy;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tgbd;
    }
}