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
    public partial class TrescSMS : Form
    {
        Glowna glowna;
        public TrescSMS(Glowna g)
        {
            glowna = g;
            InitializeComponent();
            uzupelnijTrescSms();
        }

        private void uzupelnijTrescSms()
        {
            RTBTrescSMS.AppendText(glowna.trescSms);
            tbNadawca.Text = glowna.nadawcaSms;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            string tresc = "";
            foreach (string item in RTBTrescSMS.Lines)
            {
                tresc += item;
            }
            glowna.trescSms = tresc;
            if (tbNadawca.Text != "")
            {
                glowna.nadawcaSms = tbNadawca.Text;
            }
            glowna.nadpiszUstawienia();
            Close();
            glowna.Enabled = true;
            glowna.Focus();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            glowna.Enabled = true;
            glowna.Focus();
        }

        private void TrescSMS_FormClosing(object sender, FormClosingEventArgs e)
        {
            glowna.Enabled = true;
            glowna.Focus();
        }
    }
}
