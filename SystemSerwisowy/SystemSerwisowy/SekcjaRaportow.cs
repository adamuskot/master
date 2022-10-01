using System;
using System.Collections.Generic;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Diagnostics;

namespace SystemSerwisowy
{
    public partial class SekcjaRaportow : Form
    {
        public Glowna glowna;
        private int indeks = 0;
        public SekcjaRaportow(Glowna g)
        {
            glowna = g;
            InitializeComponent();
        }

        private void SekcjaRaportow_FormClosing(object sender, FormClosingEventArgs e)
        {
            glowna.Enabled = true;
            glowna.Focus();
            glowna.generujRaport();
        }

        private void btZamknij_Click(object sender, EventArgs e)
        {
            Close();
            glowna.Enabled = true;
            glowna.Focus();
            glowna.generujRaport();
        }

        private void btRaportSerwisu_Click(object sender, EventArgs e)
        {
            try
            {
                if (chBLStatusy.CheckedItems.Count > 0)
                {
                    indeks = 0;
                    System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                    pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocumentSerwis_PrintPage);
                    //printPreviewDialogSerwis.Document = pd;  // psuje drukowanie - tylko pierwsza strona wychodzi
                    //printPreviewDialogSerwis.ShowDialog();

                    if (printDialogSerwis.ShowDialog() == DialogResult.OK)
                        pd.Print();

                }
                else
                {
                    MessageBox.Show("Nie wybrano żadnego statusu.");
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd podczas generowania wydruku.");
            }

        }

        private void printDocumentSerwis_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            List<Usterka> listaDoRaportu = new List<Usterka>();

            for (int i = 0; i < glowna.listaUsterek.Count(); i++)
            {
                DateTime now = DateTime.Today;
                //dateTimePicker1.Value = now.AddDays(2);
                var dat = DateTime.Parse(glowna.listaUsterek[i].DataRealizacji);
                TimeSpan ts = now - dat;
                if (ts.Days > 2 && glowna.listaUsterek[i].Odbior == "NIE" && glowna.listaUsterek[i].Status != "Brak możliwości naprawy")
                {
                    if (glowna.listaUsterek[i].Uwagi.Contains("Pilne"))
                    {
                        foreach (string item in chBLStatusy.CheckedItems)
                        {
                            if (item == glowna.listaUsterek[i].Status)
                            {
                                listaDoRaportu.Add(glowna.listaUsterek[i]);
                            }
                        }
                    }
                }
            }

            foreach (Usterka ust in glowna.listaUsterek)
            {
                if (ust.Odbior == "NIE")
                {
                    switch (ust.Status)
                    {
                        case "Przyjęty do naprawy":
                            if (chBLStatusy.CheckedItems.Contains("Przyjęty do naprawy"))
                            {
                                if (!listaDoRaportu.Contains(ust))
                                {
                                    listaDoRaportu.Add(ust);
                                }
                            }
                            break;
                        case "Wysłane na gwarancję":
                            if (chBLStatusy.CheckedItems.Contains("Wysłane na gwarancję"))
                            {
                                if (!listaDoRaportu.Contains(ust))
                                {
                                    listaDoRaportu.Add(ust);
                                }
                            }
                            break;

                        case "Czeka na części":
                            if (chBLStatusy.CheckedItems.Contains("Czeka na części"))
                            {
                                if (!listaDoRaportu.Contains(ust))
                                {
                                    listaDoRaportu.Add(ust);
                                }
                            }
                            break;
                        case "Czeka na decyzje klienta":
                            if (chBLStatusy.CheckedItems.Contains("Czeka na decyzje klienta"))
                            {
                                if (!listaDoRaportu.Contains(ust))
                                {
                                    listaDoRaportu.Add(ust);
                                }
                            }
                            break;
                    }
                }
                else if (ust.Odbior == "TAK" && ust.DataOdbioru == dtpDataRaportuSerwisu.Value.ToShortDateString())
                {
                    switch (ust.Status)
                    {
                        case "Naprawiony":
                            if (chBLStatusy.CheckedItems.Contains("Oddany Naprawiony/Nienaprawiony"))
                            {
                                if (!listaDoRaportu.Contains(ust))
                                {
                                    listaDoRaportu.Add(ust);
                                }
                            }
                            break;
                        case "Brak możliwości naprawy":
                            if (chBLStatusy.CheckedItems.Contains("Oddany Naprawiony/Nienaprawiony"))
                            {
                                if (!listaDoRaportu.Contains(ust))
                                {
                                    listaDoRaportu.Add(ust);
                                }
                            }
                            break;
                    }
                }
            }
            if (listaDoRaportu.Count() > 0)
            {
                int i = 0;
                Font font1 = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
                Font font2 = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
                Font font3 = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
                e.Graphics.DrawString("Raport serwisowy - " + DateTime.Today.ToShortDateString(), font3, Brushes.Black, new Point(230, 20));
                string statusy = "Wybrane statusy:";
                for (int j = 0; j < chBLStatusy.CheckedItems.Count; j++)
                {
                    statusy += " " + chBLStatusy.CheckedItems[j] + ",";
                }
                e.Graphics.DrawString(statusy, font1, Brushes.Black, new Point(50, 50));
                RectangleF[] rects =
            {
                new RectangleF(20,70,30,40), //lp
                new RectangleF(50,70,90,40), //nazwisko
                new RectangleF(140,70,70,40), // telefon
                new RectangleF(210,70,55,40), // dni po terminie
                new RectangleF(265,70,80,40), // model
                new RectangleF(345,70,80,40), //numer seryjny
                new RectangleF(425,70,140,40), //opis
                new RectangleF(565,70,125,40), //uwagi
                new RectangleF(690,70,50,40), //koszt
                new RectangleF(740,70,70,40) //data zgłoszenia
            };
                e.Graphics.DrawRectangles(new Pen(Brushes.Black, 1), rects);
                e.Graphics.DrawString("Lp.", font1, Brushes.Black, new Point(22, 78));
                e.Graphics.DrawString("Nazwisko", font1, Brushes.Black, new Point(52, 78));
                e.Graphics.DrawString("Telefon", font1, Brushes.Black, new Point(142, 78));
                e.Graphics.DrawString("Dni po terminie", font1, Brushes.Black, new Rectangle(212, 78, 55, 35));
                e.Graphics.DrawString("Model", font1, Brushes.Black, new Point(267, 78));
                e.Graphics.DrawString("Numer seryjny", font1, Brushes.Black, new Rectangle(347, 78, 75, 35));
                e.Graphics.DrawString("Opis", font1, Brushes.Black, new Point(426, 78));
                e.Graphics.DrawString("Uwagi", font1, Brushes.Black, new Point(566, 78));
                e.Graphics.DrawString("Koszt", font1, Brushes.Black, new Point(691, 78));
                e.Graphics.DrawString("Data zgłoszenia", font1, Brushes.Black, new Rectangle(741, 78, 70, 35));
                while (indeks < listaDoRaportu.Count())
                {
                    RectangleF[] rectangles =
                    {
                        new RectangleF(20,110+40*i,30,40), //lp
                        new RectangleF(50,110+40*i,90,40), //nazwisko
                        new RectangleF(140,110+40*i,70,40), // telefon
                        new RectangleF(210,110+40*i,55,40), // Dni po terminie
                        new RectangleF(265,110+40*i,80,40), // model
                        new RectangleF(345,110+40*i,80,40), //NUmer seryjny
                        new RectangleF(425,110+40*i,140,40), //Opis
                        new RectangleF(565,110+40*i,125,40), //Uwagi
                        new RectangleF(690,110+40*i,50,40), //Koszt
                        new RectangleF(740,110+40*i,70,40) //Data zgłoszenia

                    };
                    e.Graphics.DrawRectangles(new Pen(Brushes.Black, 1), rectangles);
                    e.Graphics.DrawString((indeks + 1).ToString(), font2, Brushes.Black, new Point(22, 115 + 40 * i));
                    e.Graphics.DrawString(listaDoRaportu[indeks].Nazwisko, font2, Brushes.Black, new Rectangle(52, 115 + 40 * i, 87, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].Telefon, font2, Brushes.Black, new Rectangle(142, 115 + 40 * i, 67, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].DniPoTerminie.ToString(), font2, Brushes.Black, new Rectangle(212, 115 + 40 * i, 52, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].Model, font2, Brushes.Black, new Rectangle(267, 115 + 40 * i, 77, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].NumerSeryjny.ToString(), font2, Brushes.Black, new Rectangle(347, 115 + 40 * i, 77, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].Opis, font2, Brushes.Black, new Rectangle(426, 112 + 40 * i, 138, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].Uwagi, font2, Brushes.Black, new Rectangle(566, 112 + 40 * i, 123, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].Koszt, font2, Brushes.Black, new Rectangle(691, 115 + 40 * i, 48, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].DataZgloszenia, font2, Brushes.Black, new Rectangle(742, 115 + 40 * i, 67, 35));
                    indeks++;
                    if (i < 25)
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

        private void btRaportSprzedazy_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDataOdRaportuSprzedazy.Value != DateTime.MinValue)
                {
                    List<Produkt> listaDoRaportu = new List<Produkt>();
                    for (int i = 0; i < glowna.listaProduktow.Count(); i++)
                    {
                        
                        bool parsujDateSprzedazy = DateTime.TryParseExact(glowna.listaProduktow[i].DataSprzedazy, "dd.MM.yyyy",CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime dataSprzedazy);
                        if (parsujDateSprzedazy
                            && dataSprzedazy >= Convert.ToDateTime(dtpDataOdRaportuSprzedazy.Value.ToShortDateString()) 
                            && dataSprzedazy <= Convert.ToDateTime(dtpDataDoRaportuSprzedazy.Value.ToShortDateString()))
                        {
                            listaDoRaportu.Add(glowna.listaProduktow[i]);
                        }
                    }
                    if (listaDoRaportu.Count > 0)
                    {

                        indeks = 0;
                        System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                        pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocumentSprzedaz_PrintPage);
                        printPreviewDialogSprzedaz.Document = pd;  // psuje drukowanie - tylko pierwsza strona wychodzi
                        printPreviewDialogSprzedaz.ShowDialog();

                        //if (printDialogSprzedaz.ShowDialog() == DialogResult.OK)
                        //    pd.Print();
                    }
                    else
                    {
                        MessageBox.Show("W wybranym dniu nie dokonano sprzedaży.");
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano daty raportu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas generowania wydruku.");
            }
        }

        private void printDocumentSprzedaz_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Produkt> listaDoRaportu = new List<Produkt>();
            decimal Kwota = 0;
            decimal Dochod = 0;
            for (int i = 0; i < glowna.listaProduktow.Count(); i++)
            {
                bool parsujDateSprzedazy = DateTime.TryParseExact(glowna.listaProduktow[i].DataSprzedazy, "dd.MM.yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime dataSprzedazy);
                if (parsujDateSprzedazy
                    && dataSprzedazy >= Convert.ToDateTime(dtpDataOdRaportuSprzedazy.Value.ToShortDateString())
                    && dataSprzedazy <= Convert.ToDateTime(dtpDataDoRaportuSprzedazy.Value.ToShortDateString()))
                {
                    listaDoRaportu.Add(glowna.listaProduktow[i]);
                }
            }

            if (listaDoRaportu.Count() > 0)
            {
                int i = 0;
                Font font1 = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                Font font2 = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
                Font font3 = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
                if (dtpDataOdRaportuSprzedazy.Value != dtpDataDoRaportuSprzedazy.Value)
                {
                    e.Graphics.DrawString("Raport sprzedaży z zakresu " + dtpDataOdRaportuSprzedazy.Value.ToShortDateString() + " - " + dtpDataDoRaportuSprzedazy.Value.ToShortDateString(), font3, Brushes.Black, new Point(80, 40));

                }
                else
                {
                    e.Graphics.DrawString("Raport sprzedaży z dnia - " + dtpDataOdRaportuSprzedazy.Value.ToShortDateString(), font3, Brushes.Black, new Point(130, 40));
                }

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
                e.Graphics.DrawString("Numer Seryjny", font1, Brushes.Black, new Rectangle(162, 95, 105, 35));
                e.Graphics.DrawString("Wyposażenie", font1, Brushes.Black, new Point(272, 95));
                e.Graphics.DrawString("Cena sprzedaży", font1, Brushes.Black, new Rectangle(412, 95, 85, 35));
                e.Graphics.DrawString("Data sprzedaży", font1, Brushes.Black, new Rectangle(502, 95, 85, 35));
                e.Graphics.DrawString("Zysk", font1, Brushes.Black, new Point(592, 95));
                while (indeks < listaDoRaportu.Count())
                {
                    Kwota += Convert.ToDecimal(listaDoRaportu[indeks].CenaSprzedazy);
                    Dochod += Convert.ToDecimal(listaDoRaportu[indeks].CenaSprzedazy) - Convert.ToDecimal(listaDoRaportu[indeks].CenaZakupu);
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
                    e.Graphics.DrawString(listaDoRaportu[indeks].Nazwa, font2, Brushes.Black, new Rectangle(72, 135 + 40 * i, 85, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].NumerSeryjny.ToString(), font2, Brushes.Black, new Rectangle(162, 135 + 40 * i, 105, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].Wyposazenie, font2, Brushes.Black, new Rectangle(272, 135 + 40 * i, 135, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].CenaSprzedazy + "zł ", font2, Brushes.Black, new Rectangle(412, 135 + 40 * i, 85, 35));
                    e.Graphics.DrawString(listaDoRaportu[indeks].DataSprzedazy, font2, Brushes.Black, new Point(502, 135 + 40 * i));
                    e.Graphics.DrawString((Convert.ToDecimal(listaDoRaportu[indeks].CenaSprzedazy) - Convert.ToDecimal(listaDoRaportu[indeks].CenaZakupu)).ToString() + " zł", font2, Brushes.Black, new Rectangle(592, 135 + 40 * i, 205, 35));
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
                e.Graphics.DrawString("Kwota sprzedaży łącznie wynosi: " + Kwota.ToString() + " zł", font1, Brushes.Black, new Rectangle(50, 135 + (40 * i) + 30, 405, 35));
                e.Graphics.DrawString("Dochód ze sprzedaży wynosi: " + Dochod.ToString() + " zł", font1, Brushes.Black, new Rectangle(50, 135 + (40 * i) + 60, 405, 35));

                e.HasMorePages = false;
            }

        }

        private void btRaportStanu_Click(object sender, EventArgs e)
        {
            if (glowna.listaProduktow.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"C:\";
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.Title = "Zapisz Raport do:";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    try
                    {
                        Excel.Application ExcelApp = new Excel.Application();
                        //zapisuj.WriteLine("utworzenie excelapp");
                        Excel.Workbook ExcelWorkBook = null;
                        //zapisuj.WriteLine("utworzenieworkbook");
                        Excel.Worksheet ExcelWorkSheet = null;

                        //zapisuj.WriteLine("utworzenie worksheet");


                        ExcelApp.Visible = true;

                        ExcelWorkBook = ExcelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);


                        //zapisuj.WriteLine("Przed zapisem danych");
                        ExcelWorkSheet = ExcelWorkBook.Worksheets[1];
                        int i = 2;
                        ExcelWorkSheet.Cells[1, 1] = "LP.";
                        ExcelWorkSheet.Cells[1, 2] = "Nazwa";
                        ExcelWorkSheet.Cells[1, 3] = "Numer seryjny";
                        ExcelWorkSheet.Cells[1, 4] = "Wyposażenie";
                        ExcelWorkSheet.Cells[1, 5] = "Cena kupna";
                        ExcelWorkSheet.Cells[1, 6] = "Data kupna";
                        ExcelWorkSheet.Cells[1, 7] = "Uwagi";
                        ExcelWorkSheet.Cells[1, 8] = "Kategoria";

                        foreach (Produkt item in glowna.listaProduktow)
                        {
                            if (item.Dostepny == "TAK")
                            {
                                ExcelWorkSheet.Cells[i, 1] = i - 1;
                                ExcelWorkSheet.Cells[i, 2] = item.Nazwa;
                                ExcelWorkSheet.Cells[i, 3] = item.NumerSeryjny;
                                ExcelWorkSheet.Cells[i, 4] = item.Wyposazenie;
                                ExcelWorkSheet.Cells[i, 5] = item.CenaZakupu;
                                ExcelWorkSheet.Cells[i, 6] = item.DataZakupu;
                                ExcelWorkSheet.Cells[i, 7] = item.Uwagi;
                                ExcelWorkSheet.Cells[i, 8] = item.Kategoria;

                                i++;
                            }
                        }

                        ExcelWorkBook.Worksheets[1].Name = "Raport stanu";
                        ExcelWorkBook.SaveAs(path);
                        //zapisuj.WriteLine("po zapisie workbook");

                        ExcelWorkBook.Close();

                        ExcelApp.Quit();
                        MessageBox.Show("Raport zapisano pomyślnie w: " + saveFileDialog.FileName);
                    }

                    catch (Exception)
                    {
                        //zapisuj.WriteLine("exception:" + exHandle);
                    }

                    finally
                    {
                        //zapisuj.WriteLine("Koniec");
                        //zapisuj.Close();


                        foreach (Process process in Process.GetProcessesByName("Excel"))
                        {
                            process.Kill();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Brak produktów do wydruku!");
            }
        }


    }
}
