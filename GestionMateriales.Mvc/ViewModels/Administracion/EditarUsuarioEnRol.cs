using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionMateriales.Mvc.ViewModels.Administracion
{
    public class EditarUsuarioEnRol
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool Seleccionado { get; set; }
    }
}
