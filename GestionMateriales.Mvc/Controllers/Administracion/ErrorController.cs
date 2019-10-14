using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace GestionMateriales.Mvc.Controllers.Administracion
{
    public class ErrorController : Controller
    {
        public ErrorController()
        {
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            //logger.LogError($"The path {exceptionHandlerPathFeature.Path} " +
            //    $"threw an exception {exceptionHandlerPathFeature.Error}");

            return View("Error");
        }

        [AllowAnonymous]
        public IActionResult NotFound404()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            //logger.LogError($"The path {exceptionHandlerPathFeature.Path} " +
            //    $"threw an exception {exceptionHandlerPathFeature.Error}");

            return View("NotFound404", "Error");
        }
    }
}