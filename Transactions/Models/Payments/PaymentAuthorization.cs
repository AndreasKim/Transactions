namespace Transactions.Models.Payments;

public enum PaymentAuthorizationState
{
    None,
    Pending,
    Capturable,
    Captured,
    Failed
}

public class PaymentAuthorization : Payment
{
    public PaymentAuthorization(PaymentAuthorizationState paymentState, Guid id, Guid sessionId,
        Gateway paymentGateway, PaymentAmount amount, DateTime created)
        : base(id, sessionId, paymentGateway, amount, created)
    {
        PaymentState = paymentState;
    }

    public PaymentAuthorizationState PaymentState { get; set; }
}