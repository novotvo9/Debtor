using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using Debtor.ImportExport;
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

    private void Button_ExportCSV_Click(object sender, EventArgs e)
    {
        saveFileDialog_ExportCSV.FileName = $"{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day}-Transactions";
        DialogResult result = saveFileDialog_ExportCSV.ShowDialog();
        if (result != DialogResult.Cancel || string.IsNullOrWhiteSpace(saveFileDialog_ExportCSV.FileName) == false)
        {
            string filePath = saveFileDialog_ExportCSV.FileName;
            Exporter.ExportTransactionsCsv(filePath, MyDbContext.AccountTransactions.ToList());
            MessageBox.Show("Transactions Exported!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void Button_Delete_Click(object sender, EventArgs e)
    {
        if (dataGridView_AccountTransactions.CurrentRow != null)
        {
            AccountTransaction transaction = AccountTransactionsData[dataGridView_AccountTransactions.CurrentRow.Index];
            DialogResult dialogResult = MessageBox.Show($"Do you really wish to delete transaction {transaction.Id}?", "Confirm delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MyDbContext.AccountTransactions.Remove(transaction);
                MyDbContext.SaveChanges();

                AccountTransactionsData.Remove(transaction);
            }
        }
    }
}
