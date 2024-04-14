using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public float points;
    public virtual void Interact(Vector3 position)
    {
        ScoreManager.Instance.AddScore(points);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.sqrMagnitude > 5)
        {
            ScoreManager.Instance.AddScore(5);
        }
    }
}

