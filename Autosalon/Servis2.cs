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
    public partial class Servis2 : Form
    {
        public Servis2()
        {
            InitializeComponent();
        }

        //overloadan konstruktor
        public Servis2(string model, bool diesel)
        {

            InitializeComponent();

            textBox1.Text = model;

            if (diesel == true)
                textBox2.Text = "Diesel";

            else
                textBox2.Text = "Benzin";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
