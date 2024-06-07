public interface IDamageVisitable
{
    public void Accept(IDamageVisitor visitor);
}

public interface IDamageVisitor
{
    public void Visit(Bullet bullet);
}