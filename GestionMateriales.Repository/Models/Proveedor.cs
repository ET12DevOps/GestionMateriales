using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Material = new HashSet<Material>();
            Ordencompra = new HashSet<Ordencompra>();
        }

        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Cuit { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string RazonSocial { get; set; }
        public string NombreContacto { get; set; }
        public string Zona { get; set; }
        public string Horario { get; set; }
        public short Hab { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIp { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedIp { get; set; }

        public virtual ICollection<Material> Material { get; set; }
        public virtual ICollection<Ordencompra> Ordencompra { get; set; }
    }
}
