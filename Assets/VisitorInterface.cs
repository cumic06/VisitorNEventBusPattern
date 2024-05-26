public interface IVisitable
{
    public void Accept(IVisitor visitor);
}

public interface IVisitor
{
    public void Visit(DamageBuff visitable);
    public void Visit(DefenseBuff visitable);
}