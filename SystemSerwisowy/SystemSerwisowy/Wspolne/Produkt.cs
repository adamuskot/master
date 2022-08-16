using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemSerwisowy
{
    public class Produkt
    {
        private int id;
        private string nazwa;
        private string numer;
        private string cenakupna;
        private string cenasprzedazy;
        private string wyposazenie;
        private int ilosc;
        private string dataod;
        private string datado;
        private string dostepnosc;
        private string uwagi;
        private string kategoria;

        public int Id
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

        public string Nazwa
        {
            get
            {
                return nazwa;
            }
            set
            {
                nazwa = value;
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

        public string Wyposazenie
        {
            get
            {
                return wyposazenie;
            }
            set
            {
                wyposazenie = value;
            }
        }

        public string CenaZakupu
        {
            get
            {
                return cenakupna;
            }
            set
            {
                cenakupna = value;
            }
        }

        public string CenaSprzedazy
        {
            get
            {
                return cenasprzedazy;
            }
            set
            {
                cenasprzedazy = value;
            }
        }

        public int Ilosc
        {
            get
            {
                return ilosc;
            }
            set
            {
                ilosc = value;
            }
        }

        public string DataZakupu
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

        public string DataSprzedazy
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

        public string Dostepny
        {
            get
            {
                return dostepnosc;
            }
            set
            {
                dostepnosc = value;
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
        public string Kategoria
        {
            get
            {
                return kategoria;
            }
            set
            {
                kategoria = value;
            }
        }

        public Produkt()
        {
            id = 0;
            nazwa = "";
            numer = "";
            uwagi = "";
            datado = "";
            dataod = "";
            ilosc = 0;
            wyposazenie = "";
            cenakupna = "";
            cenasprzedazy = "";
            dostepnosc = "TAK";
            kategoria = "";
        }
    }
}
