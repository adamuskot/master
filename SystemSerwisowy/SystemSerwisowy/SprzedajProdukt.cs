using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemSerwisowy
{
    public partial class SprzedajProdukt : Form
    {
        SekcjaProduktow produkt;
        Produkt temp;
        int ind;
        public SprzedajProdukt(SekcjaProduktow p, int indeks)
        {
            produkt=p;
            InitializeComponent();
            temp = produkt.glowna.listaProduktow[indeks];
            tbNazwa.Text = temp.Nazwa;
            tbNumer.Text = temp.NumerSeryjny;
            tbDataOd.Text = temp.DataZakupu;
            tbNaprawy.Text = temp.WykonaneNaprawy;
            tbUwagi.Text = temp.Uwagi;
            //nudIlosc.Maximum = temp.Ilosc;
            tbCenaZakupu.Text = temp.CenaZakupu;
            ind = indeks;
        }

        private void btSprzedaj_Click(object sender, EventArgs e)
        {
            string cena = tbCenaSprzedazy.Text;
            cena.Replace(',', '.');
            double wart;
            if (cena != "")
            {
                if (double.TryParse(cena, out wart))
                {
                    if (nudIlosc.Value <= temp.Ilosc)
                    {
                        produkt.glowna.listaProduktow[ind].DataSprzedazy = DateTime.Now.ToShortDateString();
                        produkt.glowna.listaProduktow[ind].Nazwa = tbNazwa.Text;
                        produkt.glowna.listaProduktow[ind].NumerSeryjny = tbNumer.Text;
                        produkt.glowna.listaProduktow[ind].CenaZakupu = tbCenaZakupu.Text;
                        produkt.glowna.listaProduktow[ind].WykonaneNaprawy = tbNaprawy.Text;
                        produkt.glowna.listaProduktow[ind].Uwagi = tbUwagi.Text;
                        if (tbGwarancja.Text != "")
                        {
                            produkt.glowna.listaProduktow[ind].Uwagi += " Gwarancja " + tbGwarancja.Text;
                        }
                        if (produkt.glowna.listaProduktow[ind].Ilosc == nudIlosc.Value)
                        {
                            produkt.glowna.listaProduktow[ind].Dostepny = "NIE";
                            produkt.glowna.listaProduktow[ind].Ilosc = 0;
                        }
                        else
                        {
                            produkt.glowna.listaProduktow[ind].Ilosc = produkt.glowna.listaProduktow[ind].Ilosc - (int)nudIlosc.Value;
                        }
                        double result;
                        if (double.TryParse(produkt.glowna.listaProduktow[ind].CenaSprzedazy, out result))
                        {
                            produkt.glowna.listaProduktow[ind].CenaSprzedazy = (result + wart).ToString();
                        }
                        else
                        {
                            produkt.glowna.listaProduktow[ind].CenaSprzedazy = wart.ToString();
                        }
                        produkt.glowna.nadpiszProdukty();
                        Close();
                        produkt.Enabled = true;
                        produkt.AktualizujGrida();
                        produkt.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Podano zbyt dużą ilość!");
                    }

                }
                else
                {
                    MessageBox.Show("Błędna wartość ceny!");
                }
            }
            else
            {
                MessageBox.Show("Podaj cenę sprzedaży!");
            }
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            produkt.Enabled = true;
            produkt.AktualizujGrida();
            produkt.Focus();
        }

        private void SprzedajProdukt_FormClosing(object sender, FormClosingEventArgs e)
        {
            produkt.Enabled = true;
            produkt.Focus();
        }

        private void btZapisz_Click(object sender, EventArgs e)
        {
            produkt.glowna.listaProduktow[ind].DataZakupu = tbDataOd.Text;
            produkt.glowna.listaProduktow[ind].Nazwa = tbNazwa.Text;
            produkt.glowna.listaProduktow[ind].NumerSeryjny = tbNumer.Text;
            string cena = tbCenaZakupu.Text;
            cena.Replace(',', '.');
            produkt.glowna.listaProduktow[ind].CenaZakupu = cena;
            produkt.glowna.listaProduktow[ind].Ilosc = (int)nudIlosc.Value;
            produkt.glowna.listaProduktow[ind].WykonaneNaprawy = tbNaprawy.Text;
            produkt.glowna.listaProduktow[ind].Uwagi = tbUwagi.Text;
            produkt.glowna.nadpiszProdukty();
            Close();
            produkt.Enabled = true;
            produkt.AktualizujGrida();
            produkt.Focus();
        }
    }
}
