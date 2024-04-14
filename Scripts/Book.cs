using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Randomize color
        MaterialPropertyBlock block = new MaterialPropertyBlock();
        block.SetColor("_Color", Random.ColorHSV());
        GetComponent<MeshRenderer>().SetPropertyBlock(block, 0);
    }
}
