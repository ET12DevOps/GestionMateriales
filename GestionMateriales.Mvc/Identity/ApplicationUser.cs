using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionMateriales.Mvc.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public bool Habilitado { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIp { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedIp { get; set; }
    }
}
