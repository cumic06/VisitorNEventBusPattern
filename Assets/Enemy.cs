using UnityEngine;

public class Enemy : MonoBehaviour, IDamageVisitor
{
    public int Hp = 50;
    public int Power = 5;
    [SerializeField] private Player target;
    [SerializeField] private bool isFollow;

    private void FixedUpdate()
    {
        if (isFollow)
        {
            FollowPlayer();
        }
    }

    private void FollowPlayer()
    {
        Vector3 moveVec = target.transform.position - transform.position;
        transform.Translate(moveVec * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamageVisitable bullet))
        {
            Debug.Log("Enemey");
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
        Debug.Log("EnemyDead");
        Destroy(gameObject);
    }
}