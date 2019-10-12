using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Tipoordentrabajo
    {
        public Tipoordentrabajo()
        {
            Ordentrabajo = new HashSet<Ordentrabajo>();
        }

        public int IdTipoOrdenTrabajo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Ordentrabajo> Ordentrabajo { get; set; }
    }
}
