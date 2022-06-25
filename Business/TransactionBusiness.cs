namespace Payment;

public class TransactionBusiness : Business<Read, Write>
{
    protected override Read<Transaction> Read => Repository.Transaction;

    protected override Write<Transaction> Write => Repository.Transaction;
}