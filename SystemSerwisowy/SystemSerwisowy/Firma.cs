using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemSerwisowy
{
    public class Firma
    {
        private string miasto;
        private string ulica;
        private string czynne;
        private string telefon;
        private string email;


        public string Miasto
        {
            get 
            {
                return miasto;
            }
            set 
            {
                miasto = value;
            }
        }
        public string Ulica
        {
            get
            {
                return ulica;
            }
            set
            {
                ulica = value;
            }
        }
        public string Czynne
        {
            get
            {
                return czynne;
            }
            set
            {
                czynne = value;
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
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public Firma()
        {
            miasto = "";
            ulica = "";
            czynne = "";
            telefon = "";
            email = "";
        }
    }
}
