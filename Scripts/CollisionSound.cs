using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public AudioSource collisionSound;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (!collisionSound)
            return;

        if (collision.relativeVelocity.sqrMagnitude > 1)
        {
            if (!collisionSound.isPlaying)
                collisionSound.Play();
        }
    }
}
