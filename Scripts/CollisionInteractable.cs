using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionInteractable : MonoBehaviour
{
    public Interactable interactable;

    public float magnitude;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.sqrMagnitude > magnitude)
        {
            interactable.Interact(collision.contacts[0].point);
        }
    }
}
