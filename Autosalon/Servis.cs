using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Autosalon
{
    public partial class Servis : Form
    {

        public string path = "";
        
        public static string _user;
        public Servis()
        {
            InitializeComponent();
            ServisLoad.Pocetna(this);

            path = _user + "/servis.txt";

            //ako ne postoji taj file
            if (File.Exists(path))
            {
                ServisLoad.AddServisListBox(this, path);

            }

        }
        public Servis(string user)
        {
            InitializeComponent();
            _user = user;
            ServisLoad.Pocetna(this);

            path = _user + "/servis.txt";

            //ako ne postoji taj file
            if (File.Exists(path))
            {
                ServisLoad.AddServisListBox(this, path);

            }
 
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fMain = new Main(_user);
            fMain.Show();
            fMain.Location = this.Location;
            this.Hide();
            this.Dispose();
        }

        private void rBsas_CheckedChanged(object sender, EventArgs e)
        {
            ServisLoad.Checked1(this);
        }

        private void rBman_CheckedChanged(object sender, EventArgs e)
        {
            ServisLoad.Checked1(this);
        }

        public static bool ifDiesel=false;
        public static bool ifGarancija = false;
        public static string _model="";

        private void btODA_Click(object sender, EventArgs e)
        {

            if (rBsas.Checked == true) //ako idemo po sasiji
            {
                

                //provjera
                if (tBsas.TextLength != 17 || cBgar.Text == "")
                {
                    MessageBox.Show("Neispravan unos!");
                    return;
                }

                if (cBgar.Text == "Da") ifGarancija = true;
                else ifGarancija = false;

                ifDiesel=ServisLoad.OdrediTipPoSasiji(this);
                _model = ServisLoad.OdrediModelPoSasiji(this);

                //pozivanje forme prepoznato!
                Form fServis2 = new Servis2(_model,ifDiesel);
                fServis2.Show();
                fServis2.Location = this.Location;

                ServisLoad.Activate1(this,ifDiesel);
            }
            else //ako idemo manualno
            {
                //provjera
                if (cBgar.Text == "" || cBmod.Text == "" || cBtip.Text == "")
                {
                    MessageBox.Show("Neispravan unos!");
                    return;
                }

                if (cBgar.Text == "Da") ifGarancija = true;
                else ifGarancija = false;

                if (cBtip.Text == "Diesel") ifDiesel = true;
                else ifDiesel = false;

                _model = cBmod.Text;

                ServisLoad.Activate2(this, ifDiesel);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tBcij.Text = ServisLoad.ReturnCijena(this, _model, ifGarancija);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tBcij.Text = ServisLoad.ReturnCijena(this, _model, ifGarancija);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            tBcij.Text = ServisLoad.ReturnCijena(this, _model, ifGarancija);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            tBcij.Text = ServisLoad.ReturnCijena(this, _model, ifGarancija);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            tBcij.Text = ServisLoad.ReturnCijena(this, _model, ifGarancija);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            tBcij.Text = ServisLoad.ReturnCijena(this, _model, ifGarancija);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            tBcij.Text = ServisLoad.ReturnCijena(this, _model, ifGarancija);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            tBcij.Text = ServisLoad.ReturnCijena(this, _model, ifGarancija);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            tBcij.Text = ServisLoad.ReturnCijena(this, _model, ifGarancija);
        }

        private void btPRIHV_Click(object sender, EventArgs e)
        {
            //deaktiviranje checkboxova
            ServisLoad.Deactivate1(this);


            //ako ne postoji taj file
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(_user);

            }

            ServisLoad.AddServis(this, path, _model, tBcij.Text);

            btPRIHV.Enabled = false;
            btPRIHV.Visible = false;

            btNOVI.Visible = true;
            btNOVI.Enabled = true;

        }

        private void btNOVI_Click(object sender, EventArgs e)
        {
            ServisLoad.Pocetna(this);
        }

        private void btOTK_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Odaberite auto!");
                return;
            }


            ServisLoad.RemoveFromListbox(this, path);
            listBox1.Items.Clear();
            if (File.Exists(path))
            {
                ServisLoad.AddServisListBox(this, path);

            }
        }
    }
}
