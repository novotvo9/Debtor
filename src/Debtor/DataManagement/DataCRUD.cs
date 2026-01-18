using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;

namespace DataManagement;

public class DataCRUD
{
    public MyDbContext MyDbContext { get; set; } = new();
    public void DeleteAccount(Account account)
    {
        MyDbContext.Accounts.Remove(account);
        MyDbContext.Accounts.Remove(account);
    }

    public void DeleteTransaction(AccountTransaction transaction)
    {
        MyDbContext.AccountTransactions.Remove(transaction);
        MyDbContext.AccountTransactions.Remove(transaction);
    }
}
