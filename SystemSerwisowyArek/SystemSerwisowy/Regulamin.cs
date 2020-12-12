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
    public partial class Regulamin : Form
    {
        Glowna glowna;
        public Regulamin(Glowna g)
        {
            glowna = g;
            InitializeComponent();
            uzupelnijRegulamin();
            label1.MaximumSize = new Size(800, 0);
            label1.AutoSize = true;
        }

        private void btZapisz_Click(object sender, EventArgs e)
        {
            if (RTBRegulamin.Lines.Count() > 0)
            {
                glowna.regulamin.Clear();
                for (int i = 0; i < RTBRegulamin.Lines.Count(); i++)
                {
                    glowna.regulamin.Add(RTBRegulamin.Lines[i].ToString());
                }
            }

            glowna.nadpiszRegulamin();
            Close();
            glowna.Enabled = true;
            glowna.Focus();
        }

        private void uzupelnijRegulamin()
        {
            for (int i = 0; i < glowna.regulamin.Count(); i++)
            {
                if (i == glowna.regulamin.Count() - 1)
                {
                    RTBRegulamin.AppendText(glowna.regulamin[i]);
                }
                else
                {
                    RTBRegulamin.AppendText(glowna.regulamin[i] + "\n");
                }
            }
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            Close();
            glowna.Enabled = true;
            glowna.Focus();
        }

        private void Regulamin_FormClosing(object sender, FormClosingEventArgs e)
        {
            glowna.Enabled = true;
            glowna.Focus();
        }
    }
}
