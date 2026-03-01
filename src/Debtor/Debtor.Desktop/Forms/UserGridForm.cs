using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using System.ComponentModel;
using System.Diagnostics;

namespace Debtor.Desktop.Forms;

public partial class UserGridForm : Form
{
    public BindingList<User> UsersData { get; set; } = [];
    public MyDbContext MyDbContext { get; set; } = new();
    public UserGridForm()
    {
        InitializeComponent();
        LoadUserData();
    }

    private void LoadUserData()
    {
        List<User> users = MyDbContext.Users.ToList();
        UsersData = new BindingList<User>(users);

        dataGridView_Users.DataSource = UsersData;

        DataGridViewColumn lastCol = dataGridView_Users.Columns[dataGridView_Users.Columns.Count - 1];
        lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void GithubToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo("https://github.com/novotvo9/Debtor") { UseShellExecute = true });
    }
}
