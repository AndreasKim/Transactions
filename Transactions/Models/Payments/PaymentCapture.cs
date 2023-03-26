using Transactions.Models.Enums;

namespace Transactions.Models.Payments;

public class PaymentCapture : Payment
{
    public PaymentCapture(Guid capturedPaymentId, Guid id, Guid sessionId,
        Gateway paymentGateway, PaymentAmount amount, DateTime created, PaymentState paymentState, Guid originalPaymentId, Guid? directPaymentId = null)
        : base(id, sessionId, paymentGateway, amount, created, paymentState, originalPaymentId, directPaymentId)
    {
        CapturedPaymentId = capturedPaymentId;
    }

    public Guid CapturedPaymentId { get; set; }
}