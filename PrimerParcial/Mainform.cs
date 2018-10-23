using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }


        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registro.Registro rA = new UI.Registro.Registro();
            rA.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consulta.Consulta c = new UI.Consulta.Consulta();
            c.Show();
        }

        private void metasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registro.rmetas m = new UI.Registro.rmetas();
            m.Show();
        }
    }
}
