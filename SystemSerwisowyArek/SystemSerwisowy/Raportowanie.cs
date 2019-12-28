using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SystemSerwisowy
{
    public partial class Raportowanie : Form
    {
        SekcjaProduktow produkt;
        public Raportowanie(SekcjaProduktow p)
        {
            produkt = p;
            InitializeComponent();
            dtpMiesieczny.Format = DateTimePickerFormat.Custom;
            dtpMiesieczny.CustomFormat = "MMMM yyyy";
            rbDzienny.Checked = true;
            rbKupione.Checked = true;

        }

        private void Raportowanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            produkt.Enabled = true;
            produkt.Focus();
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            tbRaport.Text = "";
            if (rbKupione.Checked)
            {
                // Raport zakupów
                List<zakup> listaZakupow = new List<zakup>();
                double SumaZakupow = 0;
                if (rbDzienny.Checked)
                {
                    tbRaport.AppendText("Raport kupionych rzeczy dla dnia: " + dtpDzienny.Value.ToShortDateString() + Environment.NewLine);
                    DateTime dateWybranaData = dtpDzienny.Value;
                    foreach (Produkt prod in produkt.glowna.listaProduktow)
                    {
                        if (Convert.ToDateTime(prod.DataZakupu).ToShortDateString() == dateWybranaData.ToShortDateString())
                        {
                            listaZakupow.Add(new zakup(prod.Nazwa, prod.CenaZakupu));
                            SumaZakupow += Convert.ToDouble(prod.CenaZakupu);
                        }
                    }
                }
                else if (rbMiesieczny.Checked)
                {
                    string miesiac = Thread.CurrentThread.CurrentCulture.DateTimeFormat.MonthNames[dtpMiesieczny.Value.Month - 1];
                    tbRaport.AppendText("Raport kupionych rzeczy w miesiącu " + miesiac.ToUpper() + Environment.NewLine);
                    DateTime dateWybranaData = dtpMiesieczny.Value;
                    foreach (Produkt prod in produkt.glowna.listaProduktow)
                    {
                        if (Convert.ToDateTime(prod.DataZakupu).Month == dateWybranaData.Month)
                        {
                            listaZakupow.Add(new zakup(prod.Nazwa, prod.CenaZakupu));
                            SumaZakupow += Convert.ToDouble(prod.CenaZakupu);
                        }
                    }
                }
                else if (rbZakres.Checked)
                {
                    DateTime dateDataOd = dtpOd.Value;
                    DateTime dateDataDo = dtpDo.Value;
                    if (Convert.ToDateTime(dateDataDo.ToShortDateString()) < Convert.ToDateTime(dateDataOd.ToShortDateString()))
                    {
                        tbRaport.Text = "";
                        MessageBox.Show("Wprowadź poprawny zakres dat");
                        return;
                    }
                    tbRaport.AppendText("Raport kupionych rzeczy od: " + dateDataOd.ToShortDateString()+ " do:" + dateDataDo.ToShortDateString() + Environment.NewLine);
                    foreach (Produkt prod in produkt.glowna.listaProduktow)
                    {
                        if (Convert.ToDateTime(prod.DataZakupu) >= Convert.ToDateTime(dateDataOd.ToShortDateString()) && Convert.ToDateTime(prod.DataZakupu) <= Convert.ToDateTime(dateDataDo.ToShortDateString()))
                        {
                            listaZakupow.Add(new zakup(prod.Nazwa, prod.CenaZakupu));
                            SumaZakupow += Convert.ToDouble(prod.CenaZakupu);
                        }
                    }
                }
                int ilosc = 0;
                foreach (zakup item in listaZakupow)
                {
                    ilosc++;
                    tbRaport.AppendText(ilosc + ". " +item.Nazwa + " " + item.Cena + " zł" + Environment.NewLine);

                }
                tbRaport.AppendText("Ilość: "+ilosc +";   Suma: " + SumaZakupow + " zł");
            }
            else
            {
                // Raport sprzedaży
                List<zakup> listaZakupow = new List<zakup>();
                double SumaZakupow = 0;
                if (rbDzienny.Checked)
                {
                    tbRaport.AppendText("Raport sprzedanych rzeczy dla dnia: " + dtpDzienny.Value.ToShortDateString() + Environment.NewLine);
                    DateTime dateWybranaData = dtpDzienny.Value;
                    foreach (Produkt prod in produkt.glowna.listaProduktow)
                    {
                        if (prod.DataSprzedazy != "")
                        {
                            if (Convert.ToDateTime(prod.DataSprzedazy).ToShortDateString() == dateWybranaData.ToShortDateString())
                            {
                                listaZakupow.Add(new zakup(prod.Nazwa, prod.CenaZakupu));
                                SumaZakupow += Convert.ToDouble(prod.CenaZakupu);
                            }
                        }

                    }
                }
                else if (rbMiesieczny.Checked)
                {
                    string miesiac = Thread.CurrentThread.CurrentCulture.DateTimeFormat.MonthNames[dtpMiesieczny.Value.Month - 1];
                    tbRaport.AppendText("Raport sprzedanych rzeczy w miesiącu " + miesiac.ToUpper() + Environment.NewLine);
                    DateTime dateWybranaData = dtpMiesieczny.Value;
                    foreach (Produkt prod in produkt.glowna.listaProduktow)
                    {
                        if (prod.DataSprzedazy != "")
                        {
                            if (Convert.ToDateTime(prod.DataSprzedazy).Month == dateWybranaData.Month)
                            {
                                listaZakupow.Add(new zakup(prod.Nazwa, prod.CenaZakupu));
                                SumaZakupow += Convert.ToDouble(prod.CenaZakupu);
                            }
                        }
                    }
                }
                else if (rbZakres.Checked)
                {
                    DateTime dateDataOd = dtpOd.Value;
                    DateTime dateDataDo = dtpDo.Value;
                    if (Convert.ToDateTime(dateDataDo.ToShortDateString()) < Convert.ToDateTime(dateDataOd.ToShortDateString()))
                    {
                        tbRaport.Text = "";
                        MessageBox.Show("Wprowadź poprawny zakres dat");
                        return;
                    }
                    tbRaport.AppendText("Raport sprzedanych rzeczy od: " + dateDataOd.ToShortDateString() + " do:" + dateDataDo.ToShortDateString() + Environment.NewLine);
                    foreach (Produkt prod in produkt.glowna.listaProduktow)
                    {
                        if (prod.DataSprzedazy != "")
                        {
                            if (Convert.ToDateTime(prod.DataSprzedazy) >= Convert.ToDateTime(dateDataOd.ToShortDateString()) && Convert.ToDateTime(prod.DataZakupu) <= Convert.ToDateTime(dateDataDo.ToShortDateString()))
                            {
                                listaZakupow.Add(new zakup(prod.Nazwa, prod.CenaZakupu));
                                SumaZakupow += Convert.ToDouble(prod.CenaZakupu);
                            }
                        }
                    }
                }
                int ilosc = 0;
                foreach (zakup item in listaZakupow)
                {
                    ilosc++;
                    tbRaport.AppendText(ilosc + ". " + item.Nazwa + " " + item.Cena + " zł" + Environment.NewLine);

                }
                tbRaport.AppendText("Ilość: " + ilosc + ";   Suma: " + SumaZakupow + " zł");
            }
            
        }

        private void Raportowanie_Load(object sender, EventArgs e)
        {

        }
    }

    class zakup
    {
        public string Nazwa { get; set; }
        public string Cena { get; set; }

        public zakup()
        {
        }

        public zakup(string naz, string cen)
        {
            Nazwa = naz;
            Cena = cen;
        }
    }
}
