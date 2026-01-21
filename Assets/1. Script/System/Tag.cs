using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag : MonoBehaviour
{

    public GameObject GameOver;








    void Start()
    {
        GameOver = GameObject.Find("GameManager").GetComponent<GameManager>().GameOverPanel;



    }


    void OnCollisionStay(Collision collision)

    {

        if (collision.gameObject.tag == "Trap")

        {

            //(collision.gameObj.tag = "Seted");
            gameObject.tag = "Seted";




        }

        /*
        if (collision.gameObject.tag == "Untagged")

        {

            //(collision.gameObj.tag = "Seted");
            Debug.Log("gsrgsrsrfdg");
            GetComponent<AudioSource>().Play();

        }
        */



    }



    void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject.tag == "Trap")

        {

            ///GetComponent<AudioSource>().Play();
            //(collision.gameObj.tag = "Seted");
            Debug.Log("GameOver");
            GameOver.SetActive(true);
            Time.timeScale = 0;
            //GameManager.instance.GameOver();





        }






    }




    /*

    private void OnTriggerStay(Collider other)

    {

        if (collision.gameObject.tag == "Trap")

        {
            ////GetComponent<AudioSource>().Play();
            //(collision.gameObj.tag = "Seted");
            gameObject.tag = "Seted";

        }

    */


        /*
        if (other.gameObject.tag == "Untagged")

        {
            //(collision.gameObj.tag = "Seted");
            Debug.Log("asasas");
            GetComponent<AudioSource>().Play();

        }
        */



    }






