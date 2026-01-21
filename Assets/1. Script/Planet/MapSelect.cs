using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelect : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
        Time.timeScale = 1;
        Destroy(GameObject.FindWithTag("Trap"));
        Destroy(GameObject.FindWithTag("Talk"));
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray toMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rhInfo;
            bool didHit = Physics.Raycast(toMouse, out rhInfo, 500.0f);

            if (didHit)
            {
                Debug.Log(rhInfo.collider.name + " . . " + rhInfo.point);
                MapGo destScript = rhInfo.collider.GetComponent<MapGo>();
                if (destScript)
                {
                    destScript.RemoveMe();
                }
            }
            else
            {
                Debug.Log("clicked on empty space");
            }

        }
    }



}
