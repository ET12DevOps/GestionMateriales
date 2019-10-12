using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Itemordentrabajoaplicacion
    {
        public int IdItemOrdenTrabajoAplicacion { get; set; }
        public string Destino { get; set; }
        public int Cantidad { get; set; }
        public int MaterialIdMaterial { get; set; }
        public int OrdenTrabajoAplicacionIdOrdenTrabajoAplicacion { get; set; }

        public virtual Material MaterialIdMaterialNavigation { get; set; }
        public virtual Ordentrabajoaplicacion OrdenTrabajoAplicacionIdOrdenTrabajoAplicacionNavigation { get; set; }
    }
}
