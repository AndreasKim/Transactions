using Transactions.Models.Enums;

namespace Transactions.Models.Payments;

public class PaymentCapture : Payment
{
    public PaymentCapture(PaymentState paymentState, Guid capturedPaymentId, Guid id, Guid sessionId,
        Gateway paymentGateway, PaymentAmount amount, DateTime created)
        : base(id, sessionId, paymentGateway, amount, created)
    {
        PaymentState = paymentState;
        CapturedPaymentId = capturedPaymentId;
    }

    public Guid CapturedPaymentId { get; set; }
    public PaymentState PaymentState { get; set; }
}