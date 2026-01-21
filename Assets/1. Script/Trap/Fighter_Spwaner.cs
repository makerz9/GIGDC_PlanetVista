using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter_Spwaner : MonoBehaviour
{
    public float interval;
    public GameObject Spike;
    public GameObject Planet;
    public float range = 9.0f;
    public float minrange = 3.0f;
    //public float minrange = 9.0f;
    //public float maxrange = 9.0f;
    public GameObject RealSpike;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            transform.position = new Vector3(transform.position.y, Random.Range(-range, range), transform.position.x);
            transform.position = new Vector3(transform.position.y, Random.Range(-range, range), transform.position.y);
            transform.position = new Vector3(transform.position.y, Random.Range(-range, range), transform.position.z);

            Instantiate(Spike, transform.position, transform.rotation);

            yield return new WaitForSeconds(interval);
        }

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Spike.transform.Rotate(Input.GetAxis("Mouse Y") * 10, 0, -Input.GetAxis("Mouse X") * 10);
        }

    }
}

