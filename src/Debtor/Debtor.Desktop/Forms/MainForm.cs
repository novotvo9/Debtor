using Debtor.Desktop.Forms;
using System.Diagnostics;

namespace Debtor.Desktop;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void Button_Accounts_Click(object sender, EventArgs e)
    {
        AccountGridForm accountGridForm = new();
        DialogResult result = accountGridForm.ShowDialog();
    }

    private void Button_AccountTransactions_Click(object sender, EventArgs e)
    {
        AccountTransactionGridForm accountTransactionGridForm = new();
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
