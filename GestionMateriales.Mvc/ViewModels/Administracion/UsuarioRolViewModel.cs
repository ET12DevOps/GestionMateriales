using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionMateriales.Mvc.ViewModels.Administracion
{
    public class UsuarioRolViewModel
    {
        public string IdRol { get; set; }
        public string NombreRol { get; set; }
        public bool Seleccionado { get; set; }
    }
}
