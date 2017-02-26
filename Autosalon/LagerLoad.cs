using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autosalon
{
    class LagerLoad : Lager
    {
        public static List<Automobil> Naruceni = new List<Automobil>();
        public static List<Automobil> Lager = new List<Automobil>();

        

        //za loadanje listboxa u formi lager
        public static int LoadLists(Lager reference)
        {
            //reference forme Lager

            //praznjenje listbox-a
            reference.listBox1.Items.Clear();
            reference.listBox2.Items.Clear();
            ListClear();
            //
            StreamReader sr = new StreamReader("narudzbe.txt");
            bool kraj = false;
            string[] linija;
            while (kraj == false)
            {
                try
                {
                    linija = sr.ReadLine().Split('|');

                    Automobil autoNar = new Automobil(linija[0], linija[1], linija[2], linija[3], linija[4], linija[5], linija[6], linija[7], linija[8], linija[9]);
                    Naruceni.Add(autoNar);
                }
                catch
                {
                    kraj = true;
                }
            }
            sr.Close();

            //reference.listBox1.DataSource = Naruceni;
            foreach(Automobil auto in Naruceni)
            {
                reference.listBox1.Items.Add(auto.OpisLA());
            }


            //za lager
            kraj = false;
            StreamReader sr2 = new StreamReader("lager.txt");
            while (kraj == false)
            {
                try
                {
                    linija = sr2.ReadLine().Split('|');

                    Automobil autoNar = new Automobil(linija[0], linija[1], linija[2], linija[3], linija[4], linija[5], linija[6], linija[7], linija[8], linija[9]);
                    Lager.Add(autoNar);
                }
                catch
                {
                    kraj = true;
                }
            }
            sr2.Close();
            foreach (Automobil auto in Lager)
            {
                reference.listBox2.Items.Add(auto.OpisLA());
            }
            return 0;
        }

        
        //uklanja naruceni auto iz listbox1 i iz file-a narudzbe.txt
        
        public static string RemoveSelectedNaruceni(Lager reference)
        {
            string[] linijaListBox;

            //broj sasije onog kojeg treba brisati
            string sasijaDel = "";

            //cijela linija koju brisemoiz .txta
            string returnline = "";

            linijaListBox = reference.listBox1.SelectedItem.ToString().Split('/');
            sasijaDel = linijaListBox[5];


            //brisanje linije iz narudzbe.txt prema broju sasije
            string tempFile ="temp.txt";
            using (var sr2 = new StreamReader("narudzbe.txt"))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;
                string[] splitLine;

                while ((line = sr2.ReadLine()) != null)
                {
                    if (line != null)
                    {
                        splitLine = line.Split('|');
                        if (splitLine[8] != sasijaDel)
                            sw.WriteLine(line);
                        else returnline = line;
                    }
                }
            }


            File.Delete("narudzbe.txt");
            //File.Move(tempFile, "narudzbe.txt");
            File.Copy(tempFile, "narudzbe.txt");

            //brisanje iz liste Narudzbe - provjeri funkcionira li
            //foreach(Automobil auto in Naruceni)
            //{
            //if (auto.Sasija == sasijaDel)
            //Naruceni.Remove(auto);
            //}



            /**string tempFile = Path.GetTempFileName();

            using (var sr2 = new StreamReader("narudzbe.txt"))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr2.ReadLine()) != null)
                {
                    if (line != "removeme")
                        sw.WriteLine(line);
                }
            }

            File.Delete("narudzbe.txt");
            File.Move(tempFile, "narudzbe.txt");
            **/
            return returnline;
        }
        
        //dodaje poslani string u .txt lager-a
        public static int AddToLager(Lager reference, string linija)
        {
            string LagerPath = "lager.txt";
            using (StreamWriter sw = new StreamWriter(LagerPath, true))
            {
                sw.WriteLine(linija);
            }

            //da se loada novi element u listbox2
            LoadLists(reference);

            return 0;
        }

        public static int ListClear()
        {
            Naruceni.Clear();
            Lager.Clear();
            return 0;
        }

        public static string SellSelectedLager(Lager reference)
        {
            string[] linijaListBox;

            //broj sasije onog kojeg treba brisati
            string sasijaDel = "";

            //cijela linija koju brisemoiz .txta
            string returnline = "";

            linijaListBox = reference.listBox2.SelectedItem.ToString().Split('/');
            sasijaDel = linijaListBox[5];


            //brisanje linije iz narudzbe.txt prema broju sasije
            string tempFile = "temp.txt";
            using (var sr2 = new StreamReader("lager.txt"))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;
                string[] splitLine;

                while ((line = sr2.ReadLine()) != null)
                {
                    if (line != null)
                    {
                        splitLine = line.Split('|');
                        if (splitLine[8] != sasijaDel)
                            sw.WriteLine(line);
                        else returnline = line;
                    }
                }
            }


            File.Delete("lager.txt");
            //File.Move(tempFile, "narudzbe.txt");
            File.Copy(tempFile, "lager.txt");

            

            return returnline;
        }
    }
}
