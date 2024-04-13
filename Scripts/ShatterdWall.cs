using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterdWall : MonoBehaviour, Interactable
{
    public GameObject shattered;
    public GameObject intactWall;
    public GameObject testPoint;

    public void Interact()
    {
        ShatterWall(testPoint.transform.position);
    }

    public void ShatterWall(Vector3 point)
    {
        intactWall.SetActive(false);
        shattered.SetActive(true);

        foreach (Rigidbody rb in shattered.GetComponentsInChildren<Rigidbody>())
        {
            rb.AddExplosionForce(800, point, 4);
        }
    }
}
