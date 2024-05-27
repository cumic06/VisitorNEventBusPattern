public class HealItem : Item, IItemVisitable
{
    public void Accept(IItemVisitor visitor)
    {
        visitor.Visit(this);
        Destroy(gameObject);
    }
}
