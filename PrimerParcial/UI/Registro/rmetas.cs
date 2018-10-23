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

namespace PrimerParcial.UI.Registro
{
    public partial class rmetas : Form
    {
        RepositorioBase<Metas> repositorio;
        public rmetas()
        {
            InitializeComponent();
        }


        public bool validar()
        {

            if (string.IsNullOrEmpty(MetaIdnumericUpDown.ToString()))
            { 
                errorProvider1.SetError(MetaIdnumericUpDown, "Meta");

                return false;
            }

            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "llena descripcion");
                return false;

            }

            if (string.IsNullOrEmpty(cuotanumericUpDown.ToString()))
            {
                errorProvider1.SetError(cuotanumericUpDown, "Llena Cuota");
                return false;

            }
            return true;
        }


        private Metas LLenaClase()
        {
            Metas Meta = new Metas();
            Meta.MetaID = Convert.ToInt32(MetaIdnumericUpDown.Value);
            Meta.Descripcion = DescripciontextBox.Text;
            Meta.Cuota = cuotanumericUpDown.Value = Convert.ToInt32(cuotanumericUpDown.Value); 

            return Meta;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           
                repositorio = new RepositorioBase<Metas>(new Contexto());
                if (!validar())
                {
                    MessageBox.Show("llena", "y trate de guardar de nuevo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                {
                    Metas Meta = LLenaClase();
                    bool paso = false;


                    if (MetaIdnumericUpDown.Value == 0)
                    {
                        paso = repositorio.Guardar(Meta);
                    }
                    else
                    {
                        paso = repositorio.Modificar(Meta);
                    }

                    if (paso)
                    {
                        MessageBox.Show("guardado", "se guardo exitosamente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
    }  
}

