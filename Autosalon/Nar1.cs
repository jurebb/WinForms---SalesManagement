using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosalon
{
    public partial class Nar1 : Form
    {
        public Nar1()
        {
            InitializeComponent();
        }

        //imagepath za formu Nar2
        string path = "";
        //string modela koji saljemo u formu Nar2 kao arg
        string model = "";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox1.Load(@"A1\RADCQ3.png");
                path = @"A1\RADCQ3.png";
                model = "A1";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox1.Load(@"A3\RADC2F.png");
                path = @"A3\RADC2F.png";
                model = "A3";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            { 
                pictureBox1.Load(@"A4\RADC5V.png");
                path = @"A4\RADC5V.png";
                model = "A4";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) 
            {
                pictureBox1.Load(@"A8\RADC4T.png");
                path = @"A8\RADC4T.png";
                model = "A8";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                pictureBox1.Load(@"Q7\BBO6FA.png");
                path = @"Q7\BBO6FA.png";
                model = "Q7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            Form fMain = new Main();
            fMain.Show();
            fMain.Location = this.Location;
            this.Hide();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fNar2 = new Nar2(model, path);
            fNar2.Show();
            fNar2.Location = this.Location;
            this.Hide();
            this.Dispose();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
