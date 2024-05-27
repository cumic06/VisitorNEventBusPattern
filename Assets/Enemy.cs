using UnityEngine;

public class Enemy : MonoBehaviour, IItemVisitor
{
    public int Hp = 50;
    public int Power = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IItemVisitable item))
        {
            item.Accept(this);
        }
    }

    public void Visit(HealItem healItem)
    {
        Hp += (int)healItem.Value;
    }

    public void Visit(PowerUpItem powerUpItem)
    {
        Power += (int)powerUpItem.Value;
    }
}