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
        DateTime startTime;
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
            groupBoxWylosowano.Visible = false;
            groupBoxPrzerwij.Visible = false;
            textBoxZakresOd.Enabled = true;
            textBoxZakresDo.Enabled = true;
            buttonLosuj.Enabled = true;
            buttonPrzerwij.Enabled = true;
            Odpowiedz.Text = "Odpowiedź";
            Odpowiedz.ForeColor = Color.Black;
            textBoxWylosowana.Text = "";

            czas2.Text = "";
            liczbaRuchow2.Text = "";
            wylosowana2.Text = "";
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            //Zakres do losowania
            int a = 0, b = 0;

            try
            {
                a = int.Parse(textBoxZakresOd.Text);
                b = int.Parse(textBoxZakresDo.Text);

                //Nowa gra

                g = new Gra(a, b);
                textBoxZakresOd.Enabled = false;
                textBoxZakresDo.Enabled = false;
                buttonLosuj.Enabled = false;


                startTime = DateTime.Now;
                timer1.Tick += (s, ev) => { czas.Text = String.Format("{0:00}", (DateTime.Now - startTime).ToString()); };
                startTime = DateTime.Now;
                timer1.Interval = 100;
                timer1.Start();

                //Wyswietl kolejne elementy formularza

                groupBoxWylosowano.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Musisz podać liczbę całkowitą.");
            }
        }

        private void groupBoxLosuj_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxWylosowano_Enter(object sender, EventArgs e)
        {

        }


        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            try
            {
                switch (g.Ocena(int.Parse(textBoxWylosowana.Text)))
                {
                    case Gra.Odpowiedz.ZaMalo:
                        Odpowiedz.Text = "Za mało";
                        Odpowiedz.ForeColor = Color.Red;
                        break;
                    case Gra.Odpowiedz.ZaDuzo:
                        Odpowiedz.Text = "Za dużo";
                        Odpowiedz.ForeColor = Color.Red;
                        break;
                    case Gra.Odpowiedz.Trafiono:
                        Odpowiedz.Text = "Trafiłeś";
                        Odpowiedz.ForeColor = Color.Green;
                        buttonPrzerwij_Click(sender, e);
                        timer1.Stop();
                        czas.Text = "";
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj liczbe.");
            }
        }


        // przycisk przerwij/poddaj

        private void buttonPrzerwij_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            g.Poddaj();
            groupBoxPrzerwij.Visible = true;
            czas2.Text = (DateTime.Now - startTime).ToString();
            liczbaRuchow2.Text = g.LicznikRuchow.ToString();
            wylosowana2.Text = g.Wylosowana.ToString();
            buttonPrzerwij.Enabled = false;
            buttonNowaGra.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHistoria_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(g);
            form3.Show();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBoxZakresOd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
