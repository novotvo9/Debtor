using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using Debtor.Web.Models.Dashboard;
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
        if (HttpContext.User.FindFirstValue("email") == "admin@hostmaster.com")
        {
            return View(new DashboardIndexViewModel());
        }

        Account account = MyDbContext.Accounts.FirstOrDefault(a => a.Email == HttpContext.User.FindFirstValue("email"))!;
        DashboardIndexViewModel model = new();

        model.Account = account;

        if (account == null)
        {
            return RedirectToAction("Create", "Accounts");
        }

        if (MyDbContext.AccountTransactions.Where(t => t.AccountId == account.Id).ToList() != null)
        {
            model.Transactions = MyDbContext.AccountTransactions.Where(t => t.AccountId == account.Id).ToList();
        }
        
        if (model.Transactions.Count == 0)
        {
            model.Balance = 0;
        }
        else
        {
            model.Balance = model.Transactions.Where(t => t.TransactionType == "payment").Sum(t => t.Amount) -
                model.Transactions.Where(t => t.TransactionType == "borrow").Sum(t => t.Amount);
            model.Currency = model.Transactions[0].Currency;
        }

        return View(model);
        
    }

    //[AllowAnonymous]
    //public IActionResult Test()
    //{
    //    return Json("Ahoj");
    //}
}
