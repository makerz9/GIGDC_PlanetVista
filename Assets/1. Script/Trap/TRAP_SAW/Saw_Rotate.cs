using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw_Rotate : MonoBehaviour
{
    public float speed;
    public Transform target;

    void Update()
    {

        transform.Rotate(speed * Time.deltaTime, 0, 0);



    }
}
