namespace Payment;

public class PaymentContext : DatabaseContext
{
    public override string ConnectionStringName => "Payment";

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
