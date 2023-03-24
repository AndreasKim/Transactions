namespace Transactions.Models
{
    public class Payment
    {
        public Payment(Guid id, Guid sessionId, Guid gatewayIntentId, 
            PaymentType paymentType, PaymentAmount amount, DateTime created)
        {
            Id = id;
            SessionId = sessionId;
            GatewayIntentId = gatewayIntentId;
            PaymentType = paymentType;
            Amount = amount;
            Created = created;
        }

        public Guid Id { get; set; }
        public Guid SessionId { get; set; }
        public Guid GatewayIntentId { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentAmount Amount { get; set; }
        public DateTime Created { get; set; }
    }
}