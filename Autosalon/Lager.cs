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
    public partial class Lager : Form
    {
        public Lager()
        {
            //dezignirani konstruktor
            InitializeComponent();
            LagerLoad.LoadLists(this);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            LagerLoad.ListClear();
            Form fMain = new Main();
            fMain.Show();
            fMain.Location = this.Location;
            this.Hide();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)//otkazi nar.
        {
            //ako nije oznacen
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Greska! Automobil nije oznacen/ lista prazna");
                return;
            }
            //ako lista prazna
            else if(listBox1.Items.Count==0)
            {
                MessageBox.Show("Lista prazna!");
                return;
            }
            LagerLoad.RemoveSelectedNaruceni(this);
            LagerLoad.LoadLists(this);
        }

        private void button6_Click(object sender, EventArgs e)//premjesti iz nar. u lag.
        {
            //ako nije oznacen
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Greska! Automobil nije oznacen/ lista prazna");
                return;
            }

            LagerLoad.AddToLager(this, LagerLoad.RemoveSelectedNaruceni(this));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ako nije oznacen
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Greska! Automobil nije oznacen/ lista prazna");
                return;
            }

            
            //pozivanje forme prodano!
            Form fLager2 = new Lager2(LagerLoad.SellSelectedLager(this));
            fLager2.Show();
            fLager2.Location = this.Location;
            
            LagerLoad.LoadLists(this);
        }
    }
}
