using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionMateriales.Mvc.ViewModels.Administracion
{
    public class PermisosUsuarioViewModel
    {
        public PermisosUsuarioViewModel()
        {
            Cliams = new List<UserClaim>();
        }

        public string UserId { get; set; }
        public List<UserClaim> Cliams { get; set; }
    }
}
