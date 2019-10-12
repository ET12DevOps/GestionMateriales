using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Ordencompra
    {
        public Ordencompra()
        {
            Itemordencompra = new HashSet<Itemordencompra>();
        }

        public int IdOrdenCompra { get; set; }
        public int NumeroInterno { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public string ChequeNro { get; set; }
        public short Hab { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIp { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedIp { get; set; }
        public int ProveedorIdProveedor { get; set; }
        public int ResponsableIdPersonal { get; set; }

        public virtual Proveedor ProveedorIdProveedorNavigation { get; set; }
        public virtual Personal ResponsableIdPersonalNavigation { get; set; }
        public virtual ICollection<Itemordencompra> Itemordencompra { get; set; }
    }
}
