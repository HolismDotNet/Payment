namespace Payment;

public class PaymentContext : DatabaseContext
{
    public override string ConnectionStringName => "Payment";

    public DbSet<Payment.Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
