using Transactions.Models.Enums;

namespace Transactions.Models.Payments;

public class PaymentRefund : Payment
{
    public PaymentRefund(Guid refundedCaptureId, Guid id, Guid sessionId,
        Gateway paymentGateway, PaymentAmount amount, DateTime created, PaymentState paymentState, Guid originalPaymentId, Guid? directPaymentId = null)
        : base(id, sessionId, paymentGateway, amount, created, paymentState, originalPaymentId, directPaymentId)
    {
        RefundedCaptureId = refundedCaptureId;
    }

    public Guid RefundedCaptureId { get; set; }
}