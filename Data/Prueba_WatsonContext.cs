using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba_Watson.Models;

namespace Prueba_Watson.Models
{
    public class Prueba_WatsonContext : DbContext
    {
        public Prueba_WatsonContext (DbContextOptions<Prueba_WatsonContext> options)
            : base(options)
        {
        }

        public DbSet<Prueba_Watson.Models.Persona> Persona { get; set; }

        public DbSet<Prueba_Watson.Models.Usuario> Usuario { get; set; }
    }
}
