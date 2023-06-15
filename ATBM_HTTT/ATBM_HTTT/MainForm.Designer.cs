
namespace ATBM_HTTT
{
    partial class MainForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_THH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(161, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(561, 192);
            this.button2.TabIndex = 1;
            this.button2.Text = "GRANT/REVOKE PRIVILEGES TO USERS / ROLES\r\n\r\nCHECK PRIVILEGES\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(485, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(393, 204);
            this.button3.TabIndex = 2;
            this.button3.Text = "ROLE / USER  INFORMATION\r\n\r\nCHECK ROLES OF USERS\r\n\r\nPRIVILEGES INFOMATION\r\n\r\nUPDA" +
    "TE PRIVILEGES\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_THH
            // 
            this.button_THH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_THH.Location = new System.Drawing.Point(46, 39);
            this.button_THH.Name = "button_THH";
            this.button_THH.Size = new System.Drawing.Size(362, 204);
            this.button_THH.TabIndex = 0;
            this.button_THH.Text = "CREATE USERS / ROLES\r\n\r\nDROP USERS / ROLES\r\n\r\nUPDATE USERS / ROLES\r\n\r\n";
            this.button_THH.UseVisualStyleBackColor = true;
            this.button_THH.Click += new System.EventHandler(this.button_THH_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 525);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_THH);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_THH;
    }
}