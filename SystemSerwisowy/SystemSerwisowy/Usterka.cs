using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemSerwisowy
{
    public class Usterka
    {
        private int id;
        private string nazwisko;
        private string telefon;
        private int dniPoTerminie;
        private string model;
        private string numer;
        private string opis;
        private string uwagi;
        private string koszt;
        private string dataod;
        private string datado;
        private string status;
        private string odbior;
        private string naprawy;
        private string dataOdbioru;
        private string smsWyslany;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
            }
        }
        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
            }
        }
        public string SMS
        {
            get
            {
                return smsWyslany;
            }
            set
            {
                smsWyslany = value;
            }
        }
        public int DniPoTerminie
        {
            get
            {
                return dniPoTerminie;
            }
            set
            {
                dniPoTerminie = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string NumerSeryjny
        {
            get
            {
                return numer;
            }
            set
            {
                numer = value;
            }
        }
        public string Opis
        {
            get
            {
                return opis;
            }
            set
            {
                opis = value;
            }
        }
        public string Uwagi
        {
            get
            {
                return uwagi;
            }
            set
            {
                uwagi = value;
            }
        }
        public string Koszt
        {
            get
            {
                return koszt;
            }
            set
            {
                koszt = value;
            }
        }
        public string DataZgloszenia
        {
            get
            {
                return dataod;
            }
            set
            {
                dataod = value;
            }
        }
        public string DataRealizacji
        {
            get
            {
                return datado;
            }
            set
            {
                datado = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public string Odbior
        {
            get
            {
                return odbior;
            }
            set
            {
                odbior = value;
            }
        }

        public string WykonaneNaprawy
        {
            get
            {
                return naprawy;
            }
            set
            {
                naprawy = value;
            }
        }

        public string DataOdbioru
        {
            get
            {
                return dataOdbioru;
            }
            set
            {
                dataOdbioru = value;
            }
        }


        public Usterka()
        {
            id = 0;
            telefon = "";
            nazwisko = "";
            model = "";
            numer = "";
            dataod = DateTime.Now.ToShortDateString();
            datado = "";
            opis = "";
            uwagi = "";
            koszt = "";
            status = "";
            odbior = "NIE";
            naprawy = "";
            dataOdbioru = "";
            smsWyslany = "NIE";
        }

        public Usterka(int _id, string tel, string nazw, string mod, string num, string datOd, string datDo, string opi, string uwag, string koszta, string stat, string odb, string napr, string dataOdb, string smsWysl)
        {
            id = _id;
            telefon = tel;
            nazwisko = nazw;
            model = mod;
            numer = num;
            dataod = datOd;
            datado = datDo;
            opis = opi;
            uwagi = uwag;
            koszt = koszta;
            status = stat;
            odbior = odb;
            naprawy = napr;
            dataOdbioru = dataOdb;
            smsWyslany = smsWysl;
        }
    }
}
