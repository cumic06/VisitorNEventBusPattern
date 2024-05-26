using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BuffData", menuName = "BuffData")]
public class BuffData : ScriptableObject, IVisitor
{
    public int damageBuffValue;
    public int defenseBuffValue;

    public void Visit(DamageBuff visitable)
    {
        visitable.damageBuffValue += damageBuffValue;
    }

    public void Visit(DefenseBuff visitable)
    {
        visitable.defenseBuffValue += defenseBuffValue;
    }
}