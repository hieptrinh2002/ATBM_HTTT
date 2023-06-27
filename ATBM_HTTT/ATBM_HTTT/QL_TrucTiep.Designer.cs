
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PB = new System.Windows.Forms.Button();
            this.btn_deAn = new System.Windows.Forms.Button();
            this.btn_infor = new System.Windows.Forms.Button();
            this.btn_pc = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 76);
            this.button1.TabIndex = 31;
            this.button1.Text = "Danh Sách Nhân Viên";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 242);
            this.label1.TabIndex = 30;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btn_PB
            // 
            this.btn_PB.Location = new System.Drawing.Point(38, 518);
            this.btn_PB.Name = "btn_PB";
            this.btn_PB.Size = new System.Drawing.Size(257, 76);
            this.btn_PB.TabIndex = 29;
            this.btn_PB.Text = "Danh Sách Phòng Ban";
            this.btn_PB.UseVisualStyleBackColor = true;
            // 
            // btn_deAn
            // 
            this.btn_deAn.Location = new System.Drawing.Point(38, 620);
            this.btn_deAn.Name = "btn_deAn";
            this.btn_deAn.Size = new System.Drawing.Size(257, 76);
            this.btn_deAn.TabIndex = 28;
            this.btn_deAn.Text = "Danh Sách Đề Án";
            this.btn_deAn.UseVisualStyleBackColor = true;
            // 
            // btn_infor
            // 
            this.btn_infor.Location = new System.Drawing.Point(940, 682);
            this.btn_infor.Name = "btn_infor";
            this.btn_infor.Size = new System.Drawing.Size(257, 69);
            this.btn_infor.TabIndex = 27;
            this.btn_infor.Text = "Thông Tin Cá Nhân";
            this.btn_infor.UseVisualStyleBackColor = true;
            // 
            // btn_pc
            // 
            this.btn_pc.Location = new System.Drawing.Point(38, 409);
            this.btn_pc.Name = "btn_pc";
            this.btn_pc.Size = new System.Drawing.Size(257, 76);
            this.btn_pc.TabIndex = 26;
            this.btn_pc.Text = "Danh Sách Phân Công";
            this.btn_pc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pc.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(323, 23);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(932, 632);
            this.dataGridView.TabIndex = 25;
            // 
            // QL_TrucTiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 774);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PB);
            this.Controls.Add(this.btn_deAn);
            this.Controls.Add(this.btn_infor);
            this.Controls.Add(this.btn_pc);
            this.Controls.Add(this.dataGridView);
            this.Name = "QL_TrucTiep";
            this.Text = "QL_TrucTiep";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PB;
        private System.Windows.Forms.Button btn_deAn;
        private System.Windows.Forms.Button btn_infor;
        private System.Windows.Forms.Button btn_pc;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}