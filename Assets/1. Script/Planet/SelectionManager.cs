using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{

    bool mouseOver = false;
    public GameObject Select;
    //public GameObject Difficulty;
    public GameObject EX;

    //public GameObject Des;

    void OnMouseEnter()
    {
        mouseOver = true;
        Instantiate(Select, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        //Instantiate(Difficulty, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        //Instantiate(Select);
    }

    void OnMouseExit()
    {
        mouseOver=false;
        //Instantiate(Des, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Destroy(GameObject.FindWithTag("MapSelect"));
        Destroy(GameObject.FindWithTag("Difficulty"));
        //Destroy(GameObject.FindWithTag("Traping"));

    }


}
