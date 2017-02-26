using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autosalon
{
    class Nar2Load : Nar2 
    {
        //reference da mozemo pristupiti non-static comboboxu
        public static int LoadElements(Nar2 refer, string model)
        {
            //obavezno "protected internal" za comboboxove forme Nar2
            string path="";
            path = "data/" + model;
            
            refer.cBmotor.Items.AddRange(File.ReadAllLines(@path + "mot.txt"));
            refer.cBprijenos.Items.AddRange(File.ReadAllLines(@path + "pri.txt"));
            refer.cBoprema.Items.AddRange(File.ReadAllLines(@path + "opr.txt"));
            refer.cBboja.Items.AddRange(File.ReadAllLines(@path + "boj.txt"));
            refer.cBkotaci.Items.AddRange(File.ReadAllLines(@path + "kot.txt"));
            

            return 0;
        }

        //prikaz boje u formi Nar2
        public static int DisplayColour(Nar2 refer, string model)
        {
            string path = "";
            path = "BOJE/"+refer.cBboja.Text;

            refer.pBboja.Load(@path + ".jpg");

            return 0;
        }

        //prikaz kotaca u formi Nar2
        public static int DisplayKotaci(Nar2 refer, string model)
        {
            string path = "";
            path = model + "/" + refer.cBkotaci.Text;

            refer.pBkotaci.Load(@path + ".jpg");

            return 0;
        }

        public static int BasePrice(string model)
        {
            int price = 0;
            if (model == "A1") price = 110500;
            else if (model == "A3") price = 148300;
            else if (model == "A4") price = 182200;
            else if (model == "Q7") price = 340700;
            else if (model == "A8") price = 574600;
            return price;
        }

        public static int Cijena(string model, string oprema, string motor, string prijenos, string boja, string kotaci)
        {
            int cijosn = BasePrice(model);
            int cijena = cijosn;
            if (oprema == "Ambition")
                cijena += 3610;
            else if (oprema == "Attraction")
                cijena += 24560;
            else if (oprema == "Ambiente")
                cijena += 37820;
            else if (oprema == "Sport")
                cijena += 69570;
            else if (oprema == "Allroad" || oprema == "business")
                cijena += 96320;
            else if (oprema == "Lang")
                cijena += 154700;
            if (motor == "1,2 TFSI")
                cijena += 3490;
            else if (motor == "1,4 TFSI")
                cijena += 14500;
            else if (motor == "1,8 TFSI")
                cijena += 19540;
            else if (motor == "2,0 TFSI")
                cijena += 27540;
            else if (motor == "3,0 TFSI")
                cijena += 39540;
            else if (motor == "4,0 TFSI")
                cijena += 56330;
            else if (motor == "1,6 TDI")
                cijena += 17700;
            else if (motor == "2,0 TDI")
                cijena += 27350;
            else if (motor == "3,0 TDI")
                cijena += 36470;
            else if (motor == "4,2 TDI")
                cijena += 48430;
            else if (motor == "6,3 W12")
                cijena += 93610;
            if (prijenos == "6-stupanjski mjenjac")
                cijena += 0;
            else if (prijenos == "S-tronic automatski mjenjac")
                cijena += 21300;
            else if (prijenos == "QUATTRO R tronic" || prijenos == "Tiptronic")
                cijena += 27450;
            else if (prijenos == "QUATTRO Tiptronic")
                cijena += 31400;
            if (boja == "Amalfi bijela")
                cijena += 330;
            else if (boja == "Brilliant crna" || boja == "Misano crvena")
                cijena += 4980;
            else if (boja == "Daytona siva" || boja == "Mugello Perleffekt")
                cijena += 9750;
            if (kotaci == "7,5J x 15" || kotaci == "7,5J x 17")
                cijena += 8700;
            else if (kotaci == "7,5J x 16" || kotaci == "7,5J x 18" || kotaci == "8J x 18" || kotaci == "10J x 20")
                cijena += 10430;
            else if (kotaci == "8J x 19" || kotaci == "10J x 21")
                cijena += 19710;
            return cijena;
        }

        public static string BaseSasija(string model)
        {
            string sasija = "";
            if (model == "A1") sasija = "2X7AA4";
            else if (model == "A3") sasija = "2X9AC3";
            else if (model == "A4") sasija = "3X9AD3";
            else if (model == "Q7") sasija = "1A77A2";
            else if (model == "A8") sasija = "6Q34P2";
            return sasija;
        }

        public static string Sasija(string model, string motor, string prijenos, string boja)
        {
            string sasija = BaseSasija(model);

            if (motor == "1,2 TFSI")
                sasija += "Y3";
            else if (motor == "1,4 TFSI")
                sasija += "Y4";
            else if (motor == "1,8 TFSI")
                sasija += "Y5";
            else if (motor == "2,0 TFSI")
                sasija += "Y6";
            else if (motor == "3,0 TFSI")
                sasija += "Y7";
            else if (motor == "4,0 TFSI")
                sasija += "Y8";
            else if (motor == "1,6 TDI")
                sasija += "W3";
            else if (motor == "2,0 TDI")
                sasija += "W4";
            else if (motor == "3,0 TDI")
                sasija += "W5";
            else if (motor == "4,2 TDI")
                sasija += "W6";
            else if (motor == "6,3 W12")
                sasija += "Y9";
            if (prijenos == "6-stupanjski mjenjac")
                sasija += "T6";
            else if (prijenos == "S-tronic automatski mjenjac")
                sasija += "TS";
            else if (prijenos == "QUATTRO R tronic" || prijenos == "Tiptronic")
                sasija += "TR";
            else if (prijenos == "QUATTRO Tiptronic")
                sasija += "TQ";
            if (boja == "Amalfi bijela")
                sasija += "9K";
            else if (boja == "Brilliant crna" || boja == "Misano crvena")
                sasija += "8K";
            else if (boja == "Daytona siva" || boja == "Mugello Perleffekt")
                sasija += "7K";

            return sasija;
        }

        public static string[] SnagaPotrosnja(string model, string motor)
        {
            //?
            string[] SnagaPotrosnja = new string[2];

            if (motor == "1,2 TFSI")
            {
                SnagaPotrosnja[0] = "105";
                SnagaPotrosnja[1] = "5,6";
            }

            else if (motor == "1,4 TFSI")
            {
                SnagaPotrosnja[0] = "140";
                SnagaPotrosnja[1] = "6,0";
            }
            else if (motor == "1,8 TFSI")
            {
                SnagaPotrosnja[0] = "180";
                SnagaPotrosnja[1] = "6,5";
            }
            else if (motor == "2,0 TFSI")
            {
                SnagaPotrosnja[0] = "210";
                SnagaPotrosnja[1] = "6,7";
            }
            else if (motor == "3,0 TFSI")
            {
                SnagaPotrosnja[0] = "270";
                SnagaPotrosnja[1] = "6,9";
            }
            else if (motor == "4,0 TFSI")
            {
                SnagaPotrosnja[0] = "330";
                SnagaPotrosnja[1] = "7,4";
            }
            else if (motor == "1,6 TDI")
            {
                SnagaPotrosnja[0] = "110";
                SnagaPotrosnja[1] = "5,1";
            }
            else if (motor == "2,0 TDI")
            {
                SnagaPotrosnja[0] = "170";
                SnagaPotrosnja[1] = "5,5";
            }
            else if (motor == "3,0 TDI")
            {
                SnagaPotrosnja[0] = "212";
                SnagaPotrosnja[1] = "6,1";
            }
            else if (motor == "4,2 TDI")
            {
                SnagaPotrosnja[0] = "270";
                SnagaPotrosnja[1] = "7,4";
            }
            else if (motor == "6,3 W12")
            {
                SnagaPotrosnja[0] = "470";
                SnagaPotrosnja[1] = "11,3";
            }

            return SnagaPotrosnja;
        }


        //vraca true ukoliko svi comboboxovi sadrzavaju neki string
        public static bool CheckIfAllcB(Nar2 reference)
        {
            bool flag = false;

            if (reference.cBboja.Text != "" && reference.cBkotaci.Text != "" && reference.cBmotor.Text != "" && reference.cBoprema.Text != "" && reference.cBprijenos.Text != "")
                flag = true;

            return flag;
        }

        //disable-a comboboxove, botun Prethodno i botun Naruci, 
        public static int DisablecBEnableDalje(Nar2 reference)
        {
            //botune isto na Protected Internal

            reference.cBboja.Enabled = false;
            reference.cBkotaci.Enabled = false;
            reference.cBmotor.Enabled = false;
            reference.cBoprema.Enabled = false;
            reference.cBprijenos.Enabled = false;
            reference.button1.Enabled = false;
            reference.button2.Enabled = false;
            reference.button2.Visible = false;
            reference.button3.Enabled = true;
            reference.button3.Visible = true;

            return 0;
        }

        //dodavanje novog automobila u .txt
        public static int AddNewToTxt(Automobil au)
        {
            //string user=
            string path = @"narudzbe.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(au.Opis());
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(au.Opis());
                }
            }
            return 0;
        }

    }
}
