namespace Transactions.Models.Payments;

public class Gateway
{
    public Gateway(Guid paymentGatewayId, Guid gatewayIntentId)
    {
        PaymentGatewayId = paymentGatewayId;
        GatewayIntentId = gatewayIntentId;
    }

    public Guid PaymentGatewayId { get; set; }
    public Guid GatewayIntentId { get; set; }
}
