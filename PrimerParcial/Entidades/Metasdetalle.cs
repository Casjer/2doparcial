


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PrimerParcial.Entidades
{
    class Metasdetalle
    {
        public class Metas
        {
            [Key]
            public int MetaID { get; set; }
            public string Descripcion { get; set; }
            public decimal Cuota { get; set; }

            public Metas()
            {
                MetaID = 0;
                Descripcion = string.Empty;
                Cuota = 0;
            }
        }
    }
}
