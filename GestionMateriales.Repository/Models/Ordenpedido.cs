using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Ordenpedido
    {
        public Ordenpedido()
        {
            Itemordenpedido = new HashSet<Itemordenpedido>();
        }

        public int IdOrdenPedido { get; set; }
        public int NumeroOrdenPedido { get; set; }
        public int NumeroOrdenTrabajoAplicacion { get; set; }
        public string Destino { get; set; }
        public short Hab { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime CreatedBy { get; set; }
        public string CreationDate { get; set; }
        public string CreationIp { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedIp { get; set; }

        public virtual ICollection<Itemordenpedido> Itemordenpedido { get; set; }
    }
}
