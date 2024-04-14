using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Interactable
{
    public override void Interact(Vector3 position)
    {
        base.Interact(position);
        Timer.Instance.PlayerFoundKey();
        Destroy(gameObject);
    }
}
