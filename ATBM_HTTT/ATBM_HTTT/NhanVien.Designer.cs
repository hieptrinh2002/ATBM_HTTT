
namespace ATBM_HTTT
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_pc = new System.Windows.Forms.Button();
            this.btn_infor = new System.Windows.Forms.Button();
            this.btn_deAn = new System.Windows.Forms.Button();
            this.btn_PB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(351, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(874, 651);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btn_pc
            // 
            this.btn_pc.Location = new System.Drawing.Point(43, 276);
            this.btn_pc.Name = "btn_pc";
            this.btn_pc.Size = new System.Drawing.Size(257, 76);
            this.btn_pc.TabIndex = 1;
            this.btn_pc.Text = "Danh Sách Phân Công";
            this.btn_pc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pc.UseVisualStyleBackColor = true;
            this.btn_pc.Click += new System.EventHandler(this.btn_pc_Click);
            // 
            // btn_infor
            // 
            this.btn_infor.Location = new System.Drawing.Point(43, 582);
            this.btn_infor.Name = "btn_infor";
            this.btn_infor.Size = new System.Drawing.Size(257, 76);
            this.btn_infor.TabIndex = 6;
            this.btn_infor.Text = "Thông Tin Cá Nhân";
            this.btn_infor.UseVisualStyleBackColor = true;
            this.btn_infor.Click += new System.EventHandler(this.btn_infor_Click);
            // 
            // btn_deAn
            // 
            this.btn_deAn.Location = new System.Drawing.Point(43, 487);
            this.btn_deAn.Name = "btn_deAn";
            this.btn_deAn.Size = new System.Drawing.Size(257, 76);
            this.btn_deAn.TabIndex = 7;
            this.btn_deAn.Text = "Danh Sách Đề Án";
            this.btn_deAn.UseVisualStyleBackColor = true;
            this.btn_deAn.Click += new System.EventHandler(this.btn_deAn_Click);
            // 
            // btn_PB
            // 
            this.btn_PB.Location = new System.Drawing.Point(43, 385);
            this.btn_PB.Name = "btn_PB";
            this.btn_PB.Size = new System.Drawing.Size(257, 76);
            this.btn_PB.TabIndex = 8;
            this.btn_PB.Text = "Danh Sách Phòng Ban";
            this.btn_PB.UseVisualStyleBackColor = true;
            this.btn_PB.Click += new System.EventHandler(this.btn_PB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(285, 242);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1258, 724);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PB);
            this.Controls.Add(this.btn_deAn);
            this.Controls.Add(this.btn_infor);
            this.Controls.Add(this.btn_pc);
            this.Controls.Add(this.dataGridView);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_pc;
        private System.Windows.Forms.Button btn_infor;
        private System.Windows.Forms.Button btn_deAn;
        private System.Windows.Forms.Button btn_PB;
        private System.Windows.Forms.Label label1;
    }
}