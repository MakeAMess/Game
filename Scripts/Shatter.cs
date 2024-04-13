using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shatter : Interactable
{
    public GameObject shattered;
    public GameObject intact;

    public float force = 500;
    public float radius = 2;

    public override void Interact(Vector3 point)
    {
        ShatterWall(point);
    }

    public void ShatterWall(Vector3 point)
    {
        intact.SetActive(false);
        shattered.SetActive(true);

        foreach (Rigidbody rb in shattered.GetComponentsInChildren<Rigidbody>())
        {
            rb.AddExplosionForce(force, point, radius);
        }
    }
}