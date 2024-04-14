using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionInteractable : MonoBehaviour
{
    public Interactable interactable;

    public float magnitude;

    public string objectName;

    private void OnCollisionEnter(Collision collision)
    {
        if (!string.IsNullOrEmpty(objectName))
        {
            if (collision.rigidbody.name != objectName)
                return;
        }

        if (collision.relativeVelocity.sqrMagnitude > magnitude)
        {
            interactable.Interact(collision.contacts[0].point);
        }
    }
}
