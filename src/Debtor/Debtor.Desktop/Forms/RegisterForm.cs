using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;

namespace Debtor.Desktop.Forms;

public partial class RegisterForm : Form
{
    public MyDbContext MyDbContext { get; set; } = new();
    public List<User> Users { get; set; } = [];
    public RegisterForm()
    {
        InitializeComponent();
        Users = MyDbContext.Users.ToList();
    }

    private void Button_Cancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void Button_Register_Click(object sender, EventArgs e)
    {
        // TODO: Validace

        if (textBox_Password.Text == textBox_PasswordAgain.Text)
        {
            User newUser = new();
            newUser.Email = textBox_Email.Text;
            newUser.Password = textBox_Password.Text;

            MyDbContext.Users.Add(newUser);
            MyDbContext.SaveChanges();

            this.Hide();
            LoginForm form = new();
            form.ShowDialog();
            this.Close();
        }
        else
        {
            textBox_Email.Clear();
            textBox_Password.Clear();
            textBox_PasswordAgain.Clear();

            MessageBox.Show("Error! Passwords do not match");
        }

        
    }
}
