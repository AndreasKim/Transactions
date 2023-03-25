using Transactions.Models.Payments;

namespace Transactions.Models;

public class Transactions
{
    public Transactions(Guid id, Guid sessionId, Guid payerId, Guid receiverId,
        List<Payment> payments, PaymentAmount amount,
        string? description, DateTime created)
    {
        Description = description;
        Payments = payments;
        Id = id;
        PayerId = payerId;
        ReceiverId = receiverId;
        Amount = amount;
        Created = created;
        SessionId = sessionId;
    }

    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public Guid PayerId { get; set; }
    public Guid ReceiverId { get; set; }
    public List<Payment> Payments { get; set; }
    public PaymentAmount Amount { get; set; }
    public decimal Balance { get; }
    public string? Description { get; set; }  
    public DateTime Created { get; set; }
}
