using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DamageBuff : MonoBehaviour, IVisitable
{
    public int damageBuffValue = 0;

    public void Accept(IVisitor visitor)
    {
        Debug.Log("DamageBuff");
        visitor.Visit(this);
    }
}
