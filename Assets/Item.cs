using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public BuffData buffData;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (other.TryGetComponent(out IVisitable player))
        {
            player.Accept(buffData);
        }

        Destroy(gameObject);
    }
}