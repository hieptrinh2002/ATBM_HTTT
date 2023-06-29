
namespace NhanSu
{
    partial class TaiChinh
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXemNhanVien = new System.Windows.Forms.Button();
            this.buttonXemPhanCong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXemPhanCong);
            this.panel1.Controls.Add(this.buttonXemNhanVien);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-20, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 528);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(652, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(77, 444);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(249, 43);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Chỉnh sửa lương và phụ cấp";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(435, 444);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(141, 43);
            this.buttonThoat.TabIndex = 1;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonXemNhanVien
            // 
            this.buttonXemNhanVien.Location = new System.Drawing.Point(144, 30);
            this.buttonXemNhanVien.Name = "buttonXemNhanVien";
            this.buttonXemNhanVien.Size = new System.Drawing.Size(131, 46);
            this.buttonXemNhanVien.TabIndex = 5;
            this.buttonXemNhanVien.Text = " Nhân viên";
            this.buttonXemNhanVien.UseVisualStyleBackColor = true;
            this.buttonXemNhanVien.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // buttonXemPhanCong
            // 
            this.buttonXemPhanCong.Location = new System.Drawing.Point(387, 30);
            this.buttonXemPhanCong.Name = "buttonXemPhanCong";
            this.buttonXemPhanCong.Size = new System.Drawing.Size(131, 46);
            this.buttonXemPhanCong.TabIndex = 6;
            this.buttonXemPhanCong.Text = "Phân công";
            this.buttonXemPhanCong.UseVisualStyleBackColor = true;
            this.buttonXemPhanCong.Click += new System.EventHandler(this.buttonXemPhanCong_Click);
            // 
            // TaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 485);
            this.Controls.Add(this.panel1);
            this.Name = "TaiChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiChinh";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXemNhanVien;
        private System.Windows.Forms.Button buttonXemPhanCong;
    }
}