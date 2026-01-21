using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackWall : MonoBehaviour
{
    public float speed;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()

    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }




}

