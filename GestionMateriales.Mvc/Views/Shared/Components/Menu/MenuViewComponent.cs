using Microsoft.AspNetCore.Mvc;
using GestionMateriales.Mvc.Models;
using System.Collections.Generic;

namespace GestionMateriales.Mvc.View.Shared.Components.Menu
{
    public class MenuViewComponent : ViewComponent
    {
        public MenuViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            List<MenuItem> menu = new List<MenuItem>();

            if (User.IsInRole("Desarrollo"))
            {
                menu.Add(new MenuItem { Id = 1, nameOption = "Inicio", controller = "Home", action = "Index", imageClass = "c-blue-500 fad fa-home", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 80, nameOption = "Tablero de Control", controller = "Dashboard", action = "Index", imageClass = "c-green-500 fad fa-tachometer-alt", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 70, nameOption = "Administración", controller = "", action = "", imageClass = "c-navy-500 fad fa-users-cog", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 71, nameOption = "Usuarios", controller = "Administracion", action = "Usuarios", imageClass = "", estatus = true, isParent = false, parentId = 70 });
                menu.Add(new MenuItem { Id = 72, nameOption = "Roles", controller = "Administracion", action = "Roles", imageClass = "", estatus = true, isParent = false, parentId = 70 });
                menu.Add(new MenuItem { Id = 40, nameOption = "Materiales", controller = "Material", action = "Index", imageClass = "c-brown-500 fad fa-tools", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 20, nameOption = "Ingreso Depósito", controller = "", action = "", imageClass = "c-deep-orange-500 fad fa-inbox-in", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 21, nameOption = "Nueva ingreso", controller = "Stock", action = "Sumar", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 23, nameOption = "Ingresos anteriores", controller = "Stock", action = "HistorialIngresos", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 90, nameOption = "Egreso Depósito", controller = "", action = "", imageClass = "c-indigo-500 fad fa-inbox-out", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 91, nameOption = "Nueva egreso", controller = "Stock", action = "Restar", imageClass = "", estatus = true, isParent = false, parentId = 90 });
                menu.Add(new MenuItem { Id = 92, nameOption = "Egresos anteriores", controller = "Stock", action = "HistorialEgresos", imageClass = "", estatus = true, isParent = false, parentId = 90 });
                menu.Add(new MenuItem { Id = 30, nameOption = "Compras", controller = "", action = "", imageClass = "c-teal-500 fad fa-shopping-cart", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 31, nameOption = "Necesidades", controller = "Compras", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 30 });
                menu.Add(new MenuItem { Id = 50, nameOption = "Proveedores", controller = "Proveedor", action = "Index", imageClass = "c-deep-purple-500 fad fa-truck", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 60, nameOption = "Personal", controller = "Personal", action = "Index", imageClass = "c-blue-grey-500 fad fa-user-friends", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 10, nameOption = "Documentos", controller = "", action = "", imageClass = "c-red-500 fad fa-copy", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 11, nameOption = "Orden de Trabajo", controller = "OrdenTrabajo", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                menu.Add(new MenuItem { Id = 12, nameOption = "Orden de Trabajo de Aplicación", controller = "OrdenTrabajoAplicacion", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                menu.Add(new MenuItem { Id = 13, nameOption = "Orden de Pedido", controller = "OrdenPedido", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                menu.Add(new MenuItem { Id = 14, nameOption = "Orden de Compra", controller = "OrdenCompra", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });

            }

            if (User.IsInRole("Administrador"))
            {
                menu.Add(new MenuItem { Id = 1, nameOption = "Inicio", controller = "Home", action = "Index", imageClass = "c-blue-500 fad fa-home", estatus = true, isParent = false, parentId = 0 });
                //menu.Add(new MenuItem { Id = 80, nameOption = "Tablero de Control", controller = "Dashboard", action = "Index", imageClass = "c-green-500 fad fa-tachometer-alt", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 70, nameOption = "Administración", controller = "", action = "", imageClass = "c-navy-500 fad fa-users-cog", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 71, nameOption = "Usuarios", controller = "Administracion", action = "Usuarios", imageClass = "", estatus = true, isParent = false, parentId = 70 });
                menu.Add(new MenuItem { Id = 72, nameOption = "Roles", controller = "Administracion", action = "Roles", imageClass = "", estatus = true, isParent = false, parentId = 70 });
                menu.Add(new MenuItem { Id = 40, nameOption = "Materiales", controller = "Material", action = "Index", imageClass = "c-brown-500 fad fa-tools", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 20, nameOption = "Ingreso Depósito", controller = "", action = "", imageClass = "c-deep-orange-500 fad fa-inbox-in", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 21, nameOption = "Nueva ingreso", controller = "Stock", action = "Sumar", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 23, nameOption = "Ingresos anteriores", controller = "Stock", action = "HistorialIngresos", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 90, nameOption = "Egreso Depósito", controller = "", action = "", imageClass = "c-indigo-500 fad fa-inbox-out", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 91, nameOption = "Nueva egreso", controller = "Stock", action = "Restar", imageClass = "", estatus = true, isParent = false, parentId = 90 });
                menu.Add(new MenuItem { Id = 92, nameOption = "Egresos anteriores", controller = "Stock", action = "HistorialEgresos", imageClass = "", estatus = true, isParent = false, parentId = 90 });
                menu.Add(new MenuItem { Id = 30, nameOption = "Compras", controller = "", action = "", imageClass = "c-teal-500 fad fa-shopping-cart", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 31, nameOption = "Necesidades", controller = "Compras", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 30 });
                menu.Add(new MenuItem { Id = 50, nameOption = "Proveedores", controller = "Proveedor", action = "Index", imageClass = "c-deep-purple-500 fad fa-truck", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 60, nameOption = "Personal", controller = "Personal", action = "Index", imageClass = "c-blue-grey-500 fad fa-user-friends", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 10, nameOption = "Documentos", controller = "", action = "", imageClass = "c-red-500 fad fa-copy", estatus = true, isParent = true, parentId = 0 });
                //menu.Add(new MenuItem { Id = 11, nameOption = "Orden de Trabajo", controller = "OrdenTrabajo", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                menu.Add(new MenuItem { Id = 12, nameOption = "Orden de Trabajo de Aplicación", controller = "OrdenTrabajoAplicacion", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                //menu.Add(new MenuItem { Id = 13, nameOption = "Orden de Pedido", controller = "OrdenPedido", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                menu.Add(new MenuItem { Id = 14, nameOption = "Orden de Compra", controller = "OrdenCompra", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
            }

            if (User.IsInRole("Oficina Técnica"))
            {
                menu.Add(new MenuItem { Id = 1, nameOption = "Inicio", controller = "Home", action = "Index", imageClass = "c-blue-500 fad fa-home", estatus = true, isParent = false, parentId = 0 });
                //menu.Add(new MenuItem { Id = 80, nameOption = "Tablero de Control", controller = "Dashboard", action = "Index", imageClass = "c-green-500 fad fa-tachometer-alt", estatus = true, isParent = false, parentId = 0 });
                //menu.Add(new MenuItem { Id = 70, nameOption = "Administración", controller = "", action = "", imageClass = "c-navy-500 fad fa-users-cog", estatus = true, isParent = true, parentId = 0 });
                //menu.Add(new MenuItem { Id = 71, nameOption = "Usuarios", controller = "Administracion", action = "Usuarios", imageClass = "", estatus = true, isParent = false, parentId = 70 });
                //menu.Add(new MenuItem { Id = 72, nameOption = "Roles", controller = "Administracion", action = "Roles", imageClass = "", estatus = true, isParent = false, parentId = 70 });
                menu.Add(new MenuItem { Id = 40, nameOption = "Materiales", controller = "Material", action = "Index", imageClass = "c-brown-500 fad fa-tools", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 20, nameOption = "Ingreso Depósito", controller = "", action = "", imageClass = "c-deep-orange-500 fad fa-inbox-in", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 21, nameOption = "Nueva ingreso", controller = "Stock", action = "Sumar", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 23, nameOption = "Ingresos anteriores", controller = "Stock", action = "HistorialIngresos", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 90, nameOption = "Egreso Depósito", controller = "", action = "", imageClass = "c-indigo-500 fad fa-inbox-out", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 91, nameOption = "Nueva egreso", controller = "Stock", action = "Restar", imageClass = "", estatus = true, isParent = false, parentId = 90 });
                menu.Add(new MenuItem { Id = 92, nameOption = "Egresos anteriores", controller = "Stock", action = "HistorialEgresos", imageClass = "", estatus = true, isParent = false, parentId = 90 });
                menu.Add(new MenuItem { Id = 30, nameOption = "Compras", controller = "", action = "", imageClass = "c-teal-500 fad fa-shopping-cart", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 31, nameOption = "Necesidades", controller = "Compras", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 30 });
                menu.Add(new MenuItem { Id = 50, nameOption = "Proveedores", controller = "Proveedor", action = "Index", imageClass = "c-deep-purple-500 fad fa-truck", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 60, nameOption = "Personal", controller = "Personal", action = "Index", imageClass = "c-blue-grey-500 fad fa-user-friends", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 10, nameOption = "Documentos", controller = "", action = "", imageClass = "c-red-500 fad fa-copy", estatus = true, isParent = true, parentId = 0 });
                //menu.Add(new MenuItem { Id = 11, nameOption = "Orden de Trabajo", controller = "OrdenTrabajo", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                menu.Add(new MenuItem { Id = 12, nameOption = "Orden de Trabajo de Aplicación", controller = "OrdenTrabajoAplicacion", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                //menu.Add(new MenuItem { Id = 13, nameOption = "Orden de Pedido", controller = "OrdenPedido", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                menu.Add(new MenuItem { Id = 14, nameOption = "Orden de Compra", controller = "OrdenCompra", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });              
            }

            if (User.IsInRole("Deposito"))
            {
                menu.Add(new MenuItem { Id = 20, nameOption = "Stock", controller = "", action = "", imageClass = "c-deep-purple-500 fad fa-sync-alt", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 21, nameOption = "Entrada", controller = "Stock", action = "Sumar", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 22, nameOption = "Salida", controller = "Stock", action = "Restar", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 23, nameOption = "Historial Entradas", controller = "Stock", action = "HistorialIngresos", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 24, nameOption = "Historial Salidas", controller = "Stock", action = "HistorialEgresos", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 40, nameOption = "Materiales", controller = "Material", action = "Index", imageClass = "c-brown-500 fad fa-wrench", estatus = true, isParent = false, parentId = 0 });

                menu.Add(new MenuItem { Id = 1, nameOption = "Inicio", controller = "Home", action = "Index", imageClass = "c-blue-500 fad fa-home", estatus = true, isParent = false, parentId = 0 });
                //menu.Add(new MenuItem { Id = 80, nameOption = "Tablero de Control", controller = "Dashboard", action = "Index", imageClass = "c-green-500 fad fa-tachometer-alt", estatus = true, isParent = false, parentId = 0 });
                //menu.Add(new MenuItem { Id = 70, nameOption = "Administración", controller = "", action = "", imageClass = "c-navy-500 fad fa-users-cog", estatus = true, isParent = true, parentId = 0 });
                //menu.Add(new MenuItem { Id = 71, nameOption = "Usuarios", controller = "Administracion", action = "Usuarios", imageClass = "", estatus = true, isParent = false, parentId = 70 });
                //menu.Add(new MenuItem { Id = 72, nameOption = "Roles", controller = "Administracion", action = "Roles", imageClass = "", estatus = true, isParent = false, parentId = 70 });
                menu.Add(new MenuItem { Id = 40, nameOption = "Materiales", controller = "Material", action = "Index", imageClass = "c-brown-500 fad fa-tools", estatus = true, isParent = false, parentId = 0 });
                menu.Add(new MenuItem { Id = 20, nameOption = "Ingreso Depósito", controller = "", action = "", imageClass = "c-deep-orange-500 fad fa-inbox-in", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 21, nameOption = "Nueva ingreso", controller = "Stock", action = "Sumar", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 23, nameOption = "Ingresos anteriores", controller = "Stock", action = "HistorialIngresos", imageClass = "", estatus = true, isParent = false, parentId = 20 });
                menu.Add(new MenuItem { Id = 90, nameOption = "Egreso Depósito", controller = "", action = "", imageClass = "c-indigo-500 fad fa-inbox-out", estatus = true, isParent = true, parentId = 0 });
                menu.Add(new MenuItem { Id = 91, nameOption = "Nueva egreso", controller = "Stock", action = "Restar", imageClass = "", estatus = true, isParent = false, parentId = 90 });
                menu.Add(new MenuItem { Id = 92, nameOption = "Egresos anteriores", controller = "Stock", action = "HistorialEgresos", imageClass = "", estatus = true, isParent = false, parentId = 90 });
                //menu.Add(new MenuItem { Id = 30, nameOption = "Compras", controller = "", action = "", imageClass = "c-teal-500 fad fa-shopping-cart", estatus = true, isParent = true, parentId = 0 });
                //menu.Add(new MenuItem { Id = 31, nameOption = "Necesidades", controller = "Compras", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 30 });
                //menu.Add(new MenuItem { Id = 50, nameOption = "Proveedores", controller = "Proveedor", action = "Index", imageClass = "c-deep-purple-500 fad fa-truck", estatus = true, isParent = false, parentId = 0 });
                //menu.Add(new MenuItem { Id = 60, nameOption = "Personal", controller = "Personal", action = "Index", imageClass = "c-blue-grey-500 fad fa-user-friends", estatus = true, isParent = false, parentId = 0 });
                //menu.Add(new MenuItem { Id = 10, nameOption = "Documentos", controller = "", action = "", imageClass = "c-red-500 fad fa-copy", estatus = true, isParent = true, parentId = 0 });
                //menu.Add(new MenuItem { Id = 11, nameOption = "Orden de Trabajo", controller = "OrdenTrabajo", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                //menu.Add(new MenuItem { Id = 12, nameOption = "Orden de Trabajo de Aplicación", controller = "OrdenTrabajoAplicacion", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                //menu.Add(new MenuItem { Id = 13, nameOption = "Orden de Pedido", controller = "OrdenPedido", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
                //menu.Add(new MenuItem { Id = 14, nameOption = "Orden de Compra", controller = "OrdenCompra", action = "Index", imageClass = "", estatus = true, isParent = false, parentId = 10 });
            }

            return View("Menu", menu);
        }
    }
}
