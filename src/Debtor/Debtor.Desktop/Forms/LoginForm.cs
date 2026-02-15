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
        string email = textBox_Email.Text;
        string password = HashPassword(textBox_Password.Text);

        foreach (var user in Users)
        {
            if (email == user.Email && password == user.Password)
            {
                if (email == "admin@hostmaster.com" && password == "admin")
                {
                    MessageBox.Show("ADMIN");
                    this.Hide();
                    MainForm form = new();
                    form.ShowDialog();
                }
                else
                {
                    // TODO: Change Logic
                    MessageBox.Show("REGULAR USER, OPENING ADMIN PANEL FOR NOW");
                    this.Hide();
                    MainForm form = new();
                    form.ShowDialog();
                }
            }
        }      
    }

    public static string HashPassword(string password)
    {
        return password;
    }
}
