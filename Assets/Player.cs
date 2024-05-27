using UnityEngine;

public class Player : MonoBehaviour, IItemVisitor
{
    public int Hp = 100;
    public int Power = 10;

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