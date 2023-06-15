
namespace ATBM_HTTT
{
    partial class DeleteRole
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
            this.button_deleteRole = new System.Windows.Forms.Button();
            this.textBox_RoleName = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_notice_deleteRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_handleUser
            // 
            this.label_handleUser.AutoSize = true;
            this.label_handleUser.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_handleUser.Location = new System.Drawing.Point(129, 39);
            this.label_handleUser.Name = "label_handleUser";
            this.label_handleUser.Size = new System.Drawing.Size(190, 33);
            this.label_handleUser.TabIndex = 9;
            this.label_handleUser.Text = "DELETE ROLE";
            // 
            // button_deleteRole
            // 
            this.button_deleteRole.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteRole.Location = new System.Drawing.Point(168, 250);
            this.button_deleteRole.Name = "button_deleteRole";
            this.button_deleteRole.Size = new System.Drawing.Size(137, 46);
            this.button_deleteRole.TabIndex = 7;
            this.button_deleteRole.Text = "Delete";
            this.button_deleteRole.UseVisualStyleBackColor = true;
            this.button_deleteRole.Click += new System.EventHandler(this.button_deleteRole_Click);
            // 
            // textBox_RoleName
            // 
            this.textBox_RoleName.Location = new System.Drawing.Point(168, 112);
            this.textBox_RoleName.Name = "textBox_RoleName";
            this.textBox_RoleName.Size = new System.Drawing.Size(152, 26);
            this.textBox_RoleName.TabIndex = 6;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(23, 115);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(112, 23);
            this.label_Username.TabIndex = 5;
            this.label_Username.Text = "ROLENAME";
            // 
            // label_notice_deleteRole
            // 
            this.label_notice_deleteRole.AutoSize = true;
            this.label_notice_deleteRole.Location = new System.Drawing.Point(58, 173);
            this.label_notice_deleteRole.Name = "label_notice_deleteRole";
            this.label_notice_deleteRole.Size = new System.Drawing.Size(17, 20);
            this.label_notice_deleteRole.TabIndex = 10;
            this.label_notice_deleteRole.Text = "  ";
            // 
            // DeleteRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 326);
            this.Controls.Add(this.label_notice_deleteRole);
            this.Controls.Add(this.label_handleUser);
            this.Controls.Add(this.button_deleteRole);
            this.Controls.Add(this.textBox_RoleName);
            this.Controls.Add(this.label_Username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeleteRole";
            this.Text = "DeleteRole";
            this.Load += new System.EventHandler(this.DeleteRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_handleUser;
        private System.Windows.Forms.Button button_deleteRole;
        private System.Windows.Forms.TextBox textBox_RoleName;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_notice_deleteRole;
    }
}