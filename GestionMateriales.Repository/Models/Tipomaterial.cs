using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Tipomaterial
    {
        public Tipomaterial()
        {
            Material = new HashSet<Material>();
        }

        public int IdTipoMaterial { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Material> Material { get; set; }
    }
}
