using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial.UI.Consulta
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Vendedores, bool>> filtro = x => true;

            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(CriteriotextBox.Text);
                    filtro = x => x.VendedroresId == id
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 1:// Fecha
                    filtro = x => x.Fecha.Equals(CriteriotextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 2:// Nombre
                    filtro = x => x.Nombres.Equals(CriteriotextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 3:// Sueldo
                    filtro = x => x.Sueldo.Equals(CriteriotextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 4:// Retencion
                    filtro = x => x.Retencion.Equals(CriteriotextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 5://todo
                    ConsultadataGridView.DataSource = BLL.VendedoresBLL.GetList(filtro);
                    break;
            }
            ConsultadataGridView.DataSource = BLL.VendedoresBLL.GetList(filtro);
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 5)
            {
                CriteriotextBox.Enabled = false;
            }
            else
            {
                CriteriotextBox.Enabled = true;
            }
        }
    }
}
