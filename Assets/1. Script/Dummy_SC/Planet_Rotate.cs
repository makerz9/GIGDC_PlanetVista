using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_Rotate : MonoBehaviour
{
    bool rotating;
    float rotateSpeed = 0.5f;
    float fixAngle = 1.0f;
    Vector3 mousePos, offset, rotation;

    void OnMouseDown()
    {
        rotating = true;

        mousePos = Input.mousePosition;
    }

    void OnMouseUp()
    {
        rotating = false;

        float yAngle = ((int)this.transform.localEulerAngles.y / (int)fixAngle) * fixAngle;
        Vector3 localEulerAngles = this.transform.localEulerAngles;

        localEulerAngles.y = yAngle;
        this.transform.localEulerAngles = localEulerAngles;
    }

    void Update()
    {
        if (rotating)
        {
            offset = (Input.mousePosition - mousePos);

            rotation.y = -(offset.x) * rotateSpeed;

            transform.Rotate(rotation);

            mousePos = Input.mousePosition;
        }
    }
}