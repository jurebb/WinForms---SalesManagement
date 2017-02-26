namespace Autosalon
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOrd = new System.Windows.Forms.Button();
            this.btnLag = new System.Windows.Forms.Button();
            this.btnServ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autosalon x d.d.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 102);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnOrd
            // 
            this.btnOrd.Location = new System.Drawing.Point(377, 82);
            this.btnOrd.Name = "btnOrd";
            this.btnOrd.Size = new System.Drawing.Size(96, 41);
            this.btnOrd.TabIndex = 2;
            this.btnOrd.Text = "Narudzba novog modela";
            this.btnOrd.UseVisualStyleBackColor = true;
            this.btnOrd.Click += new System.EventHandler(this.btnOrd_Click);
            // 
            // btnLag
            // 
            this.btnLag.Location = new System.Drawing.Point(377, 143);
            this.btnLag.Name = "btnLag";
            this.btnLag.Size = new System.Drawing.Size(96, 41);
            this.btnLag.TabIndex = 2;
            this.btnLag.Text = "Narudzbe i Lager";
            this.btnLag.UseVisualStyleBackColor = true;
            this.btnLag.Click += new System.EventHandler(this.btnLag_Click);
            // 
            // btnServ
            // 
            this.btnServ.Location = new System.Drawing.Point(377, 204);
            this.btnServ.Name = "btnServ";
            this.btnServ.Size = new System.Drawing.Size(96, 41);
            this.btnServ.TabIndex = 2;
            this.btnServ.Text = "Servis";
            this.btnServ.UseVisualStyleBackColor = true;
            this.btnServ.Click += new System.EventHandler(this.btnServ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista za servis je posebna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "za svakog usera!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 344);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnServ);
            this.Controls.Add(this.btnLag);
            this.Controls.Add(this.btnOrd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOrd;
        private System.Windows.Forms.Button btnLag;
        private System.Windows.Forms.Button btnServ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}