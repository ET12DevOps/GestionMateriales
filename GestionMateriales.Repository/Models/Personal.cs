using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Personal
    {
        public Personal()
        {
            Ordencompra = new HashSet<Ordencompra>();
            OrdentrabajoJefeSeccionIdPersonalNavigation = new HashSet<Ordentrabajo>();
            OrdentrabajoSolicitanteIdPersonalNavigation = new HashSet<Ordentrabajo>();
            OrdentrabajoaplicacionJefeSeccionIdPersonalNavigation = new HashSet<Ordentrabajoaplicacion>();
            OrdentrabajoaplicacionResponsableIdPersonalNavigation = new HashSet<Ordentrabajoaplicacion>();
        }

        public int IdPersonal { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public int FichaCensal { get; set; }
        public bool Hab { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIp { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedIp { get; set; }

        public virtual ICollection<Ordencompra> Ordencompra { get; set; }
        public virtual ICollection<Ordentrabajo> OrdentrabajoJefeSeccionIdPersonalNavigation { get; set; }
        public virtual ICollection<Ordentrabajo> OrdentrabajoSolicitanteIdPersonalNavigation { get; set; }
        public virtual ICollection<Ordentrabajoaplicacion> OrdentrabajoaplicacionJefeSeccionIdPersonalNavigation { get; set; }
        public virtual ICollection<Ordentrabajoaplicacion> OrdentrabajoaplicacionResponsableIdPersonalNavigation { get; set; }
    }
}
