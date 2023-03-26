using Transactions.Models.Payments;

namespace Transactions.Models;

public class PlannedTransaction : Transaction
{
    public PlannedTransaction(Guid plannedId, Guid id, Guid payerId, Guid receiverId, List<Payment> payments, PaymentAmount amount, string? description, DateTime created)
        : base(id, payerId, receiverId, payments, amount, description, created)
    {
        PlannedId = plannedId;
    }

    public Guid PlannedId { get; set; }
}
