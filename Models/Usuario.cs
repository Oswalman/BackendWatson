using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Watson.Models
{
    public class Usuario
    {
        [Key]
        public int Identificador { get; set; }
         public string Username { get; set; }
        public string Clave { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }
    }
}
