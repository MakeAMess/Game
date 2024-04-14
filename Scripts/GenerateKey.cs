using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateKey : MonoBehaviour
{
    [SerializeField] private Transform[] keyLocations;
    [SerializeField] private GameObject key;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(key, keyLocations[Random.Range(0, keyLocations.Length)]);        
    }
}
