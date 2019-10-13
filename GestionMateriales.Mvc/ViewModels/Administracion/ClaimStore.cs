using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GestionMateriales.Mvc.ViewModels.Administracion
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
            new Claim("Crear Usuarios", "Crear Usuarios"),
            new Claim("Editar Usuarios", "Editar Usuarios"),
            new Claim("Borrar Usuarios", "Borrar Usuarios"),
            new Claim("Crear Roles", "Crear Roles"),
            new Claim("Editar Roles", "Editar Roles"),
            new Claim("Borrar Roles", "Borrar Roles"),
            new Claim("Crear Personal", "Crear Personal"),
            new Claim("Editar Personal", "Editar Personal"),
            new Claim("Borrar Personal", "Borrar Personal"),
            new Claim("Crear Proveedor", "Crear Proveedor"),
            new Claim("Editar Proveedor", "Editar Proveedor"),
            new Claim("Borrar Proveedor", "Borrar Proveedor"),
            new Claim("Crear Material", "Crear Material"),
            new Claim("Editar Material", "Editar Material"),
            new Claim("Borrar Material", "Borrar Material"),
            new Claim("Ingresar Material", "Ingresar Material"),
            new Claim("Retirar Material", "Retirar Material")
        };
    }
}
