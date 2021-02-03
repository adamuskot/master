using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemSerwisowy
{
    class Pomocnik
    {
        public Pomocnik()
        {

        }

        public bool czyUsterkiTakieSame(Usterka ust1, Usterka ust2)
        {
            if (ust1.DataRealizacji != ust2.DataRealizacji)
                return false;
            if (ust1.DataZgloszenia != ust2.DataZgloszenia)
                return false;
            if (ust1.ID != ust2.ID)
                return false;
            if (ust1.Koszt != ust2.Koszt)
                return false;
            if (ust1.Model != ust2.Model)
                return false;
            if (ust1.Nazwisko != ust2.Nazwisko)
                return false;
            if (ust1.NumerSeryjny != ust2.NumerSeryjny)
                return false;
            if (ust1.Odbior != ust2.Odbior)
                return false;
            if (ust1.Opis != ust2.Opis)
                return false;
            if (ust1.Status != ust2.Status)
                return false;
            if (ust1.Telefon != ust2.Telefon)
                return false;
            if (ust1.Uwagi != ust2.Uwagi)
                return false;
            if (ust1.WykonaneNaprawy != ust2.WykonaneNaprawy)
                return false;
            if (ust1.ZgodaElektro != ust2.ZgodaElektro)
                return false;
            if (ust1.BlokujKlienta != ust2.BlokujKlienta)
                return false;
            return true;
        }
    }
}
