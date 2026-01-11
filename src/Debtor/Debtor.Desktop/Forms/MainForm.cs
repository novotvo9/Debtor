using Debtor.Desktop.Forms;

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
}
