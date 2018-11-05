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
    public partial class SekcjaAkcesoriow : Form
    {
        public Glowna glowna;
        int aktualny = 0;
        public SekcjaAkcesoriow(Glowna g)
        {
            glowna = g;
            InitializeComponent();
            AktualizujGrida();
            cbWarunek.SelectedIndex = 0;
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            DodajAkcesoria dodaj = new DodajAkcesoria(this);
            dodaj.Show(this);
            this.Enabled = false;
        }

        private void btSprzedaj_Click(object sender, EventArgs e)
        {
            if (glowna.listaAkcesoriow.Count() > 0 && glowna.listaAkcesoriow[zwroc_id(aktualny)].Ilosc > 0)
            {
                SprzedajAkcesoria sprzedaj = new SprzedajAkcesoria(this, zwroc_id(aktualny));
                sprzedaj.Show();
                this.Enabled = false;
            }
        }

        private void btUsun_Click(object sender, EventArgs e)
        {
            if (glowna.listaAkcesoriow.Count() > 0)
            {
                string message = "Czy na pewno chcesz usunąć akcesoria: " + glowna.listaAkcesoriow[zwroc_id(aktualny)].Nazwa + "?";
                if (MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    glowna.listaAkcesoriow.RemoveAt(zwroc_id(aktualny));
                }
            }
            dgvAkcesoria.DataSource = null;
            List<Czesc> temp = glowna.listaAkcesoriow;
            dgvAkcesoria.DataSource = temp;
            glowna.nadpiszAkcesoria();
        }


        public void AktualizujGrida()
        {
            dgvAkcesoria.DataSource = null;
            List<Czesc> temp = new List<Czesc>();
            if (chbDostepne.Checked)
            {
                for (int i = 0; i < glowna.listaAkcesoriow.Count(); i++)
                {
                    if (glowna.listaAkcesoriow[i].Dostepny == "TAK")
                    {
                        temp.Add(glowna.listaAkcesoriow[i]);
                    }
                }
            }
            else
            {
                temp = glowna.listaAkcesoriow;
            }
            dgvAkcesoria.DataSource = temp;
            tbSzukajka.Text = "";
            this.Refresh();
        }

        private void BtZamknij_Click(object sender, EventArgs e)
        {
            Close();
            glowna.Enabled = true;
            glowna.Focus();
        }

        private void SekcjaAkcesoriow_FormClosing(object sender, FormClosingEventArgs e)
        {
            glowna.Enabled = true;
            glowna.Focus();
            glowna.generujRaport();
            glowna.nadpiszAkcesoria();
        }

        private void dgvArtykuly_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                aktualny = Convert.ToInt32(dgvAkcesoria.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private int zwroc_id(int akt)
        {
            int index = 0;
            for (int i = 0; i < glowna.listaAkcesoriow.Count(); i++)
            {
                if (glowna.listaAkcesoriow[i].Id == akt)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private void tbSzukajka_TextChanged(object sender, EventArgs e)
        {
            List<Czesc> temp = new List<Czesc>();
            if (tbSzukajka.Text.Length > 0)
            {
                if (chbDostepne.Checked)
                {
                    for (int i = 0; i < glowna.listaAkcesoriow.Count(); i++)
                    {
                        if (glowna.listaAkcesoriow[i].Nazwa.ToUpper().Contains(tbSzukajka.Text.ToUpper()) && glowna.listaAkcesoriow[i].Dostepny == "TAK")
                        {
                            temp.Add(glowna.listaAkcesoriow[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < glowna.listaAkcesoriow.Count(); i++)
                    {
                        if (glowna.listaAkcesoriow[i].Nazwa.ToUpper().Contains(tbSzukajka.Text.ToUpper()))
                        {
                            temp.Add(glowna.listaAkcesoriow[i]);
                        }
                    }
                }
            }
            else
            {
                if (chbDostepne.Checked)
                {
                    for (int i = 0; i < glowna.listaAkcesoriow.Count(); i++)
                    {
                        if (glowna.listaAkcesoriow[i].Dostepny == "TAK")
                        {
                            temp.Add(glowna.listaAkcesoriow[i]);
                        }
                    }
                }
                else
                {
                    temp = glowna.listaAkcesoriow;
                }
            }
            dgvAkcesoria.DataSource = null;
            dgvAkcesoria.DataSource = temp;
            if (temp.Count > 0)
            {
                aktualny = Convert.ToInt32(dgvAkcesoria.Rows[0].Cells[0].Value);
            }
            else
            {
                aktualny = 0;
            }
        }

        private void chbDostepne_CheckedChanged(object sender, EventArgs e)
        {
            List<Czesc> temp = new List<Czesc>();
            if (chbDostepne.Checked)
            {
                chbSprzedane.Checked = false;
                for (int i = 0; i < glowna.listaAkcesoriow.Count(); i++)
                {
                    if (glowna.listaAkcesoriow[i].Dostepny == "TAK")
                    {
                        temp.Add(glowna.listaAkcesoriow[i]);
                    }
                }
            }
            else
            {
                temp = glowna.listaAkcesoriow;
            }
            dgvAkcesoria.DataSource = temp;
        }

        private void dgvAkcesoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                aktualny = Convert.ToInt32(dgvAkcesoria.Rows[e.RowIndex].Cells[0].Value);
                if (glowna.listaAkcesoriow[zwroc_id(aktualny)].Ilosc > 0)
                {
                    SprzedajAkcesoria sprzedaj = new SprzedajAkcesoria(this, zwroc_id(aktualny));
                    sprzedaj.Show();
                    this.Enabled = false;
                }
            }
        }

        private void chbSprzedane_CheckedChanged(object sender, EventArgs e)
        {
            List<Czesc> temp = new List<Czesc>();
            if (chbSprzedane.Checked)
            {
                chbDostepne.Checked = false;
                for (int i = 0; i < glowna.listaAkcesoriow.Count(); i++)
                {
                    if (glowna.listaAkcesoriow[i].Dostepny == "NIE")
                    {
                        temp.Add(glowna.listaAkcesoriow[i]);
                    }
                }
            }
            else
            {
                temp = glowna.listaAkcesoriow;
            }
            dgvAkcesoria.DataSource = temp;
        }
    }
}
