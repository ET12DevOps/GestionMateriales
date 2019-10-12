using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Itemordenpedido
    {
        public int IdItemOrdenPedido { get; set; }
        public int Cantidad { get; set; }
        public int MaterialIdMaterial { get; set; }
        public int OrdenPedidoIdOrdenPedido { get; set; }

        public virtual Material MaterialIdMaterialNavigation { get; set; }
        public virtual Ordenpedido OrdenPedidoIdOrdenPedidoNavigation { get; set; }
    }
}
