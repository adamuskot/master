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
    public partial class KategorieProduktow : Form
    {
        Glowna glowna;
        public KategorieProduktow(Glowna g)
        {
            glowna = g;
            InitializeComponent();
            foreach (string item in g.kategorieProduktow)
            {
                RTBStatusy.AppendText(item + "\r\n");
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            List<string> statusy = new List<string>();
            foreach (string item in RTBStatusy.Lines)
            {
                if (item != string.Empty)
                {
                    statusy.Add(item);
                }
            }
            glowna.kategorieProduktow = statusy;
            glowna.nadpiszUstawienia();
            Close();
            glowna.Enabled = true;
            glowna.generujRaport();
            glowna.Focus();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            glowna.Enabled = true;
            glowna.Focus();
            glowna.generujRaport();
        }

        private void StatusyProduktow_FormClosing(object sender, FormClosingEventArgs e)
        {
            glowna.Enabled = true;
            glowna.Focus();
            glowna.generujRaport();
        }
    }
}
