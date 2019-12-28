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
            cena.Replace("zł", "");
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
                nowy.WykonaneNaprawy = tbNaprawy.Text;
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
    }
}
