using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Ordentrabajoaplicacion
    {
        public Ordentrabajoaplicacion()
        {
            Itemordentrabajoaplicacion = new HashSet<Itemordentrabajoaplicacion>();
        }

        public int IdOrdenTrabajoAplicacion { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public int IdTurno { get; set; }
        public DateTime Fecha { get; set; }
        public short Hab { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIp { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedIp { get; set; }
        public int JefeSeccionIdPersonal { get; set; }
        public int ResponsableIdPersonal { get; set; }

        public virtual Turno IdTurnoNavigation { get; set; }
        public virtual Personal JefeSeccionIdPersonalNavigation { get; set; }
        public virtual Personal ResponsableIdPersonalNavigation { get; set; }
        public virtual ICollection<Itemordentrabajoaplicacion> Itemordentrabajoaplicacion { get; set; }
    }
}
