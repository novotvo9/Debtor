using System.ComponentModel.DataAnnotations;

namespace Debtor.Web.Models.Users;

public class UsersRegisterViewModel : UsersLoginViewModel
{
    [MaxLength(254, ErrorMessage = "Too long!")]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    [Required]
    public string ConfirmPassword { get; set; }
}
