
namespace ATBM_HTTT
{
    partial class CreateUser
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
            this.label_handleUser = new System.Windows.Forms.Label();
            this.handleuser_username = new System.Windows.Forms.Label();
            this.handleuser_pass = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Create_user = new System.Windows.Forms.Button();
            this.status_mess_createUSER = new System.Windows.Forms.Label();
            this.label_invalidUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_handleUser
            // 
            this.label_handleUser.AutoSize = true;
            this.label_handleUser.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_handleUser.Location = new System.Drawing.Point(214, 24);
            this.label_handleUser.Name = "label_handleUser";
            this.label_handleUser.Size = new System.Drawing.Size(190, 33);
            this.label_handleUser.TabIndex = 0;
            this.label_handleUser.Text = "CREATE USER";
            // 
            // handleuser_username
            // 
            this.handleuser_username.AutoSize = true;
            this.handleuser_username.Location = new System.Drawing.Point(34, 83);
            this.handleuser_username.Name = "handleuser_username";
            this.handleuser_username.Size = new System.Drawing.Size(117, 28);
            this.handleuser_username.TabIndex = 1;
            this.handleuser_username.Text = "Username";
            // 
            // handleuser_pass
            // 
            this.handleuser_pass.AutoSize = true;
            this.handleuser_pass.Location = new System.Drawing.Point(34, 159);
            this.handleuser_pass.Name = "handleuser_pass";
            this.handleuser_pass.Size = new System.Drawing.Size(113, 28);
            this.handleuser_pass.TabIndex = 2;
            this.handleuser_pass.Text = "Password";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(202, 83);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(202, 36);
            this.textBox_Username.TabIndex = 4;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(202, 151);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(202, 36);
            this.textBox_Password.TabIndex = 5;
            // 
            // button_Create_user
            // 
            this.button_Create_user.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Create_user.Location = new System.Drawing.Point(202, 227);
            this.button_Create_user.Name = "button_Create_user";
            this.button_Create_user.Size = new System.Drawing.Size(155, 51);
            this.button_Create_user.TabIndex = 6;
            this.button_Create_user.Text = "Create";
            this.button_Create_user.UseVisualStyleBackColor = true;
            this.button_Create_user.Click += new System.EventHandler(this.button_Create_user_Click);
            // 
            // status_mess_createUSER
            // 
            this.status_mess_createUSER.AutoSize = true;
            this.status_mess_createUSER.Location = new System.Drawing.Point(34, 218);
            this.status_mess_createUSER.Name = "status_mess_createUSER";
            this.status_mess_createUSER.Size = new System.Drawing.Size(0, 28);
            this.status_mess_createUSER.TabIndex = 7;
            // 
            // label_invalidUsername
            // 
            this.label_invalidUsername.AutoSize = true;
            this.label_invalidUsername.Location = new System.Drawing.Point(40, 218);
            this.label_invalidUsername.Name = "label_invalidUsername";
            this.label_invalidUsername.Size = new System.Drawing.Size(0, 28);
            this.label_invalidUsername.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_invalidUsername);
            this.panel1.Controls.Add(this.status_mess_createUSER);
            this.panel1.Controls.Add(this.button_Create_user);
            this.panel1.Controls.Add(this.textBox_Password);
            this.panel1.Controls.Add(this.textBox_Username);
            this.panel1.Controls.Add(this.handleuser_pass);
            this.panel1.Controls.Add(this.handleuser_username);
            this.panel1.Controls.Add(this.label_handleUser);
            this.panel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(36, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 386);
            this.panel1.TabIndex = 0;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 424);
            this.Controls.Add(this.panel1);
            this.Name = "CreateUser";
            this.Text = "Handle_USERS_options";
            this.Load += new System.EventHandler(this.Handle_USERS_options_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_handleUser;
        private System.Windows.Forms.Label handleuser_username;
        private System.Windows.Forms.Label handleuser_pass;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Create_user;
        private System.Windows.Forms.Label status_mess_createUSER;
        private System.Windows.Forms.Label label_invalidUsername;
        private System.Windows.Forms.Panel panel1;
    }
}