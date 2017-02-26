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
    public partial class Nar2: Form
    {
        public Nar2()
        {
            InitializeComponent();
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string _model;
        //lista narucenih automobila - nije potrebna
        //List<Automobil> Automobili = new List<Automobil>();

        //konstruktor s argumentom izabranog modela i patha za sliku:
        public Nar2(string model, string imagePath)
        {
            InitializeComponent();

            _model=model;

            tBmodel.Text = model;
            pBmodel.Load(imagePath);

            //Loadanje elemenata comboboxa forme Nar2
            Nar2Load.LoadElements(this, model);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fNar2 = new Nar1();
            ActiveForm.Hide();
            fNar2.Show();
            fNar2.Location = this.Location;
            //this.Hide();
            //this.Close();
        }

        private void cBboja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nar2Load.DisplayColour(this, _model);
            tBcijena.Text = Nar2Load.Cijena(_model, cBoprema.Text, cBmotor.Text, cBprijenos.Text, cBboja.Text, cBkotaci.Text).ToString() + ",00 kn";
            tBsasija.Text = Nar2Load.Sasija(_model,  cBmotor.Text, cBprijenos.Text, cBboja.Text);
            tBsnaga.Text = Nar2Load.SnagaPotrosnja(_model, cBmotor.Text)[0] + "KS";
            tBpotrosnja.Text = Nar2Load.SnagaPotrosnja(_model, cBmotor.Text)[1] + "L/100km";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //obaviti provjeru ukoliko nisu svi comboboxovi ispunjeni -> Nema narudzbe!
            //CheckIfAllcB vraca true ukoliko svi comboboxovi sadrzavaju neki string
            if (Nar2Load.CheckIfAllcB(this) == true)
            {
                tBcijena.Text = Nar2Load.Cijena(_model, cBoprema.Text, cBmotor.Text, cBprijenos.Text, cBboja.Text, cBkotaci.Text).ToString() + ",00 kn";
                //zadnjih 5 znamenki broja sasije
                int br = RandomNumber(10000, 99999);
                tBsasija.Text = tBsasija.Text + br.ToString();

                //disable-a comboboxove, botun Prethodno i botun Naruci, 
                Nar2Load.DisablecBEnableDalje(this);

                ///dodati Automobil new au
                ///dodati au u listu <Automobil> 
                /// ako je moguce !!appendat!! ih u .txt uz mogucnost da neki vec postoje u tom .txtu ili da se prvo loadaju iz drugoga u Lageru

                Automobil auto = new Automobil(_model, cBoprema.Text, cBmotor.Text, cBprijenos.Text, cBboja.Text, cBkotaci.Text, tBsnaga.Text, tBpotrosnja.Text, tBsasija.Text, tBcijena.Text);
                //Automobili.Add(auto);
                Nar2Load.AddNewToTxt(auto);

                MessageBox.Show("Narudzba pohranjena! Za pregled svih narudzbi, idite u Main menu > Lager!");
                MessageBox.Show("Za povratak u Main menu, pritisnite tipku Dalje.");
            }
            else
            {
                MessageBox.Show("Niste odabrali sva polja!");
            }
            //fali argumenata
            //Automobil auto = new Automobil(_model, cBoprema.Text, cBmotor.Text, cBprijenos.Text, cBboja.Text, cBkotaci.Text);
        }

        private void cBmotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBcijena.Text = Nar2Load.Cijena(_model, cBoprema.Text, cBmotor.Text, cBprijenos.Text, cBboja.Text, cBkotaci.Text).ToString() + ",00 kn";
            tBsasija.Text = Nar2Load.Sasija(_model, cBmotor.Text, cBprijenos.Text, cBboja.Text);
            tBsnaga.Text = Nar2Load.SnagaPotrosnja(_model, cBmotor.Text)[0] + "KS";
            tBpotrosnja.Text = Nar2Load.SnagaPotrosnja(_model, cBmotor.Text)[1] + "L/100km";
        }

        private void cBprijenos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBcijena.Text = Nar2Load.Cijena(_model, cBoprema.Text, cBmotor.Text, cBprijenos.Text, cBboja.Text, cBkotaci.Text).ToString() + ",00 kn";
            tBsasija.Text = Nar2Load.Sasija(_model, cBmotor.Text, cBprijenos.Text, cBboja.Text);
            tBsnaga.Text = Nar2Load.SnagaPotrosnja(_model, cBmotor.Text)[0] + "KS";
            tBpotrosnja.Text = Nar2Load.SnagaPotrosnja(_model, cBmotor.Text)[1] + "L/100km";
        }

        private void cBoprema_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBcijena.Text = Nar2Load.Cijena(_model, cBoprema.Text, cBmotor.Text, cBprijenos.Text, cBboja.Text, cBkotaci.Text).ToString() + ",00 kn";
            tBsasija.Text = Nar2Load.Sasija(_model, cBmotor.Text, cBprijenos.Text, cBboja.Text);
            tBsnaga.Text = Nar2Load.SnagaPotrosnja(_model, cBmotor.Text)[0] + "KS";
            tBpotrosnja.Text = Nar2Load.SnagaPotrosnja(_model, cBmotor.Text)[1] + "L/100km";
        }

        private void cBkotaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nar2Load.DisplayKotaci(this, _model);

            tBcijena.Text = Nar2Load.Cijena(_model, cBoprema.Text, cBmotor.Text, cBprijenos.Text, cBboja.Text, cBkotaci.Text).ToString() + ",00 kn";
            tBsasija.Text = Nar2Load.Sasija(_model, cBmotor.Text, cBprijenos.Text, cBboja.Text);
            tBsnaga.Text = Nar2Load.SnagaPotrosnja(_model, cBmotor.Text)[0] + "KS";
            tBpotrosnja.Text = Nar2Load.SnagaPotrosnja(_model, cBmotor.Text)[1] + "L/100km";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //treba podesiti property Visible i Enabled (oboje false u startu) 
            //botun Dalje
            Form fMain = new Main();
            fMain.Show();
            fMain.Location = this.Location;
            this.Hide();
            this.Dispose();
        }
    }
}
