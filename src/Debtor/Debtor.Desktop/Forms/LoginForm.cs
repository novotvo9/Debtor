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
                this.Hide();
                MainForm form = new(userToCheck);
                form.ShowDialog();
            }
        }      
    }

    public static string HashPassword(string password)
    {
        return password;
    }
}
