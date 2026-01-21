using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAble : MonoBehaviour
{
    public void RemoveMe ()
    {
        Debug.Log("" + name);
        Destroy(gameObject);
    }
}
