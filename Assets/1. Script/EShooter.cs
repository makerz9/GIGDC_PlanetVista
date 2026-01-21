using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EShooter : MonoBehaviour
{

    public GameObject dustFactory;


    //[SerializeField] public GameObject StopPlanet;


    void Start()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Trap")

        {

            Destroy(gameObject);
            //Debug.Log(collision.gameObject.name);
            Debug.Log("maydaymadyad");
            GameObject dust = Instantiate(dustFactory);
            dust.transform.position = transform.position;
            
            //this.GetComponent<rotObj>().enabled = false;


        }


    }



}
