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


        [StringLength(100)]
        

        public virtual ICollection<Metasdetalle> Detalle { get; set; }

        public Metas()
        {
            this.Detalle = new List<Metasdetalle>();
        }
        public void AgregarDetalle( int MetaID, string Descripcion, int Cuota)
        {
            this.Detalle.Add(new Metasdetalle( MetaID, Descripcion, Cuota));
        }
    }
}
