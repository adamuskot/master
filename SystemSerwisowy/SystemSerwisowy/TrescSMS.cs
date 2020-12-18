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
            RTBTrescSMS.Clear();
            cbWyborTresci.SelectedIndex = -1;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (cbWyborTresci.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz rodzaj treści!");
            }
            else
            {

                string tresc = "";
                foreach (string item in RTBTrescSMS.Lines)
                {
                    tresc += item;
                }

                switch (cbWyborTresci.SelectedIndex)
                {
                    case 0:
                        glowna.trescSmsNaprawiony = tresc;
                        break;
                    case 1:
                        glowna.trescSmsNienaprawiony = tresc;
                        break;
                    case 2:
                        glowna.trescSmsInny = tresc;
                        break;
                }
                glowna.nadpiszUstawienia();
                Close();
                glowna.Enabled = true;
                glowna.Focus();
            }
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

        private void cbWyborTresci_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbWyborTresci.SelectedIndex)
            {
                case 0:
                    RTBTrescSMS.Text = glowna.trescSmsNaprawiony;
                    break;
                case 1:
                    RTBTrescSMS.Text = glowna.trescSmsNienaprawiony;
                    break;
                case 2:
                    RTBTrescSMS.Text = glowna.trescSmsInny;
                    break;
            }
        }
    }
}
