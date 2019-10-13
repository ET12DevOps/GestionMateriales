using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionMateriales.Mvc.ViewModels.Administracion
{
    public class CrearRolViewModel
    {
        [Required]
        [Display(Name = "Rol")]
        public string NombreRol { get; set; }

        [Required]
        [Display(Name = "Area")]
        public string Area { get; set; }
    }
}
