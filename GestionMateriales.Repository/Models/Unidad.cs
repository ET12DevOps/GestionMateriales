using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Unidad
    {
        public Unidad()
        {
            Material = new HashSet<Material>();
        }

        public int IdUnidad { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Material> Material { get; set; }
    }
}
