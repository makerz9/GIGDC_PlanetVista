using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigger : MonoBehaviour
{

    //public GameObject AS;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localScale += new Vector3(0.0016f, 0.0016f, 0.0016f);
    }

    void OnDestroy()

    {
        //Instantiate(AS, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "STOP")
        {

            transform.localScale -= new Vector3(0.0001f, 0.0001f, 0.0001f);

        }
    }
    */





}
