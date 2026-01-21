using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MapGo : MonoBehaviour
{


    public void RemoveMe()
    {
        Debug.Log("" + name);
        Destroy(gameObject);

    }
}
