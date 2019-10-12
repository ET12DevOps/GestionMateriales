using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Ordentrabajo
    {
        public Ordentrabajo()
        {
            Itemordentrabajo = new HashSet<Itemordentrabajo>();
        }

        public int IdOrdenTrabajo { get; set; }
        public int Numero { get; set; }
        public string Encabezado { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        public string DescripcionTarea { get; set; }
        public DateTime Fechainiciada { get; set; }
        public DateTime FechaTerminada { get; set; }
        public DateTime FechaIngresoDeposito { get; set; }
        public short Hab { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIp { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedIp { get; set; }
        public int JefeSeccionIdPersonal { get; set; }
        public int SolicitanteIdPersonal { get; set; }
        public int TipoOrdenTrabajoIdTipoOrdenTrabajo { get; set; }

        public virtual Personal JefeSeccionIdPersonalNavigation { get; set; }
        public virtual Personal SolicitanteIdPersonalNavigation { get; set; }
        public virtual Tipoordentrabajo TipoOrdenTrabajoIdTipoOrdenTrabajoNavigation { get; set; }
        public virtual ICollection<Itemordentrabajo> Itemordentrabajo { get; set; }
    }
}
