using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using Debtor.ImportExport;
using System.ComponentModel;
using System.Diagnostics;

namespace Debtor.Desktop.Forms;

public partial class AccountGridForm : Form
{
    public BindingList<Account> AccountsData { get; set; } = [];
    public MyDbContext MyDbContext { get; set; } = new();
    public User LoggedUser { get; set; }
    public AccountGridForm(User loggedUser)
    {
        InitializeComponent();
        LoggedUser = loggedUser;
        LoadAccountData();
    }

    private void LoadAccountData()
    {
        List<Account> accounts = MyDbContext.Accounts.ToList();
        AccountsData = new BindingList<Account>(accounts);

        dataGridView_Accounts.DataSource = AccountsData;

        DataGridViewColumn lastCol = dataGridView_Accounts.Columns[dataGridView_Accounts.Columns.Count - 1];
        lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        if (LoggedUser.Email != "admin@hostmaster.com")
        {
            button_Delete.Enabled = false;
            button_Update.Enabled = false;
            button_Detail.Enabled = false;

            dataGridView_Accounts.DataSource = AccountsData = new BindingList<Account>(accounts.Where(a => a.Email == LoggedUser.Email).ToList());
        }
    }

    private void Button_ExportCSV_Click(object sender, EventArgs e)
    {
        saveFileDialog_ExportCSV.FileName = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}-Accounts";
        DialogResult result = saveFileDialog_ExportCSV.ShowDialog();
        if (result != DialogResult.Cancel)
        {
            string filePath = saveFileDialog_ExportCSV.FileName;
            Exporter.ExportAccountsCsv(filePath, MyDbContext.Accounts.ToList());
            MessageBox.Show("Accounts Exported!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void Button_Delete_Click(object sender, EventArgs e)
    {
        if (dataGridView_Accounts.CurrentRow != null)
        {
            Account account = AccountsData[dataGridView_Accounts.CurrentRow.Index];
            DialogResult dialogResult = MessageBox.Show($"Do you really wish to delete account {account.Id}?", "Confirm delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MyDbContext.Accounts.Remove(account);
                MyDbContext.SaveChanges();

                AccountsData.Remove(account);
            }
        }
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void Button_Create_Click(object sender, EventArgs e)
    {
        AccountEditForm form = new();
        this.Hide();
        DialogResult dialogResult = form.ShowDialog();


        if (dialogResult == DialogResult.Yes)
        {
            Account newAccount = form.CreateAccount();

            foreach (var account in MyDbContext.Accounts.ToList())
            {
                if (newAccount.Email != account.Email)
                {
                    MyDbContext.Accounts.Add(newAccount);
                    MyDbContext.SaveChanges();

                    AccountsData.Add(newAccount);
                }
            }
        }

        this.Show();
    }

    private void Button_Update_Click(object sender, EventArgs e)
    {
        if (dataGridView_Accounts.CurrentRow != null)
        {
            AccountEditForm form = new();

            Account accountToUpdate = AccountsData[dataGridView_Accounts.CurrentRow.Index];

            form.LoadDataToUpdate(accountToUpdate);
            this.Hide();
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                form.UpdateData(accountToUpdate);

                MyDbContext.Accounts.Update(accountToUpdate);
                MyDbContext.SaveChanges();

                dataGridView_Accounts.Refresh();
            }
            this.Show();
        }

    }

    private void Button_Detail_Click(object sender, EventArgs e)
    {
        if (dataGridView_Accounts.CurrentRow != null)
        {
            Account accountToDetail = AccountsData[dataGridView_Accounts.CurrentRow.Index];
            List<AccountTransaction> accountDetailTransactions = MyDbContext.AccountTransactions.Where(t => t.AccountId == accountToDetail.Id).ToList();
            AccountTransactionGridForm form = new(new BindingList<AccountTransaction>(accountDetailTransactions), LoggedUser);
            form.ShowDialog();
        }
    }

    private void GithubToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo("https://github.com/novotvo9/Debtor") { UseShellExecute = true });
    }
}
