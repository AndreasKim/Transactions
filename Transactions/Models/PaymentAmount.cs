namespace Transactions.Models
{
    public class PaymentAmount
    {
        public PaymentAmount(decimal total, decimal tax, string currency)
        {
            Total = total;
            Tax = tax;
            Currency = currency;
        }

        public decimal Total { get; set; }
        public decimal Tax { get; set; }
        public string Currency { get; set; }
    }
}