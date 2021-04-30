using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Watson.Models
{
    public class Persona
    {
        [Key]
        public int Identificador { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string  TipoDocumento { get; set; }
        public DateTime FechaCreacion { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string SumaDocumento
        {
            get { return TipoDocumento + " " + Documento; }
            private set { /* needed for EF */ }
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string SumaNombres
        {
            get { return Nombres + " " + Apellidos; }
            private set { /* needed for EF */ }
        }
        [ForeignKey("IdPersona")]
        public Usuario Usuario { get; set; }

    }
}
