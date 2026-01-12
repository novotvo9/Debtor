using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Debtor.Web.Controllers;

public class TransactionsController : Controller
{
    public MyDbContext MyDbContext { get; set; } = new();
    public List<AccountTransaction> Transactions { get; set; } = [];

    public TransactionsController()
    {
        Transactions = MyDbContext.AccountTransactions.ToList();
    }

    public IActionResult All()
    {
        return View(Transactions);
    }
}
