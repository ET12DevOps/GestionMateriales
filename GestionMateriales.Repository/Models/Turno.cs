using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Turno
    {
        public Turno()
        {
            Ordentrabajoaplicacion = new HashSet<Ordentrabajoaplicacion>();
        }

        public int IdTurno { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Ordentrabajoaplicacion> Ordentrabajoaplicacion { get; set; }
    }
}
