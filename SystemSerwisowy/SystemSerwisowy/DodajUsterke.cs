using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SystemSerwisowy
{
    public partial class DodajUsterke : Form
    {
        SekcjaSerwisu serwis;
        public DodajUsterke(SekcjaSerwisu s)
        {
            serwis = s;
            InitializeComponent();
            tbId.Text = serwis.glowna.GetFreeIdUsterek().ToString();
            nudCzasNaprawy.Value = serwis.glowna.czasNaprawy;
            tbData.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime now = DateTime.Today;
            dateTimePicker1.Value = now.AddDays((double)nudCzasNaprawy.Value);
            cbStatus.SelectedIndex = 3;
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            if (SprawdzFormularz())
            {
                Usterka usterka = new Usterka();
                usterka.DataZgloszenia = tbData.Text;
                usterka.DataRealizacji = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                usterka.ID = Convert.ToInt32(tbId.Text);
                usterka.Koszt = tbKoszt.Text;
                usterka.Model = tbModel.Text;
                usterka.Nazwisko = tbNazwisko.Text;
                usterka.NumerSeryjny = tbNumer.Text;
                usterka.Opis = tbOpis.Text;
                usterka.Status = cbStatus.SelectedItem.ToString();
                usterka.Telefon = tbTelefon.Text;
                usterka.Uwagi = tbUwagi.Text;
                usterka.Odbior = "NIE";
                usterka.WykonaneNaprawy = "";

                var bylaZgoda = serwis.glowna.listaUsterek.Cast<Usterka>().Where(x => x.Telefon == tbTelefon.Text && x.ZgodaElektro == "TAK" ).FirstOrDefault();
                if (bylaZgoda == null)
                {
                    DialogResult dialogResult = MessageBox.Show("Czy klient wyraża zgodę RODO?", "Zgoda RODO", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        usterka.ZgodaElektro = "TAK";
                        //printPreviewDialog2.Document = printDocument2;
                        //printPreviewDialog2.ShowDialog();
                        if (printDialog1.ShowDialog() == DialogResult.OK)
                            printDocument2.Print();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        usterka.ZgodaElektro = "NIE";
                    }
                }
                else
                {
                    // już wcześniej ten klient odpowiadał na to pytanie więc teraz już automatycznie ma zgodę.
                    usterka.ZgodaElektro = "TAK";
                }
                var bylaBlokada = serwis.glowna.listaUsterek.Cast<Usterka>().Where(x => x.Telefon == tbTelefon.Text && x.BlokujKlienta == "TAK").FirstOrDefault();
                if (bylaBlokada != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Czy wciąż chcesz blokować klienta?", "Uwaga Podejrzany klient", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        usterka.BlokujKlienta = "TAK";
                    }
                    else
                    {
                        usterka.BlokujKlienta = "NIE";
                        var listaTemp = serwis.glowna.listaUsterek.Cast<Usterka>().Where(x => x.Telefon == tbTelefon.Text && x.BlokujKlienta == "TAK").ToList();
                        foreach (Usterka item in listaTemp)
                        {
                            item.BlokujKlienta = "NIE";
                        }
                    }
                }
                else
                {
                    usterka.BlokujKlienta = "NIE";
                }
                if (!serwis.glowna.bazaKlientow.ContainsKey(usterka.Nazwisko))
                {
                    serwis.glowna.bazaKlientow.Add(usterka.Nazwisko, usterka.Telefon);
                }
                else
                {
                    serwis.glowna.bazaKlientow[usterka.Nazwisko] = usterka.Telefon;
                }
                serwis.glowna.listaUsterek.Add(usterka);
                serwis.glowna.czasNaprawy = (int)nudCzasNaprawy.Value;

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                if (chbDrukuj.Checked)
                {
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                        printDocument1.Print();
                }

                Close();
                serwis.glowna.nadpiszUsterki();
                serwis.Enabled = true;
                serwis.AktualizujGrida();
            }
        }

        private bool SprawdzFormularz()
        {
            bool ok = true;
            double res;
            string cena = tbKoszt.Text;
            cena.Replace(',', '.');
            if (cena == "" && double.TryParse(cena, out res))
            {
                ok = false;
                MessageBox.Show("Wpisz poprawny koszt!");
            }
            if (tbTelefon.Text == "")
            {
                ok = false;
            }
            if (tbNazwisko.Text == "")
            {
                ok = false;
            }
            if (tbModel.Text == "")
            {
                ok = false;
            }
            if (tbData.Text == "")
            {
                ok = false;
            }

            return ok;
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            serwis.Enabled = true;
            serwis.Focus();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                generujWydruk(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void generujWydruk(System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);
            Font font2 = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            Font font3 = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            Font font4 = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
            Font font5 = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);
            float[] dashValues = { 2, 2, 2, 2 };
            Pen blackPen = new Pen(Color.Black, 3);
            Bitmap image1;
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(40, 582), new Point(780, 582));
            for (int indeks = 0; indeks < 2; indeks++)
            {
                StringFormat drawFormat = new StringFormat();
                drawFormat.Alignment = StringAlignment.Center;
                if (File.Exists(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Serwis2015\\Wizytowka.jpg"))
                {
                    image1 = (Bitmap)Image.FromFile(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Serwis2015\\Wizytowka.jpg", true);
                    e.Graphics.DrawImage(image1, 70, 50 + indeks * 550, 700, 145);
                }
                else
                {
                    e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(70, 50 + indeks * 550, 700, 145));
                    e.Graphics.DrawString("S E R W I S  L U M I K", font, Brushes.Black, new Point(234, 55 + indeks * 550));
                    //e.Graphics.DrawString("S E R W I S  H A L O G S M", font, Brushes.Black, new Point(234, 55 + indeks * 550));
                    e.Graphics.DrawString(serwis.glowna.firma.Miasto + ", " + serwis.glowna.firma.Ulica + "  " + serwis.glowna.firma.Czynne, font2, Brushes.Black, new Point(145, 85 + indeks * 550));
                    e.Graphics.DrawString("Tel. " + serwis.glowna.firma.Telefon + "  " + serwis.glowna.firma.Email, font2, Brushes.Black, new Point(270, 100 + indeks * 550));
                    e.Graphics.DrawString("SERWIS GSM - simlocki, języki, naprawy wszelkiego rodzaju usterek \n TELEFONY KOMÓRKOWE - skup, sprzedaż, zamiana \n AKCESORIA GSM \n LOMBARD - pożyczki pod zastaw", font3, Brushes.Black, new RectangleF(80, 120 + indeks * 550, 660, 80), drawFormat);
                }
                e.Graphics.DrawString("POTWIERDZENIE PRZYJĘCIA DO NAPRAWY \n " + serwis.glowna.firma.Miasto + ", " + tbData.Text, font2, Brushes.Black, new RectangleF(180, 200 + indeks * 550, 430, 50), drawFormat);
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(70, 255 + indeks * 550, 340, 110));
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(410, 255 + indeks * 550, 360, 110));
                e.Graphics.DrawString("DANE KLIENTA", font3, Brushes.Black, new Point(70, 235 + indeks * 550));
                e.Graphics.DrawString("Imię i Nazwisko:        " + tbNazwisko.Text, font2, Brushes.Black, new Point(75, 260 + indeks * 550));
                e.Graphics.DrawString("Telefon kontaktowy:  " + tbTelefon.Text, font2, Brushes.Black, new Point(75, 280 + indeks * 550));

                e.Graphics.DrawString("SPRZĘT", font3, Brushes.Black, new Point(410, 235 + indeks * 550));
                e.Graphics.DrawString("Marka i Model:            " + tbModel.Text, font2, Brushes.Black, new Point(415, 258 + indeks * 550));
                e.Graphics.DrawString("Numer seryjny:           " + tbNumer.Text, font2, Brushes.Black, new Point(415, 276 + indeks * 550));
                e.Graphics.DrawString("Opis usterki:                " + tbOpis.Text, font2, Brushes.Black, new Point(415, 294 + indeks * 550));
                e.Graphics.DrawString("Uwagi:                          " + tbUwagi.Text, font2, Brushes.Black, new Point(415, 312 + indeks * 550));
                e.Graphics.DrawString("Przewidywany koszt: " + tbKoszt.Text, font2, Brushes.Black, new Point(415, 330 + indeks * 550));
                e.Graphics.DrawString("Przewidywana data odbioru: " + dateTimePicker1.Value.ToShortDateString(), font2, Brushes.Black, new Point(415, 348 + indeks * 550));
                if (serwis.glowna.regulamin.Count() > 0)
                {
                    int top = 365;
                    if (serwis.glowna.regulamin.Count() <= 10)
                    {
                        for (int i = 0; i < serwis.glowna.regulamin.Count(); i++)
                        {
                            if (serwis.glowna.regulamin[i].Length > 140)
                            {
                                e.Graphics.DrawString(serwis.glowna.regulamin[i], font4, Brushes.Black, new RectangleF(70, top + indeks * 550, 720, 25));
                                top += 25;
                            }
                            else
                            {
                                e.Graphics.DrawString(serwis.glowna.regulamin[i], font4, Brushes.Black, new RectangleF(70, top + indeks * 550, 720, 15));
                                top += 15;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < serwis.glowna.regulamin.Count(); i++)
                        {
                            if (serwis.glowna.regulamin[i].Length > 160)
                            {
                                e.Graphics.DrawString(serwis.glowna.regulamin[i], font5, Brushes.Black, new RectangleF(70, top + indeks * 550, 720, 22));
                                top += 22;
                            }
                            else
                            {
                                e.Graphics.DrawString(serwis.glowna.regulamin[i], font5, Brushes.Black, new RectangleF(70, top + indeks * 550, 720, 11));
                                top += 11;
                            }
                        }
                    }
                }
                else
                {
                    e.Graphics.DrawString("1. Oryginał zgłoszenia jest podstawą do wydania sprzętu z serwisu.", font4, Brushes.Black, new RectangleF(70, 355 + indeks * 550, 720, 15));
                    e.Graphics.DrawString("2. Serwis nie odpowiada za ewentualne skutki wynikłe ze zgubienia druku zgłoszenia przez klienta.", font4, Brushes.Black, new RectangleF(70, 370 + indeks * 550, 720, 15));
                    e.Graphics.DrawString("3. Serwis nie ponosi odpowiedzialności za dane pozostawione w pamięci urządzenia, mogą one zostać utracone w trakcie naprawy.", font4, Brushes.Black, new RectangleF(70, 385 + indeks * 550, 720, 15));
                    e.Graphics.DrawString("4. Serwis diagnozuje i naprawia sprzęt pod kątem usterek zgłoszonych przez klienta.", font4, Brushes.Black, new RectangleF(70, 400 + indeks * 550, 680, 15));
                    e.Graphics.DrawString("5. W sytuacji nie odebrania sprzętu przez klienta w terminie 30 dni będą naliczane koszty magazynowania w wysokości 1% wartości naprawy za każdy dzień zwłoki.", font4, Brushes.Black, new RectangleF(70, 415 + indeks * 550, 720, 25));
                    e.Graphics.DrawString("6. Na naprawy po zalaniu nie udzielamy gwarancji.", font4, Brushes.Black, new RectangleF(70, 440 + indeks * 550, 720, 15));
                    e.Graphics.DrawString("7. Ze względu na specyfikę uszkodzeń telefonów po zalaniu, serwis nie ponosi odpowiedzialności za usterki postępujące w trakcie naprawy.", font4, Brushes.Black, new RectangleF(70, 455 + indeks * 550, 720, 15));
                    e.Graphics.DrawString("8. Klient zgłaszając telefon do serwisu akceptuje powyższy regulamin.", font4, Brushes.Black, new RectangleF(70, 470 + indeks * 550, 720, 12));
                    e.Graphics.DrawString("9. Uprzedzony o odpowiedzialności karnej wynikającej z art. 233 Kodeksu Karnego za składanie fałszywych oświadczeń, zleceniodawca oświadcza, że przedmiot wymieniny w rubryce SPRZĘT nie pochodzi z przestępstwa.", font4, Brushes.Black, new RectangleF(70, 485 + indeks * 550, 720, 25));
                    e.Graphics.DrawString("10. Zleceniodawca oświadcza, że jeżeli okaże się, że przedmiot oddany do serwisu pochodził z kradzieży bierze na siebie całą odpowiedzialność, zwalniając Serwis z odpowiedzialności.", font4, Brushes.Black, new RectangleF(70, 510 + indeks * 550, 720, 25));
                }
                e.Graphics.DrawString("..................................", font4, Brushes.Black, new Point(100, 553 + indeks * 550));
                e.Graphics.DrawString("..................................", font4, Brushes.Black, new Point(550, 553 + indeks * 550));
                e.Graphics.DrawString("(Podpis klienta)", font5, Brushes.Black, new Point(110, 565 + indeks * 550));
                e.Graphics.DrawString("(Podpis zleceniobiorcy)", font5, Brushes.Black, new Point(560, 565 + indeks * 550));
            }
        }

        private void DodajUsterke_FormClosing(object sender, FormClosingEventArgs e)
        {
            serwis.Enabled = true;
            serwis.Focus();
            serwis.AktualizujGrida();
            serwis.glowna.nadpiszUsterki();
            serwis.glowna.nadpiszUstawienia();
        }

        private void nudCzasNaprawy_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today;
            dateTimePicker1.Value = now.AddDays((double)nudCzasNaprawy.Value);
            serwis.glowna.czasNaprawy = (int)nudCzasNaprawy.Value;
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
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

        private void tbTelefon_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTelefon.Text, "[^0-9]"))
            {
                MessageBox.Show("Możesz wpowadzać tylko cyfry.");
                tbTelefon.Text = tbTelefon.Text.Remove(tbTelefon.Text.Length - 1);
            }
        }
    }
}
