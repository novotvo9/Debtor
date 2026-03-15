using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using Debtor.Web.Models.Accounts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Debtor.Web.Controllers;

public class AccountsController : Controller
{
    public MyDbContext MyDbContext { get; set; } = new();
    public List<Account> Accounts { get; set; } = [];
    public List<AccountTransaction> AccountTransactions { get; set; } = [];

    public AccountsController()
    {
        Accounts = MyDbContext.Accounts.ToList();
        AccountTransactions = MyDbContext.AccountTransactions.ToList();
    }

    public IActionResult All()
    {
        if (HttpContext.User.FindFirstValue("email") != "admin@hostmaster.com")
        {
            return RedirectToAction("Index", "Dashboard");
        }

        return View(Accounts);
    }

    public IActionResult Detail(Guid id)
    {
        List<AccountTransaction> slectedAccountTransactions = AccountTransactions.Where(t => t.AccountId == id).ToList();

        if (slectedAccountTransactions == null)
        {
            return NotFound();
        }

        if (HttpContext.User.FindFirstValue("email") != "admin@hostmaster.com")
        {
            return RedirectToAction("Index", "Dashboard");
        }

        return View(slectedAccountTransactions);
    }

    [HttpGet]
    public IActionResult Create()
    { 
        Account? existingAccount = MyDbContext.Accounts.Where(a => a.Email == HttpContext.User.FindFirstValue("email")).FirstOrDefault();

        if (HttpContext.User.FindFirstValue("email") != "admin@hostmaster.com")
        {
            if (existingAccount != null)
            {
                return RedirectToAction("Index", "Dashboard");
            }
        }

        AccountsCreateViewModel model = new();
        if (HttpContext.User.FindFirstValue("email") != "admin@hostmaster.com")
        {
            model.IsNonAdmin = true;
            model.UsersEmail = HttpContext.User.FindFirstValue("email")!;
        }
        
        return View(model);
    }

    [HttpPost]
    public IActionResult Create(AccountsCreateViewModel model)
    {
        if (ModelState.IsValid == false)
        {
            return View(model);
        }

        foreach (var account in MyDbContext.Accounts.ToList())
        {
            if (model.Email != account.Email)
            {
                Account newAccount = new();
                newAccount.Id = Guid.NewGuid();

                newAccount.FullName = model.FullName;
                newAccount.AccountType = model.AccountType;
                newAccount.Email = model.Email;
                newAccount.Phone = model.Phone;

                newAccount.CreatedAt = DateTime.Now;

                MyDbContext.Accounts.Add(newAccount);
                MyDbContext.SaveChanges();

                if (HttpContext.User.FindFirstValue("email") == "admin@hostmaster.com")
                {
                    return RedirectToAction("All", "Accounts");
                }
                return RedirectToAction("Index", "Dashboard");
                //return RedirectToAction(nameof(Detail), new { id = newAccount.Id });
            }

        }
        return RedirectToAction("Index", "Dashboard");
    }


    [HttpGet]
    public IActionResult Update(Guid id)
    {
        Account? existingAccount = MyDbContext.Accounts.FirstOrDefault(a => a.Id == id);
        if (existingAccount == null)
        {
            if (HttpContext.User.FindFirstValue("email") != "admin@hostmaster.com")
            {
                return RedirectToAction("Index", "Dashboard");
            }

            return RedirectToAction(nameof(All));
        }

        AccountsUpdateViewModel model = new();

        model.Id = id;

        model.FullName = existingAccount.FullName;
        model.AccountType = existingAccount.AccountType;
        model.Email = existingAccount.Email;
        model.Phone = existingAccount.Phone;

        model.CreatedAt = existingAccount.CreatedAt;

        return View(model);
    }

    [HttpPost]
    public IActionResult Update(Guid id, AccountsUpdateViewModel model)
    {
        Account? existingAccount = MyDbContext.Accounts.FirstOrDefault(a => a.Id == id);
        if (existingAccount == null)
        {
            if (HttpContext.User.FindFirstValue("email") != "admin@hostmaster.com")
            {
                return RedirectToAction("Index", "Dashboard");
            }

            return RedirectToAction(nameof(All));
        }

        if (ModelState.IsValid == false)
        {
            return View(model);
        }

        existingAccount.FullName = model.FullName;
        existingAccount.AccountType = model.AccountType;
        existingAccount.Email = model.Email;
        existingAccount.Phone = model.Phone;

        MyDbContext.Accounts.Update(existingAccount);
        MyDbContext.SaveChanges();

        //return RedirectToAction(nameof(Detail), new { id = id });
        if (HttpContext.User.FindFirstValue("email") == "admin@hostmaster.com")
        {
            return RedirectToAction("All", "Accounts");
        }
        return RedirectToAction("Index", "Dashboard");
    }

    [HttpPost]
    public IActionResult Delete(Guid id)
    {
        Account? account = MyDbContext.Accounts.FirstOrDefault(a => a.Id == id);
        if (account == null)
        {
            return NotFound();
        }

        MyDbContext.Remove(account);
        MyDbContext.SaveChanges();

        return RedirectToAction(nameof(All));
    }
}
