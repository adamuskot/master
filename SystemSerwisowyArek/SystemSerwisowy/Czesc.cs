using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemSerwisowy
{
    public class Czesc
    {
        private int id;
        private string nazwa;
        private string cenakupna;
        private string cenasprzedazy;
        private string dostawca;
        private string uwagi;
        private string dostepnosc;
        private int ilosc;

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

        public string Dostawca
        {
            get
            {
                return dostawca;
            }
            set
            {
                dostawca = value;
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

    }
}
