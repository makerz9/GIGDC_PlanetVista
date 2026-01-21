using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FT_X : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update


    void Start()
    {
        Destroy(gameObject, time);

        Invoke("OnDestroy", time);



        void OnDestroy()

        {
            Destroy(GameObject.FindWithTag("F_Talk"));
        }
    }
}
