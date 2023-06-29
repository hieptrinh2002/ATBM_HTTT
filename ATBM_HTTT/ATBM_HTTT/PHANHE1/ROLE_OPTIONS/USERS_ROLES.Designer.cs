
namespace ATBM_HTTT
{
    partial class USERS_ROLES
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.USERS = new System.Windows.Forms.TabPage();
            this.button_CapNhatUser_tabUSER = new System.Windows.Forms.Button();
            this.button_xoaUser_tabUSER = new System.Windows.Forms.Button();
            this.button_TaoUSER_tabUSER = new System.Windows.Forms.Button();
            this.button_xemDS_tabUSERS = new System.Windows.Forms.Button();
            this.dataGridView_listUser = new System.Windows.Forms.DataGridView();
            this.ROLES = new System.Windows.Forms.TabPage();
            this.dataGridView_listROLES = new System.Windows.Forms.DataGridView();
            this.button_CapNhatROLE_TabROLES = new System.Windows.Forms.Button();
            this.button_XoaRole_tabROLES = new System.Windows.Forms.Button();
            this.button_TaoROLE_tabROLES = new System.Windows.Forms.Button();
            this.button_XemDS_TabROLES = new System.Windows.Forms.Button();
            this.buttonDX = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.USERS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listUser)).BeginInit();
            this.ROLES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listROLES)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.USERS);
            this.tabControl1.Controls.Add(this.ROLES);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(26, 24);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1376, 774);
            this.tabControl1.TabIndex = 2;
            // 
            // USERS
            // 
            this.USERS.Controls.Add(this.buttonDX);
            this.USERS.Controls.Add(this.button_CapNhatUser_tabUSER);
            this.USERS.Controls.Add(this.button_xoaUser_tabUSER);
            this.USERS.Controls.Add(this.button_TaoUSER_tabUSER);
            this.USERS.Controls.Add(this.button_xemDS_tabUSERS);
            this.USERS.Controls.Add(this.dataGridView_listUser);
            this.USERS.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERS.Location = new System.Drawing.Point(4, 28);
            this.USERS.Margin = new System.Windows.Forms.Padding(5, 15, 15, 5);
            this.USERS.Name = "USERS";
            this.USERS.Padding = new System.Windows.Forms.Padding(3);
            this.USERS.Size = new System.Drawing.Size(1368, 742);
            this.USERS.TabIndex = 0;
            this.USERS.Text = "        USERS        ";
            this.USERS.UseVisualStyleBackColor = true;
            // 
            // button_CapNhatUser_tabUSER
            // 
            this.button_CapNhatUser_tabUSER.Location = new System.Drawing.Point(26, 387);
            this.button_CapNhatUser_tabUSER.Name = "button_CapNhatUser_tabUSER";
            this.button_CapNhatUser_tabUSER.Size = new System.Drawing.Size(213, 82);
            this.button_CapNhatUser_tabUSER.TabIndex = 15;
            this.button_CapNhatUser_tabUSER.Text = "Cập Nhật USER";
            this.button_CapNhatUser_tabUSER.UseVisualStyleBackColor = true;
            this.button_CapNhatUser_tabUSER.Click += new System.EventHandler(this.button_CapNhatUser_tabUSER_Click);
            // 
            // button_xoaUser_tabUSER
            // 
            this.button_xoaUser_tabUSER.Location = new System.Drawing.Point(26, 269);
            this.button_xoaUser_tabUSER.Name = "button_xoaUser_tabUSER";
            this.button_xoaUser_tabUSER.Size = new System.Drawing.Size(213, 82);
            this.button_xoaUser_tabUSER.TabIndex = 14;
            this.button_xoaUser_tabUSER.Text = "Xóa USER";
            this.button_xoaUser_tabUSER.UseVisualStyleBackColor = true;
            this.button_xoaUser_tabUSER.Click += new System.EventHandler(this.button_xoaUser_tabUSER_Click);
            // 
            // button_TaoUSER_tabUSER
            // 
            this.button_TaoUSER_tabUSER.Location = new System.Drawing.Point(26, 141);
            this.button_TaoUSER_tabUSER.Name = "button_TaoUSER_tabUSER";
            this.button_TaoUSER_tabUSER.Size = new System.Drawing.Size(213, 82);
            this.button_TaoUSER_tabUSER.TabIndex = 13;
            this.button_TaoUSER_tabUSER.Text = "Tạo USER";
            this.button_TaoUSER_tabUSER.UseVisualStyleBackColor = true;
            this.button_TaoUSER_tabUSER.Click += new System.EventHandler(this.button_TaoUSER_tabUSER_Click);
            // 
            // button_xemDS_tabUSERS
            // 
            this.button_xemDS_tabUSERS.Location = new System.Drawing.Point(26, 24);
            this.button_xemDS_tabUSERS.Name = "button_xemDS_tabUSERS";
            this.button_xemDS_tabUSERS.Size = new System.Drawing.Size(213, 82);
            this.button_xemDS_tabUSERS.TabIndex = 12;
            this.button_xemDS_tabUSERS.Text = "Refresh Danh Sách";
            this.button_xemDS_tabUSERS.UseVisualStyleBackColor = true;
            this.button_xemDS_tabUSERS.Click += new System.EventHandler(this.button_xemDS_tabUSERS_Click);
            // 
            // dataGridView_listUser
            // 
            this.dataGridView_listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listUser.Location = new System.Drawing.Point(269, 15);
            this.dataGridView_listUser.Name = "dataGridView_listUser";
            this.dataGridView_listUser.RowHeadersWidth = 62;
            this.dataGridView_listUser.RowTemplate.Height = 28;
            this.dataGridView_listUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_listUser.Size = new System.Drawing.Size(1091, 720);
            this.dataGridView_listUser.TabIndex = 11;
            this.dataGridView_listUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_listUser_CellContentClick_1);
            // 
            // ROLES
            // 
            this.ROLES.Controls.Add(this.button1);
            this.ROLES.Controls.Add(this.dataGridView_listROLES);
            this.ROLES.Controls.Add(this.button_CapNhatROLE_TabROLES);
            this.ROLES.Controls.Add(this.button_XoaRole_tabROLES);
            this.ROLES.Controls.Add(this.button_TaoROLE_tabROLES);
            this.ROLES.Controls.Add(this.button_XemDS_TabROLES);
            this.ROLES.Location = new System.Drawing.Point(4, 28);
            this.ROLES.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.ROLES.Name = "ROLES";
            this.ROLES.Padding = new System.Windows.Forms.Padding(3, 15, 15, 3);
            this.ROLES.Size = new System.Drawing.Size(1368, 742);
            this.ROLES.TabIndex = 1;
            this.ROLES.Text = "        ROLES        ";
            this.ROLES.UseVisualStyleBackColor = true;
            // 
            // dataGridView_listROLES
            // 
            this.dataGridView_listROLES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listROLES.Location = new System.Drawing.Point(268, 15);
            this.dataGridView_listROLES.Name = "dataGridView_listROLES";
            this.dataGridView_listROLES.RowHeadersWidth = 62;
            this.dataGridView_listROLES.RowTemplate.Height = 28;
            this.dataGridView_listROLES.Size = new System.Drawing.Size(1092, 720);
            this.dataGridView_listROLES.TabIndex = 4;
            // 
            // button_CapNhatROLE_TabROLES
            // 
            this.button_CapNhatROLE_TabROLES.Location = new System.Drawing.Point(24, 386);
            this.button_CapNhatROLE_TabROLES.Name = "button_CapNhatROLE_TabROLES";
            this.button_CapNhatROLE_TabROLES.Size = new System.Drawing.Size(215, 82);
            this.button_CapNhatROLE_TabROLES.TabIndex = 3;
            this.button_CapNhatROLE_TabROLES.Text = "Cập Nhật ROLE";
            this.button_CapNhatROLE_TabROLES.UseVisualStyleBackColor = true;
            this.button_CapNhatROLE_TabROLES.Click += new System.EventHandler(this.button_CapNhatROLE_TabROLES_Click);
            // 
            // button_XoaRole_tabROLES
            // 
            this.button_XoaRole_tabROLES.Location = new System.Drawing.Point(24, 267);
            this.button_XoaRole_tabROLES.Name = "button_XoaRole_tabROLES";
            this.button_XoaRole_tabROLES.Size = new System.Drawing.Size(215, 82);
            this.button_XoaRole_tabROLES.TabIndex = 2;
            this.button_XoaRole_tabROLES.Text = "Xóa ROLE";
            this.button_XoaRole_tabROLES.UseVisualStyleBackColor = true;
            this.button_XoaRole_tabROLES.Click += new System.EventHandler(this.button_XoaRole_tabROLES_Click);
            // 
            // button_TaoROLE_tabROLES
            // 
            this.button_TaoROLE_tabROLES.Location = new System.Drawing.Point(24, 146);
            this.button_TaoROLE_tabROLES.Name = "button_TaoROLE_tabROLES";
            this.button_TaoROLE_tabROLES.Size = new System.Drawing.Size(215, 82);
            this.button_TaoROLE_tabROLES.TabIndex = 1;
            this.button_TaoROLE_tabROLES.Text = "Tạo ROLE";
            this.button_TaoROLE_tabROLES.UseVisualStyleBackColor = true;
            this.button_TaoROLE_tabROLES.Click += new System.EventHandler(this.button_TaoROLE_tabROLES_Click);
            // 
            // button_XemDS_TabROLES
            // 
            this.button_XemDS_TabROLES.Location = new System.Drawing.Point(26, 24);
            this.button_XemDS_TabROLES.Name = "button_XemDS_TabROLES";
            this.button_XemDS_TabROLES.Size = new System.Drawing.Size(213, 82);
            this.button_XemDS_TabROLES.TabIndex = 0;
            this.button_XemDS_TabROLES.Text = "Refresh Danh Sách";
            this.button_XemDS_TabROLES.UseVisualStyleBackColor = true;
            this.button_XemDS_TabROLES.Click += new System.EventHandler(this.button_XemDS_TabROLES_Click);
            // 
            // buttonDX
            // 
            this.buttonDX.Location = new System.Drawing.Point(26, 527);
            this.buttonDX.Name = "buttonDX";
            this.buttonDX.Size = new System.Drawing.Size(213, 82);
            this.buttonDX.TabIndex = 16;
            this.buttonDX.Text = "Đăng Xuất";
            this.buttonDX.UseVisualStyleBackColor = true;
            this.buttonDX.Click += new System.EventHandler(this.buttonDX_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 82);
            this.button1.TabIndex = 17;
            this.button1.Text = "Đăng Xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // USERS_ROLES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 775);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1398, 831);
            this.MinimumSize = new System.Drawing.Size(1398, 831);
            this.Name = "USERS_ROLES";
            this.Text = "USERS_ROLES";
            this.Load += new System.EventHandler(this.USERS_ROLES_Load);
            this.tabControl1.ResumeLayout(false);
            this.USERS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listUser)).EndInit();
            this.ROLES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listROLES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage USERS;
        private System.Windows.Forms.Button button_CapNhatUser_tabUSER;
        private System.Windows.Forms.Button button_xoaUser_tabUSER;
        private System.Windows.Forms.Button button_TaoUSER_tabUSER;
        private System.Windows.Forms.Button button_xemDS_tabUSERS;
        private System.Windows.Forms.DataGridView dataGridView_listUser;
        private System.Windows.Forms.TabPage ROLES;
        private System.Windows.Forms.Button button_CapNhatROLE_TabROLES;
        private System.Windows.Forms.Button button_XoaRole_tabROLES;
        private System.Windows.Forms.Button button_TaoROLE_tabROLES;
        private System.Windows.Forms.Button button_XemDS_TabROLES;
        private System.Windows.Forms.DataGridView dataGridView_listROLES;
        private System.Windows.Forms.Button buttonDX;
        private System.Windows.Forms.Button button1;
    }
}

