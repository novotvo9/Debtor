using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using System.ComponentModel;

namespace Debtor.Desktop.Forms;

public partial class AccountTransactionGridForm : Form
{
    public BindingList<AccountTransaction> AccountTransactionsData { get; set; } = [];
    public MyDbContext MyDbContext { get; set; } = new();
    public AccountTransactionGridForm()
    {
        InitializeComponent();
        LoadAccountTransactionData();
    }

    private void LoadAccountTransactionData()
    {
        //List<AccountTransaction> accountTransactions = MyDbContext.AccountTransactions.Include(a => a.Account).ToList();
        List<AccountTransaction> accountTransactions = MyDbContext.AccountTransactions.ToList();
        AccountTransactionsData = new BindingList<AccountTransaction>(accountTransactions);

        dataGridView_AccountTransactions.DataSource = AccountTransactionsData;

        DataGridViewColumn lastCol = dataGridView_AccountTransactions.Columns[dataGridView_AccountTransactions.Columns.Count - 1];
        lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }
}
