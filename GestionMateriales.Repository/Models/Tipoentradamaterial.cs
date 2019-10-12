using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Tipoentradamaterial
    {
        public Tipoentradamaterial()
        {
            Entradamaterial = new HashSet<Entradamaterial>();
        }

        public int IdTipoEntradaMaterial { get; set; }
        public string Nombre { get; set; }
        public int SectorIdSector { get; set; }

        public virtual Sector SectorIdSectorNavigation { get; set; }
        public virtual ICollection<Entradamaterial> Entradamaterial { get; set; }
    }
}
