using Transactions.Models.Enums;
using Transactions.Models.Payments;

namespace Transactions.Models;

public class Transaction
{
    public Transaction(Guid id, Guid payerId, Guid receiverId,
        List<Payment> payments, PaymentAmount amount,
        string? description, DateTime created)
    {
        Description = description;
        Payments = payments;
        Id = id;
        PayerId = payerId;
        ReceiverId = receiverId;
        Amount = amount;
        Created = created;
    }

    public Guid Id { get; set; }
    public Guid PayerId { get; set; }
    public Guid ReceiverId { get; set; }
    public List<Payment> Payments { get; set; }
    public PaymentAmount Amount { get; set; }
    public decimal Balance => GetBalance();
    public string? Description { get; set; }  
    public DateTime Created { get; set; }

    private decimal GetBalance()
    {
       var paymentAmount = Payments
            .Where(p => p is PaymentCapture or PaymentRefund && p.PaymentState == PaymentState.Completed)
            .Sum(p => p.Amount.Total);

        return Amount.Total - paymentAmount;
    }
}
