using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    public override void Interact(Vector3 position)
    {
        base.Interact(position);
        Timer.Instance.PlayerExited();
    }
}
