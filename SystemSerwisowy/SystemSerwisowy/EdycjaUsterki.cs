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
            cbZgoda.SelectedItem = usterka.ZgodaElektro;
            cbBlokuj.SelectedItem = usterka.BlokujKlienta;
            try
            {
                cbStatus.SelectedItem = usterka.Status;
            }
            catch
            {
                cbStatus.SelectedIndex = 0;
            }
            chbSmsWyslany.Checked = (usterka.SMS.Contains("TAK"));
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

            if (cbZgoda.SelectedItem.ToString() == "TAK")
            {
                bool bylaZgoda = serwis.glowna.listaUsterek.Cast<Usterka>().Where(x => x.Telefon == tbTelefon.Text && (x.ZgodaElektro == "TAK")).Any();

                serwis.glowna.listaUsterek[indeks].ZgodaElektro = "TAK";
                if (!bylaZgoda)
                {
                    //printPreviewDialog1.Document = printDocument1;
                    //printPreviewDialog1.ShowDialog();
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                        printDocument1.Print();
                }
                var listaTemp = serwis.glowna.listaUsterek.Cast<Usterka>().Where(x => x.Telefon == tbTelefon.Text && x.ZgodaElektro == "NIE").ToList();
                foreach (Usterka item in listaTemp)
                {
                    item.ZgodaElektro = "TAK";
                }
            }
            else
            {
                serwis.glowna.listaUsterek[indeks].ZgodaElektro = cbZgoda.SelectedItem.ToString();
                var listaTemp = serwis.glowna.listaUsterek.Cast<Usterka>().Where(x => x.Telefon == tbTelefon.Text && x.ZgodaElektro == "TAK").ToList();
                foreach (Usterka item in listaTemp)
                {
                    item.ZgodaElektro = "NIE";
                }
            }

            var bylaBlokada = serwis.glowna.listaUsterek.Cast<Usterka>().Where(x => x.Telefon == tbTelefon.Text && x.BlokujKlienta == "TAK").FirstOrDefault();
            if (cbBlokuj.SelectedItem.ToString() == "TAK")
            {

                var listaTemp = serwis.glowna.listaUsterek.Cast<Usterka>().Where(x => x.Telefon == tbTelefon.Text && x.BlokujKlienta == "NIE").ToList();
                foreach (Usterka item in listaTemp)
                {
                    item.BlokujKlienta = "TAK";
                }
                serwis.glowna.listaUsterek[indeks].BlokujKlienta = "TAK";
            }
            else
            {
                serwis.glowna.listaUsterek[indeks].BlokujKlienta = "NIE";
                var listaTemp = serwis.glowna.listaUsterek.Cast<Usterka>().Where(x => x.Telefon == tbTelefon.Text && x.BlokujKlienta == "TAK").ToList();
                foreach (Usterka item in listaTemp)
                {
                    item.BlokujKlienta = "NIE";
                }
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
                cbStatus.SelectedItem.ToString(), cbOdbior.SelectedItem.ToString(), tbNaprawy.Text, DateTime.Now.ToShortDateString(), (chbSmsWyslany.Checked ? "TAK" : "NIE"), cbZgoda.SelectedItem.ToString(), cbBlokuj.SelectedItem.ToString());
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                generujWydrukRodo(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void generujWydrukRodo(System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular);
            float[] dashValues = { 2, 2, 2, 2 };
            Pen blackPen = new Pen(Color.Black, 3);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(40, 560), new Point(780, 560));

            StringFormat drawFormat = new StringFormat();
            e.Graphics.DrawString(serwis.glowna.firma.Miasto + ", " + DateTime.Today.ToShortDateString(), font, Brushes.Black, new Point(75, 70));
            e.Graphics.DrawString("Ja niżej podpisany wyrażam zgodę ne przesyłanie informacji handlowych za pomocą", font, Brushes.Black, new Point(110, 120));
            e.Graphics.DrawString("środków komunikacji elektronicznej w rozumieniu ustawy z dnia 18 lipca 2002 roku", font, Brushes.Black, new Point(75, 150));
            e.Graphics.DrawString("o świadczenie usług drogą elektroniczną (Dz.U.2017.1219 t.j.) w formie wiadomości", font, Brushes.Black, new Point(75, 180));
            e.Graphics.DrawString("tekstowej sms na podany numer telefonu: " + tbTelefon.Text + " na temat usług oferowanych przez", font, Brushes.Black, new Point(75, 210));
            e.Graphics.DrawString(serwis.glowna.firma.NazwaRodo, font, Brushes.Black, new RectangleF(75, 240, 650, 60), drawFormat);
            //e.Graphics.DrawString("LUMIK A.PAWLAK, Ł. MIKOŁAJCZYK SPÓŁKA CYWILNA przy ul. SIERADZKIEJ 6", font, Brushes.Black, new Point(75, 240));
            //e.Graphics.DrawString("z siedzibą w ZDUŃSKIEJ WOLI.", font, Brushes.Black, new Point(75, 270));
            e.Graphics.DrawString("Zgoda jest dobrowolna i może być w każdej chwili wycofana.", font, Brushes.Black, new Point(75, 315));
            e.Graphics.DrawString("Wycofanie zgody nie wływa na zgodność z prawem przetwarzania, którego dokonano na", font, Brushes.Black, new Point(75, 360));
            e.Graphics.DrawString("podstawie  zgody przed jej wycofaniem.", font, Brushes.Black, new Point(75, 390));
            e.Graphics.DrawString("..................................", font, Brushes.Black, new Point(550, 510));
            e.Graphics.DrawString(tbNazwisko.Text, font, Brushes.Black, new Point(560, 530));
        }
    }
}
