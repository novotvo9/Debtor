using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
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
}
