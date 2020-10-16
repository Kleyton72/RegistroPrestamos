using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPrestamos.Entities
{
    public class Personas {
        [Key]
        public int PersonaID { get; set; }
        public string Nombres { get; set; }
        public float Balance { get; set; }

        [ForeignKey("PersonaID")]
        public virtual List<Prestamos> Prestamos { get; set; }
    }   
}