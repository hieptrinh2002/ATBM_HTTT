
namespace ATBM_HTTT
{
    partial class TruongPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruongPhong));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TrangChu = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_DX_TC = new System.Windows.Forms.Button();
            this.button_DSDA_TC = new System.Windows.Forms.Button();
            this.button_TTCN_TC = new System.Windows.Forms.Button();
            this.dataGridView_TC = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_deletePC = new System.Windows.Forms.Button();
            this.button_updatePC = new System.Windows.Forms.Button();
            this.button_DSPC_TC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_insertPC = new System.Windows.Forms.Button();
            this.dataGridViewQLPC = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button_DX_QLNV = new System.Windows.Forms.Button();
            this.button_DSNV_QLNV = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TC)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLPC)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TrangChu);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1545, 724);
            this.tabControl1.TabIndex = 1;
            // 
            // TrangChu
            // 
            this.TrangChu.Controls.Add(this.label4);
            this.TrangChu.Controls.Add(this.button1);
            this.TrangChu.Controls.Add(this.button_DX_TC);
            this.TrangChu.Controls.Add(this.button_DSDA_TC);
            this.TrangChu.Controls.Add(this.button_TTCN_TC);
            this.TrangChu.Controls.Add(this.dataGridView_TC);
            this.TrangChu.Location = new System.Drawing.Point(4, 29);
            this.TrangChu.Margin = new System.Windows.Forms.Padding(10);
            this.TrangChu.Name = "TrangChu";
            this.TrangChu.Padding = new System.Windows.Forms.Padding(3);
            this.TrangChu.Size = new System.Drawing.Size(1537, 691);
            this.TrangChu.TabIndex = 0;
            this.TrangChu.Text = "     Trang Chủ     ";
            this.TrangChu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20);
            this.label4.Size = new System.Drawing.Size(282, 242);
            this.label4.TabIndex = 53;
            this.label4.Text = "*Note:\r\n\r\nbtn danh sách phòng ban\r\n=> hiện thị danh sách phòng ban\r\nbtn danh sách" +
    " đề án\r\n=> hiện thị danh sách đề án\r\nbtn thông tin cá nhân\r\n=> hiển thị thông ti" +
    "n cá nhân,\r\ncập nhật , chỉnh sửa\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 62);
            this.button1.TabIndex = 52;
            this.button1.Text = "Danh Sách Phòng Ban";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_DX_TC
            // 
            this.button_DX_TC.Location = new System.Drawing.Point(19, 603);
            this.button_DX_TC.Name = "button_DX_TC";
            this.button_DX_TC.Size = new System.Drawing.Size(269, 63);
            this.button_DX_TC.TabIndex = 49;
            this.button_DX_TC.Text = "Đăng Xuất";
            this.button_DX_TC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_DX_TC.UseVisualStyleBackColor = true;
            this.button_DX_TC.Click += new System.EventHandler(this.button_DX_TC_Click);
            // 
            // button_DSDA_TC
            // 
            this.button_DSDA_TC.Location = new System.Drawing.Point(19, 402);
            this.button_DSDA_TC.Name = "button_DSDA_TC";
            this.button_DSDA_TC.Size = new System.Drawing.Size(269, 62);
            this.button_DSDA_TC.TabIndex = 46;
            this.button_DSDA_TC.Text = "Danh Sách Đề Án";
            this.button_DSDA_TC.UseVisualStyleBackColor = true;
            this.button_DSDA_TC.Click += new System.EventHandler(this.button_DSDA_TC_Click);
            // 
            // button_TTCN_TC
            // 
            this.button_TTCN_TC.Location = new System.Drawing.Point(19, 502);
            this.button_TTCN_TC.Name = "button_TTCN_TC";
            this.button_TTCN_TC.Size = new System.Drawing.Size(269, 65);
            this.button_TTCN_TC.TabIndex = 45;
            this.button_TTCN_TC.Text = "Thông Tin Cá Nhân";
            this.button_TTCN_TC.UseVisualStyleBackColor = true;
            this.button_TTCN_TC.Click += new System.EventHandler(this.button_TTCN_TC_Click);
            // 
            // dataGridView_TC
            // 
            this.dataGridView_TC.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_TC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TC.Location = new System.Drawing.Point(318, 19);
            this.dataGridView_TC.Name = "dataGridView_TC";
            this.dataGridView_TC.RowHeadersWidth = 62;
            this.dataGridView_TC.RowTemplate.Height = 28;
            this.dataGridView_TC.Size = new System.Drawing.Size(1200, 649);
            this.dataGridView_TC.TabIndex = 43;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.button_deletePC);
            this.tabPage2.Controls.Add(this.button_updatePC);
            this.tabPage2.Controls.Add(this.button_DSPC_TC);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button_insertPC);
            this.tabPage2.Controls.Add(this.dataGridViewQLPC);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1537, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "     Quản Lý Phân Công     ";
            // 
            // button_deletePC
            // 
            this.button_deletePC.Location = new System.Drawing.Point(19, 603);
            this.button_deletePC.Name = "button_deletePC";
            this.button_deletePC.Size = new System.Drawing.Size(269, 63);
            this.button_deletePC.TabIndex = 58;
            this.button_deletePC.Text = "Xóa Phân Công";
            this.button_deletePC.UseVisualStyleBackColor = true;
            this.button_deletePC.Click += new System.EventHandler(this.button_deletePC_Click);
            // 
            // button_updatePC
            // 
            this.button_updatePC.Location = new System.Drawing.Point(19, 502);
            this.button_updatePC.Name = "button_updatePC";
            this.button_updatePC.Size = new System.Drawing.Size(269, 65);
            this.button_updatePC.TabIndex = 57;
            this.button_updatePC.Text = "Cập Nhật Phân Công";
            this.button_updatePC.UseVisualStyleBackColor = true;
            this.button_updatePC.Click += new System.EventHandler(this.button_updatePC_Click);
            // 
            // button_DSPC_TC
            // 
            this.button_DSPC_TC.Location = new System.Drawing.Point(19, 303);
            this.button_DSPC_TC.Name = "button_DSPC_TC";
            this.button_DSPC_TC.Size = new System.Drawing.Size(269, 62);
            this.button_DSPC_TC.TabIndex = 56;
            this.button_DSPC_TC.Text = "Danh Sách Phân Công";
            this.button_DSPC_TC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_DSPC_TC.UseVisualStyleBackColor = true;
            this.button_DSPC_TC.Click += new System.EventHandler(this.button_DSPC_TC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(268, 242);
            this.label2.TabIndex = 54;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // button_insertPC
            // 
            this.button_insertPC.Location = new System.Drawing.Point(19, 402);
            this.button_insertPC.Name = "button_insertPC";
            this.button_insertPC.Size = new System.Drawing.Size(269, 62);
            this.button_insertPC.TabIndex = 51;
            this.button_insertPC.Text = "Thêm Phân Công";
            this.button_insertPC.UseVisualStyleBackColor = true;
            this.button_insertPC.Click += new System.EventHandler(this.button_insertPC_Click);
            // 
            // dataGridViewQLPC
            // 
            this.dataGridViewQLPC.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewQLPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLPC.Location = new System.Drawing.Point(318, 19);
            this.dataGridViewQLPC.Name = "dataGridViewQLPC";
            this.dataGridViewQLPC.RowHeadersWidth = 62;
            this.dataGridViewQLPC.RowTemplate.Height = 28;
            this.dataGridViewQLPC.Size = new System.Drawing.Size(1200, 649);
            this.dataGridViewQLPC.TabIndex = 44;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.button_DX_QLNV);
            this.tabPage3.Controls.Add(this.button_DSNV_QLNV);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1537, 691);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "     Quản Lý Nhân Viên   ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(259, 242);
            this.label3.TabIndex = 60;
            this.label3.Text = "*Note:\r\n\r\nbtn danh sách nhân viên\r\n=> hiển thi ds nhân viên\r\n\r\nbtn thêm nhân viên" +
    "\r\n=> thực hiện thêm mới nhân viên\r\n\r\nbtn cập nhật nhân viên\r\n=> thực hiện cập nh" +
    "ật thông tin\r\nnhân viên\r\n";
            // 
            // button_DX_QLNV
            // 
            this.button_DX_QLNV.Location = new System.Drawing.Point(19, 404);
            this.button_DX_QLNV.Name = "button_DX_QLNV";
            this.button_DX_QLNV.Size = new System.Drawing.Size(269, 63);
            this.button_DX_QLNV.TabIndex = 59;
            this.button_DX_QLNV.Text = "Đăng Xuất";
            this.button_DX_QLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_DX_QLNV.UseVisualStyleBackColor = true;
            this.button_DX_QLNV.Click += new System.EventHandler(this.button_DX_QLNV_Click);
            // 
            // button_DSNV_QLNV
            // 
            this.button_DSNV_QLNV.Location = new System.Drawing.Point(19, 309);
            this.button_DSNV_QLNV.Name = "button_DSNV_QLNV";
            this.button_DSNV_QLNV.Size = new System.Drawing.Size(269, 62);
            this.button_DSNV_QLNV.TabIndex = 57;
            this.button_DSNV_QLNV.Text = "Danh Sách Nhân Viên";
            this.button_DSNV_QLNV.UseVisualStyleBackColor = true;
            this.button_DSNV_QLNV.Click += new System.EventHandler(this.button_DSNV_QLNV_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(318, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1200, 649);
            this.dataGridView3.TabIndex = 56;
            // 
            // TruongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 734);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1571, 790);
            this.MinimumSize = new System.Drawing.Size(1571, 790);
            this.Name = "TruongPhong";
            this.Text = "TruongPhong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TruongPhong_Load);
            this.tabControl1.ResumeLayout(false);
            this.TrangChu.ResumeLayout(false);
            this.TrangChu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TC)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLPC)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TrangChu;
        private System.Windows.Forms.Button button_DX_TC;
        private System.Windows.Forms.Button button_DSDA_TC;
        private System.Windows.Forms.Button button_TTCN_TC;
        private System.Windows.Forms.DataGridView dataGridView_TC;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_insertPC;
        private System.Windows.Forms.DataGridView dataGridViewQLPC;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_DX_QLNV;
        private System.Windows.Forms.Button button_DSNV_QLNV;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_DSPC_TC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_deletePC;
        private System.Windows.Forms.Button button_updatePC;
    }
}