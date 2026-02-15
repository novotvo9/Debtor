using System.ComponentModel.DataAnnotations;

namespace Debtor.Web.Models.Transactions;

public class TransactionsCreateViewModel
{
    public int Id { get; set; }
    [Required]
    public Guid AccountId { get; set; }
    [MaxLength(16, ErrorMessage = "Too long!")]
    [Required]
    public string TransactionType { get; set; }
    [Required]
    public decimal Amount { get; set; }
    [MaxLength(3, ErrorMessage = "Too long!")]
    [MinLength(3, ErrorMessage = "Too short!")]
    [Required]
    public string Currency { get; set; }
    [Required]
    public DateTime TransactionAt { get; set; }
    [MaxLength(16, ErrorMessage = "Too long!")]
    [Required]
    public string PaymentMethod { get; set; }
}
