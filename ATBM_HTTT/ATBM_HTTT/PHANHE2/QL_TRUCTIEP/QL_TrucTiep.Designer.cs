
namespace ATBM_HTTT
{
    partial class QL_TrucTiep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_TrucTiep));
            this.btn_dsNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PB = new System.Windows.Forms.Button();
            this.btn_deAn = new System.Windows.Forms.Button();
            this.btn_infor = new System.Windows.Forms.Button();
            this.btn_pc = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dsNV
            // 
            this.btn_dsNV.Location = new System.Drawing.Point(40, 295);
            this.btn_dsNV.Name = "btn_dsNV";
            this.btn_dsNV.Size = new System.Drawing.Size(257, 57);
            this.btn_dsNV.TabIndex = 31;
            this.btn_dsNV.Text = "Danh Sách Nhân Viên";
            this.btn_dsNV.UseVisualStyleBackColor = true;
            this.btn_dsNV.Click += new System.EventHandler(this.btn_dsNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(265, 262);
            this.label1.TabIndex = 30;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btn_PB
            // 
            this.btn_PB.Location = new System.Drawing.Point(40, 441);
            this.btn_PB.Name = "btn_PB";
            this.btn_PB.Size = new System.Drawing.Size(257, 60);
            this.btn_PB.TabIndex = 29;
            this.btn_PB.Text = "Danh Sách Phòng Ban";
            this.btn_PB.UseVisualStyleBackColor = true;
            this.btn_PB.Click += new System.EventHandler(this.btn_PB_Click);
            // 
            // btn_deAn
            // 
            this.btn_deAn.Location = new System.Drawing.Point(40, 523);
            this.btn_deAn.Name = "btn_deAn";
            this.btn_deAn.Size = new System.Drawing.Size(257, 61);
            this.btn_deAn.TabIndex = 28;
            this.btn_deAn.Text = "Danh Sách Đề Án";
            this.btn_deAn.UseVisualStyleBackColor = true;
            this.btn_deAn.Click += new System.EventHandler(this.btn_deAn_Click);
            // 
            // btn_infor
            // 
            this.btn_infor.Location = new System.Drawing.Point(40, 603);
            this.btn_infor.Name = "btn_infor";
            this.btn_infor.Size = new System.Drawing.Size(257, 58);
            this.btn_infor.TabIndex = 27;
            this.btn_infor.Text = "Thông Tin Cá Nhân";
            this.btn_infor.UseVisualStyleBackColor = true;
            this.btn_infor.Click += new System.EventHandler(this.btn_infor_Click);
            // 
            // btn_pc
            // 
            this.btn_pc.Location = new System.Drawing.Point(40, 368);
            this.btn_pc.Name = "btn_pc";
            this.btn_pc.Size = new System.Drawing.Size(257, 57);
            this.btn_pc.TabIndex = 26;
            this.btn_pc.Text = "Danh Sách Phân Công";
            this.btn_pc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pc.UseVisualStyleBackColor = true;
            this.btn_pc.Click += new System.EventHandler(this.btn_pc_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(325, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1212, 649);
            this.dataGridView.TabIndex = 25;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Location = new System.Drawing.Point(698, 683);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(428, 45);
            this.btn_DangXuat.TabIndex = 32;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // QL_TrucTiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 740);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.btn_dsNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PB);
            this.Controls.Add(this.btn_deAn);
            this.Controls.Add(this.btn_infor);
            this.Controls.Add(this.btn_pc);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(1571, 796);
            this.MinimumSize = new System.Drawing.Size(1571, 765);
            this.Name = "QL_TrucTiep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhan Viên Quản Lý Trực Tiếp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dsNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PB;
        private System.Windows.Forms.Button btn_deAn;
        private System.Windows.Forms.Button btn_infor;
        private System.Windows.Forms.Button btn_pc;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}