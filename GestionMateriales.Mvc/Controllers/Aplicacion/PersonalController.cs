using Microsoft.AspNetCore.Mvc;
using System.Linq;
using GestionMateriales.Repository.Models;
using GestionMateriales.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using GestionMateriales.Services.Exceptions;
using System;

namespace GestionMateriales.Mvc.Controllers.Aplicacion
{
    [Authorize(Roles = "Administrador, Oficina Técnica")]
    //[Route("/Personal")]
    public class PersonalController : Controller
    {
        private readonly IPersonalService personalService;

        public PersonalController(IPersonalService personalService)
        {
            this.personalService = personalService;
        }

        //[Authorize(Roles = "administrador, oficinatecnica, rectoria")]
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            return View("Agregar");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Personal personal;

            try
            {
                personal = personalService.BuscarPersonalCon(id);
            }
            catch (PersonalException)
            {
                return RedirectToAction("NotFound404", "Error");
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Error");
            }

            return View("Editar", personal);
        }

        [HttpPost]
        public ActionResult Agregar(Personal personal)
        {
            try
            {
                personalService.CrearNuevo(personal, User.Identity.Name, Request.Host.Host);                
            }
            catch
            {
                ViewBag.Result = 1; //muestro mensaje error

                return View("Agregar", personal);
            }

            ViewBag.Result = 0; //muestro mensaje de realizacion

            return View("Agregar");
        }


        [HttpPost]
        public ActionResult Editar(int id, Personal personalActulizado)
        {
            try
            {
                personalService.EditarExistente(id, personalActulizado, User.Identity.Name, Request.Host.Host);
            }
            catch
            {
                ViewBag.Result = 1; //muestro mensaje de error

                return View("Editar", personalActulizado);
            }

            ViewBag.Result = 0; //muestro mensaje de realizacion

            return View("Editar", personalActulizado);
        }

        public ActionResult Borrar(int id)
        {         
            try
            {
                personalService.EliminarExistente(id, User.Identity.Name, Request.Host.Host);
            }
            catch
            {
                return RedirectToAction("Error", "Error");
            }

            return RedirectToAction("Index", "Personal");
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var personas = personalService.ListarTodo().Select(x => new { x.IdPersonal, x.Nombre, x.Dni, x.FichaCensal });

            return Json(new { Response = personas });
        }

        [HttpGet]
        public JsonResult GetLastUpdated()
        {
            var fecha = personalService.UltimoModificado().LastUpdatedDate;

            return Json(new { Response = string.Format("{0} {1} hs", fecha.ToShortDateString(), fecha.ToLongTimeString()) });
        }
    }
}
