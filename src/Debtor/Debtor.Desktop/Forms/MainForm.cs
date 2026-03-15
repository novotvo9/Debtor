using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using Debtor.Desktop.Forms;
using System.Diagnostics;

namespace Debtor.Desktop;

public partial class MainForm : Form
{
    public decimal Balance { get; set; } = 0;
    public string Currency { get; set; } = "";
    public MyDbContext MyDbContext { get; set; } = new();
    public User LoggedUser { get; set; }
    public MainForm(User loggedUser)
    {
        InitializeComponent();
        LoggedUser = loggedUser;
        if (LoggedUser.Email != "admin@hostmaster.com")
        {
            button_Users.Enabled = false;
        }

        if (LoggedUser.Email != "admin@hostmaster.com")
        {
            Account usersAccount = MyDbContext.Accounts.FirstOrDefault(a => a.Email == LoggedUser.Email)!;
            List<AccountTransaction>? usersTransactions = MyDbContext.AccountTransactions.Where(t => t.AccountId == usersAccount.Id).ToList();

            if (usersTransactions.Any())
            {
                Balance = usersTransactions.Where(t => t.TransactionType == "payment").Sum(t => t.Amount) -
                    usersTransactions.Where(t => t.TransactionType == "borrow").Sum(t => t.Amount);
                Currency = usersTransactions.First().Currency;
            }

            MessageBox.Show($"Balance: {Balance} {Currency}");
        }
    }

    private void Button_Accounts_Click(object sender, EventArgs e)
    {
        AccountGridForm accountGridForm = new(LoggedUser);
        DialogResult result = accountGridForm.ShowDialog();
    }

    private void Button_AccountTransactions_Click(object sender, EventArgs e)
    {
        AccountTransactionGridForm accountTransactionGridForm = new(LoggedUser);
        DialogResult result = accountTransactionGridForm.ShowDialog();
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void GithubToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo("https://github.com/novotvo9/Debtor") { UseShellExecute = true });
    }

    private void Button_Users_Click(object sender, EventArgs e)
    {
        UserGridForm form = new();
        DialogResult result = form.ShowDialog();
    }
}
