using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearDes : MonoBehaviour
{
    public float interval;
    public GameObject BackWall1Prefab;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            transform.position = new Vector3(0, 0, 0);
            Instantiate(BackWall1Prefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);

    }
}
