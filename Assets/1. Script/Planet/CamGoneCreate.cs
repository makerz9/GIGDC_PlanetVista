using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamGoneCreate : MonoBehaviour
{
    public GameObject objectToSpawn;

    void OnDestroy()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

    /*
    public List<GameObject> Tutorial_Touch = new List<GameObject>();

    public void MachineRefresh()
    {
        Destroy(Tutorial_Touch[0].transform.GetChild(0).gameObject);
        Instantiate(Resources.Load<GameObject>("Prefabs/SecondMachine"), Tutorial_Touch[0].transform);
    }
    */

}
