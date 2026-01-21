using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetStop : MonoBehaviour
{
    public Behaviour scriptA;
    // Start is called before the first frame update
    void Start()
    {
        scriptA.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
