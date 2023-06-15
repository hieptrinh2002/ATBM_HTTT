
namespace ATBM_HTTT
{
    partial class DeleteUser
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
            this.Username = new System.Windows.Forms.Label();
            this.textBox_username_deleteUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_handleUser = new System.Windows.Forms.Label();
            this.label_invalid_username_deleteform = new System.Windows.Forms.Label();
            this.checkBox_cascade_dropUser = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(24, 106);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(135, 26);
            this.Username.TabIndex = 0;
            this.Username.Text = "USERNAME :";
            // 
            // textBox_username_deleteUser
            // 
            this.textBox_username_deleteUser.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username_deleteUser.Location = new System.Drawing.Point(183, 99);
            this.textBox_username_deleteUser.Name = "textBox_username_deleteUser";
            this.textBox_username_deleteUser.Size = new System.Drawing.Size(152, 33);
            this.textBox_username_deleteUser.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_handleUser
            // 
            this.label_handleUser.AutoSize = true;
            this.label_handleUser.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_handleUser.Location = new System.Drawing.Point(177, 31);
            this.label_handleUser.Name = "label_handleUser";
            this.label_handleUser.Size = new System.Drawing.Size(190, 33);
            this.label_handleUser.TabIndex = 4;
            this.label_handleUser.Text = "DELETE USER";
            // 
            // label_invalid_username_deleteform
            // 
            this.label_invalid_username_deleteform.AutoSize = true;
            this.label_invalid_username_deleteform.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_invalid_username_deleteform.Location = new System.Drawing.Point(58, 158);
            this.label_invalid_username_deleteform.Name = "label_invalid_username_deleteform";
            this.label_invalid_username_deleteform.Size = new System.Drawing.Size(0, 23);
            this.label_invalid_username_deleteform.TabIndex = 3;
            // 
            // checkBox_cascade_dropUser
            // 
            this.checkBox_cascade_dropUser.AutoSize = true;
            this.checkBox_cascade_dropUser.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cascade_dropUser.Location = new System.Drawing.Point(353, 102);
            this.checkBox_cascade_dropUser.Name = "checkBox_cascade_dropUser";
            this.checkBox_cascade_dropUser.Size = new System.Drawing.Size(129, 30);
            this.checkBox_cascade_dropUser.TabIndex = 5;
            this.checkBox_cascade_dropUser.Text = "CASCADE";
            this.checkBox_cascade_dropUser.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 262);
            this.Controls.Add(this.checkBox_cascade_dropUser);
            this.Controls.Add(this.label_handleUser);
            this.Controls.Add(this.label_invalid_username_deleteform);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_username_deleteUser);
            this.Controls.Add(this.Username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textBox_username_deleteUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_handleUser;
        private System.Windows.Forms.Label label_invalid_username_deleteform;
        private System.Windows.Forms.CheckBox checkBox_cascade_dropUser;
    }
}