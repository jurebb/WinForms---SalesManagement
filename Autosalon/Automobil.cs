using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalon
{
    class Automobil
    {
        string _model, _oprema, _motor, _prijenos, _boja, _kotaci;
        string _snaga, _potrosnja, _sasija, _cijena;

        public Automobil(string model, string oprema, string motor, string prijenos, string boja, string kotaci, string snaga, string potrosnja, string sasija, string cijena)
        {
            _model = model;
            _oprema = oprema;
            _motor = motor;
            _prijenos = prijenos;
            _boja = boja;
            _kotaci = kotaci;
            _snaga = snaga;
            _potrosnja = potrosnja;
            _sasija = sasija;
            _cijena = cijena;
        }

        public string Model
        {
            get { return _model; }
        }
        public string Oprema
        {
            get { return _oprema; }
        }
        public string Motor
        {
            get { return _motor; }
        }
        public string Prijenos
        {
            get { return _prijenos; }
        }
        public string Boja
        {
            get { return _boja; }
        }
        public string Kotaci
        {
            get { return _kotaci; }
        }
        public string Snaga
        {
            get { return _snaga; }
        }
        public string Potrosnja
        {
            get { return _potrosnja; }
        }
        public string Sasija
        {
            get { return _sasija; }
        }
        public string Cijena
        {
            get { return _cijena; }
        }


        public string Opis()
        {
            string opis;
            opis = _model + "|" + _oprema + "|" + _motor + "|" + _prijenos + "|" + _boja + "|" + _kotaci + "|" + _snaga + "|" + _potrosnja + "|" + _sasija + "|" + _cijena;
            return opis;
        }
        public string OpisNA()
        {
            string opis;
            opis = _model + "/" + _motor + "/" + _boja + "/" + _sasija + "/" + _cijena;
            return opis;
        }
        public string OpisLA()
        {
            string opis;
            opis = _model + "/" + _motor + "/" + _boja + "/" + _oprema + "/" + _cijena + "/" + _sasija;
            return opis;
        }
        public string OpisSKR()
        {
            string opis;
            opis = _model + " " + _motor + " " + _boja + " " + _sasija;
            return opis;
        }

    }
}
