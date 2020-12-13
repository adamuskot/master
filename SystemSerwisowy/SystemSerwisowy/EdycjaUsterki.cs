using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using smsApi;

namespace SystemSerwisowy
{
    public partial class EdycjaUsterki : Form
    {
        public SekcjaSerwisu serwis;
        public Usterka ust;
        int indeks;
        public EdycjaUsterki(SekcjaSerwisu s, int ind)
        {
            indeks = ind;
            serwis = s;
            InitializeComponent();
            ust = serwis.glowna.listaUsterek[ind];
            UzupelnijFormularz(ust);
        }

        public void UzupelnijFormularz(Usterka usterka)
        {
            tbId.Text = usterka.ID.ToString();
            tbDataOd.Text = usterka.DataZgloszenia;
            tbKoszt.Text = usterka.Koszt;
            tbModel.Text = usterka.Model;
            tbNazwisko.Text = usterka.Nazwisko;
            tbNumer.Text = usterka.NumerSeryjny;
            tbOpis.Text = usterka.Opis;
            tbTelefon.Text = usterka.Telefon;
            tbUwagi.Text = usterka.Uwagi;
            tbDataDo.Text = usterka.DataRealizacji;
            tbNaprawy.Text = usterka.WykonaneNaprawy;
            if (usterka.Uwagi.Contains("Pilne"))
            {
                chbPilne.Checked = true;
            }
            else
            {
                chbPilne.Checked = false;
            }
            switch (usterka.Odbior)
            {
                case "TAK":
                    cbOdbior.SelectedIndex = 1;
                    break;
                default:
                    cbOdbior.SelectedIndex = 0;
                    break;
            }
            try
            {
                cbStatus.SelectedItem = usterka.Status;
            }
            catch
            {
                cbStatus.SelectedIndex = 0;
            }
            chbSmsWyslany.Checked = (usterka.SMS == "TAK");
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            serwis.Enabled = true;
            serwis.AktualizujGrida();
            serwis.Focus();
        }

        private void btZapisz_Click(object sender, EventArgs e)
        {
            zapiszZmiany();
            Close();
        }

        private void zapiszZmiany()
        {
            DateTime a;
            serwis.glowna.listaUsterek[indeks].ID = Convert.ToInt32(tbId.Text);
            if (DateTime.TryParse(tbDataOd.Text, out a))
            {
                serwis.glowna.listaUsterek[indeks].DataZgloszenia = tbDataOd.Text;
            }
            if (DateTime.TryParse(tbDataDo.Text, out a))
            {
                serwis.glowna.listaUsterek[indeks].DataRealizacji = tbDataDo.Text;
            }
            serwis.glowna.listaUsterek[indeks].Koszt = tbKoszt.Text;
            serwis.glowna.listaUsterek[indeks].Model = tbModel.Text;
            serwis.glowna.listaUsterek[indeks].Nazwisko = tbNazwisko.Text;
            serwis.glowna.listaUsterek[indeks].NumerSeryjny = tbNumer.Text;
            serwis.glowna.listaUsterek[indeks].Opis = tbOpis.Text;
            serwis.glowna.listaUsterek[indeks].Status = cbStatus.SelectedItem.ToString();
            serwis.glowna.listaUsterek[indeks].Telefon = tbTelefon.Text;
            serwis.glowna.listaUsterek[indeks].Uwagi = tbUwagi.Text;
            serwis.glowna.listaUsterek[indeks].Odbior = cbOdbior.SelectedItem.ToString();
            if (cbOdbior.SelectedItem.ToString() == "TAK" && serwis.glowna.listaUsterek[indeks].DataOdbioru == "")
            {
                serwis.glowna.listaUsterek[indeks].DataOdbioru = DateTime.Now.ToString("yyyy-MM-dd");
            }
            serwis.glowna.listaUsterek[indeks].WykonaneNaprawy = tbNaprawy.Text;
            if (chbPilne.Checked && !serwis.glowna.listaUsterek[indeks].Uwagi.Contains("Pilne"))
            {
                serwis.glowna.listaUsterek[indeks].Uwagi += "Pilne";
            }
            serwis.glowna.nadpiszUsterki();
            serwis.Enabled = true;
            serwis.AktualizujGrida();
            serwis.Focus();
        }

        private void EdycjaUsterki_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pomocnik pomoc = new Pomocnik();
            Usterka uster = new Usterka(Convert.ToInt32(tbId.Text), tbTelefon.Text, tbNazwisko.Text, tbModel.Text, tbNumer.Text, tbDataOd.Text, tbDataDo.Text, tbOpis.Text, (chbPilne.Checked) ? tbUwagi.Text + "Pilne" : tbUwagi.Text, tbKoszt.Text,
                cbStatus.SelectedItem.ToString(), cbOdbior.SelectedItem.ToString(), tbNaprawy.Text, DateTime.Now.ToShortDateString(), (chbSmsWyslany.Checked ? "TAK" : "NIE"));
            if (pomoc.czyUsterkiTakieSame(serwis.glowna.listaUsterek[indeks], uster))
            {
                serwis.Enabled = true;
                serwis.Focus();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wykonałeś pewne zmiany. Czy chcesz je zapisać?", "Zapisać zmiany?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    zapiszZmiany();
                }
                else if (dialogResult == DialogResult.No)
                {
                    serwis.Enabled = true;
                    serwis.Focus();
                }
            }

        }

        private void btnWyslijSms_Click(object sender, EventArgs e)
        {
            WyslijSMS sms = new WyslijSMS(this, ust);
            sms.Show(this);


            
        }
    }
}
