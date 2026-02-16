using Debtor.DataAcess.Entities;

namespace Debtor.Web.Models.Transactions;

public class TransactionsUpdateViewModel : TransactionsCreateViewModel
{
    public int Id { get; set; }
    public List<Account>? Accounts { get; set; } = [];
}
