using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Debtor.DataAcess.Entities;

[Table("users")]
public class User
{
    [Key]
    [Column("user_id")]
    [DisplayName("ID")]
    public int Id { get; set; }
    [Column("email")]
    [DisplayName("Email")]
    public string email { get; set; }
    [Column("password")]
    [DisplayName("Password")]
    public string Password { get; set; }
}
