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
    public partial class Przypominacz : Form
    {
        public Przypominacz(List<string> lista)
        {
            InitializeComponent();
            lbLista.DataSource = lista;
            lbLista.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbLista_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(lbLista.Items[e.Index].ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }
    }
}
