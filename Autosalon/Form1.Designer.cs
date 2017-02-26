namespace Autosalon
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBuser = new System.Windows.Forms.TextBox();
            this.tBpass = new System.Windows.Forms.TextBox();
            this.buLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // tBuser
            // 
            this.tBuser.Location = new System.Drawing.Point(114, 190);
            this.tBuser.MaxLength = 10;
            this.tBuser.Name = "tBuser";
            this.tBuser.Size = new System.Drawing.Size(138, 20);
            this.tBuser.TabIndex = 2;
            // 
            // tBpass
            // 
            this.tBpass.Location = new System.Drawing.Point(114, 220);
            this.tBpass.MaxLength = 6;
            this.tBpass.Name = "tBpass";
            this.tBpass.Size = new System.Drawing.Size(138, 20);
            this.tBpass.TabIndex = 3;
            this.tBpass.UseSystemPasswordChar = true;
            // 
            // buLogin
            // 
            this.buLogin.Location = new System.Drawing.Point(114, 263);
            this.buLogin.Name = "buLogin";
            this.buLogin.Size = new System.Drawing.Size(75, 23);
            this.buLogin.TabIndex = 4;
            this.buLogin.Text = "Login";
            this.buLogin.UseVisualStyleBackColor = true;
            this.buLogin.Click += new System.EventHandler(this.buLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 346);
            this.Controls.Add(this.buLogin);
            this.Controls.Add(this.tBpass);
            this.Controls.Add(this.tBuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Autosalon - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBuser;
        private System.Windows.Forms.TextBox tBpass;
        private System.Windows.Forms.Button buLogin;
    }
}

