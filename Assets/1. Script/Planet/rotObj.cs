using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour
{

    //public GameObject GameOver;

    float rotSpeed = 5;

    void Start()
    {

    }



    void OnMouseDrag()
    {




    }

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;


            transform.RotateAround(Vector3.up, -rotX);
            transform.RotateAround(Vector3.right, rotY);
        }
    }



}









/*
void OnCollisionEnter(Collision collision)
{


    if (collision.gameObject.tag == "Stop")

    {
        GameOver.SetActive(false);

        //Debug.Log(collision.gameObject.name);
        //Debug.Log("collllli");

        //Destroy(gameObject);
        //this.GetComponent<rotObj>().enabled = false;


    }


}
*/


