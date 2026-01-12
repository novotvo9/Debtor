using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Debtor.DataAcess.Entities;

[Table("accounts")]
public class Account
{
    [Key]
    [Column("account_id")]
    [DisplayName("ID")]
    public Guid Id { get; set; }
    [Column("full_name")]
    [DisplayName("Full Name")]
    public string FullName { get; set; }
    [Column("account_type")]
    [DisplayName("Account Type")]
    public string AccountType { get; set; }
    [Column("email")]
    [DisplayName("Email")]
    public string Email { get; set; }
    [Column("phone")]
    [DisplayName("Phone")]
    public string Phone { get; set; }
    [Column("created_at")]
    [DisplayName("Created At")]
    public DateTime CreatedAt { get; set; }

    //public List<AccountTransaction> AccountTransactions { get; set; } = [];
}
