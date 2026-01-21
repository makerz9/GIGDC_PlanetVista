using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Talk : MonoBehaviour
{
    public GameObject[] FTalk;
    public GameObject set2;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, time);

        Invoke("OnDestroy", time);

    }

    // Update is called once per frame
    void OnDestroy()

    {
        set2.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        int randomIndex = Random.Range(0, FTalk.Length);
        Instantiate(FTalk[randomIndex], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        //Instantiate(set2, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }




}

