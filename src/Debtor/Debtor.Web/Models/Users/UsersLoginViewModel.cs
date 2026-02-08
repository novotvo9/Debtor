using System.ComponentModel.DataAnnotations;

namespace Debtor.Web.Models.Users;

public class UsersLoginViewModel
{
    public int Id { get; set; }

    [MaxLength(254, ErrorMessage = "Too long!")]
    [Required]
    public string Email { get; set; }
    [MaxLength(254, ErrorMessage = "Too long!")]
    [Required]
    public string Password { get; set; }
}
