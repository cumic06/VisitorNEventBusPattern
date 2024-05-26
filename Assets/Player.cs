using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IVisitable
{
    List<IVisitable> buffList = new();

    private void Awake()
    {
        var damageBuff = gameObject.AddComponent<DamageBuff>();
        var defenseBuff = gameObject.AddComponent<DefenseBuff>();
        buffList.Add(damageBuff);
        buffList.Add(defenseBuff);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var buff in buffList)
        {
            buff.Accept(visitor);
        }
    }
}
