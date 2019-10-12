using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Itemordencompra
    {
        public int IdItemOrdenCompra { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Subtotal { get; set; }
        public int MaterialIdMaterial { get; set; }
        public int OrdenCompraIdOrdenCompra { get; set; }

        public virtual Material MaterialIdMaterialNavigation { get; set; }
        public virtual Ordencompra OrdenCompraIdOrdenCompraNavigation { get; set; }
    }
}
