using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_Talk : MonoBehaviour
{
    public float interval;
    public GameObject[] g_talk;
    public GameObject set3;
    //public GameObject MachinGun;
    //public float range = 9.0f;




    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            set3.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            int randomIndex = Random.Range(0, g_talk.Length);
            Instantiate(g_talk[randomIndex], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(interval);
        }

    }


}