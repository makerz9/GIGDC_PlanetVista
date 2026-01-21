using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter_0 : MonoBehaviour
{
    // Start is called before the first frame update
    //GameObject gameObjectToMove;

    /*
    public void MoveGameObject()
    {
        //gameObjectToMove.transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
    }
    */

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, -1f) ;
        //transform.Rotate(0, 0, 0);   //transform.rotation.x
        //transform.rotation = Quaternion.Euler(transform.rotation.x, -90, 0);
        //gameObject.transform.rotation = Quaternion.Euler(RotationX, RotationY, RotationZ);





    }
}
