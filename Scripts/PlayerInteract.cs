using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] Transform handPos;
    [SerializeField] float throwForce;

    Rigidbody rigidbody = null;
    Collider collider = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (rigidbody)
            {
                rigidbody.isKinematic = false;
                collider.enabled = true;

                rigidbody.AddForce(transform.forward * throwForce, ForceMode.Impulse);
                rigidbody = null;

                return;
            }

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2.5f, LayerMask.GetMask("Interactable")))
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
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2.5f, LayerMask.GetMask("Interactable")))
            {
                if (!rigidbody)
                {
                    if (hit.rigidbody.mass > 5)
                        return;

                    rigidbody = hit.rigidbody;
                    collider = hit.collider;

                    rigidbody.isKinematic = true;
                    collider.enabled = false;
                }
            }
        }

        if (rigidbody)
        {
            rigidbody.position = handPos.position;
            rigidbody.rotation = handPos.rotation;
        }
    }
}
