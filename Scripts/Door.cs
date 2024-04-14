using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    [SerializeField] Timer timer;

    public override void Interact(Vector3 position)
    {
        base.Interact(position);
        timer.PlayerExited();
    }
}
