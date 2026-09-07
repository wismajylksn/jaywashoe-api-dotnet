namespace JaywashoeApi.Models;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string WhatsappNumber { get; set; } = string.Empty;
    public int ServiceId { get; set; }
    public decimal TotalAmount { get; set; }
    public string PaymentStatus { get; set; } = "Unpaid"; 
}