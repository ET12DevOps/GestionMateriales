using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Tiposalidamaterial
    {
        public Tiposalidamaterial()
        {
            Salidamaterial = new HashSet<Salidamaterial>();
        }

        public int IdTipoSalidaMaterial { get; set; }
        public string Nombre { get; set; }
        public int SectorIdSector { get; set; }

        public virtual Sector SectorIdSectorNavigation { get; set; }
        public virtual ICollection<Salidamaterial> Salidamaterial { get; set; }
    }
}
