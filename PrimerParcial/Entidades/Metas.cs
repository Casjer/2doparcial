using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PrimerParcial.Entidades
{
    public class Metas
    {
        [Key]
        public int MetaID { get; set; }
        public string Descripcion { get; set; }
        public decimal Cuota { get; set; }

        public Metas()
        {
            this.MetaID = 0;
            this.Descripcion = string.Empty;
            this.Cuota = 0;
        }
    }
}
