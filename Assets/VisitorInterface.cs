public interface IItemVisitable
{
    public void Accept(IItemVisitor visitor);
}

public interface IItemVisitor
{
    public void Visit(HealItem healItem);
    public void Visit(PowerUpItem powerUpItem);
}