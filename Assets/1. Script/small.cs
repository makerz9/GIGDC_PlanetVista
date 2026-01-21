using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class small : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.6f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localScale -= new Vector3(0.0002f, 0.0002f, 0);
    }
}
