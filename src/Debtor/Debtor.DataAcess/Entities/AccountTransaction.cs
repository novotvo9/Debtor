using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Debtor.DataAcess.Entities;

[Table("account_transactions")]
public class AccountTransaction
{
    [Key]
    [Column("transaction_id")]
    [DisplayName("ID")]
    public int Id { get; set; }
    [Column("account_id")]
    [DisplayName("Account ID")]
    public Guid AccountId { get; set; }
    [Column("transaction_type")]
    [DisplayName("Transaction Type")]
    public string TransactionType { get; set; }

    [Column("amount")]
    [DisplayName("Amount")]
    public decimal Amount { get; set; }

    [Column("currency")]
    [DisplayName("Currency")]
    public string Currency { get; set; }

    [Column("transaction_at")]
    [DisplayName("Transaction Date")]
    public DateTime TransactionAt { get; set; }

    [Column("payment_method")]
    [DisplayName("Payment Method")]
    public string PaymentMethod { get; set; }


    // TODO: Huh?
    /*
    [DisplayName("Account")]
    [ForeignKey(nameof(AccountId))]
    [Browsable(false)]
    public Account Account { get; set; }
    */
}
