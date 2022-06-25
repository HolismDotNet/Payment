namespace Payment;

public class Transaction : IEntity, IGuid
{
    public Transaction()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public string UniqueKey { get; set; }

    public dynamic RelatedItems { get; set; }
}
