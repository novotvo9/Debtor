using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using System.ComponentModel;

namespace Debtor.Desktop.Forms;

public partial class AccountGridForm : Form
{
    public BindingList<Account> AccountsData { get; set; } = [];
    public MyDbContext MyDbContext { get; set; } = new();
    public AccountGridForm()
    {
        InitializeComponent();
        LoadAccountData();
    }

    private void LoadAccountData()
    {
        List<Account> accounts = MyDbContext.Accounts.ToList();
        AccountsData = new BindingList<Account>(accounts);

        dataGridView_Accounts.DataSource = AccountsData;

        DataGridViewColumn lastCol = dataGridView_Accounts.Columns[dataGridView_Accounts.Columns.Count - 1];
        lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }
}
