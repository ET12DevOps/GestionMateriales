using System;
using System.Collections.Generic;

namespace GestionMateriales.Repository.Models
{
    public partial class Salidamaterial
    {
        public int IdSalidaMaterial { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string CodigoMaterial { get; set; }
        public string CodigoDocumento { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIp { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedIp { get; set; }
        public int MaterialIdMaterial { get; set; }
        public int TipoSalidaMaterialIdTipoSalidaMaterial { get; set; }

        public virtual Material MaterialIdMaterialNavigation { get; set; }
        public virtual Tiposalidamaterial TipoSalidaMaterialIdTipoSalidaMaterialNavigation { get; set; }
    }
}
