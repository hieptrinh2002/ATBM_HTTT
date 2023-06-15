
namespace ATBM_HTTT
{
    partial class CreateRole
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
            this.label_createRole = new System.Windows.Forms.Label();
            this.label_invalid_Role = new System.Windows.Forms.Label();
            this.button_createRole = new System.Windows.Forms.Button();
            this.textBox_roleName = new System.Windows.Forms.TextBox();
            this.label_RoleName = new System.Windows.Forms.Label();
            this.textBox_pass_role = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_createRole
            // 
            this.label_createRole.AutoSize = true;
            this.label_createRole.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_createRole.Location = new System.Drawing.Point(169, 42);
            this.label_createRole.Name = "label_createRole";
            this.label_createRole.Size = new System.Drawing.Size(190, 33);
            this.label_createRole.TabIndex = 14;
            this.label_createRole.Text = "CREATE ROLE";
            // 
            // label_invalid_Role
            // 
            this.label_invalid_Role.AutoSize = true;
            this.label_invalid_Role.Location = new System.Drawing.Point(74, 237);
            this.label_invalid_Role.Name = "label_invalid_Role";
            this.label_invalid_Role.Size = new System.Drawing.Size(21, 20);
            this.label_invalid_Role.TabIndex = 13;
            this.label_invalid_Role.Text = "   ";
            // 
            // button_createRole
            // 
            this.button_createRole.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_createRole.Location = new System.Drawing.Point(173, 296);
            this.button_createRole.Name = "button_createRole";
            this.button_createRole.Size = new System.Drawing.Size(125, 53);
            this.button_createRole.TabIndex = 12;
            this.button_createRole.Text = "Create";
            this.button_createRole.UseVisualStyleBackColor = true;
            this.button_createRole.Click += new System.EventHandler(this.button_createRole_Click);
            // 
            // textBox_roleName
            // 
            this.textBox_roleName.Location = new System.Drawing.Point(173, 100);
            this.textBox_roleName.Name = "textBox_roleName";
            this.textBox_roleName.Size = new System.Drawing.Size(245, 26);
            this.textBox_roleName.TabIndex = 11;
            // 
            // label_RoleName
            // 
            this.label_RoleName.AutoSize = true;
            this.label_RoleName.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RoleName.Location = new System.Drawing.Point(25, 100);
            this.label_RoleName.Name = "label_RoleName";
            this.label_RoleName.Size = new System.Drawing.Size(120, 23);
            this.label_RoleName.TabIndex = 10;
            this.label_RoleName.Text = "ROLE NAME ";
            // 
            // textBox_pass_role
            // 
            this.textBox_pass_role.Location = new System.Drawing.Point(173, 158);
            this.textBox_pass_role.Name = "textBox_pass_role";
            this.textBox_pass_role.Size = new System.Drawing.Size(245, 26);
            this.textBox_pass_role.TabIndex = 16;
            this.textBox_pass_role.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "PASSWORD  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(169, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "**password có thể  trống";
            // 
            // CreateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_pass_role);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_createRole);
            this.Controls.Add(this.label_invalid_Role);
            this.Controls.Add(this.button_createRole);
            this.Controls.Add(this.textBox_roleName);
            this.Controls.Add(this.label_RoleName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateRole";
            this.Text = "CreateRole";
            this.Load += new System.EventHandler(this.CreateRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_createRole;
        private System.Windows.Forms.Label label_invalid_Role;
        private System.Windows.Forms.Button button_createRole;
        private System.Windows.Forms.TextBox textBox_roleName;
        private System.Windows.Forms.Label label_RoleName;
        private System.Windows.Forms.TextBox textBox_pass_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}