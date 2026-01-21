using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_rotate : MonoBehaviour
{
    public float degreePersecond;


    private void Update()
    {

        transform.Rotate(Vector3.forward * Time.deltaTime * degreePersecond);



    }
}
