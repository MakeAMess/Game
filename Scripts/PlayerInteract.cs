using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] Transform handPos;
    [SerializeField] float throwForce;

    Pickup pickup = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (pickup)
            {
                pickup.rb.isKinematic = false;
                pickup.colliders.ForEach(c => c.enabled = true);

                pickup.Throw(transform.forward);

                pickup = null;
                return;
            }

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 3f, LayerMask.GetMask("Interactable")))
            {
                Interactable interactable = hit.rigidbody.GetComponentInParent<Interactable>();
                if (interactable != null)
                {
                    interactable.Interact(hit.point);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 3f, LayerMask.GetMask("Interactable")))
            {
                if (!pickup)
                {
                    pickup = hit.rigidbody.GetComponentInParent<Pickup>();
                    if (!pickup)
                        return;

                    pickup.rb.isKinematic = true;
                    pickup.colliders.ForEach(c => c.enabled = false);
                }
            }
        }

        if (pickup)
        {
            pickup.transform.position = handPos.position;
            pickup.transform.rotation = handPos.rotation;
        }
    }
}
