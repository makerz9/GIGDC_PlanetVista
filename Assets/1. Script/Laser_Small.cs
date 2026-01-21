using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Small : MonoBehaviour
{
    public GameObject sa;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localScale -= new Vector3(0.0065f, 0, 0.0065f);
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "STOP")
        {

            transform.localScale += new Vector3(transform.position.x, transform.position.y, transform.position.z);

        }
    }
    */


    void OnDestroy()

    {
        Instantiate(sa, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }

}
