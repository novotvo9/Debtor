using Debtor.DataAcess.Entities;

namespace Debtor.ImportExport;

public class Exporter
{
    public static void ExportAccountsCsv(string filePath, List<Account> accounts)
    {
        using StreamWriter writer = new(filePath, false);
        writer.WriteLine("Id;FullName;AccountType;Email;Phone;CreatedAt");

        foreach (var account in accounts)
        {
            string line = $"{account.Id};{account.FullName};{account.AccountType};{account.Email};{account.Phone};{account.CreatedAt}";
            writer.WriteLine(line);
        }
    }

    public static void ExportTransactionsCsv(string filePath, List<AccountTransaction> transactions)
    {
        using StreamWriter writer = new(filePath, false);
        writer.WriteLine("Id;AccountID;TransactionType;Amount;Currency;TransactionAt;Payment Method");

        foreach (var transaction in transactions)
        {
            string line = $"{transaction.Id};{transaction.AccountId};{transaction.TransactionType};{transaction.Amount};{transaction.Currency};{transaction.TransactionAt};{transaction.PaymentMethod}";
            writer.WriteLine(line);
        }
    }
}
