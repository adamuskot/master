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
            InitializeComponent();
            produkt=p;
            cbKategorie.DataSource = p.glowna.kategorieProduktow;
            temp = produkt.glowna.listaProduktow[indeks];
            tbNazwa.Text = temp.Nazwa;
            tbNumer.Text = temp.NumerSeryjny;
            tbDataOd.Text = temp.DataZakupu;
            tbWyposazenie.Text = temp.Wyposazenie;
            tbUwagi.Text = temp.Uwagi;
            nudIlosc.Value = temp.Ilosc;
            tbCenaZakupu.Text = temp.CenaZakupu;
            if (cbKategorie.Items.Contains(temp.Kategoria))
            {
                cbKategorie.SelectedItem = temp.Kategoria;
            }
            else
            {
                cbKategorie.SelectedIndex = -1;
            }
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
                        produkt.glowna.listaProduktow[ind].Wyposazenie = tbWyposazenie.Text;
                        produkt.glowna.listaProduktow[ind].Uwagi = tbUwagi.Text;
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
                        if (cbKategorie.Text != "Inne")
                        {
                            produkt.glowna.listaProduktow[ind].Kategoria = cbKategorie.SelectedItem.ToString();
                        }
                        else
                        {
                            produkt.glowna.listaProduktow[ind].Kategoria = tbInnaKategoria.Text;
                        }
                        if (!produkt.glowna.kategorieProduktow.Contains(produkt.glowna.listaProduktow[ind].Kategoria))
                        {
                            produkt.glowna.kategorieProduktow.Add(produkt.glowna.listaProduktow[ind].Kategoria);
                            produkt.glowna.nadpiszUstawienia();
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
            if (SprawdzFormularz())
            {
                produkt.glowna.listaProduktow[ind].DataZakupu = tbDataOd.Text;
                produkt.glowna.listaProduktow[ind].Nazwa = tbNazwa.Text;
                produkt.glowna.listaProduktow[ind].NumerSeryjny = tbNumer.Text;
                string cena = tbCenaZakupu.Text;
                cena.Replace(',', '.');
                produkt.glowna.listaProduktow[ind].CenaZakupu = cena;
                produkt.glowna.listaProduktow[ind].Ilosc = (int)nudIlosc.Value;
                produkt.glowna.listaProduktow[ind].Wyposazenie = tbWyposazenie.Text;
                produkt.glowna.listaProduktow[ind].Uwagi = tbUwagi.Text;
                if (cbKategorie.Text != "Inne")
                {
                    produkt.glowna.listaProduktow[ind].Kategoria = cbKategorie.SelectedItem.ToString();
                }
                else
                {
                    produkt.glowna.listaProduktow[ind].Kategoria = tbInnaKategoria.Text;
                }
                if (!produkt.glowna.kategorieProduktow.Contains(produkt.glowna.listaProduktow[ind].Kategoria))
                {
                    produkt.glowna.kategorieProduktow.Add(produkt.glowna.listaProduktow[ind].Kategoria);
                    produkt.glowna.nadpiszUstawienia();
                }
                produkt.glowna.nadpiszProdukty();
                Close();
                produkt.Enabled = true;
                produkt.AktualizujGrida();
                produkt.Focus();
            }
        }

        private void cbKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategorie.Text == "Inne")
            {
                LblInnaKategoria.Visible = true;
                tbInnaKategoria.Visible = true;
            }
            else
            {
                LblInnaKategoria.Visible = false;
                tbInnaKategoria.Visible = false;
            }
        }
        private bool SprawdzFormularz()
        {
            bool ok = true;
            string cena = tbCenaZakupu.Text;
            cena.Replace(',', '.');
            double res;
            if (cena == "" || !double.TryParse(cena, out res))
            {
                ok = false;
                MessageBox.Show("Wpisz poprawną cenę!");
            }
            if (tbNazwa.Text == "")
            {
                ok = false;
                MessageBox.Show("Wprowadź Nazwę!");
            }
            if (tbNumer.Text == "")
            {
                ok = false;
                MessageBox.Show("Wprowadź Numer!");
            }
            if (cbKategorie.SelectedItem.ToString() == "")
            {
                ok = false;
                MessageBox.Show("Wybierz Kategorię!");
            }
            if (cbKategorie.SelectedItem.ToString() == "Inne" && tbInnaKategoria.Text == "")
            {
                ok = false;
                MessageBox.Show("Wpisz nazwę nowej kategorii!");
            }
            return ok;
        }
    }
}
