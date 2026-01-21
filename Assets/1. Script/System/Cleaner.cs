using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 1f;
    // Start is called before the first frame update

    private void Update()
    {
        Destroy(GameObject.FindWithTag("Trap"));
        Destroy(GameObject.FindWithTag("Traping"));
        Destroy(GameObject.FindWithTag("Fighter"));

    }

    void Start()
    {
        Destroy(gameObject, time);

        Invoke("OnDestroy", time);

    }
}
