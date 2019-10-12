using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Sector
    {
        public Sector()
        {
            Tipoentradamaterial = new HashSet<Tipoentradamaterial>();
            Tiposalidamaterial = new HashSet<Tiposalidamaterial>();
        }

        public int IdSector { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Tipoentradamaterial> Tipoentradamaterial { get; set; }
        public virtual ICollection<Tiposalidamaterial> Tiposalidamaterial { get; set; }
    }
}
