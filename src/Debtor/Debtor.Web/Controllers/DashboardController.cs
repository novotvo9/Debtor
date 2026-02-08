using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Debtor.Web.Controllers;

// Ochrana celé kontroleru - přístup pouze pro přihlášené uživatele
    //přesměruje na login dle program.cs configu
[Authorize]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        int id = Convert.ToInt32(HttpContext.User.FindFirstValue("id"));
        return View();
    }

    [AllowAnonymous]
    public IActionResult Test()
    {
        return Json("Ahoj");
    }
}
