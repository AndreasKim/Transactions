using Transactions.Models.Enums;

namespace Transactions.Models.Payments;

public class PaymentAuthorization : Payment
{
    public PaymentAuthorization(bool captured, Guid id,
        Guid sessionId, Gateway paymentGateway, PaymentAmount amount, DateTime created, PaymentState paymentState, Guid originalPaymentId, Guid? directPaymentId = null)
        : base(id, sessionId, paymentGateway, amount, created, paymentState, originalPaymentId, directPaymentId)
    {
        Captured = captured;
    }

    public bool Captured { get; set; }
}