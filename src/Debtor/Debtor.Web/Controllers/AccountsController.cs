using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using Debtor.Web.Models.Accounts;
using Microsoft.AspNetCore.Mvc;

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
        return View(Accounts);
    }

    public IActionResult Detail(Guid id)
    {
        List<AccountTransaction> slectedAccountTransactions = AccountTransactions.Where(t => t.AccountId == id).ToList();

        if (slectedAccountTransactions == null)
        {
            return NotFound();
        }

        return View(slectedAccountTransactions);
    }

    [HttpGet]
    public IActionResult Create()
    {
        AccountsCreateViewModel model = new();
        return View(model);
    }

    [HttpPost]
    public IActionResult Create(AccountsCreateViewModel model)
    {
        if (ModelState.IsValid == false)
        {
            return View(model);
        }

        Account newAccount = new();
        newAccount.Id = Guid.NewGuid();

        newAccount.FullName = model.FullName;
        newAccount.AccountType = model.AccountType;
        newAccount.Email = model.Email;
        newAccount.Phone = model.Phone;

        newAccount.CreatedAt = DateTime.Now;

        MyDbContext.Accounts.Add(newAccount);
        MyDbContext.SaveChanges();

        return RedirectToAction(nameof(Detail), new { id = newAccount.Id });
    }

    [HttpGet]
    public IActionResult Update(Guid id)
    {
        Account? existingAccount = MyDbContext.Accounts.FirstOrDefault(a => a.Id == id);
        if (existingAccount == null)
        {
            return RedirectToAction(nameof(All));
        }

        AccountsUpdateViewModel model = new();

        model.Id = id; // TODO: musím toto dělat? zkus odkomentovat v modelu id a created at
        
        model.FullName = existingAccount.FullName;
        model.AccountType = existingAccount.AccountType;
        model.Email = existingAccount.Email;
        model.Phone = existingAccount.Phone;

        model.CreatedAt = existingAccount.CreatedAt; // same

        return View(model);
    }

    [HttpPost]
    public IActionResult Update(Guid id, AccountsUpdateViewModel model)
    {
        Account? existingAccount = MyDbContext.Accounts.FirstOrDefault(a => a.Id == id);
        if (existingAccount == null)
        {
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

        return RedirectToAction(nameof(Detail), new { id = id });
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
