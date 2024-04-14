using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Rigidbody rb;
    public List<Collider> colliders;

    public float throwForce;

    public void Throw(Vector3 direction)
    {
        rb.AddForce(direction * throwForce, ForceMode.Impulse);
    }
}
