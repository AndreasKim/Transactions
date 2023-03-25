using Transactions.Models.Enums;

namespace Transactions.Models.Payments;

public class PaymentRefund : Payment
{
    public PaymentRefund(PaymentState paymentState, Guid refundedCaptureId, Guid id, Guid sessionId,
        Gateway paymentGateway, PaymentAmount amount, DateTime created)
        : base(id, sessionId, paymentGateway, amount, created)
    {
        PaymentState = paymentState;
        RefundedCaptureId = refundedCaptureId;
    }

    public Guid RefundedCaptureId { get; set; }
    public PaymentState PaymentState { get; set; }
}