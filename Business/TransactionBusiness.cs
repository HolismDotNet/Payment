namespace Payment;

public class TransactionBusiness : Business<Transaction, Transaction>
{
    protected override Read<Transaction> Read => Repository.Transaction;

    protected override Write<Transaction> Write => Repository.Transaction;
}