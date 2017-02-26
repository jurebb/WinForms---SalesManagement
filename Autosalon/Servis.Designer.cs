namespace Autosalon
{
    partial class Servis
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBsas = new System.Windows.Forms.RadioButton();
            this.rBman = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBgar = new System.Windows.Forms.ComboBox();
            this.cBtip = new System.Windows.Forms.ComboBox();
            this.cBmod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btODA = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btOTK = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBsas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBcij = new System.Windows.Forms.TextBox();
            this.btPRIHV = new System.Windows.Forms.Button();
            this.btNOVI = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(345, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Natrag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBsas);
            this.groupBox1.Controls.Add(this.rBman);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos";
            // 
            // rBsas
            // 
            this.rBsas.AutoSize = true;
            this.rBsas.Location = new System.Drawing.Point(14, 42);
            this.rBsas.Name = "rBsas";
            this.rBsas.Size = new System.Drawing.Size(93, 17);
            this.rBsas.TabIndex = 1;
            this.rBsas.TabStop = true;
            this.rBsas.Text = "Po broju šasije";
            this.rBsas.UseVisualStyleBackColor = true;
            this.rBsas.CheckedChanged += new System.EventHandler(this.rBsas_CheckedChanged);
            // 
            // rBman
            // 
            this.rBman.AutoSize = true;
            this.rBman.Location = new System.Drawing.Point(14, 19);
            this.rBman.Name = "rBman";
            this.rBman.Size = new System.Drawing.Size(72, 17);
            this.rBman.TabIndex = 1;
            this.rBman.TabStop = true;
            this.rBman.Text = "Manualno";
            this.rBman.UseVisualStyleBackColor = true;
            this.rBman.CheckedChanged += new System.EventHandler(this.rBman_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBsas);
            this.groupBox2.Controls.Add(this.cBgar);
            this.groupBox2.Controls.Add(this.cBtip);
            this.groupBox2.Controls.Add(this.cBmod);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btODA);
            this.groupBox2.Location = new System.Drawing.Point(152, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unos";
            // 
            // cBgar
            // 
            this.cBgar.FormattingEnabled = true;
            this.cBgar.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cBgar.Location = new System.Drawing.Point(76, 38);
            this.cBgar.Name = "cBgar";
            this.cBgar.Size = new System.Drawing.Size(60, 21);
            this.cBgar.TabIndex = 9;
            // 
            // cBtip
            // 
            this.cBtip.FormattingEnabled = true;
            this.cBtip.Items.AddRange(new object[] {
            "Benzin",
            "Diesel"});
            this.cBtip.Location = new System.Drawing.Point(193, 16);
            this.cBtip.Name = "cBtip";
            this.cBtip.Size = new System.Drawing.Size(90, 21);
            this.cBtip.TabIndex = 8;
            // 
            // cBmod
            // 
            this.cBmod.FormattingEnabled = true;
            this.cBmod.Items.AddRange(new object[] {
            "A1",
            "A3",
            "A4",
            "A8",
            "Q7"});
            this.cBmod.Location = new System.Drawing.Point(60, 15);
            this.cBmod.Name = "cBmod";
            this.cBmod.Size = new System.Drawing.Size(60, 21);
            this.cBmod.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Garancija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tip Motora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model:";
            // 
            // btODA
            // 
            this.btODA.Location = new System.Drawing.Point(169, 36);
            this.btODA.Name = "btODA";
            this.btODA.Size = new System.Drawing.Size(137, 23);
            this.btODA.TabIndex = 2;
            this.btODA.Text = "Odaberi Servis/Usluge";
            this.btODA.UseVisualStyleBackColor = true;
            this.btODA.Click += new System.EventHandler(this.btODA_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.checkBox9);
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 97);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servis/Usluge";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "(samo benzinci)";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(269, 65);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(201, 17);
            this.checkBox9.TabIndex = 3;
            this.checkBox9.Text = "Gradski paket (parkirni senzori i GPS)";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(269, 42);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(224, 17);
            this.checkBox8.TabIndex = 3;
            this.checkBox8.Text = "Sportski paket (sportski branici i deflektori)";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(269, 19);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(220, 17);
            this.checkBox7.TabIndex = 3;
            this.checkBox7.Text = "Zimski paket (zimske gume, lanci, antifriz)";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(140, 65);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(109, 17);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.Text = "Zamjena svjećica";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(140, 42);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(89, 17);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Promjena ulja";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(140, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(106, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Zamjena svjetiljki";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(14, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Kompletan servis";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Temeljito čišćenje";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Pregled automobila";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btOTK);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(494, 107);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista automobila za Servis/Usluge";
            // 
            // btOTK
            // 
            this.btOTK.Location = new System.Drawing.Point(434, 47);
            this.btOTK.Name = "btOTK";
            this.btOTK.Size = new System.Drawing.Size(60, 54);
            this.btOTK.TabIndex = 2;
            this.btOTK.Text = "Otkaži odabrani";
            this.btOTK.UseVisualStyleBackColor = true;
            this.btOTK.Click += new System.EventHandler(this.btOTK_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 82);
            this.listBox1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Broj Šasije: (17 znamenki)";
            // 
            // tBsas
            // 
            this.tBsas.Location = new System.Drawing.Point(149, 12);
            this.tBsas.Name = "tBsas";
            this.tBsas.Size = new System.Drawing.Size(157, 20);
            this.tBsas.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cijena servisa/usluge (ovisi o garanciji):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(23, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "(70% popusta uz garanciju)";
            // 
            // tBcij
            // 
            this.tBcij.Location = new System.Drawing.Point(221, 227);
            this.tBcij.Name = "tBcij";
            this.tBcij.Size = new System.Drawing.Size(100, 20);
            this.tBcij.TabIndex = 6;
            // 
            // btPRIHV
            // 
            this.btPRIHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPRIHV.Location = new System.Drawing.Point(339, 243);
            this.btPRIHV.Name = "btPRIHV";
            this.btPRIHV.Size = new System.Drawing.Size(119, 30);
            this.btPRIHV.TabIndex = 7;
            this.btPRIHV.Text = "Prihvati";
            this.btPRIHV.UseVisualStyleBackColor = true;
            this.btPRIHV.Click += new System.EventHandler(this.btPRIHV_Click);
            // 
            // btNOVI
            // 
            this.btNOVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btNOVI.Location = new System.Drawing.Point(339, 233);
            this.btNOVI.Name = "btNOVI";
            this.btNOVI.Size = new System.Drawing.Size(119, 30);
            this.btNOVI.TabIndex = 8;
            this.btNOVI.Text = "Novi unos";
            this.btNOVI.UseVisualStyleBackColor = true;
            this.btNOVI.Click += new System.EventHandler(this.btNOVI_Click);
            // 
            // Servis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 441);
            this.Controls.Add(this.btNOVI);
            this.Controls.Add(this.btPRIHV);
            this.Controls.Add(this.tBcij);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Servis";
            this.Text = "Servis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.RadioButton rBsas;
        protected internal System.Windows.Forms.RadioButton rBman;
        protected internal System.Windows.Forms.TextBox tBsas;
        protected internal System.Windows.Forms.ComboBox cBgar;
        protected internal System.Windows.Forms.ComboBox cBtip;
        protected internal System.Windows.Forms.ComboBox cBmod;
        protected internal System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Button btODA;
        protected internal System.Windows.Forms.CheckBox checkBox9;
        protected internal System.Windows.Forms.CheckBox checkBox8;
        protected internal System.Windows.Forms.CheckBox checkBox7;
        protected internal System.Windows.Forms.CheckBox checkBox6;
        protected internal System.Windows.Forms.CheckBox checkBox5;
        protected internal System.Windows.Forms.CheckBox checkBox4;
        protected internal System.Windows.Forms.CheckBox checkBox3;
        protected internal System.Windows.Forms.CheckBox checkBox2;
        protected internal System.Windows.Forms.CheckBox checkBox1;
        protected internal System.Windows.Forms.Button btOTK;
        protected internal System.Windows.Forms.ListBox listBox1;
        protected internal System.Windows.Forms.TextBox tBcij;
        protected internal System.Windows.Forms.Button btPRIHV;
        protected internal System.Windows.Forms.Button btNOVI;
        private System.Windows.Forms.Label label7;
    }
}