using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Itemordentrabajo
    {
        public int IdItemOrdenTrabajo { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaRetiro { get; set; }
        public int MaterialIdMaterial { get; set; }
        public int OrdenTrabajoIdOrdenTrabajo { get; set; }

        public virtual Material MaterialIdMaterialNavigation { get; set; }
        public virtual Ordentrabajo OrdenTrabajoIdOrdenTrabajoNavigation { get; set; }
    }
}
