using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour, Interactable
{
    public GameObject point;
    public float force = 500;
    public float radius = 2;

    public void Interact()
    {
        Explode();
    }

    // Start is called before the first frame update
    void Explode()
    {
        foreach (Rigidbody rb in GetComponentsInChildren<Rigidbody>())
        {
            rb.AddExplosionForce(force, point.transform.position, radius);
        }
    }
}
