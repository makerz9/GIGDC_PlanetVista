using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw_sangsok : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.parent = GameObject.Find("Saw_Roll").transform;
        this.gameObject.transform.SetParent(GameObject.Find("Saw_Roll").transform);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
