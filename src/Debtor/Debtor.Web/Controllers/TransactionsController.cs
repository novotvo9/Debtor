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
        ViewBag.Accounts = MyDbContext.Accounts.ToList();
        TransactionsCreateViewModel model = new();
        return View(model);
    }

    [HttpPost]
    public IActionResult Create(TransactionsCreateViewModel model)
    {
        if (ModelState.IsValid == false)
        {
            ViewBag.Accounts = MyDbContext.Accounts.ToList();
            return View(model);
        }

        AccountTransaction newTransaction = new();
        // id autoset
        newTransaction.AccountId = model.AccountId;
        newTransaction.TransactionType = model.TransactionType;
        newTransaction.Amount = model.Amount;
        newTransaction.Currency = model.Currency;
        newTransaction.PaymentMethod = model.PaymentMethod;

        newTransaction.TransactionAt = DateTime.Now;

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

        ViewBag.Accounts = MyDbContext.Accounts.ToList();
        TransactionsUpdateViewModel model = new();

        model.Id = id;

        model.AccountId = existingTransaction.AccountId;
        model.TransactionType = existingTransaction.TransactionType;
        model.Amount = existingTransaction.Amount;
        model.Currency = existingTransaction.Currency;
        model.TransactionAt = existingTransaction.TransactionAt;
        model.PaymentMethod = existingTransaction.PaymentMethod;

        return View(model);
    }

    [HttpPost]
    public IActionResult Update(int id, TransactionsUpdateViewModel model)
    {
        AccountTransaction? existingTransaction = MyDbContext.AccountTransactions.FirstOrDefault(t => t.Id == id);
        
        if (existingTransaction == null)
        {
            return RedirectToAction(nameof(All));
        }

        if (ModelState.IsValid == false)
        {
            ViewBag.Accounts = MyDbContext.Accounts.ToList();
            return View(model);
        }

        existingTransaction.AccountId = model.AccountId;
        existingTransaction.TransactionType = model.TransactionType;
        existingTransaction.Amount = model.Amount;
        existingTransaction.Currency = model.Currency;
        existingTransaction.PaymentMethod = model.PaymentMethod;

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
