using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;

namespace Debtor.Desktop.Forms;

public partial class AccountTransactionEditForm : Form
{
    public MyDbContext MyDbContext { get; set; } = new();
    public List<string> TransactionTypes { get; set; } = [];
    public List<Account> Accounts { get; set; } = [];
    public AccountTransactionEditForm()
    {
        InitializeComponent();
        LoadCombobox();
    }

    private void LoadCombobox()
    {
        TransactionTypes = ["payment", "borrow"];
        comboBox_TransactionTypes.DataSource = TransactionTypes;

        Accounts = MyDbContext.Accounts.ToList();

        //TODO: ZLEPŠIT?
        comboBox_Accounts.DataSource = Accounts
            .Select(a => a.Id.ToString())
            .ToList();
    }

    public AccountTransaction CreateTransaction()
    {
        AccountTransaction newTransaction = new();

        // PRASÁRNA
        newTransaction.AccountId = Guid.Parse(comboBox_Accounts.SelectedValue!.ToString()!);
        newTransaction.TransactionType = (string)comboBox_TransactionTypes.SelectedValue!;
        newTransaction.Amount = numericUpDown_Amount.Value;
        newTransaction.Currency = textBox_Currency.Text.ToUpper();

        if (radioButton_Bank.Checked)
        {
            newTransaction.PaymentMethod = radioButton_Bank.Text.ToLower();
        }
        else
        {
            newTransaction.PaymentMethod = radioButton_Cash.Text.ToLower();
        }

        newTransaction.TransactionAt = DateTime.Now;

        return newTransaction;
    }

    public void LoadDataToUpdate(AccountTransaction transactionToUpate)
    {
        comboBox_Accounts.SelectedItem = transactionToUpate.AccountId;
        comboBox_Accounts.Enabled = false; //TODO: READ ONLY?
        comboBox_TransactionTypes.SelectedItem = transactionToUpate.TransactionType;
        numericUpDown_Amount.Value = transactionToUpate.Amount;
        textBox_Currency.Text = transactionToUpate.Currency;
        if (transactionToUpate.PaymentMethod == "bank")
        {
            radioButton_Bank.Checked = true;
        }
        else
        {
            radioButton_Cash.Checked = true;
        }

    }

    public void UpdateData(AccountTransaction transactionToUpate)
    {

        transactionToUpate.AccountId = Guid.Parse(comboBox_Accounts.SelectedValue!.ToString()!);
        transactionToUpate.TransactionType = (string)comboBox_TransactionTypes.SelectedValue!;
        transactionToUpate.Amount = numericUpDown_Amount.Value;
        transactionToUpate.Currency = textBox_Currency.Text.ToUpper();

        if (radioButton_Bank.Checked)
        {
            transactionToUpate.PaymentMethod = radioButton_Bank.Text.ToLower();
        }
        else
        {
            transactionToUpate.PaymentMethod = radioButton_Cash.Text.ToLower();
        }
    }

    private void Button_Cancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.No;
    }

    private void Button_Update_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Yes;
    }
}
