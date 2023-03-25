namespace Transactions.Models.Payments;

public abstract class Payment
{
    public Payment(Guid id, Guid sessionId,
        Gateway paymentGateway, PaymentAmount amount, DateTime created)
    {
        Id = id;
        SessionId = sessionId;
        Amount = amount;
        Created = created;
        PaymentGateway = paymentGateway;
    }

    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public Gateway PaymentGateway { get; set; }
    public PaymentAmount Amount { get; set; }
    public DateTime Created { get; set; }
}