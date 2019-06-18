using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxZakresOd.Text);
            int b = int.Parse(textBoxZakresDo.Text);

            g = new Gra(a, b);

            buttonLosuj.Enabled = false;
            textBoxZakresOd.Enabled = false;
            textBoxZakresDo.Enabled = false;

            groupBoxWylosowano.Visible = true;
            buttonLosuj.Enabled = false;

            // pokazać następne elementy formularza

        }

        private void groupBoxLosuj_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxWylosowano_Enter(object sender, EventArgs e)
        {

        }


        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxWylosowana.Text);
            g.Ocena(propozycja);
        }


        // przycisk przerwij/poddaj

        private void buttonPrzerwij_Click(object sender, EventArgs e)
        {
            g.Poddaj();
        }

    }
}
