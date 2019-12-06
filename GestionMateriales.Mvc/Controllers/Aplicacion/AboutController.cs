using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GestionMateriales.Mvc.Controllers.Aplicacion
{
    [Authorize(Roles = "Desarrollo, Administrador, Oficina Técnica, Deposito, Directivo")]
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Simpsons()
        {
            return View();
        }
    }
}