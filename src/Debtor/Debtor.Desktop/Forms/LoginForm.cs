using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;

namespace Debtor.Desktop.Forms;

public partial class LoginForm : Form
{
    public MyDbContext MyDbContext { get; set; } = new();
    public List<User> Users { get; set; } = [];
    public LoginForm()
    {
        InitializeComponent();
        Users = MyDbContext.Users.ToList();
    }

    private void Button_Cancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void Button_Login_Click(object sender, EventArgs e)
    {
        User userToCheck = new();
        userToCheck.Email = textBox_Email.Text;
        userToCheck.Password = HashPassword(textBox_Password.Text);

        foreach (var user in Users)
        {
            if (userToCheck.Email == user.Email && userToCheck.Password == user.Password)
            {
                Account? account = MyDbContext.Accounts.FirstOrDefault(a => a.Email == userToCheck.Email);
                if (account == null && userToCheck.Email != "admin@hostmaster.com")
                {
                    AccountEditForm createForm = new(userToCheck);
                    this.Hide();
                    DialogResult dialogResult = createForm.ShowDialog();

                    if (dialogResult == DialogResult.Yes)
                    {
                        Account newAccount = createForm.CreateAccount();

                        int i = 0;
                        foreach (var a in MyDbContext.Accounts.ToList())
                        {
                            if (newAccount.Email == a.Email)
                            {
                                i++;
                                break;
                            }
                        }

                        if (i == 0)
                        {
                            MyDbContext.Accounts.Add(newAccount);
                            MyDbContext.SaveChanges();
                        }
                    }

                    this.Show();
                }

                this.Hide();
                MainForm form = new(userToCheck);
                form.ShowDialog();
                this.Close();
                break;
            }
        }
    }

    public static string HashPassword(string password)
    {
        return password;
    }
}
