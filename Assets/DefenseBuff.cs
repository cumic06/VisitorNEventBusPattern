using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DefenseBuff : MonoBehaviour, IVisitable
{
    public int defenseBuffValue = 0;

    public void Accept(IVisitor visitor)
    {
        Debug.Log("DefenseBuff");
        visitor.Visit(this);
    }
}