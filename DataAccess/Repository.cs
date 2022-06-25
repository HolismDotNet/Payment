namespace Payment;

public class Repository
{
    public static Write<Payment.Transaction> Transaction
    {
        get
        {
            return new Write<Payment.Transaction>(new PaymentContext());
        }
    }
}
