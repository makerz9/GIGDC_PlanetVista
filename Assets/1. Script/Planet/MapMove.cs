using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMove : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject.tag == "MapGone")

        {
            SceneManager.LoadScene("Tutorial");
            ///GetComponent<AudioSource>().Play();
            //(collision.gameObj.tag = "Seted");
            //GameManager.instance.GameOver();
        }

        if (collision.gameObject.tag == "SG_Gone")

        {
            SceneManager.LoadScene("SkyGazer");
            ///GetComponent<AudioSource>().Play();
            //(collision.gameObj.tag = "Seted");
            //GameManager.instance.GameOver();
        }

        if (collision.gameObject.tag == "PA_Gone")

        {
            SceneManager.LoadScene("PhantomAbyss");
            ///GetComponent<AudioSource>().Play();
            //(collision.gameObj.tag = "Seted");
            //GameManager.instance.GameOver();
        }

        if (collision.gameObject.tag == "Exit")

        {
            Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
        }


    }
}
