using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : Interactable
{
    public GameObject point;
    public float force = 500;
    public float radius = 2;

    private bool done;

    public override void Interact(Vector3 point)
    {
        if (done) return;
        done = true;
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
