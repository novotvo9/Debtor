using System.ComponentModel.DataAnnotations;

namespace Debtor.Web.Models.Accounts;

public class AccountsCreateViewModel
{
    public Guid Id { get; set; }
    [MaxLength(120, ErrorMessage = "Too long!")]
    [Required]
    public string FullName { get; set; }
    [MaxLength(16, ErrorMessage = "Too long!")]
    [Required]
    public string AccountType { get; set; }
    [MaxLength(254, ErrorMessage = "Too long!")]
    [Required]
    public string Email { get; set; }
    [MaxLength(32, ErrorMessage = "Too long!")]
    [Required]
    public string Phone { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }

}
