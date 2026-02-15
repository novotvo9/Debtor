using Microsoft.EntityFrameworkCore.Internal;

namespace Debtor.Desktop.Forms;

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();
    }

    private void Button_Login_Click(object sender, EventArgs e)
    {
        this.Hide();
        LoginForm form = new();
        form.ShowDialog();
        this.Close();
    }

    private void Button_Register_Click(object sender, EventArgs e)
    {
        this.Hide();
        RegisterForm form = new();
        form.ShowDialog();
        this.Close();
    }

    private void Button_Exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
