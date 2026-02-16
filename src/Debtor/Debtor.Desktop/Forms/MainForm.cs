using Debtor.DataAcess.Entities;
using Debtor.Desktop.Forms;
using System.Diagnostics;

namespace Debtor.Desktop;

public partial class MainForm : Form
{
    public User LoggedUser { get; set; }
    public MainForm(User loggedUser)
    {
        InitializeComponent();
        LoggedUser = loggedUser;
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
}
