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
    public partial class FirmaDane : Form
    {
        Glowna glowna;
        Firma firma;
        public FirmaDane(Glowna g, Firma f)
        {
            InitializeComponent();
            glowna = g;
            firma = f;
            uzupelnijFormularz();
        }

        private void uzupelnijFormularz()
        {
            tbCzynne.Text = firma.Czynne;
            tbEmail.Text = firma.Email;
            tbMiasto.Text = firma.Miasto;
            tbTelefon.Text = firma.Telefon;
            tbUlica.Text = firma.Ulica;
            tbNazwaRodo.Text = firma.NazwaRodo;
        }

        private void btZapisz_Click(object sender, EventArgs e)
        {
            firma.Czynne = tbCzynne.Text;
            firma.Email = tbEmail.Text;
            firma.Miasto = tbMiasto.Text;
            firma.Telefon = tbTelefon.Text;
            firma.Ulica = tbUlica.Text;
            firma.NazwaRodo = tbNazwaRodo.Text;
            glowna.nadpiszFirme();
            Close();
            glowna.Enabled = true;
            glowna.Focus();
            glowna.generujRaport();
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            glowna.Enabled = true;
            glowna.Focus();
            glowna.generujRaport();
        }

        private void FirmaDane_FormClosing(object sender, FormClosingEventArgs e)
        {
            glowna.Enabled = true;
            glowna.Focus();
        }
    }
}
