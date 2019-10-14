using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GestionMateriales.Mvc.Identity;
using GestionMateriales.Mvc.ViewModels.Administracion;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GestionMateriales.Mvc.Controllers.Administracion
{
    public class AdministracionController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        private readonly SignInManager<ApplicationUser> signInManager;

        private readonly RoleManager<ApplicationRole> roleManager;
        
        private readonly ILogger<AdministracionController> logger;

        public AdministracionController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, ILogger<AdministracionController> logger)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.logger = logger;
        }

        [HttpGet]
        [Authorize(Roles = "Desarrollo, Administrador")]
        public IActionResult CrearUsuario()
        {
            return View();
        }

        //Registrar un nuevo usuario
        [HttpPost]
        public async Task<IActionResult> CrearUsuario(CrearUsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { 
                    UserName = model.Email, 
                    Email = model.Email, 
                    NombreCompleto = model.Nombre, 
                    CreatedBy = HttpContext.User.Identity.Name, 
                    CreationDate = DateTime.Now, 
                    CreationIp = HttpContext.Connection.RemoteIpAddress.ToString(),
                    LastUpdatedBy = HttpContext.User.Identity.Name,
                    LastUpdatedDate = DateTime.Now,
                    LastUpdatedIp = HttpContext.Connection.RemoteIpAddress.ToString(),
                    Habilitado = true 
                };

                var result = await userManager.CreateAsync(user, model.Contrasenia);

                if (result.Succeeded)
                {
                    //await signInManager.SignInAsync(user, isPersistent: false); //Persistent es por la cookie de sesión
                    return RedirectToAction("Usuarios", "Administracion");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        //Acceder al sistema con un usuario existente (Login)
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Contrasenia, model.Recordarme, true);

                if (result.Succeeded)
                {
                    logger.LogInformation("Login Correcto Usuario: {Email}", model.Email);

                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError(string.Empty, "Error ingreso, verifique usuario y/o contraseña");
            }

            logger.LogInformation("Login Incorrecto Usuario: {Email}", model.Email);

            return View(model);
        }

        //Irse del sistema con un usuario existente (Login)
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Usuarios()
        {
            var users = userManager.Users;
            return View(users);
        }

        [HttpGet]
        public IActionResult Roles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public IActionResult CrearRol()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearRol(CrearRolViewModel model)
        {
            if (ModelState.IsValid)
            {
                // We just need to specify a unique role name to create a new role
                var identityRole = new ApplicationRole
                {
                    Name = model.NombreRol,
                    Area = model.Area,
                    CreatedBy = HttpContext.User.Identity.Name,
                    CreationDate = DateTime.Now,
                    CreationIp = HttpContext.Connection.RemoteIpAddress.ToString(),
                    LastUpdatedBy = HttpContext.User.Identity.Name,
                    LastUpdatedDate = DateTime.Now,
                    LastUpdatedIp = HttpContext.Connection.RemoteIpAddress.ToString(),
                    Habilitado = true
                };

                // Saves the role in the underlying AspNetRoles table
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("Roles", "Administracion");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditarRol(string id)
        {
            // Find the role by Role ID
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rol con Id = {id} no existe";
                return View("NotFound404", "Error");
            }

            var model = new EditarRolViewModel
            {
                Id = role.Id,
                NombreRol = role.Name,
                Area = role.Area
            };

            // Retrieve all the Users
            foreach (var user in userManager.Users)
            {
                // If the user is in this role, add the username to
                // Users property of EditRoleViewModel. This model
                // object is then passed to the view for display
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        public async Task<IActionResult> EditarRol(EditarRolViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rol con Id = {model.Id} no existe";
                return View("NotFound404", "Error");
            }
            else
            {
                role.Name = model.NombreRol;
                role.Area = model.Area;
                role.LastUpdatedBy = HttpContext.User.Identity.Name;
                role.LastUpdatedDate = DateTime.Now;
                role.LastUpdatedIp = HttpContext.Connection.RemoteIpAddress.ToString();
                role.Habilitado = true;

                // Update the Role using UpdateAsync
                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("Roles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditarUsuario(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Usuario con Id = {id} no existe";
                return View("NotFound404", "Error");
            }

            // GetClaimsAsync retunrs the list of user Claims
            var userClaims = await userManager.GetClaimsAsync(user);
            // GetRolesAsync returns the list of user Roles
            var userRoles = await userManager.GetRolesAsync(user);

            var model = new EditarUsuarioViewModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                NombreCompleto = user.NombreCompleto,
                Claims = userClaims.Select(c => c.Value).ToList(),
                Roles = userRoles
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditarUsuario(EditarUsuarioViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Usuario con Id = {model.Id} no existe";
                return View("NotFound404", "Error");
            }
            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;
                user.NombreCompleto = model.NombreCompleto;
                user.LastUpdatedBy = HttpContext.User.Identity.Name;
                user.LastUpdatedDate = DateTime.Now;
                user.LastUpdatedIp = HttpContext.Connection.RemoteIpAddress.ToString();

                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Usuarios");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> AdministrarUsuarioRol(string userId)
        {
            ViewBag.userId = userId;

            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Usuario con Id = {userId} no existe";
                return View("NotFound404", "Error");
            }

            var model = new List<UsuarioRolViewModel>();

            foreach (var role in roleManager.Roles)
            {
                var userRolesViewModel = new UsuarioRolViewModel
                {
                    IdRol = role.Id,
                    NombreRol = role.Name
                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.Seleccionado = true;
                }
                else
                {
                    userRolesViewModel.Seleccionado = false;
                }

                model.Add(userRolesViewModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AdministrarUsuarioRol(List<UsuarioRolViewModel> model, string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Usuario con Id = {userId} no existe";
                return View("NotFound404", "Error");
            }

            var roles = await userManager.GetRolesAsync(user);
            var result = await userManager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "No se puede eliminar un usuarios con roles asignados");
                return View(model);
            }

            result = await userManager.AddToRolesAsync(user,
                model.Where(x => x.Seleccionado).Select(y => y.NombreRol));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "No se puede agregar los roles seleccionados al usuario");
                return View(model);
            }

            return RedirectToAction("EditarUsuario", new { Id = userId });
        }

        [HttpGet]
        public async Task<IActionResult> EditarUsuarioEnRol(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rol con Id = {roleId} no existe";
                return View("NotFound404", "Error");
            }

            var model = new List<EditarUsuarioEnRol>();

            foreach (var user in userManager.Users)
            {
                var userRoleViewModel = new EditarUsuarioEnRol
                {
                    UserId = user.Id,
                    UserName = user.UserName                    
                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.Seleccionado = true;
                }
                else
                {
                    userRoleViewModel.Seleccionado = false;
                }

                model.Add(userRoleViewModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditarUsuarioEnRol(List<EditarUsuarioEnRol> model, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rol con Id = {roleId} no existe";
                return View("NotFound404", "Error");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].Seleccionado && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].Seleccionado && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditarRol", new { Id = roleId });
                }
            }

            return RedirectToAction("EditarRol", new { Id = roleId });
        }

        [HttpPost]
        public async Task<IActionResult> BorrarRol(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rol con Id = {id} no existe";
                return View("NotFound404", "Error");
            }
            else
            {
                var result = await roleManager.DeleteAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("Roles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("Roles");
            }
        }

        [HttpPost]
        public async Task<IActionResult> BorrarUsuario(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Usuario con Id = {id} no existe";
                return View("NotFound404", "Error");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Usuarios");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("Usuarios");
            }
        }

        [HttpGet]
        public async Task<IActionResult> AdministrarPermisosUsuario(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Usuario con Id = {userId} no existe";
                return View("NotFound404", "Error");
            }

            // UserManager service GetClaimsAsync method gets all the current claims of the user
            var existingUserClaims = await userManager.GetClaimsAsync(user);

            var model = new PermisosUsuarioViewModel
            {
                UserId = userId
            };

            // Loop through each claim we have in our application
            foreach (Claim claim in ClaimsStore.AllClaims)
            {
                UserClaim userClaim = new UserClaim
                {
                    ClaimType = claim.Type
                };

                // If the user has the claim, set IsSelected property to true, so the checkbox
                // next to the claim is checked on the UI
                if (existingUserClaims.Any(c => c.Type == claim.Type))
                {
                    userClaim.IsSelected = true;
                }

                model.Cliams.Add(userClaim);
            }

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> AdministrarPermisosUsuario(PermisosUsuarioViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.UserId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Usuario con Id = {model.UserId} no existe";
                return View("NotFound404", "Error");
            }

            // Get all the user existing claims and delete them
            var claims = await userManager.GetClaimsAsync(user);
            var result = await userManager.RemoveClaimsAsync(user, claims);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "No se puede eliminar usuario con permisos asignados");
                return View(model);
            }

            // Add all the claims that are selected on the UI
            result = await userManager.AddClaimsAsync(user,
                model.Cliams.Where(c => c.IsSelected).Select(c => new Claim(c.ClaimType, c.ClaimType)));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "No se puede agregar permisos al usuario");
                return View(model);
            }

            return RedirectToAction("EditarUsuario", new { Id = model.UserId });

        }

    }
}