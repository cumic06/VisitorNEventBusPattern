using UnityEngine;

public class Player : MonoBehaviour, IDamageVisitor
{
    public int Hp = 100;
    public int Power = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamageVisitable bullet))
        {
            Debug.Log("Player");
            bullet.Accept(this);
        }
    }

    public void Visit(Bullet bullet)
    {
        if (Hp <= 0)
        {
            OnDead();
            return;
        }
        Hp -= bullet.GetDamage();
    }

    private void OnDead()
    {
        Debug.Log("PlayerDead");
        EventBus.Publish(GameState.GameOver);
    }
}