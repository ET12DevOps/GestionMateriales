using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionMateriales.Mvc.ViewModels.Cuenta
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }

        [Display(Name = "Recordarme")]
        public bool Recordarme { get; set; }
    }
}
