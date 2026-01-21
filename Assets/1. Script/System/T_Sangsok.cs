using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Sangsok : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        this.gameObject.transform.parent = GameObject.Find("PRoll").transform;
 
        this.gameObject.transform.SetParent(GameObject.Find("PRoll").transform);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
