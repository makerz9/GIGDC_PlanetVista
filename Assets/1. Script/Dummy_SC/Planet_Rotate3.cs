using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Rotate3 : MonoBehaviour
{
    bool rotating;
    float rotateSpeed = 0.5f;
    float fixAngle = 10.0f;
    Vector3 mousePos, offset, rotation;

    void OnMouseDown()
    {
        rotating = true;

        mousePos = Input.mousePosition;
    }

    void OnMouseUp()
    {
        rotating = false;

        float zAngle = ((int)this.transform.localEulerAngles.z / (int)fixAngle) * fixAngle;
        Vector3 localEulerAngles = this.transform.localEulerAngles;

        localEulerAngles.z = zAngle;
        this.transform.localEulerAngles = localEulerAngles;
    }

    void Update()
    {
        if (rotating)
        {
            offset = (Input.mousePosition - mousePos);

            rotation.z = -(offset.x) * rotateSpeed;

            transform.Rotate(rotation);

            mousePos = Input.mousePosition;
        }
    }
}