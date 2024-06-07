using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IDamageVisitable
{
    [SerializeField] private int damage;

    public int GetDamage()
    {
        return damage;
    }

    public void Accept(IDamageVisitor visitor)
    {
        visitor.Visit(this);
    }
}
