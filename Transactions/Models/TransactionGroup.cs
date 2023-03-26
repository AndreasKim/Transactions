using Transactions.Models.Payments;

namespace Transactions.Models;

public class TransactionGroup
{
    public TransactionGroup(Guid sessionId, List<Transaction> transactions, List<Payment> directPayments)
    {
        SessionId = sessionId;
        Transactions = transactions;
        DirectPayments = directPayments;
    }

    public Guid SessionId { get; set; }
    public List<Transaction> Transactions { get; set; }
    public List<Payment> DirectPayments { get; set; }
}
