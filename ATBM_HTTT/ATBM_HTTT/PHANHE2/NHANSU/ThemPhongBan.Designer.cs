
namespace ATBM_HTTT
{
    partial class ThemPhongBan
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
            this.button_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_maPB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_tenPB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_maTP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(232, 268);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(156, 42);
            this.button_them.TabIndex = 0;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phòng Ban :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_maPB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 69);
            this.panel1.TabIndex = 2;
            // 
            // textBox_maPB
            // 
            this.textBox_maPB.Location = new System.Drawing.Point(185, 23);
            this.textBox_maPB.Name = "textBox_maPB";
            this.textBox_maPB.Size = new System.Drawing.Size(352, 26);
            this.textBox_maPB.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_tenPB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 69);
            this.panel2.TabIndex = 3;
            // 
            // textBox_tenPB
            // 
            this.textBox_tenPB.Location = new System.Drawing.Point(185, 23);
            this.textBox_tenPB.Name = "textBox_tenPB";
            this.textBox_tenPB.Size = new System.Drawing.Size(352, 26);
            this.textBox_tenPB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phòng Ban :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_maTP);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 69);
            this.panel3.TabIndex = 3;
            // 
            // textBox_maTP
            // 
            this.textBox_maTP.Location = new System.Drawing.Point(185, 23);
            this.textBox_maTP.Name = "textBox_maTP";
            this.textBox_maTP.Size = new System.Drawing.Size(352, 26);
            this.textBox_maTP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Trưởng Phòng :";
            // 
            // ThemPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 326);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_them);
            this.MaximumSize = new System.Drawing.Size(648, 382);
            this.MinimumSize = new System.Drawing.Size(648, 382);
            this.Name = "ThemPhongBan";
            this.Text = "Thêm Phòng Ban";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_maPB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_tenPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_maTP;
        private System.Windows.Forms.Label label3;
    }
}