using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autosalon
{
    class ServisLoad : Servis
    {
        //vraca stanje forme na pocetno
        public static int Pocetna(Servis reference)
        {
            reference.rBman.Enabled = true;
            reference.rBman.Visible = true;
            reference.rBsas.Enabled = true;
            reference.rBsas.Visible = true;
            reference.label1.Visible = true;
            reference.label2.Visible = true;
            reference.label3.Visible = true;
            reference.label4.Visible = false;

            reference.cBgar.Enabled = true;
            reference.cBgar.Text = "";
            reference.cBmod.Enabled = true;
            reference.cBmod.Text = "";
            reference.cBtip.Enabled = true;
            reference.cBtip.Text = "";
            reference.tBsas.Text = "";
            reference.tBsas.Visible = false;
            reference.tBsas.Enabled = true;

            reference.btODA.Visible = true;
            reference.btODA.Enabled = true;

            reference.rBman.Checked = true;
            reference.rBsas.Checked = false;

            reference.checkBox1.Enabled = false;
            reference.checkBox1.Checked = false;
            reference.checkBox2.Enabled = false;
            reference.checkBox2.Checked = false;
            reference.checkBox3.Enabled = false;
            reference.checkBox3.Checked = false;
            reference.checkBox4.Enabled = false;
            reference.checkBox4.Checked = false;
            reference.checkBox5.Enabled = false;
            reference.checkBox5.Checked = false;
            reference.checkBox6.Enabled = false;
            reference.checkBox6.Checked = false;
            reference.checkBox7.Enabled = false;
            reference.checkBox7.Checked = false;
            reference.checkBox8.Enabled = false;
            reference.checkBox8.Checked = false;
            reference.checkBox9.Enabled = false;
            reference.checkBox9.Checked = false;

            reference.tBcij.Enabled = false;
            reference.btNOVI.Visible = false;
            reference.btNOVI.Enabled = false;
            reference.btPRIHV.Visible = true;
            reference.btPRIHV.Enabled = false;


            return 0;
        }

        //ako se promjeni checked state prva 2 radio botuna
        public static int Checked1(Servis reference)
        {
            if(reference.rBman.Checked==true)
            {
                reference.label1.Visible = true;
                reference.label2.Visible = true;
                reference.label4.Visible = false;

                reference.cBmod.Visible = true;
                reference.cBtip.Visible = true;
                reference.tBsas.Visible = false;
            }
            else
            {
                reference.label1.Visible = false;
                reference.label2.Visible = false;
                reference.label4.Visible = true;

                reference.cBmod.Visible = false;
                reference.cBtip.Visible = false;
                reference.tBsas.Visible = true;
            }
            
            return 0;
        }

        //ako stisnemo botun odaberi
        public static int Activate2(Servis reference, bool diesel)
        {
            reference.rBman.Enabled = false;
            reference.rBsas.Enabled = false;

            reference.cBgar.Enabled = false;
            reference.cBmod.Enabled = false;
            reference.cBtip.Enabled = false;

            reference.btODA.Enabled = false;

            reference.checkBox1.Enabled = true;
            reference.checkBox2.Enabled = true;
            reference.checkBox3.Enabled = true;
            reference.checkBox4.Enabled = true;
            reference.checkBox5.Enabled = true;
            if (diesel == true)
                reference.checkBox6.Enabled = false;
            else
                reference.checkBox6.Enabled = true;

            reference.checkBox7.Enabled = true;
            reference.checkBox8.Enabled = true;
            reference.checkBox9.Enabled = true;

            reference.btPRIHV.Enabled = true;

            return 0;
        }

        //kad stisnemo btn odaberi, sluc.2
        public static int Activate1(Servis reference, bool diesel)
        {
            reference.rBman.Enabled = false;
            reference.rBsas.Enabled = false;

            reference.cBgar.Enabled = false;
            reference.tBsas.Enabled = false;

            reference.btODA.Enabled = false;

            reference.checkBox1.Enabled = true;
            reference.checkBox2.Enabled = true;
            reference.checkBox3.Enabled = true;
            reference.checkBox4.Enabled = true;
            reference.checkBox5.Enabled = true;
            if (diesel == true)
                reference.checkBox6.Enabled = false;
            else
                reference.checkBox6.Enabled = true;

            reference.checkBox7.Enabled = true;
            reference.checkBox8.Enabled = true;
            reference.checkBox9.Enabled = true;

            reference.btPRIHV.Enabled = true;

            return 0;
        }

        //racunanje cijene checkboxova
        public static string ReturnCijena(Servis reference, string model, bool garancija)
        {
            double cijena = 0;
            double modifier=1;

            if (model == "A1") modifier = 0.6;
            else if (model == "A3") modifier = 0.9;
            else if (model == "A4") modifier = 1.1;
            else if (model == "A8") modifier = 2.1;
            else modifier = 1.9;

            if (reference.checkBox1.Checked == true) cijena += 1450*modifier;
            if (reference.checkBox2.Checked == true) cijena += 120*modifier;
            if (reference.checkBox3.Checked == true) cijena += 2370*modifier;
            if (reference.checkBox4.Checked == true) cijena += 820*modifier;
            if (reference.checkBox5.Checked == true) cijena += 290*modifier;
            if (reference.checkBox6.Checked == true) cijena += 980*modifier;
            if (reference.checkBox7.Checked == true) cijena += 4500* modifier;
            if (reference.checkBox8.Checked == true) cijena += 8620* modifier;
            if (reference.checkBox9.Checked == true) cijena += 6310* modifier;

            if (garancija == true) cijena = cijena - 0.7 * cijena;

            return cijena.ToString() + ",00 kn";
        }

        //odredjivanje tipa motora po broju sasije
        public static bool OdrediTipPoSasiji(Servis reference)
        {
            bool Diesel = false;

            if (reference.tBsas.Text[6] == 'Y') Diesel = false;
            else Diesel = true;

            return Diesel;
        }

        //odredjivanje modela po broju sasije
        public static string OdrediModelPoSasiji(Servis reference)
        {
            string model="";
            string str = reference.tBsas.Text.Substring(0, 6);
            if (str == "2X7AA4") model = "A1";
            else if (str == "2X9AC3") model = "A3";
            else if (str == "3X9AD3") model = "A4";
            else if (str == "6Q34P2") model = "A8";
            else if (str == "1A77A2") model = "Q7";
            else model = "ERR";

            return model;
        }

        //deaktiviranje checkboxova
        public static int Deactivate1(Servis reference)
        {

            reference.checkBox1.Enabled = false;
            reference.checkBox2.Enabled = false;
            reference.checkBox3.Enabled = false;
            reference.checkBox4.Enabled = false;
            reference.checkBox5.Enabled = false;
            reference.checkBox6.Enabled = false;
            reference.checkBox7.Enabled = false;
            reference.checkBox8.Enabled = false;
            reference.checkBox9.Enabled = false;

            return 0;
        }

        //dodavanje servisa u txt 
        public static int AddServis(Servis reference, string path, string model, string cijena)
        {
            string lineToWrite = "";
            string[] att= {"Ne", "Ne", "Ne", "Ne", "Ne", "Ne", "Ne", "Ne", "Ne"};
            if (reference.checkBox1.Checked == true) att[0] = "Da";
            if (reference.checkBox2.Checked == true) att[1] = "Da";
            if (reference.checkBox3.Checked == true) att[2] = "Da";
            if (reference.checkBox4.Checked == true) att[3] = "Da";
            if (reference.checkBox5.Checked == true) att[4] = "Da";
            if (reference.checkBox6.Checked == true) att[5] = "Da";
            if (reference.checkBox7.Checked == true) att[6] = "Da";
            if (reference.checkBox8.Checked == true) att[7] = "Da";
            if (reference.checkBox9.Checked == true) att[8] = "Da";

            lineToWrite = model + " /" + "PR:" + att[0] + " /" + "TC:" + att[1] + " /" + "KS:" + att[2] + " /" + "ZS:" + att[3] + " /" + "PU:" + att[4] + " /" + "Z:" + att[5] + " /" + "ZP:" + att[6] + " /" + "S:" + att[7] + " /" + "G:" + att[8] + " /" + cijena;

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(lineToWrite);
            }

            AddServisListBox(reference,path);

            return 0;
        }

        //dodavanje toga u listbox
        public static int AddServisListBox(Servis reference,string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                reference.listBox1.Items.Clear();
                string line;

                while ((line=sr.ReadLine())!=null)
                {
                    reference.listBox1.Items.Add(line);
                }
            }

            return 0;
        }

        //uklanjanje odabranog iz listboxa
        public static int RemoveFromListbox(Servis reference, string path)
        {

            string tempFile = Path.GetTempFileName();

            string lineToRemove;

            lineToRemove = reference.listBox1.SelectedItem.ToString();

            using (var sr2 = new StreamReader(path))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr2.ReadLine()) != null)
                {
                    if (line != lineToRemove)
                        sw.WriteLine(line);
                }
            }

            File.Delete(path);
            File.Move(tempFile, path);

            return 0;
        }

    }
}
