using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;


public class Range_Obj : MonoBehaviour
{

    public float interval;
    public GameObject MachinGun;
    //public GameObject Re;
    public GameObject Bullet;

    public float range = 9.0f;



    IEnumerator Start()
    {
        while (true)
        {


            Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

            Destroy(gameObject);

            yield return new WaitForSeconds(interval);
            //Debug.Log("gsrgsrsrfdg");
        }

    }

    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {

        
        if (collision.gameObject.tag == "Planet")

        {
            transform.position = new Vector3(transform.position.y, Random.Range(-range, range), transform.position.x);
            transform.position = new Vector3(transform.position.y, Random.Range(-range, range), transform.position.y);
            transform.position = new Vector3(transform.position.y, Random.Range(-range, range), transform.position.z);



        }
        


    }
    


}


