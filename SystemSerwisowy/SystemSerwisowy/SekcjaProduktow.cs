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
    public partial class SekcjaProduktow : Form
    {
        public Glowna glowna;
        int aktualny = 0;
        public SekcjaProduktow(Glowna g)
        {
            glowna = g;
            InitializeComponent();
            AktualizujGrida();
            cbWarunek.SelectedIndex = 0;
        }

        private void btDodawanie_Click(object sender, EventArgs e)
        {
            DodajProdukt dodaj = new DodajProdukt(this);
            dodaj.Show(this);
            this.Enabled = false;
        }

        public void AktualizujGrida()
        {
            dgvProdukty.DataSource = null;
            List<Produkt> temp = new List<Produkt>();
            if (chkDostepne.Checked)
            {
                for (int i = 0; i < glowna.listaProduktow.Count(); i++)
                {
                    if (glowna.listaProduktow[i].Dostepny == "TAK")
                    {
                        temp.Add(glowna.listaProduktow[i]);
                    }
                }
            }
            else
            {
                temp = glowna.listaProduktow;
            }
            dgvProdukty.DataSource = temp;
            tbSzukajka.Text = "";
            this.Refresh();
        }

        private void btZamknij_Click(object sender, EventArgs e)
        {
            Close();
            glowna.Enabled = true;
            glowna.Focus();
        }

        private void SekcjaProduktow_FormClosing(object sender, FormClosingEventArgs e)
        {
            glowna.Enabled = true;
            glowna.Focus();
            glowna.generujRaport();
            glowna.nadpiszProdukty();
        }

        private void btSprzedaz_Click(object sender, EventArgs e)
        {
            if (glowna.listaProduktow.Count() > 0 && glowna.listaProduktow[zwroc_id(aktualny)].Ilosc>0)
            {
                SprzedajProdukt sprzedaj = new SprzedajProdukt(this, zwroc_id(aktualny));
                sprzedaj.Show();
                this.Enabled = false;
            }
        }

        private void dgvProdukty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                aktualny = Convert.ToInt32(dgvProdukty.Rows[e.RowIndex].Cells[0].Value);
            }
        }
         
        private int zwroc_id(int akt)
        {
            int index = 0;
            for (int i = 0; i < glowna.listaProduktow.Count(); i++)
            {
                if (glowna.listaProduktow[i].Id == akt)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private void btUsuwanie_Click(object sender, EventArgs e)
        {
            if (glowna.listaProduktow.Count() > 0 && glowna.listaProduktow[zwroc_id(aktualny)].Ilosc > 0)
            {
                string message ="Czy na pewno chcesz usunąć produkt: "+ glowna.listaProduktow[zwroc_id(aktualny)].Nazwa+"?";
                if (MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    glowna.listaProduktow.RemoveAt(zwroc_id(aktualny));
                }
            }
            dgvProdukty.DataSource = null;
            List<Produkt> temp = glowna.listaProduktow;
            dgvProdukty.DataSource = temp;
            glowna.nadpiszProdukty();
        }

        private void tbSzukajka_TextChanged(object sender, EventArgs e)
        {
            List<Produkt> temp = new List<Produkt>();
            if (tbSzukajka.Text.Length > 0)
            {
                if (cbWarunek.SelectedIndex == 0)
                {
                    if (chkDostepne.Checked)
                    {
                        for (int i = 0; i < glowna.listaProduktow.Count(); i++)
                        {
                            if (glowna.listaProduktow[i].Nazwa.ToUpper().Contains(tbSzukajka.Text.ToUpper()) && glowna.listaProduktow[i].Dostepny =="TAK")
                            {
                                temp.Add(glowna.listaProduktow[i]);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < glowna.listaProduktow.Count(); i++)
                        {
                            if (glowna.listaProduktow[i].Nazwa.ToUpper().Contains(tbSzukajka.Text.ToUpper()))
                            {
                                temp.Add(glowna.listaProduktow[i]);
                            }
                        }
                    }
                }
                else
                {
                    if (chkDostepne.Checked)
                    {
                        for (int i = 0; i < glowna.listaProduktow.Count(); i++)
                        {
                            if (glowna.listaProduktow[i].NumerSeryjny.ToUpper().Contains(tbSzukajka.Text.ToUpper()) && glowna.listaProduktow[i].Dostepny == "TAK")
                            {
                                temp.Add(glowna.listaProduktow[i]);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < glowna.listaProduktow.Count(); i++)
                        {
                            if (glowna.listaProduktow[i].NumerSeryjny.ToUpper().Contains(tbSzukajka.Text.ToUpper()))
                            {
                                temp.Add(glowna.listaProduktow[i]);
                            }
                        }
                    }
                }
            }
            else
            {
                if (chkDostepne.Checked)
                {
                    for (int i = 0; i < glowna.listaProduktow.Count(); i++)
                    {
                        if (glowna.listaProduktow[i].Dostepny == "TAK")
                        {
                            temp.Add(glowna.listaProduktow[i]);
                        }
                    }
                }
                else
                {
                    temp = glowna.listaProduktow;
                }
            }
            dgvProdukty.DataSource = null;
            dgvProdukty.DataSource = temp;
            if (temp.Count > 0)
            {
                aktualny = Convert.ToInt32(dgvProdukty.Rows[0].Cells[0].Value);
            }
            else
            {
                aktualny = 0;
            }
        }

        private void chkDostepne_CheckedChanged(object sender, EventArgs e)
        {
            List<Produkt> temp = new List<Produkt>();
            if (chkDostepne.Checked)
            {
                chbSprzedane.Checked = false;
                for (int i = 0; i < glowna.listaProduktow.Count(); i++)
                {
                    if (glowna.listaProduktow[i].Dostepny == "TAK")
                    {
                        temp.Add(glowna.listaProduktow[i]);
                    }
                }
            }
            else
            {
                temp = glowna.listaProduktow;
            }
            dgvProdukty.DataSource = temp;
        }

        private void dgvProdukty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                aktualny = Convert.ToInt32(dgvProdukty.Rows[e.RowIndex].Cells[0].Value);
                if (glowna.listaProduktow[zwroc_id(aktualny)].Ilosc > 0)
                {
                    SprzedajProdukt sprzedaj = new SprzedajProdukt(this, zwroc_id(aktualny));
                    sprzedaj.Show();
                    this.Enabled = false;
                }
            }
        }

        private void chbSprzedane_CheckedChanged(object sender, EventArgs e)
        {
            List<Produkt> temp = new List<Produkt>();
            if (chbSprzedane.Checked)
            {
                chkDostepne.Checked = false;
                for (int i = 0; i < glowna.listaProduktow.Count(); i++)
                {
                    if (glowna.listaProduktow[i].Dostepny == "NIE")
                    {
                        temp.Add(glowna.listaProduktow[i]);
                    }
                }
            }
            else
            {
                temp = glowna.listaProduktow;
            }
            dgvProdukty.DataSource = temp;
        }
    }
}
