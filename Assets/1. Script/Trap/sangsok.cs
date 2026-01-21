using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sangsok : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()    
    {
        
        this.gameObject.transform.parent = GameObject.Find("Planet").transform;
        this.gameObject.transform.SetParent(GameObject.Find("Planet").transform);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
