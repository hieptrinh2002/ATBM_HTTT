
namespace ATBM_HTTT
{
    partial class UpdateRole
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
            this.label2 = new System.Windows.Forms.Label();
            this.label_notice_updaterole = new System.Windows.Forms.Label();
            this.button_update_role = new System.Windows.Forms.Button();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.textBox_rolename_update = new System.Windows.Forms.TextBox();
            this.handleuser_pass = new System.Windows.Forms.Label();
            this.handleuser_username = new System.Windows.Forms.Label();
            this.label_handleUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_notice_updaterole);
            this.panel1.Controls.Add(this.button_update_role);
            this.panel1.Controls.Add(this.textBox_NewPassword);
            this.panel1.Controls.Add(this.textBox_rolename_update);
            this.panel1.Controls.Add(this.handleuser_pass);
            this.panel1.Controls.Add(this.handleuser_username);
            this.panel1.Controls.Add(this.label_handleUser);
            this.panel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(35, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 368);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(228, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "**password có thể  trống";
            // 
            // label_notice_updaterole
            // 
            this.label_notice_updaterole.AutoSize = true;
            this.label_notice_updaterole.Location = new System.Drawing.Point(44, 209);
            this.label_notice_updaterole.Name = "label_notice_updaterole";
            this.label_notice_updaterole.Size = new System.Drawing.Size(27, 28);
            this.label_notice_updaterole.TabIndex = 7;
            this.label_notice_updaterole.Text = "   ";
            // 
            // button_update_role
            // 
            this.button_update_role.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update_role.Location = new System.Drawing.Point(243, 257);
            this.button_update_role.Name = "button_update_role";
            this.button_update_role.Size = new System.Drawing.Size(148, 51);
            this.button_update_role.TabIndex = 6;
            this.button_update_role.Text = "Update";
            this.button_update_role.UseVisualStyleBackColor = true;
            this.button_update_role.Click += new System.EventHandler(this.button_update_role_Click);
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Location = new System.Drawing.Point(233, 133);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(202, 36);
            this.textBox_NewPassword.TabIndex = 5;
            // 
            // textBox_rolename_update
            // 
            this.textBox_rolename_update.Location = new System.Drawing.Point(233, 70);
            this.textBox_rolename_update.Name = "textBox_rolename_update";
            this.textBox_rolename_update.Size = new System.Drawing.Size(202, 36);
            this.textBox_rolename_update.TabIndex = 4;
            // 
            // handleuser_pass
            // 
            this.handleuser_pass.AutoSize = true;
            this.handleuser_pass.Location = new System.Drawing.Point(22, 141);
            this.handleuser_pass.Name = "handleuser_pass";
            this.handleuser_pass.Size = new System.Drawing.Size(165, 28);
            this.handleuser_pass.TabIndex = 2;
            this.handleuser_pass.Text = "New Password";
            // 
            // handleuser_username
            // 
            this.handleuser_username.AutoSize = true;
            this.handleuser_username.Location = new System.Drawing.Point(22, 73);
            this.handleuser_username.Name = "handleuser_username";
            this.handleuser_username.Size = new System.Drawing.Size(70, 28);
            this.handleuser_username.TabIndex = 1;
            this.handleuser_username.Text = "ROLE";
            // 
            // label_handleUser
            // 
            this.label_handleUser.AutoSize = true;
            this.label_handleUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_handleUser.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_handleUser.Location = new System.Drawing.Point(227, 12);
            this.label_handleUser.Name = "label_handleUser";
            this.label_handleUser.Size = new System.Drawing.Size(194, 33);
            this.label_handleUser.TabIndex = 0;
            this.label_handleUser.Text = "UPDATE ROLE";
            // 
            // UpdateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 412);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateRole";
            this.Text = "UpdateRole";
            this.Load += new System.EventHandler(this.UpdateRole_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_notice_updaterole;
        private System.Windows.Forms.Button button_update_role;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.TextBox textBox_rolename_update;
        private System.Windows.Forms.Label handleuser_pass;
        private System.Windows.Forms.Label handleuser_username;
        private System.Windows.Forms.Label label_handleUser;
        private System.Windows.Forms.Label label2;
    }
}