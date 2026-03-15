using Debtor.DataAcess.Entities;
using System.ComponentModel;

namespace Debtor.Desktop.Forms;

public partial class AccountEditForm : Form
{
    public List<string> AccountTypes { get; set; } = [];
    public User LoggedUser { get; set; }

    public AccountEditForm(User loggedUser)
    {
        InitializeComponent();
        LoadCombobox();
        LoggedUser = loggedUser;
        if (LoggedUser.Email != "admin@hostmaster.com")
        {
            comboBox_AccountTypes.Enabled = false;
            textBox_Email.Text = LoggedUser.Email;
            textBox_Email.Enabled = false;
        }
    }

    private void LoadCombobox()
    {
        AccountTypes = ["debtor", "testor"];
        comboBox_AccountTypes.DataSource = AccountTypes;
    }

    public Account CreateAccount()
    {
        Account newAccount = new();

        newAccount.Id = new Guid();

        newAccount.FullName = textBox_Name.Text;
        newAccount.AccountType = (string)comboBox_AccountTypes.SelectedValue!;
        newAccount.Email = textBox_Email.Text;
        newAccount.Phone = textBox_Phone.Text;

        newAccount.CreatedAt = DateTime.Now;

        return newAccount;
    }

    private void Button_Cancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.No;
    }

    private void Button_Update_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Yes;
    }

    public void LoadDataToUpdate(Account accountToUpdate)
    {
        textBox_Name.Text = accountToUpdate.FullName;
        comboBox_AccountTypes.SelectedItem = accountToUpdate.AccountType;
        textBox_Email.Text = accountToUpdate.Email;
        textBox_Phone.Text = accountToUpdate.Phone;
    }

    public void UpdateData(Account accountToUpdate)
    {
        accountToUpdate.FullName = textBox_Name.Text;
        accountToUpdate.AccountType = (string)comboBox_AccountTypes.SelectedValue!;
        accountToUpdate.Email = textBox_Email.Text;
        accountToUpdate.Phone = textBox_Phone.Text;
    }
}
