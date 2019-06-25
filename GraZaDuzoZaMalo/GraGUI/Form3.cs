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
    public partial class Form3 : Form
    {
        public Form3(Gra gra)
        {
            InitializeComponent();
            dataGridView1.Invalidate();
            dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.DataSource = gra.getRuchy();
            dataGridView1.Columns[0].DataPropertyName = "propozycja";

        }
    }
}
