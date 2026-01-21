    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Talk : MonoBehaviour
{
    
    public GameObject[] Talk;
    //public GameObject Talk;


    void Start()
    {

        //Destroy(GameObject.FindWithTag("G_Talk"));
        int randomIndex = Random.Range(0, Talk.Length);
        //Vector3 randomSpawnPosiion

        //Instantiate(Talk[randomIndex]);
        Instantiate(Talk[randomIndex], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

        ////Instantiate(Talk, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
