using PrimerParcial.DAL;
using PrimerParcial.Entidades;
using SegundoParcial.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PrimerParcial.UI.Registro
{

    public partial class Registro : Form
    {
        RepositorioBase<Vendedores> repositorio;
        public Registro()
        {
            InitializeComponent();
        }

        public bool validar()
        {

            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "llenar Nombre");

                return false;
            }

            if (string.IsNullOrEmpty(SueldonumericUpDown.ToString()))
            {
                errorProvider1.SetError(SueldonumericUpDown, "No debes dejar el sueldo vacio");
                return false;

            }

            if (string.IsNullOrEmpty(PorcientoRetencionnumericUpDown.ToString()))
            {
                errorProvider1.SetError(PorcientoRetencionnumericUpDown, "No debes dejar el porciento vacio");
                return false;

            }
            return true;
        }

        private Vendedores LLenaClase()
        {
            Vendedores vendedor = new Vendedores();
            vendedor.VendedroresId = Convert.ToInt32(IdnumericUpDown.Value);
            vendedor.Fecha = FechadateTimePicker.Value;
            vendedor.Nombres = NombretextBox.Text;
            vendedor.Sueldo = Convert.ToInt32(SueldonumericUpDown.Value);
            vendedor.PorcentajeRentencion = Convert.ToInt32(PorcientoRetencionnumericUpDown.Value);
            vendedor.Retencion = RetenciontextBox.Text;

            return vendedor;

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombretextBox.Clear();
            SueldonumericUpDown.Value = 0;
            PorcientoRetencionnumericUpDown.Value = 0;
            RetenciontextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedores>(new Contexto());
            if (!validar())
            {
                MessageBox.Show("llena", "y trate de guardar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

            {
                Vendedores vendedor = LLenaClase();
                bool paso = false;


                if (IdnumericUpDown.Value == 0)
                {
                    paso = repositorio.Guardar(vendedor);
                }
                else
                {
                    paso = repositorio.Modificar(vendedor);
                }

                if (paso)
                {
                    MessageBox.Show("guardado", "se guardo exitosamente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            if (BLL.VendedoresBLL.Eliminar(id))
                MessageBox.Show("fue eliminado", "acceptado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Vendedores vendedor = repositorio.Buscar(id);


            if (vendedor != null)

            {
                FechadateTimePicker.Value = vendedor.Fecha;
                NombretextBox.Text = vendedor.Nombres;
                SueldonumericUpDown.Value = vendedor.Sueldo;
                PorcientoRetencionnumericUpDown.Value = vendedor.PorcentajeRentencion;
                RetenciontextBox.Text = Convert.ToString((vendedor.Sueldo * vendedor.PorcentajeRentencion) / 100);

            }
            else
            {
                MessageBox.Show("no encontrado", "Buscar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SueldonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PorcientoRetencionnumericUpDown.Value != 0 && SueldonumericUpDown.Value != 0)
            {
                RetenciontextBox.Text = Convert.ToString((SueldonumericUpDown.Value * PorcientoRetencionnumericUpDown.Value) / 100);
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            List<Metasdetalle> Detalle = new List<Metasdetalle>();
            rmetas rmeta = new rmetas();
            if (DetalledataGridView.DataSource != null)
            {
                Detalle = (List<Metasdetalle>)DetalledataGridView.DataSource;
            }



            Detalle.Add(
              new Metasdetalle(
                   MetaID: 0,
                  Descripcion: (string)DescripciontextBox.ToString(),
                   Cuota: (int)CuotanumericUpDown.Value

             ));

            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = Detalle;
        }

        private void LlenarCampos(Metas Meta)
        {
            MetanumericUpDown.Value = Meta.MetaID;
            DescripciontextBox.Text = Meta.Descripcion;
            CuotanumericUpDown.Value = Meta.Cuota;
            


            DetalledataGridView.DataSource = Meta.Detalle;


            DetalledataGridView.Columns["Id"].Visible = false;
            DetalledataGridView.Columns["MetaID"].Visible = false;
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            
                if (DetalledataGridView.Rows.Count > 0
                  && DetalledataGridView.CurrentRow != null)
                {

                    List<Metasdetalle> Detalle
                        = (List<Metasdetalle>)DetalledataGridView.DataSource;

                    Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);


                    DetalledataGridView.DataSource = null;
                    DetalledataGridView.DataSource = Detalle;
                }
           
        }

        private bool Errores()
        {
            bool Errores = false;

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox,
                    "No debes dejar el Descripcion vacio");
                Errores = true;
            }

            if (DetalledataGridView.RowCount == 0)
            {
                errorProvider1.SetError(DetalledataGridView,
                    "escribir Cuota");
                Errores = true;
            }

            return Errores;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;

            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }
    }
}

