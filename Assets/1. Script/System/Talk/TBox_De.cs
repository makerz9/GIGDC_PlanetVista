using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TBox_De : MonoBehaviour
{

    public GameObject MachinGun;
    public float time = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, time);

        Invoke("OnDestroy", time);

    }

    // Update is called once per frame
    void OnDestroy()

    {
        GameObject.Find("talkbox").GetComponent<SpriteRenderer>().enabled = false;
        //GameObject.Find("talkbox").GetComponent<SpriteRenderer>().enabled = false;


    }




}

