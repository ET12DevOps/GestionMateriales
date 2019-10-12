using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Material
    {
        public Material()
        {
            Entradamaterial = new HashSet<Entradamaterial>();
            Itemordencompra = new HashSet<Itemordencompra>();
            Itemordenpedido = new HashSet<Itemordenpedido>();
            Itemordentrabajo = new HashSet<Itemordentrabajo>();
            Itemordentrabajoaplicacion = new HashSet<Itemordentrabajoaplicacion>();
            Salidamaterial = new HashSet<Salidamaterial>();
        }

        public int IdMaterial { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public string Detalle { get; set; }
        public short Hab { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIp { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedIp { get; set; }
        public int ProveedorIdProveedor { get; set; }
        public int TipoMaterialIdTipoMaterial { get; set; }
        public int UnidadIdUnidad { get; set; }

        public virtual Proveedor ProveedorIdProveedorNavigation { get; set; }
        public virtual Tipomaterial TipoMaterialIdTipoMaterialNavigation { get; set; }
        public virtual Unidad UnidadIdUnidadNavigation { get; set; }
        public virtual ICollection<Entradamaterial> Entradamaterial { get; set; }
        public virtual ICollection<Itemordencompra> Itemordencompra { get; set; }
        public virtual ICollection<Itemordenpedido> Itemordenpedido { get; set; }
        public virtual ICollection<Itemordentrabajo> Itemordentrabajo { get; set; }
        public virtual ICollection<Itemordentrabajoaplicacion> Itemordentrabajoaplicacion { get; set; }
        public virtual ICollection<Salidamaterial> Salidamaterial { get; set; }
    }
}
