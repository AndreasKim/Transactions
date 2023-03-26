using Transactions.Models.Enums;

namespace Transactions.Models.Payments;

public abstract class Payment
{
    public Payment(Guid id, Guid sessionId, Gateway paymentGateway, PaymentAmount amount,
        DateTime created, PaymentState paymentState, Guid originalPaymentId, Guid? directPaymentId = null)
    {
        Id = id;
        SessionId = sessionId;
        Amount = amount;
        Created = created;
        PaymentGateway = paymentGateway;
        DirectPaymentId = directPaymentId;
        PaymentState = paymentState;
        OriginalPaymentId = originalPaymentId;
    }

    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public Gateway PaymentGateway { get; set; }
    public PaymentAmount Amount { get; set; }
    public DateTime Created { get; set; }    
    public PaymentState PaymentState { get; set; }
    public Guid OriginalPaymentId { get; set; }
    public Guid? DirectPaymentId { get; set; }
}