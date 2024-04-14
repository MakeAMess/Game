using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public AudioSource collisionSound;

    // Start is called before the first frame update
    void Start()
    {
        //Randomize color
        MaterialPropertyBlock block = new MaterialPropertyBlock();
        block.SetColor("_Color", Random.ColorHSV());
        GetComponent<MeshRenderer>().SetPropertyBlock(block, 0);
    }

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
