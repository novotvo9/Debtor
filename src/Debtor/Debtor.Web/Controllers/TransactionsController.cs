using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using Debtor.Web.Models.Transactions;
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

    [HttpGet]
    public IActionResult Create()
    {
        TransactionsCreateViewModel model = new();
        return View(model);
    }

    [HttpPost]
    public IActionResult Create(TransactionsCreateViewModel model)
    {
        if (ModelState.IsValid == false)
        {
            return View(model);
        }

        AccountTransaction newTransaction = new();
        // id autoset??
        // TODO: další sety

        MyDbContext.AccountTransactions.Add(newTransaction);
        MyDbContext.SaveChanges();

        return RedirectToAction(nameof(All)); // TODO: Spíš detail s route value???
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        AccountTransaction? existingTransaction = MyDbContext.AccountTransactions.FirstOrDefault(t => t.Id == id);

        if (existingTransaction == null)
        {
            return RedirectToAction(nameof(All));
        }

        TransactionsUpdateViewModel model = new();

        // id autoset??
        // TODO: další sety

        return View(model);
    }

    [HttpPost]
    public IActionResult Update(int id, TransactionsUpdateViewModel model)
    {
        // Opakuje se??
        AccountTransaction? existingTransaction = MyDbContext.AccountTransactions.FirstOrDefault(t => t.Id == id);
        
        if (existingTransaction == null)
        {
            return RedirectToAction(nameof(All));
        }

        if (ModelState.IsValid == false)
        {
            return View(model);
        }

        // TODO: Sety

        MyDbContext.AccountTransactions.Update(existingTransaction);
        MyDbContext.SaveChanges();

        return RedirectToAction(nameof(All));
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        AccountTransaction? transaction = MyDbContext.AccountTransactions.FirstOrDefault(t => t.Id == id);
        if (transaction == null)
        {
            return NotFound();
        }

        MyDbContext.Remove(transaction);
        MyDbContext.SaveChanges();

        return RedirectToAction(nameof(All));
    }
}
