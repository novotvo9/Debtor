using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Debtor.Web.Controllers;

// Ochrana celé kontroleru - přístup pouze pro přihlášené uživatele
    //přesměruje na login dle program.cs configu
[Authorize]
public class DashboardController : Controller
{
    public MyDbContext MyDbContext { get; set; } = new();

    public IActionResult Index()
    {
        //int id = Convert.ToInt32(HttpContext.User.FindFirstValue("id"));
        Account account = MyDbContext.Accounts.FirstOrDefault(a => a.Email == HttpContext.User.FindFirstValue("email"))!;

        if (HttpContext.User.FindFirstValue("email") == "admin@hostmaster.com")
        {
            ViewBag.AccountTransactions = "";
            return View();
        }
        ViewBag.AccountTransactions = MyDbContext.AccountTransactions.Where(t => t.AccountId == account.Id).ToList();
        return View(account);
        
    }

    //[AllowAnonymous]
    //public IActionResult Test()
    //{
    //    return Json("Ahoj");
    //}
}
