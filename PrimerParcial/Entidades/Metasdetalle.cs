


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace PrimerParcial.Entidades
{
    public class Metasdetalle
    {
        
     
            [Key]
            
            public int MetaID { get; set; }
            public string Descripcion { get; set; }
            public decimal Cuota { get; set; }


            [ForeignKey("MetaId")]

            public virtual Vendedores vendedor { get; set; }
            
        public Metasdetalle()
            {
                this.MetaID = 0;
                this.Descripcion = string.Empty;
                this.Cuota = 0;
            }

        public Metasdetalle(int MetaID, string Descripcion, int Cuota)
        {
            this.MetaID = 0;
            this.Descripcion = string.Empty;
            this.Cuota = 0;
        }
    }
}
