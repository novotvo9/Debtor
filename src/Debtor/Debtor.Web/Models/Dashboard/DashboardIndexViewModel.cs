using Debtor.DataAcess.Entities;

namespace Debtor.Web.Models.Dashboard
{
    public class DashboardIndexViewModel
    {
        public Account Account { get; set; } = new();
        public List<AccountTransaction> Transactions { get; set; } = [];
        public decimal Balance { get; set; }
    }
}
