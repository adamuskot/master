using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemSerwisowy
{
    public partial class DodajProdukt : Form
    {
        SekcjaProduktow produkt;
        public DodajProdukt(SekcjaProduktow p)
        {
            produkt = p;
            InitializeComponent();
            tbData.Text = DateTime.Now.Date.ToShortDateString();
            tbId.Text = produkt.glowna.GetFreeIdProduktu().ToString();
            cbKategorie.DataSource = p.glowna.kategorieProduktow;
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            produkt.Enabled = true;
            produkt.AktualizujGrida();
            produkt.Focus();
        }
        private bool SprawdzFormularz()
        {
            bool ok = true;
            double res;
            string cena = tbCena.Text;
            cena.Replace(',', '.');
            if (cena == "" && double.TryParse(cena, out res))
            {
                ok = false;
                MessageBox.Show("Wpisz poprawną cenę!");
            }
            if (tbData.Text == "")
            {
                ok = false;
            }
            if (tbNazwa.Text == "")
            {
                ok = false;
            }
            if (tbNumer.Text == "")
            {
                ok = false;
            }
            if (cbKategorie.SelectedItem.ToString() == "")
            {
                ok = false;
                MessageBox.Show("Wybierz" +
                    " kategorię!");
            }
            if (cbKategorie.SelectedItem.ToString() == "Inne" && tbInnaKategoria.Text == "")
            {
                ok = false;
                MessageBox.Show("Wpisz nazwę nowej kategorii!");
            }
            return ok;
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            if (SprawdzFormularz())
            {
                Produkt nowy = new Produkt();
                string cena = tbCena.Text;
                cena.Replace(',', '.');
                nowy.CenaZakupu = cena;
                nowy.DataZakupu = tbData.Text;
                nowy.Dostepny = "TAK";
                nowy.Id = Convert.ToInt32(tbId.Text);
                nowy.Ilosc = Convert.ToInt32(nudIlosc.Value);
                nowy.Nazwa = tbNazwa.Text;
                nowy.NumerSeryjny = tbNumer.Text;
                nowy.Uwagi = tbUwagi.Text;
                nowy.Wyposazenie = tbWyposazenie.Text;
                if (cbKategorie.Text != "Inne")
                {
                    nowy.Kategoria = cbKategorie.SelectedItem.ToString();
                }
                else
                {
                    nowy.Kategoria = tbInnaKategoria.Text;
                }
                if (!produkt.glowna.kategorieProduktow.Contains(nowy.Kategoria))
                {
                    produkt.glowna.kategorieProduktow.Add(nowy.Kategoria);
                    produkt.glowna.nadpiszUstawienia();
                }
                produkt.glowna.listaProduktow.Add(nowy);
                produkt.glowna.nadpiszProdukty();
                Close();
                produkt.Enabled = true;
                produkt.AktualizujGrida();
            }
        }

        private void DodajProdukt_FormClosing(object sender, FormClosingEventArgs e)
        {
            produkt.Enabled = true;
            produkt.Focus();
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
    }
}
