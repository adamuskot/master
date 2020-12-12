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
    public partial class DodajAkcesoria : Form
    {
        SekcjaAkcesoriow produkt;
        public DodajAkcesoria(SekcjaAkcesoriow p)
        {
            produkt = p;
            InitializeComponent();
            tbData.Text = DateTime.Now.Date.ToShortDateString();
            tbId.Text = produkt.glowna.GetFreeIdAkcesoriow().ToString();
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            if (SprawdzFormularz())
            {
                Czesc nowy = new Czesc();
                string cena = tbCena.Text;
                cena.Replace(',', '.');
                nowy.CenaZakupu = cena;
                nowy.Dostepny = "TAK";
                nowy.Dostawca = tbDostawca.Text;
                nowy.Id = Convert.ToInt32(tbId.Text);
                nowy.Ilosc = Convert.ToInt32(nudIlosc.Value);
                nowy.Nazwa = tbNazwa.Text;
                nowy.Uwagi = tbUwagi.Text;
                produkt.glowna.listaAkcesoriow.Add(nowy);
                produkt.glowna.nadpiszAkcesoria();
                Close();
                produkt.Enabled = true;
                produkt.AktualizujGrida();
                produkt.Focus();
            }
            else
            {
                MessageBox.Show("Uzupełnij formularz!");
            }
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
            if (tbDostawca.Text == "")
            {
                ok = false;
            }
            return ok;
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            produkt.Enabled = true;
            produkt.AktualizujGrida();
            produkt.Focus();
        }

        private void DodajAkcesoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            produkt.Enabled = true;
            produkt.Focus();
        }

    }
}
