using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GestionMateriales.Mvc.Controllers.Administracion
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            this.logger = logger;
        }

        [AllowAnonymous]
        [Route("/Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            logger.LogError("Se ha producido un error: {statusCode}", statusCode);

            switch(statusCode)
            {
                case 401:
                    ViewBag.ErrorCode = "401";
                    ViewBag.ErrorTitle = "Acceso no autorizado";
                    ViewBag.ErrorMessage = "No tiene permisos para acceder a la página solicitada, comuniquese con el Administrador";
                    break;
                case 404:
                    ViewBag.ErrorCode = "404";
                    ViewBag.ErrorTitle = "Página no encontrada";
                    ViewBag.ErrorMessage = "La página a la cual intenta acceder no existe";
                    break;
                case 500:
                    ViewBag.ErrorCode = "500";
                    ViewBag.ErrorTitle = "Error interno del servidor";
                    ViewBag.ErrorMessage = "Se ha producido un error intente mas tarde, si el error persiste, comuniquese con el Administrador";
                    break;
            }

            return View("NotFound");
        }

        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            logger.LogError("Se ha producido un error: {Path} {Message} {StackTrace}", exceptionHandlerPathFeature.Path, exceptionHandlerPathFeature.Error.Message, exceptionHandlerPathFeature.Error.StackTrace);

            ViewBag.ErrorCode = "500";
            ViewBag.ErrorTitle = "Error interno del servidor";
            ViewBag.ErrorMessage = "Se ha producido un error intente mas tarde, si el error persiste, comuniquese con el Administrador";

            ViewBag.ExceptionPath = exceptionHandlerPathFeature.Path;
            ViewBag.ExceptionMessage = exceptionHandlerPathFeature.Error.Message;
            ViewBag.StackTrace = exceptionHandlerPathFeature.Error.StackTrace;

            return View("Error");
        }
    }
}