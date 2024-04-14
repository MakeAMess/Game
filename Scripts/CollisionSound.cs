using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public AudioSource collisionSound;
    public float points;
    public float magnetude = 5;

    private bool pointsGotten;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (!collisionSound)
            return;

        if (collision.relativeVelocity.sqrMagnitude > magnetude)
        {
            if (!collisionSound.isPlaying)
                collisionSound.Play();

            if (!pointsGotten)
            {
                pointsGotten = true;
                ScoreManager.Instance.AddScore(points);
            }
        }
    }
}
