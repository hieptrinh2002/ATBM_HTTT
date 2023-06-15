
namespace ATBM_HTTT
{
    partial class UpdateUser
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
            this.label_notice = new System.Windows.Forms.Label();
            this.button_update_user = new System.Windows.Forms.Button();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.textBox_Username_update = new System.Windows.Forms.TextBox();
            this.handleuser_pass = new System.Windows.Forms.Label();
            this.handleuser_username = new System.Windows.Forms.Label();
            this.label_handleUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_notice);
            this.panel1.Controls.Add(this.button_update_user);
            this.panel1.Controls.Add(this.textBox_NewPassword);
            this.panel1.Controls.Add(this.textBox_Username_update);
            this.panel1.Controls.Add(this.handleuser_pass);
            this.panel1.Controls.Add(this.handleuser_username);
            this.panel1.Controls.Add(this.label_handleUser);
            this.panel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(34, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 421);
            this.panel1.TabIndex = 1;
            // 
            // label_notice
            // 
            this.label_notice.AutoSize = true;
            this.label_notice.Location = new System.Drawing.Point(79, 232);
            this.label_notice.Name = "label_notice";
            this.label_notice.Size = new System.Drawing.Size(27, 28);
            this.label_notice.TabIndex = 7;
            this.label_notice.Text = "   ";
            // 
            // button_update_user
            // 
            this.button_update_user.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update_user.Location = new System.Drawing.Point(259, 257);
            this.button_update_user.Name = "button_update_user";
            this.button_update_user.Size = new System.Drawing.Size(160, 51);
            this.button_update_user.TabIndex = 6;
            this.button_update_user.Text = "Update";
            this.button_update_user.UseVisualStyleBackColor = true;
            this.button_update_user.Click += new System.EventHandler(this.button_update_user_Click);
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Location = new System.Drawing.Point(249, 171);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(202, 36);
            this.textBox_NewPassword.TabIndex = 5;
            // 
            // textBox_Username_update
            // 
            this.textBox_Username_update.Location = new System.Drawing.Point(249, 106);
            this.textBox_Username_update.Name = "textBox_Username_update";
            this.textBox_Username_update.Size = new System.Drawing.Size(202, 36);
            this.textBox_Username_update.TabIndex = 4;
            // 
            // handleuser_pass
            // 
            this.handleuser_pass.AutoSize = true;
            this.handleuser_pass.Location = new System.Drawing.Point(48, 179);
            this.handleuser_pass.Name = "handleuser_pass";
            this.handleuser_pass.Size = new System.Drawing.Size(165, 28);
            this.handleuser_pass.TabIndex = 2;
            this.handleuser_pass.Text = "New Password";
            // 
            // handleuser_username
            // 
            this.handleuser_username.AutoSize = true;
            this.handleuser_username.Location = new System.Drawing.Point(48, 106);
            this.handleuser_username.Name = "handleuser_username";
            this.handleuser_username.Size = new System.Drawing.Size(117, 28);
            this.handleuser_username.TabIndex = 1;
            this.handleuser_username.Text = "Username";
            // 
            // label_handleUser
            // 
            this.label_handleUser.AutoSize = true;
            this.label_handleUser.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_handleUser.Location = new System.Drawing.Point(229, 27);
            this.label_handleUser.Name = "label_handleUser";
            this.label_handleUser.Size = new System.Drawing.Size(194, 33);
            this.label_handleUser.TabIndex = 0;
            this.label_handleUser.Text = "UPDATE USER";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 452);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_update_user;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.TextBox textBox_Username_update;
        private System.Windows.Forms.Label handleuser_pass;
        private System.Windows.Forms.Label handleuser_username;
        private System.Windows.Forms.Label label_handleUser;
        private System.Windows.Forms.Label label_notice;
    }
}