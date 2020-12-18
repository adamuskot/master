using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;


namespace SystemSerwisowy
{
    public partial class Glowna : Form
    {
        public List<Produkt> listaProduktow;
        public List<Czesc> listaAkcesoriow;
        public List<Usterka> listaUsterek;
        public Dictionary<string, string> bazaKlientow;
        public Firma firma;
        public List<string> regulamin;
        private int indeks = 0;
        public int czasNaprawy = 2;
        public string trescSmsNaprawiony = "";
        public string trescSmsNienaprawiony = "";
        public string trescSmsInny = "";

        public Glowna()
        {
            firma = new Firma();
            InitializeComponent();
            listaProduktow = new List<Produkt>();
            listaAkcesoriow = new List<Czesc>();
            listaUsterek = new List<Usterka>();
            bazaKlientow = new Dictionary<string, string>();
            regulamin = new List<string>();
            wczytajPliki();
            //Przypominacz();
            timer1.Enabled = true;
            timer2.Enabled = true;
            generujRaport();
            //timer1.Interval = 10000;
        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void nadpiszProdukty()
        {
            string sciezka = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Serwis2015\\Baza\\Produkty.txt";
            FileStream plik = new FileStream(sciezka, FileMode.Truncate, FileAccess.Write); // czyszczenie pliku txt
            plik.Close();
            plik = new FileStream(sciezka, FileMode.Append, FileAccess.Write);
            StreamWriter zapisuj = new StreamWriter(plik);
            for (int i = 0; i < listaProduktow.Count(); i++)
            {
                zapisuj.WriteLine(listaProduktow[i].Id + "|" + listaProduktow[i].Nazwa + "|" + listaProduktow[i].NumerSeryjny + "|" + listaProduktow[i].CenaZakupu + "|" + listaProduktow[i].CenaSprzedazy + "|" + listaProduktow[i].Wyposazenie + "|" + listaProduktow[i].Ilosc + "|" + listaProduktow[i].DataZakupu + "|" + listaProduktow[i].DataSprzedazy + "|" + listaProduktow[i].Uwagi + "|" + listaProduktow[i].Dostepny + "|" + listaProduktow[i].WykonaneNaprawy);
            }
            zapisuj.Close();
        }

        public void nadpiszAkcesoria()
        {
            string sciezka = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Serwis2015\\Baza\\Akcesoria.txt";
            FileStream plik = new FileStream(sciezka, FileMode.Truncate, FileAccess.Write); // czyszczenie pliku txt
            plik.Close();
            plik = new FileStream(sciezka, FileMode.Append, FileAccess.Write);
            StreamWriter zapisuj = new StreamWriter(plik);
            for (int i = 0; i < listaAkcesoriow.Count(); i++)
            {
                zapisuj.WriteLine(listaAkcesoriow[i].Id + "|" + listaAkcesoriow[i].Nazwa + "|" + listaAkcesoriow[i].CenaZakupu + "|" + listaAkcesoriow[i].CenaSprzedazy + "|" + listaAkcesoriow[i].Uwagi + "|" + listaAkcesoriow[i].Ilosc + "|" + listaAkcesoriow[i].Dostepny);
            }
            zapisuj.Close();
        }

        public void nadpiszUsterki()
        {
            string sciezka = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Serwis2015\\Baza\\Baza.txt";
            FileStream plik = new FileStream(sciezka, FileMode.Truncate, FileAccess.Write); // czyszczenie pliku txt
            plik.Close();
            plik = new FileStream(sciezka, FileMode.Append, FileAccess.Write);
            StreamWriter zapisuj = new StreamWriter(plik);
            for (int i = 0; i < listaUsterek.Count(); i++)
            {
                string dataRealizacji = "";
                if (listaUsterek[i].DataRealizacji.Contains(".") && listaUsterek[i].DataRealizacji != "" && listaUsterek[i].DataRealizacji.Length == 10)
                {
                    dataRealizacji = listaUsterek[i].DataRealizacji.Substring(6, 4) + "-" + listaUsterek[i].DataRealizacji.Substring(3, 2) + "-" + listaUsterek[i].DataRealizacji.Substring(0, 2);
                }
                else
                {
                    dataRealizacji = listaUsterek[i].DataRealizacji;
                }
                string dataZgloszenia = "";
                if (listaUsterek[i].DataZgloszenia.Contains(".") && listaUsterek[i].DataZgloszenia != "" && listaUsterek[i].DataZgloszenia.Length == 10)
                {
                    dataZgloszenia = listaUsterek[i].DataZgloszenia.Substring(6, 4) + "-" + listaUsterek[i].DataZgloszenia.Substring(3, 2) + "-" + listaUsterek[i].DataZgloszenia.Substring(0, 2);
                }
                else
                {
                    dataZgloszenia = listaUsterek[i].DataZgloszenia;
                }
                string dataOdbioru = "";
                if (listaUsterek[i].DataOdbioru.Contains(".") && listaUsterek[i].DataOdbioru != "" && listaUsterek[i].DataOdbioru.Length == 10)
                {
                    dataOdbioru = listaUsterek[i].DataOdbioru.Substring(6, 4) + "-" + listaUsterek[i].DataOdbioru.Substring(3, 2) + "-" + listaUsterek[i].DataOdbioru.Substring(0, 2);
                }
                else
                {
                    dataOdbioru = listaUsterek[i].DataOdbioru;
                }

                zapisuj.WriteLine(listaUsterek[i].ID + "|" + listaUsterek[i].Nazwisko + "|" + listaUsterek[i].Telefon + "|" + listaUsterek[i].Model + "|" + listaUsterek[i].NumerSeryjny + "|" + listaUsterek[i].Opis + "|" + listaUsterek[i].Uwagi + "|" + listaUsterek[i].Koszt + "|" + dataZgloszenia + "|" + dataRealizacji + "|" + listaUsterek[i].Status + "|" + listaUsterek[i].Odbior + "|" + listaUsterek[i].WykonaneNaprawy + "|" + dataOdbioru + "|" + listaUsterek[i].SMS);
            }
            zapisuj.Close();
        }

        public void nadpiszFirme()
        {
            string sciezka = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Serwis2015\\Baza\\Firma.txt";
            FileStream plik = new FileStream(sciezka, FileMode.Truncate, FileAccess.Write); // czyszczenie pliku txt
            plik.Close();
            plik = new FileStream(sciezka, FileMode.Append, FileAccess.Write);
            StreamWriter zapisuj = new StreamWriter(plik);
            zapisuj.WriteLine(firma.Miasto + "|" + firma.Ulica + "|" + firma.Czynne + "|" + firma.Telefon + "|" + firma.Email);
            zapisuj.Close();
        }

        public void nadpiszRegulamin()
        {
            string sciezka = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Serwis2015\\Baza\\Regulamin.txt";
            FileStream plik = new FileStream(sciezka, FileMode.Truncate, FileAccess.Write); // czyszczenie pliku txt
            plik.Close();
            plik = new FileStream(sciezka, FileMode.Append, FileAccess.Write);
            StreamWriter zapisuj = new StreamWriter(plik);
            for (int i = 0; i < regulamin.Count(); i++)
            {
                zapisuj.WriteLine(regulamin[i]);
            }
            zapisuj.Close();
        }

        public void nadpiszUstawienia()
        {
            string sciezka = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Serwis2015\\Baza\\Ustawienia.txt";
            FileStream plik = new FileStream(sciezka, FileMode.Truncate, FileAccess.Write); // czyszczenie pliku txt
            plik.Close();
            plik = new FileStream(sciezka, FileMode.Append, FileAccess.Write);
            StreamWriter zapisuj = new StreamWriter(plik);
            zapisuj.WriteLine("Czas naprawy=" + czasNaprawy.ToString());
            zapisuj.WriteLine("Tresc sms naprawiony=" + trescSmsNaprawiony);
            zapisuj.WriteLine("Tresc sms nienaprawiony=" + trescSmsNienaprawiony);
            zapisuj.WriteLine("Tresc sms inny=" + trescSmsInny);
            zapisuj.Close();
        }

        //public void nadpiszUsterki()
        //{
        //    string sciezka = "C:\\Serwis2015\\Baza\\Baza.xls";
        //    Excel.Application xlApp;
        //    Excel.Workbook xlWorkBook;
        //    Excel.Worksheet xlWorkSheet;
        //    Excel.Range range;
        //    object misValue = System.Reflection.Missing.Value;
        //    xlApp = new Excel.Application();
        //    xlWorkBook = xlApp.Workbooks.Open(sciezka, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
        //    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
        //    range = xlWorkSheet.UsedRange;
        //    try
        //    {
        //        for (int i = 0; i < listaUsterek.Count; i++)
        //        {
        //            for (int j = 1; j <= range.Columns.Count; j++)
        //            {
        //                switch (j)
        //                {
        //                    case 1:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].ID;
        //                        break;
        //                    case 2:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].Nazwisko;
        //                        break;
        //                    case 3:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].Telefon;
        //                        break;
        //                    case 4:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].Model;
        //                        break;
        //                    case 5:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].NumerSeryjny;
        //                        break;
        //                    case 6:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].Opis;
        //                        break;
        //                    case 7:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].Uwagi;
        //                        break;
        //                    case 8:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].Koszt;
        //                        break;
        //                    case 9:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].DataZgloszenia;
        //                        break;
        //                    case 10:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].DataRealizacji;
        //                        break;
        //                    case 11:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].Status;
        //                        break;
        //                    case 12:
        //                        xlWorkSheet.Cells[i + 2, j] = listaUsterek[i].Odbior;
        //                        break;
        //                }
        //            }
        //        }
        //        if (range.Rows.Count > listaUsterek.Count() + 1)
        //        {
        //            for (int i = listaUsterek.Count; i <= range.Rows.Count; i++)
        //            {
        //                Excel.Range ran;
        //                ran = (Excel.Range)xlWorkSheet.Rows[i + 2, Type.Missing];
        //                ran.Select();
        //                ran.Delete(Excel.XlDirection.xlUp);
        //            }
        //        }
        //        xlApp.DisplayAlerts = false;
        //        xlApp.ActiveWorkbook.SaveAs(sciezka, Excel.XlFileFormat.xlWorkbookDefault,
        //            Type.Missing, Type.Missing, true, false,
        //            Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
        //        xlApp.DisplayAlerts = true;
        //        xlWorkBook.Close(true, misValue, misValue);
        //        xlApp.Quit();
        //    }
        //    catch (Exception)
        //    {
        //        xlWorkBook.Close(false, null, null);
        //        xlApp.Quit();
        //    }
        //    finally
        //    {
        //        releaseObject(xlWorkSheet);
        //        releaseObject(xlWorkBook);
        //        releaseObject(xlApp);
        //    }
        //}

        private void wczytajPliki()
        {
            string sciezka = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Serwis2015\\Baza";

            if (Directory.Exists(sciezka))
            {
                if (File.Exists(sciezka + "\\Firma.txt"))
                {
                    string linia = "";
                    StreamReader czytaj;
                    czytaj = new StreamReader(sciezka + "\\Firma.txt");
                    while (linia != null)
                    {
                        linia = czytaj.ReadLine();
                        if (linia != null && linia != "")
                        {
                            Firma fir = new Firma();
                            var split = linia.Split('|');
                            fir.Miasto = split[0];
                            fir.Ulica = split[1];
                            fir.Czynne = split[2];
                            fir.Telefon = split[3];
                            fir.Email = split[4];
                            firma = fir;
                        }
                    }
                    czytaj.Close();
                    if (firma.Miasto == "")
                    {
                        firma.Miasto = "Zduńska Wola";
                        firma.Ulica = "ul. Sieradzka 6";
                        firma.Czynne = "poniedziałek - piątek 9:00 - 18:30, sobota 9:00 - 14:00";
                        firma.Email = "www.lumik.pl";
                        firma.Telefon = "513 343 438";
                    }
                }
                else
                {
                    var myFile = File.Create(sciezka + "\\Firma.txt");
                    myFile.Close();
                }
                if (File.Exists(sciezka + "\\Ustawienia.txt"))
                {
                    string linia = "";
                    StreamReader czytaj;
                    czytaj = new StreamReader(sciezka + "\\Ustawienia.txt");
                    while (linia != null)
                    {
                        linia = czytaj.ReadLine();
                        if (linia != null && linia != "")
                        {
                            var split = linia.Split('=');
                            if (split[0] == "Czas naprawy")
                            {
                                czasNaprawy = Convert.ToInt32(split[1]);
                            }
                            if (split[0] == "Tresc sms naprawiony")
                            {
                                trescSmsNaprawiony = split[1];
                            }
                            if (split[0] == "Tresc sms nienaprawiony")
                            {
                                trescSmsNienaprawiony = split[1];
                            }
                            if (split[0] == "Tresc sms inny")
                            {
                                trescSmsInny = split[1];
                            }
                        }
                    }
                    czytaj.Close();
                }
                else
                {
                    var myFile = File.Create(sciezka + "\\Ustawienia.txt");
                    myFile.Close();
                }
                if (File.Exists(sciezka + "\\Produkty.txt"))
                {
                    string linia = "";
                    StreamReader czytaj;
                    czytaj = new StreamReader(sciezka + "\\Produkty.txt");
                    while (linia != null)
                    {
                        linia = czytaj.ReadLine();
                        if (linia != null && linia != "")
                        {
                            Produkt pr = new Produkt();
                            var split = linia.Split('|');
                            try
                            {
                                pr.Id = Convert.ToInt32(split[0]);
                                pr.Nazwa = split[1];
                                pr.NumerSeryjny = split[2];
                                pr.CenaZakupu = split[3];
                                pr.CenaZakupu.Replace(',', '.');
                                pr.CenaSprzedazy = split[4];
                                pr.CenaSprzedazy.Replace(',', '.');
                                pr.Wyposazenie = split[5];
                                pr.Ilosc = Convert.ToInt32(split[6]);
                                pr.DataZakupu = split[7];
                                pr.DataSprzedazy = split[8];
                                pr.Uwagi = split[9];
                                pr.Dostepny = split[10];
                                pr.WykonaneNaprawy = split[11];

                            }
                            catch
                            {
                                if (split.Count() < 12)
                                    pr.WykonaneNaprawy = "";
                                if (split.Count() < 11)
                                {
                                    if (pr.Ilosc > 0)
                                        pr.Dostepny = "TAK";
                                    else
                                        pr.Dostepny = "NIE";
                                }
                                if (split.Count() < 10)
                                    pr.Uwagi = "";
                                if (split.Count() < 9)
                                    pr.DataSprzedazy = "";
                                if (split.Count() < 8)
                                    pr.DataZakupu = "";
                                if (split.Count() < 7)
                                    pr.Ilosc = 0;
                                if (split.Count() < 6)
                                    pr.Wyposazenie = "";
                                if (split.Count() < 5)
                                    pr.CenaSprzedazy = "";
                                if (split.Count() < 4)
                                    pr.CenaZakupu = "";
                                if (split.Count() < 3)
                                    pr.NumerSeryjny = "";
                                if (split.Count() < 2)
                                    pr.Nazwa = "";
                                if (split.Count() < 1)
                                    pr.Id = 1;
                            }
                            finally
                            {
                                var item = listaProduktow.Find(x => (x.Id == pr.Id) && (x.Nazwa == pr.Nazwa));
                                if (item == null)
                                {
                                    listaProduktow.Add(pr);
                                }
                            }
                        }
                    }
                    czytaj.Close();
                }
                else
                {
                    var myFile = File.Create(sciezka + "\\Produkty.txt");
                    myFile.Close();
                }
                if (File.Exists(sciezka + "\\Akcesoria.txt"))
                {
                    string linia = "";
                    StreamReader czytaj;
                    czytaj = new StreamReader(sciezka + "\\Akcesoria.txt");
                    while (linia != null)
                    {
                        linia = czytaj.ReadLine();
                        if (linia != null && linia != "")
                        {
                            Czesc cz = new Czesc();
                            var split = linia.Split('|');
                            try
                            {
                                cz.Id = Convert.ToInt32(split[0]);
                                cz.Nazwa = split[1];
                                cz.CenaZakupu = split[2];
                                cz.CenaZakupu.Replace(',', '.');
                                cz.CenaSprzedazy = split[3];
                                cz.CenaSprzedazy.Replace(',', '.');
                                cz.Uwagi = split[4];
                                cz.Ilosc = Convert.ToInt32(split[5]);
                                cz.Dostepny = split[6];
                            }
                            catch
                            {
                                if (split.Count() < 7)
                                {
                                    if (cz.Ilosc > 0)
                                        cz.Dostepny = "TAK";
                                    else
                                        cz.Dostepny = "NIE";
                                }
                                if (split.Count() < 6)
                                    cz.Ilosc = 0;
                                if (split.Count() < 5)
                                    cz.Uwagi = "";
                                if (split.Count() < 4)
                                    cz.CenaSprzedazy = "";
                                if (split.Count() < 3)
                                    cz.CenaZakupu = "";
                                if (split.Count() < 2)
                                    cz.Nazwa = "";
                                if (split.Count() < 1)
                                    cz.Id = 1;
                            }
                            finally
                            {
                                var item = listaAkcesoriow.Find(x => (x.Id == cz.Id) && (x.Nazwa == cz.Nazwa));
                                if (item == null)
                                {
                                    listaAkcesoriow.Add(cz);
                                }
                            }
                        }
                    }
                    czytaj.Close();
                }
                else
                {
                    var myFile = File.Create(sciezka + "\\Akcesoria.txt");
                    myFile.Close();
                }
                if (File.Exists(sciezka + "\\Baza.txt"))
                {
                    string linia = "";
                    StreamReader czytaj;
                    czytaj = new StreamReader(sciezka + "\\Baza.txt");
                    while (linia != null)
                    {
                        linia = czytaj.ReadLine();
                        if (linia != null && linia != "")
                        {
                            Usterka ust = new Usterka();
                            var split = linia.Split('|');
                            try
                            {
                                ust.ID = Convert.ToInt32(split[0]);
                                ust.Nazwisko = split[1];
                                ust.Telefon = split[2];
                                ust.Model = split[3];
                                ust.NumerSeryjny = split[4];
                                ust.Opis = split[5];
                                ust.Uwagi = split[6];
                                ust.Koszt = split[7];
                                ust.DataZgloszenia = split[8];
                                ust.DataRealizacji = split[9];
                                ust.Status = split[10];
                                ust.Odbior = split[11];
                                ust.WykonaneNaprawy = split[12];
                                ust.DataOdbioru = split[13];
                                ust.DniPoTerminie = Convert.ToInt32((Convert.ToDateTime(DateTime.Today) - Convert.ToDateTime(ust.DataRealizacji)).TotalDays);
                                ust.SMS = (split[14] == null) ? "NIE" : split[14];
                            }
                            catch
                            {
                                if (split.Count() < 15)
                                    ust.SMS = "NIE";
                                if (split.Count() < 14)
                                    ust.DataOdbioru = "";
                                if (split.Count() < 13)
                                    ust.WykonaneNaprawy = "";
                                if (split.Count() < 12)
                                    ust.Odbior = "";
                                if (split.Count() < 11)
                                    ust.Status = "";
                                if (split.Count() < 10)
                                    ust.DataRealizacji = "";
                                if (split.Count() < 9)
                                    ust.DataZgloszenia = "";
                                if (split.Count() < 8)
                                    ust.Koszt = "";
                                if (split.Count() < 7)
                                    ust.Uwagi = "";
                                if (split.Count() < 6)
                                    ust.Opis = "";
                                if (split.Count() < 5)
                                    ust.NumerSeryjny = "";
                                if (split.Count() < 4)
                                    ust.Model = "";
                                if (split.Count() < 3)
                                    ust.Telefon = "";
                                if (split.Count() < 2)
                                    ust.Nazwisko = "";
                                if (split.Count() < 1)
                                    ust.ID = 1;

                            }
                            finally
                            {
                                var item = listaUsterek.Find(x => (x.ID == ust.ID) && (x.Nazwisko == ust.Nazwisko) && (x.DataZgloszenia == ust.DataZgloszenia));
                                if (item == null)
                                {
                                    listaUsterek.Add(ust);
                                    if (!bazaKlientow.ContainsKey(ust.Nazwisko + " " + ust.Telefon))
                                    {
                                        bazaKlientow.Add(ust.Nazwisko + " " + ust.Telefon, ust.Telefon);
                                    }

                                }
                            }
                        }
                    }
                    czytaj.Close();
                }
                else
                {
                    var myFile = File.Create(sciezka + "\\Baza.txt");
                    myFile.Close();
                }
                if (File.Exists(sciezka + "\\Regulamin.txt"))
                {
                    string linia = "";
                    StreamReader czytaj;
                    czytaj = new StreamReader(sciezka + "\\Regulamin.txt");
                    while (linia != null)
                    {
                        linia = czytaj.ReadLine();
                        if (linia != null && linia != "")
                        {
                            if (!regulamin.Contains(linia))
                            {
                                regulamin.Add(linia);
                            }
                        }
                    }
                    czytaj.Close();
                }
                else
                {
                    var myFile = File.Create(sciezka + "\\Regulamin.txt");
                    myFile.Close();
                    regulamin.Add("1. Oryginał zgłoszenia jest podstawą do wydania sprzętu z serwisu.");
                    regulamin.Add("2. Serwis nie odpowiada za ewentualne skutki wynikłe ze zgubienia druku zgłoszenia przez klienta.");
                    regulamin.Add("3. Serwis nie ponosi odpowiedzialności za dane pozostawione w pamięci urządzenia, mogą one zostać utracone w trakcie naprawy.");
                    regulamin.Add("4. Serwis diagnozuje i naprawia sprzęt pod kątem usterek zgłoszonych przez klienta.");
                    regulamin.Add("5. W sytuacji nie odebrania sprzętu przez klienta w terminie 30 dni będą naliczane koszty magazynowania w wysokości 1% wartości naprawy za każdy dzień zwłoki.");
                    regulamin.Add("6. Na naprawy po zalaniu nie udzielamy gwarancji.");
                    regulamin.Add("7. Ze względu na specyfikę uszkodzeń telefonów po zalaniu, serwis nie ponosi odpowiedzialności za usterki postępujące w trakcie naprawy.");
                    regulamin.Add("8. Klient zgłaszając telefon do serwisu akceptuje powyższy regulamin.");
                    regulamin.Add("9. Uprzedzony o odpowiedzialności karnej wynikającej z art. 233 Kodeksu Karnego za składanie fałszywych oświadczeń, zleceniodawca oświadcza, że przedmiot wymieniny w rubryce SPRZĘT nie pochodzi z przestępstwa.");
                    regulamin.Add("10. Zleceniodawca oświadcza, że jeżeli okaże się, że przedmiot oddany do serwisu pochodził z kradzieży bierze na siebie całą odpowiedzialność, zwalniając Serwis z odpowiedzialności.");
                }
            }
            else
            {
                Directory.CreateDirectory(sciezka);
            }
        }

        public int GetFreeIdProduktu()
        {
            int licznik = 1;
            bool wystepuje = false;
            while (wystepuje == false)
            {
                if (listaProduktow.Count() == 0)
                {
                    wystepuje = true;
                }
                else
                {
                    for (int i = 0; i < listaProduktow.Count; i++)
                    {
                        if (listaProduktow[i].Id == licznik)
                        {
                            wystepuje = false;
                            break;
                        }
                        else
                        {
                            wystepuje = true;
                        }
                    }
                }
                if (!wystepuje)
                {
                    licznik++;
                }
            }
            return licznik;
        }

        public int GetFreeIdUsterek()
        {
            int licznik = 1;
            bool wystepuje = false;
            while (wystepuje == false)
            {
                if (listaUsterek.Count() == 0)
                {
                    wystepuje = true;
                }
                else
                {
                    for (int i = 0; i < listaUsterek.Count; i++)
                    {
                        if (listaUsterek[i].ID == licznik)
                        {
                            wystepuje = false;
                            break;
                        }
                        else
                        {
                            wystepuje = true;
                        }
                    }
                }
                if (!wystepuje)
                {
                    licznik++;
                }
            }
            return licznik;
        }

        public int GetFreeIdAkcesoriow()
        {
            int licznik = 1;
            bool wystepuje = false;
            while (wystepuje == false)
            {
                if (listaAkcesoriow.Count() == 0)
                {
                    wystepuje = true;
                }
                else
                {
                    for (int i = 0; i < listaAkcesoriow.Count; i++)
                    {
                        if (listaAkcesoriow[i].Id == licznik)
                        {
                            wystepuje = false;
                            break;
                        }
                        else
                        {
                            wystepuje = true;
                        }
                    }
                }
                if (!wystepuje)
                {
                    licznik++;
                }
            }
            return licznik;
        }

        #region Sekcje
        private void btProdukty_Click(object sender, EventArgs e)
        {
            SekcjaProduktow produkty = new SekcjaProduktow(this);
            produkty.Show(this);
            this.Enabled = false;
        }

        private void btAkcesoria_Click(object sender, EventArgs e)
        {
            SekcjaAkcesoriow akcesoria = new SekcjaAkcesoriow(this);
            akcesoria.Show(this);
            this.Enabled = false;
        }

        private void btSerwis_Click(object sender, EventArgs e)
        {
            SekcjaSerwisu serwis = new SekcjaSerwisu(this);
            serwis.Show();
            this.Enabled = false;
        }

        private void btnRaporty_Click(object sender, EventArgs e)
        {
            SekcjaRaportow raporty = new SekcjaRaportow(this);
            raporty.Show(this);
            this.Enabled = false;
        }
        #endregion

        #region Przypominacz
        private void Przypominacz()
        {
            List<string> wynik = new List<string>();
            try
            {
                for (int i = 0; i < listaUsterek.Count(); i++)
                {
                    DateTime now = DateTime.Today;
                    //dateTimePicker1.Value = now.AddDays(2);
                    TimeSpan ts = now - Convert.ToDateTime(listaUsterek[i].DataRealizacji);
                    if (ts.Days > 2 && listaUsterek[i].Odbior == "NIE" && listaUsterek[i].Status != "Brak możliwości naprawy")
                    {
                        if (listaUsterek[i].Uwagi.Contains("Pilne"))
                        {
                            wynik.Add((listaUsterek[i].Model + " : " + listaUsterek[i].Nazwisko + " - PILNE ").ToUpper());
                        }
                    }
                }
                for (int i = 0; i < listaUsterek.Count(); i++)
                {
                    DateTime now = DateTime.Today;
                    //dateTimePicker1.Value = now.AddDays(2);
                    TimeSpan ts = now - Convert.ToDateTime(listaUsterek[i].DataRealizacji);
                    if (ts.Days > 2 && listaUsterek[i].Odbior == "NIE" && listaUsterek[i].Status != "Brak możliwości naprawy" && listaUsterek[i].Status != "Naprawiony")
                    {
                        if (!listaUsterek[i].Uwagi.Contains("Pilne"))
                        {
                            wynik.Add(listaUsterek[i].Model + " : " + listaUsterek[i].Nazwisko);
                        }
                    }
                }
                if (wynik.Count() > 0)
                {
                    //ShowRichMessageBox("Usterki przeterminowane", result);
                    Przypominacz nowy = new Przypominacz(wynik);
                    nowy.Show(this);
                }
            }
            catch
            {

            }
        }

        private void ShowRichMessageBox(string title, string message)
        {
            RichTextBox rtbMessage = new RichTextBox();
            rtbMessage.Text = message;
            rtbMessage.Dock = DockStyle.Fill;
            rtbMessage.ReadOnly = true;
            Form RichMessageBox = new Form();
            RichMessageBox.Text = title;
            RichMessageBox.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Underline);
            RichMessageBox.StartPosition = FormStartPosition.CenterScreen;
            RichMessageBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            RichMessageBox.Controls.Add(rtbMessage);
            RichMessageBox.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Przypominacz();
        }
        #endregion

        public void generujRaport()
        {
            int przyjete = 0, gwarancja = 0, czesci = 0, decyzja = 0, naprawione = 0, popsute = 0;
            double urzadzenia = 0, akcesoria = 0;
            try
            {
                foreach (Usterka ust in listaUsterek)
                {
                    if (ust.Odbior == "NIE")
                    {
                        switch (ust.Status)
                        {
                            case "Naprawiony":
                                naprawione++;
                                break;
                            case "Brak możliwości naprawy":
                                popsute++;
                                break;
                            case "Wysłane na gwarancję":
                                gwarancja++;
                                break;
                            case "Przyjęty do naprawy":
                                przyjete++;
                                break;
                            case "Czeka na części":
                                czesci++;
                                break;
                            case "Czeka na decyzje klienta":
                                decyzja++;
                                break;
                        }
                    }
                }

                foreach (Produkt prod in listaProduktow)
                {
                    if (prod.Dostepny == "TAK")
                    {
                        urzadzenia = urzadzenia + (double.Parse(prod.CenaZakupu, System.Globalization.CultureInfo.InvariantCulture) * (double)prod.Ilosc);
                    }
                }

                foreach (Czesc cz in listaAkcesoriow)
                {
                    if (cz.Dostepny == "TAK")
                    {
                        akcesoria += double.Parse(cz.CenaZakupu, System.Globalization.CultureInfo.InvariantCulture) * (double)cz.Ilosc;
                    }
                }

                lblCzesci.Text = "Oczekuje na części: " + czesci.ToString() + " szt.";
                lblDecyzja.Text = "Oczekuje na decyzję klienta: " + decyzja.ToString() + " szt.";
                lblGwarancja.Text = "Wysłane na gwarancję: " + gwarancja.ToString() + " szt.";
                lblNaprawione.Text = "Naprawione: " + naprawione.ToString() + " szt.";
                lblPopsute.Text = "Brak możliwości naprawy: " + popsute.ToString() + " szt.";
                lblPrzyjete.Text = "Przyjęte do naprawy: " + przyjete.ToString() + " szt.";
                lblSprzedaz.Text = "Wartość rzeczy na stanie: " + urzadzenia.ToString() + " zł.";
                lblAkcesoria.Text = "Wartość części na stanie: " + akcesoria.ToString() + " zł.";
            }
            catch
            {

            }
        }

        private void DaneOFirmie_Click(object sender, EventArgs e)
        {
            FirmaDane f = new FirmaDane(this, firma);
            f.Show(this);
        }

        private void Glowna_FormClosing(object sender, FormClosingEventArgs e)
        {
            nadpiszAkcesoria();
            nadpiszProdukty();
            nadpiszUsterki();
        }

        private void regulaminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regulamin reg = new Regulamin(this);
            reg.Show(this);
        }

        private void raportStanuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            indeks = 0;
            if (listaProduktow.Count > 0)
            {
                try
                {
                    System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                    pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
                    //printPreviewDialog1.Document = pd;  // psuje drukowanie - tylko pierwsza strona wychodzi
                    //printPreviewDialog1.ShowDialog();

                    if (printDialog1.ShowDialog() == DialogResult.OK)
                        pd.Print();
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Brak listów do wydruku!");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (listaProduktow.Count() > 0)
            {
                List<Produkt> listatemp = new List<Produkt>();
                for (int j = 0; j < listaProduktow.Count; j++)
                {
                    if (listaProduktow[j].Dostepny == "TAK")
                    {
                        listatemp.Add(listaProduktow[j]);
                    }
                }
                Font font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
                int i = 0;
                Font font1 = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                Font font2 = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
                Font font3 = new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold);
                e.Graphics.DrawString("Raport rzeczy będących na stanie - " + DateTime.Today.ToShortDateString(), font3, Brushes.Black, new Point(130, 60));

                RectangleF[] rects = 
            {
                new RectangleF(40,90,30,40), //lp
                new RectangleF(70,90,90,40), //nazwa
                new RectangleF(160,90,110,40), // numer seryjny
                new RectangleF(270,90,140,40), // wyposazenie
                new RectangleF(410,90,90,40), // cena
                new RectangleF(500,90,90,40), //data
                new RectangleF(590,90,210,40) //uwagi
            };
                e.Graphics.DrawRectangles(new Pen(Brushes.Black, 1), rects);
                e.Graphics.DrawString("Lp.", font1, Brushes.Black, new Point(42, 95));
                e.Graphics.DrawString("Nazwa", font1, Brushes.Black, new Point(72, 95));
                e.Graphics.DrawString("Numer Seryjny", font1, Brushes.Black, new Point(162, 95));
                e.Graphics.DrawString("Wyposażenie", font1, Brushes.Black, new Point(272, 95));
                e.Graphics.DrawString("Cena kupna", font1, Brushes.Black, new Point(412, 95));
                e.Graphics.DrawString("Data kupna", font1, Brushes.Black, new Point(502, 95));
                e.Graphics.DrawString("Uwagi", font1, Brushes.Black, new Point(592, 95));
                while (indeks < listatemp.Count())
                {
                    RectangleF[] rectangles = 
                {
                    new RectangleF(40,130+40*i,30,40), //lp
                    new RectangleF(70,130+40*i,90,40), //nazwa
                    new RectangleF(160,130+40*i,110,40), // numer seryjny
                    new RectangleF(270,130+40*i,140,40), // wyposazenie
                    new RectangleF(410,130+40*i,90,40), // cena
                    new RectangleF(500,130+40*i,90,40), //data
                    new RectangleF(590,130+40*i,210,40) //uwagi
                };
                    e.Graphics.DrawRectangles(new Pen(Brushes.Black, 1), rectangles);
                    e.Graphics.DrawString((indeks + 1).ToString(), font2, Brushes.Black, new Point(42, 135 + 40 * i));
                    e.Graphics.DrawString(listatemp[indeks].Nazwa, font2, Brushes.Black, new Rectangle(72, 135 + 40 * i, 85, 35));
                    e.Graphics.DrawString(listatemp[indeks].NumerSeryjny.ToString(), font2, Brushes.Black, new Rectangle(162, 135 + 40 * i, 105, 35));
                    e.Graphics.DrawString(listatemp[indeks].Wyposazenie, font2, Brushes.Black, new Rectangle(272, 135 + 40 * i, 135, 35));
                    e.Graphics.DrawString(listatemp[indeks].CenaZakupu + "zł " + "[" + listatemp[indeks].Ilosc + "szt.]", font2, Brushes.Black, new Rectangle(412, 135 + 40 * i, 85, 35));
                    e.Graphics.DrawString(listatemp[indeks].DataZakupu, font2, Brushes.Black, new Point(502, 135 + 40 * i));
                    e.Graphics.DrawString(listatemp[indeks].Uwagi, font2, Brushes.Black, new Rectangle(592, 135 + 40 * i, 205, 35));
                    indeks++;
                    if (i < 24)
                    {
                        i++;
                    }
                    else
                    {
                        i = 0;
                        e.HasMorePages = true;
                        return;
                    }

                }
                e.HasMorePages = false;
            }
        }


        private void generujWydruk(System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Produkt> listatemp = new List<Produkt>();
            for (int j = 0; j < listaProduktow.Count; j++)
            {
                if (listaProduktow[j].Dostepny == "TAK")
                {
                    listatemp.Add(listaProduktow[j]);
                }
            }
            Font font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            int i = 0;
            Font font1 = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            Font font2 = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            Font font3 = new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold);
            e.Graphics.DrawString("Raport rzeczy będących na stanie - " + DateTime.Today.ToShortDateString(), font3, Brushes.Black, new Point(130, 60));

            RectangleF[] rects = 
            {
                new RectangleF(40,90,30,40), //lp
                new RectangleF(70,90,90,40), //nazwa
                new RectangleF(160,90,110,40), // numer seryjny
                new RectangleF(270,90,140,40), // wyposazenie
                new RectangleF(410,90,90,40), // cena
                new RectangleF(500,90,90,40), //data
                new RectangleF(590,90,210,40) //uwagi
            };
            e.Graphics.DrawRectangles(new Pen(Brushes.Black, 1), rects);
            e.Graphics.DrawString("Lp.", font1, Brushes.Black, new Point(42, 95));
            e.Graphics.DrawString("Nazwa", font1, Brushes.Black, new Point(72, 95));
            e.Graphics.DrawString("Numer Seryjny", font1, Brushes.Black, new Point(162, 95));
            e.Graphics.DrawString("Wyposażenie", font1, Brushes.Black, new Point(272, 95));
            e.Graphics.DrawString("Cena kupna", font1, Brushes.Black, new Point(412, 95));
            e.Graphics.DrawString("Data kupna", font1, Brushes.Black, new Point(502, 95));
            e.Graphics.DrawString("Uwagi", font1, Brushes.Black, new Point(592, 95));
            while (indeks < listatemp.Count())
            {
                RectangleF[] rectangles = 
                {
                    new RectangleF(40,130+40*i,30,40), //lp
                    new RectangleF(70,130+40*i,90,40), //nazwa
                    new RectangleF(160,130+40*i,110,40), // numer seryjny
                    new RectangleF(270,130+40*i,140,40), // wyposazenie
                    new RectangleF(410,130+40*i,90,40), // cena
                    new RectangleF(500,130+40*i,90,40), //data
                    new RectangleF(590,130+40*i,210,40) //uwagi
                };
                e.Graphics.DrawRectangles(new Pen(Brushes.Black, 1), rectangles);
                e.Graphics.DrawString((indeks + 1).ToString(), font2, Brushes.Black, new Point(42, 135 + 40 * i));
                e.Graphics.DrawString(listatemp[indeks].Nazwa, font2, Brushes.Black, new Rectangle(72, 135 + 40 * i, 85, 35));
                e.Graphics.DrawString(listatemp[indeks].NumerSeryjny.ToString(), font2, Brushes.Black, new Rectangle(162, 135 + 40 * i, 105, 35));
                e.Graphics.DrawString(listatemp[indeks].Wyposazenie, font2, Brushes.Black, new Rectangle(272, 135 + 40 * i, 135, 35));
                e.Graphics.DrawString(listatemp[indeks].CenaZakupu + "zł " + "[" + listatemp[indeks].Ilosc + "szt.]", font2, Brushes.Black, new Rectangle(412, 135 + 40 * i, 85, 35));
                e.Graphics.DrawString(listatemp[indeks].DataZakupu, font2, Brushes.Black, new Point(502, 135 + 40 * i));
                e.Graphics.DrawString(listatemp[indeks].Uwagi, font2, Brushes.Black, new Rectangle(592, 135 + 40 * i, 205, 35));
                indeks++;
                if (i < 24)
                {
                    i++;
                }
                else
                {
                    i = 0;
                    e.HasMorePages = true;
                    return;
                }

            }
            e.HasMorePages = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ZapiszWczytaj();
        }

        private void ZapiszWczytaj()
        {
            nadpiszAkcesoria();
            nadpiszFirme();
            nadpiszProdukty();
            nadpiszRegulamin();
            nadpiszUstawienia();
            nadpiszUsterki();
            wczytajPliki();
        }

        private void trescSmsToolStrip_Click(object sender, EventArgs e)
        {
            TrescSMS sms = new TrescSMS(this);
            sms.Show(this);
        }


    }
}
