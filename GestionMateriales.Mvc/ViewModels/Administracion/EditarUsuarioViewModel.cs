using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionMateriales.Mvc.ViewModels.Administracion
{
    public class EditarUsuarioViewModel
    {
        public EditarUsuarioViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<string> Claims { get; set; }

        public IList<string> Roles { get; set; }
    }
}
