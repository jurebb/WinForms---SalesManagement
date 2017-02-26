using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autosalon
{
    class User
    {
       

        public static int Check(string user, string pass)
        {
            string _user, _pass;
            StreamReader sr = new StreamReader("user.txt");
            bool kraj = false;
            string[] linija;

            while(kraj==false)
            {
                try
                {
                    linija = sr.ReadLine().Split('|');
                    _user = user;
                    _pass = pass;
                    if (linija[0] == _user && linija[1] == _pass)
                    {
                        sr.Close();
                        return 1;
                    }
                    else if (linija[0] == _user)
                    {
                        sr.Close();
                        return 2;
                    }
                }
                catch
                {
                    kraj = true;
                }
            }
            sr.Close();
            return 0;
        }

        public static int CreateUser(string user, string pass)
        {
            string _user, _pass;

            //true za append?
            _user = user;
            _pass = pass;
            /**try
            {
                
            }
            catch
            {
                return -1;
            }**/

            using (StreamWriter sw = new StreamWriter("user.txt", true)) //true za append?
            {
                //sw.WriteLine(' ');
                sw.WriteLine( "\n" +_user + '|' + _pass);
            }

            //sw.Close();
            return 0;
        }

    }
}
