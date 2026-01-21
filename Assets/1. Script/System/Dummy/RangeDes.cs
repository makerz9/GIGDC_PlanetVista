using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeDes : MonoBehaviour
{

    public float interval;
    public GameObject BackWall1Prefab;

    public float time = 3f;


    void Start()
    {
        Destroy(gameObject, 1f);
        Instantiate(BackWall1Prefab, transform.position, transform.rotation);
        //Invoke("OnDestroy", time);

    }


    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Trap")

        {
            Destroy(gameObject);
        }


        if (collision.gameObject.tag == "Planet")

        {
            Destroy(gameObject);
        }



    }




}
