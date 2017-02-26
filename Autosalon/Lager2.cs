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
    public partial class Lager2 : Form
    {
        public Lager2()
        {
            InitializeComponent();
        }

        //overloadan konstruktor sa argumentom tipa string auta
        public Lager2(string linijaArg)
        {
            InitializeComponent();
            string[] linija;
            linija = linijaArg.Split('|');

            Automobil auto = new Automobil(linija[0], linija[1], linija[2], linija[3], linija[4], linija[5], linija[6], linija[7], linija[8], linija[9]);
            textBox1.Text = auto.Model;
            textBox2.Text = auto.Motor;
            textBox3.Text = auto.Sasija;
            textBox4.Text = auto.Cijena;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
