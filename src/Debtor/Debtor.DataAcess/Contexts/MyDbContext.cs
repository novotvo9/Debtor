using Debtor.DataAcess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Debtor.DataAcess.Contexts;

public class MyDbContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountTransaction> AccountTransactions { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string MySqlConnectionString = "server=localhost;port=3307;database=4c2_novotnyvojtech_db2;uid=novotnyvojtech;password=123456;";
        //string MySqlConnectionString = "server=mysqlstudenti.litv.sssvt.cz;database=4c2_novotnyvojtech_db2;uid=novotnyvojtech;password=123456";
        optionsBuilder.UseMySQL(MySqlConnectionString);
    }
}
