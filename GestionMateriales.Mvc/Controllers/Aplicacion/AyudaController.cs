using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GestionMateriales.Mvc.Controllers.Aplicacion
{
    [Authorize(Roles = "Desarrollo, Administrador, Oficina Técnica, Deposito, Directivo")]
    public class AyudaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}