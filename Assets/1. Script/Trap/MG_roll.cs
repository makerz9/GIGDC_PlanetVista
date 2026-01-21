using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_roll : MonoBehaviour
{
    public float degreePersecond;


    private void Update()
    {

        transform.Rotate(Vector3.up * Time.deltaTime * degreePersecond);



    }
}
