namespace HealthDomain.Entities
{
    public enum Method
    {
        Cash,
        Card
    }

    public enum BillingStatus
    {
        Pending,
        Paid,
        Failed,
        Refunded
    }

    public class Billing
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Method Method { get; set; }
        public BillingStatus Status { get; set; } = BillingStatus.Pending;
        public int patient_id { get; set; }
        public Patient Patient { get; set; }
    }
}