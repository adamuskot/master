using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace SystemSerwisowy
{
    public partial class SekcjaSerwisu : Form
    {
        public Glowna glowna;
        int aktualny = 0;
        public SekcjaSerwisu(Glowna g)
        {
            glowna = g;
            InitializeComponent();
            AktualizujGrida();
            foreach (DataGridViewColumn col in dgvUsterki.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            cbKryterium.SelectedIndex = 0;
        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dgvUsterki.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 8.5F, GraphicsUnit.Pixel);
            }
        }

        private void btNowy_Click(object sender, EventArgs e)
        {
            DodajUsterke dodaj = new DodajUsterke(this);
            dodaj.Show(this);
            this.Enabled = false;
        }

        public void AktualizujGrida()
        {
            dgvUsterki.DataSource = null;

            if (chbStan.Checked)
            {
                List<Usterka> lista = new List<Usterka>();
                for (int i = 0; i < glowna.listaUsterek.Count(); i++)
                {
                    if (glowna.listaUsterek[i].Odbior == "NIE")
                    {
                        lista.Add(glowna.listaUsterek[i]);
                    }
                }

                if (chbNaprawa.Checked)
                {
                    List<Usterka> listatmp = new List<Usterka>();
                    for (int i = 0; i < lista.Count(); i++)
                    {
                        if (lista[i].Status == "Przyjęty do naprawy" || lista[i].Status == "Czeka na części" || lista[i].Status == "Czeka na decyzje klienta" || lista[i].Status == "Wysłane na gwarancję")
                        {
                            listatmp.Add(lista[i]);
                        }
                    }
                    dgvUsterki.DataSource = listatmp;
                }
                else
                {
                    dgvUsterki.DataSource = lista;
                }
            }
            else
            {
                List<Usterka> lista = new List<Usterka>();
                if (chbNaprawa.Checked)
                {
                    for (int i = 0; i < glowna.listaUsterek.Count(); i++)
                    {
                        if (glowna.listaUsterek[i].Status == "Przyjęty do naprawy" || glowna.listaUsterek[i].Status == "Czeka na części" || glowna.listaUsterek[i].Status == "Czeka na decyzje klienta" || glowna.listaUsterek[i].Status == "Wysłane na gwarancję")
                        {
                            lista.Add(glowna.listaUsterek[i]);
                        }
                    }
                    dgvUsterki.DataSource = lista;
                }
                else
                {
                    dgvUsterki.DataSource = glowna.listaUsterek;
                }
            }
            foreach (DataGridViewRow row in dgvUsterki.Rows)
            {
                if (row.Cells[12].Value.ToString() == "Naprawiony")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (row.Cells[12].Value.ToString() == "Brak możliwości naprawy")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (row.Cells[12].Value.ToString() == "Wysłane na gwarancję")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (row.Cells[12].Value.ToString() == "Przyjęty do naprawy")
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
            dgvUsterki.Columns[4].DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
            dgvUsterki.Columns[4].DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvUsterki.Columns[0].Width = 40; // ID
            dgvUsterki.Columns[1].Width = 160; // Imie i nazwisko
            dgvUsterki.Columns[2].Width = 70;
            dgvUsterki.Columns[3].Width = 40;
            dgvUsterki.Columns[4].Width = 40;
            dgvUsterki.Columns[5].Width = 125;
            dgvUsterki.Columns[7].Width = 220;
            dgvUsterki.Columns[8].Width = 220;
            dgvUsterki.Columns[9].Width = 50;
            this.Refresh();
        }


        private void btZamknij_Click(object sender, EventArgs e)
        {
            Close();
            glowna.Enabled = true;
            glowna.Focus();
            glowna.generujRaport();
        }

        private void SekcjaSerwisu_FormClosing(object sender, FormClosingEventArgs e)
        {
            glowna.nadpiszUsterki();
            glowna.Enabled = true;
            glowna.Focus();
            glowna.generujRaport();
        }

        private void dgvUsterki_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                aktualny = Convert.ToInt32(dgvUsterki.Rows[e.RowIndex].Cells[0].Value);
                EdycjaUsterki edycja = new EdycjaUsterki(this, zwroc_id(aktualny));
                edycja.Show(this);
                this.Enabled = false;
            }
        }

        private void btEdycja_Click(object sender, EventArgs e)
        {
            if (glowna.listaUsterek.Count > 0)
            {
                EdycjaUsterki edycja = new EdycjaUsterki(this, zwroc_id(aktualny));
                edycja.Show(this);
                this.Enabled = false;
            }
        }

        private void dgvUsterki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                aktualny = Convert.ToInt32(dgvUsterki.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private int zwroc_id(int akt)
        {
            int index = 0;
            for (int i = 0; i < glowna.listaUsterek.Count(); i++)
            {
                if (glowna.listaUsterek[i].ID == akt)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private void btUsun_Click(object sender, EventArgs e)
        {
            if (glowna.listaUsterek.Count() > 0)
            {
                string message = "Czy na pewno chcesz usunąć pozycję : " + glowna.listaUsterek[zwroc_id(aktualny)].Model + "?";
                if (MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    glowna.listaUsterek.RemoveAt(zwroc_id(aktualny));
                }
            }
            AktualizujGrida();
            glowna.nadpiszUsterki();
        }

        private void SekcjaSerwisu_Load(object sender, EventArgs e)
        {
            AktualizujGrida();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AktualizujGrida();
        }

        private void btPotwierdzenie_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (glowna.listaUsterek.Count() > 0)
            {
                generujWydruk(e, zwroc_id(aktualny));
            }
        }

        private void generujWydruk(System.Drawing.Printing.PrintPageEventArgs e, int ind)
        {
            Usterka ust = glowna.listaUsterek[ind];
            Font font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);
            Font font2 = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            Font font3 = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            Font font4 = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
            Font font5 = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);
            float[] dashValues = { 2, 2, 2, 2 };
            Pen blackPen = new Pen(Color.Black, 3);
            Bitmap image1;

            //Bitmap tempImage = new Bitmap("C:\\Wizytowka.jpeg", true);
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
                    e.Graphics.DrawString(glowna.firma.Miasto + ", " + glowna.firma.Ulica + "  " + glowna.firma.Czynne, font2, Brushes.Black, new Point(145, 85 + indeks * 550));
                    e.Graphics.DrawString("Tel. " + glowna.firma.Telefon + "  " + glowna.firma.Email, font2, Brushes.Black, new Point(270, 100 + indeks * 550));
                    e.Graphics.DrawString("SERWIS GSM - simlocki, języki, naprawy wszelkiego rodzaju usterek \n TELEFONY KOMÓRKOWE - skup, sprzedaż, zamiana \n AKCESORIA GSM \n LOMBARD - pożyczki pod zastaw", font3, Brushes.Black, new RectangleF(80, 120 + indeks * 550, 660, 80), drawFormat);
                }

                e.Graphics.DrawString("POTWIERDZENIE PRZYJĘCIA DO NAPRAWY \n " + glowna.firma.Miasto + ", " + ust.DataZgloszenia, font2, Brushes.Black, new RectangleF(180, 200 + indeks * 550, 430, 50), drawFormat);
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(70, 255 + indeks * 550, 340, 110));
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(410, 255 + indeks * 550, 360, 110));
                e.Graphics.DrawString("DANE KLIENTA", font3, Brushes.Black, new Point(70, 235 + indeks * 550));
                e.Graphics.DrawString("Imię i Nazwisko:        " + ust.Nazwisko, font2, Brushes.Black, new Point(75, 260 + indeks * 550));
                e.Graphics.DrawString("Telefon kontaktowy:  " + ust.Telefon, font2, Brushes.Black, new Point(75, 280 + indeks * 550));

                e.Graphics.DrawString("SPRZĘT", font3, Brushes.Black, new Point(410, 235 + indeks * 550));
                e.Graphics.DrawString("Marka i Model:            " + ust.Model, font2, Brushes.Black, new Point(415, 258 + indeks * 550));
                e.Graphics.DrawString("Numer seryjny:           " + ust.NumerSeryjny, font2, Brushes.Black, new Point(415, 276 + indeks * 550));
                e.Graphics.DrawString("Opis usterki:                " + ust.Opis, font2, Brushes.Black, new Point(415, 294 + indeks * 550));
                e.Graphics.DrawString("Uwagi:                          " + ust.Uwagi, font2, Brushes.Black, new Point(415, 312 + indeks * 550));
                e.Graphics.DrawString("Przewidywany koszt: " + ust.Koszt, font2, Brushes.Black, new Point(415, 330 + indeks * 550));
                e.Graphics.DrawString("Przewidywana data odbioru: " + ust.DataRealizacji, font2, Brushes.Black, new Point(415, 348 + indeks * 550));
                if (glowna.regulamin.Count() > 0)
                {
                    int top = 365;
                    if (glowna.regulamin.Count() <= 10)
                    {
                        for (int i = 0; i < glowna.regulamin.Count(); i++)
                        {
                            if (glowna.regulamin[i].Length > 140)
                            {
                                e.Graphics.DrawString(glowna.regulamin[i], font4, Brushes.Black, new RectangleF(70, top + indeks * 550, 720, 25));
                                top += 25;
                            }
                            else
                            {
                                e.Graphics.DrawString(glowna.regulamin[i], font4, Brushes.Black, new RectangleF(70, top + indeks * 550, 720, 15));
                                top += 15;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < glowna.regulamin.Count(); i++)
                        {
                            if (glowna.regulamin[i].Length > 160)
                            {
                                e.Graphics.DrawString(glowna.regulamin[i], font5, Brushes.Black, new RectangleF(70, top + indeks * 550, 720, 22));
                                top += 22;
                            }
                            else
                            {
                                e.Graphics.DrawString(glowna.regulamin[i], font5, Brushes.Black, new RectangleF(70, top + indeks * 550, 720, 11));
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
                    e.Graphics.DrawString("8. Klient zgłaszając telefon do serwisu akceptuje powyższy regulamin.", font4, Brushes.Black, new RectangleF(70, 470 + indeks * 550, 720, 15));
                    e.Graphics.DrawString("9. Uprzedzony o odpowiedzialności karnej wynikającej z art. 233 Kodeksu Karnego za składanie fałszywych oświadczeń, zleceniodawca oświadcza, że przedmiot wymieniny w rubryce SPRZĘT nie pochodzi z przestępstwa.", font4, Brushes.Black, new RectangleF(70, 485 + indeks * 550, 720, 25));
                    e.Graphics.DrawString("10. Zleceniodawca oświadcza, że jeżeli okaże się, że przedmiot oddany do serwisu pochodził z kradzieży bierze na siebie całą odpowiedzialność, zwalniając Serwis z odpowiedzialności.", font4, Brushes.Black, new RectangleF(70, 510 + indeks * 550, 720, 25));
                }
                //e.Graphics.DrawString("1. Oryginał zgłoszenia jest podstawą do wydania sprzętu z serwisu.", font4, Brushes.Black, new RectangleF(70, 355 + indeks * 550, 720, 15));
                //e.Graphics.DrawString("2. Serwis nie odpowiada za ewentualne skutki wynikłe ze zgubienia druku zgłoszenia przez klienta.", font4, Brushes.Black, new RectangleF(70, 370 + indeks * 550, 720, 15));
                //e.Graphics.DrawString("3. Serwis nie ponosi odpowiedzialności za dane pozostawione w pamięci urządzenia, mogą one zostać utracone w trakcie naprawy.", font4, Brushes.Black, new RectangleF(70, 385 + indeks * 550, 720, 15));
                //e.Graphics.DrawString("4. Serwis diagnozuje i naprawia sprzęt pod kątem usterek zgłoszonych przez klienta.", font4, Brushes.Black, new RectangleF(70, 400 + indeks * 550, 680, 15));
                //e.Graphics.DrawString("5. W sytuacji nie odebrania sprzętu przez klienta w terminie 30 dni będą naliczane koszty magazynowania w wysokości 1% wartości naprawy za każdy dzień zwłoki.", font4, Brushes.Black, new RectangleF(70, 415 + indeks * 550, 720, 25));
                //e.Graphics.DrawString("6. Na naprawy po zalaniu nie udzielamy gwarancji.", font4, Brushes.Black, new RectangleF(70, 440 + indeks * 550, 720, 15));
                //e.Graphics.DrawString("7. Ze względu na specyfikę uszkodzeń telefonów po zalaniu, serwis nie ponosi odpowiedzialności za usterki postępujące w trakcie naprawy.", font4, Brushes.Black, new RectangleF(70, 455 + indeks * 550, 720, 15));
                //e.Graphics.DrawString("8. Klient zgłaszając telefon do serwisu akceptuje powyższy regulamin.", font4, Brushes.Black, new RectangleF(70, 470 + indeks * 550, 720, 15));
                //e.Graphics.DrawString("9. Uprzedzony o odpowiedzialności karnej wynikającej z art. 233 Kodeksu Karnego za składanie fałszywych oświadczeń, zleceniodawca oświadcza, że przedmiot wymieniny w rubryce SPRZĘT nie pochodzi z przestępstwa.", font4, Brushes.Black, new RectangleF(70, 485 + indeks * 550, 720, 25));
                //e.Graphics.DrawString("10. Zleceniodawca oświadcza, że jeżeli okaże się, że przedmiot oddany do serwisu pochodził z kradzieży bierze na siebie całą odpowiedzialność, zwalniając Serwis z odpowiedzialności.", font4, Brushes.Black, new RectangleF(70, 510 + indeks * 550, 720, 25));
                e.Graphics.DrawString("..................................", font4, Brushes.Black, new Point(100, 553 + indeks * 550));
                e.Graphics.DrawString("..................................", font4, Brushes.Black, new Point(550, 553 + indeks * 550));
                e.Graphics.DrawString("(Podpis klienta)", font5, Brushes.Black, new Point(110, 565 + indeks * 550));
                e.Graphics.DrawString("(Podpis zleceniobiorcy)", font5, Brushes.Black, new Point(560, 565 + indeks * 550));
            }
        }

        private void tbSzukajka_TextChanged(object sender, EventArgs e)
        {
            List<Usterka> temp = new List<Usterka>();
            if (tbSzukajka.Text.Length > 0)
            {
                if (cbKryterium.SelectedIndex == 0)
                {
                    if (chbStan.Checked)
                    {
                        for (int i = 0; i < glowna.listaUsterek.Count(); i++)
                        {
                            if (glowna.listaUsterek[i].Nazwisko.ToUpper().Contains(tbSzukajka.Text.ToUpper()) && glowna.listaUsterek[i].Odbior == "NIE")
                            {
                                temp.Add(glowna.listaUsterek[i]);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < glowna.listaUsterek.Count(); i++)
                        {
                            if (glowna.listaUsterek[i].Nazwisko.ToUpper().Contains(tbSzukajka.Text.ToUpper()))
                            {
                                temp.Add(glowna.listaUsterek[i]);
                            }
                        }
                    }
                }
                else if (cbKryterium.SelectedIndex == 1)
                {
                    if (chbStan.Checked)
                    {
                        for (int i = 0; i < glowna.listaUsterek.Count(); i++)
                        {
                            if (glowna.listaUsterek[i].Model.ToUpper().Contains(tbSzukajka.Text.ToUpper()) && glowna.listaUsterek[i].Odbior == "NIE")
                            {
                                temp.Add(glowna.listaUsterek[i]);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < glowna.listaUsterek.Count(); i++)
                        {
                            if (glowna.listaUsterek[i].Model.ToUpper().Contains(tbSzukajka.Text.ToUpper()))
                            {
                                temp.Add(glowna.listaUsterek[i]);
                            }
                        }
                    }
                }
                else
                {
                    if (chbStan.Checked)
                    {
                        for (int i = 0; i < glowna.listaUsterek.Count(); i++)
                        {
                            if (glowna.listaUsterek[i].NumerSeryjny.ToUpper().Contains(tbSzukajka.Text.ToUpper()) && glowna.listaUsterek[i].Odbior == "NIE")
                            {
                                temp.Add(glowna.listaUsterek[i]);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < glowna.listaUsterek.Count(); i++)
                        {
                            if (glowna.listaUsterek[i].NumerSeryjny.ToUpper().Contains(tbSzukajka.Text.ToUpper()))
                            {
                                temp.Add(glowna.listaUsterek[i]);
                            }
                        }
                    }
                }
            }
            else
            {
                if (chbStan.Checked)
                {
                    for (int i = 0; i < glowna.listaUsterek.Count(); i++)
                    {
                        if (glowna.listaUsterek[i].Odbior == "NIE")
                        {
                            temp.Add(glowna.listaUsterek[i]);
                        }
                    }
                }
                else
                {
                    temp = glowna.listaUsterek;
                }
            }
            dgvUsterki.DataSource = null;
            dgvUsterki.DataSource = temp;
            if (temp.Count > 0)
            {
                aktualny = Convert.ToInt32(dgvUsterki.Rows[0].Cells[0].Value);
            }
            else
            {
                aktualny = 0;
            }
            foreach (DataGridViewRow row in dgvUsterki.Rows)
            {
                if (row.Cells[12].Value.ToString() == "Naprawiony")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (row.Cells[12].Value.ToString() == "Brak możliwości naprawy")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (row.Cells[12].Value.ToString() == "Wysłane na gwarancję")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (row.Cells[12].Value.ToString() == "Przyjęty do naprawy")
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
            this.Refresh();
        }

        private void chbNaprawa_CheckedChanged(object sender, EventArgs e)
        {
            AktualizujGrida();
        }

        private void btnRaportRodo_Click(object sender, EventArgs e)
        {
            //string sciezka = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Serwis2015\\Baza\\LogiRaport.txt";
            //FileStream plik = new FileStream(sciezka, FileMode.Truncate, FileAccess.Write); // czyszczenie pliku txt
            //plik.Close();
            //plik = new FileStream(sciezka, FileMode.Append, FileAccess.Write);
            //StreamWriter zapisuj = new StreamWriter(plik);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Zapisz Raport do:";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                try
                {
                    Excel.Application ExcelApp = new Excel.Application();
                    //zapisuj.WriteLine("utworzenie excelapp");
                    Excel.Workbook ExcelWorkBook = null;
                    //zapisuj.WriteLine("utworzenieworkbook");
                    Excel.Worksheet ExcelWorkSheet = null;

                    //zapisuj.WriteLine("utworzenie worksheet");


                    ExcelApp.Visible = true;

                    ExcelWorkBook = ExcelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);


                    //zapisuj.WriteLine("Przed zapisem danych");
                    ExcelWorkSheet = ExcelWorkBook.Worksheets[1];
                    int i = 2;
                    ExcelWorkSheet.Cells[1, 1] = "Imię i nazwisko";
                    ExcelWorkSheet.Cells[1, 2] = "Numer Telefonu";
                    foreach (Usterka item in glowna.listaUsterek)
                    {
                        if (item.ZgodaElektro == "TAK")
                        {
                            ExcelWorkSheet.Cells[i, 1] = item.Nazwisko;
                            ExcelWorkSheet.Cells[i, 2] = item.Telefon;
                            i++;
                        }
                    }

                    ExcelWorkBook.Worksheets[1].Name = "Raport zgód RODO";
                    ExcelWorkBook.SaveAs(path);
                    //zapisuj.WriteLine("po zapisie workbook");

                    ExcelWorkBook.Close();

                    ExcelApp.Quit();
                    MessageBox.Show("Raport zapisano pomyślnie w: " + saveFileDialog.FileName);
                }

                catch (Exception)
                {
                    //zapisuj.WriteLine("exception:" + exHandle);
                }

                finally
                {
                    //zapisuj.WriteLine("Koniec");
                    //zapisuj.Close();


                    foreach (Process process in Process.GetProcessesByName("Excel"))
                    {
                        process.Kill();
                    }
                }

            }


        }
    }
}
