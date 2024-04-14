using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Interactable
{
    [SerializeField] Timer timer;

    public override void Interact(Vector3 position)
    {
        base.Interact(position);
        timer.PlayerFoundKey();
        Destroy(gameObject);
    }
}
