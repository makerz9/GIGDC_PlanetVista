using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Rotate2 : MonoBehaviour
{
    bool rotating;
    float rotateSpeed = 0.5f;
    float fixAngle = 0.1f;
    Vector3 mousePos, offset, rotation;

    void OnMouseDown()
    {
        rotating = true;

        mousePos = Input.mousePosition;
    }

    void OnMouseUp()
    {
        rotating = false;

        float xAngle = ((int)this.transform.localEulerAngles.x / (int)fixAngle) * fixAngle;
        Vector3 localEulerAngles = this.transform.localEulerAngles;

        localEulerAngles.x = xAngle;
        this.transform.localEulerAngles = localEulerAngles;
    }

    void Update()
    {
        if (rotating)
        {
            offset = (Input.mousePosition - mousePos);

            rotation.x = +(offset.y) * rotateSpeed;

            transform.Rotate(rotation);

            mousePos = Input.mousePosition;
        }
    }
}