using Microsoft.AspNetCore.Mvc;

namespace Debtor.Web.Controllers;

public class UsersController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
}
