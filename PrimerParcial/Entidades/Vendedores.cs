using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PrimerParcial.Entidades
{
    public class Vendedores
    {
        [Key]
        public int VendedroresId { get; set; }
        public string Nombres { get; set; }
        public decimal Sueldo { get; set; }
        public decimal PorcentajeRentencion { get; set; }
        public string Retencion { get; set; }
        public DateTime Fecha { get; set; }

        public Vendedores()
        {
            VendedroresId = 0;
            Nombres = string.Empty;
            Sueldo = 0;
            PorcentajeRentencion = 0;
            Retencion = string.Empty;
            Fecha = DateTime.Now;

           
        }
    }
}
