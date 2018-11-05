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
    public partial class SprzedajAkcesoria : Form
    {
        SekcjaAkcesoriow produkt;
        Czesc temp;
        int ind;
        public SprzedajAkcesoria(SekcjaAkcesoriow a, int indeks)
        {
            produkt = a;
            InitializeComponent();
            temp = produkt.glowna.listaAkcesoriow[indeks];
            tbNazwa.Text = temp.Nazwa;
            nudIlosc.Maximum = temp.Ilosc;
            ind = indeks;
        }

        private void btSprzedaj_Click(object sender, EventArgs e)
        {
            string cena = tbCena.Text;
            cena.Replace(',', '.');
            double wart;
            if (cena != "")
            {
                if (double.TryParse(cena, out wart))
                {
                    if (produkt.glowna.listaAkcesoriow[ind].Ilosc == nudIlosc.Value)
                    {
                        produkt.glowna.listaAkcesoriow[ind].Dostepny = "NIE";
                        produkt.glowna.listaAkcesoriow[ind].Ilosc = 0;
                    }
                    else
                    {
                        produkt.glowna.listaAkcesoriow[ind].Ilosc = produkt.glowna.listaAkcesoriow[ind].Ilosc - (int)nudIlosc.Value;
                    }
                    double result;
                    if (double.TryParse(produkt.glowna.listaAkcesoriow[ind].CenaSprzedazy, out result))
                    {
                        produkt.glowna.listaAkcesoriow[ind].CenaSprzedazy = (result + wart).ToString();
                    }
                    else
                    {
                        produkt.glowna.listaAkcesoriow[ind].CenaSprzedazy = wart.ToString();
                    }
                    produkt.glowna.nadpiszAkcesoria();
                    Close();
                    produkt.Enabled = true;
                    produkt.Focus();
                    produkt.AktualizujGrida();

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
            produkt.Focus();
            produkt.AktualizujGrida();
        }

        private void SprzedajAkcesoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            produkt.Enabled = true;
            produkt.Focus();
        }
    }
}
