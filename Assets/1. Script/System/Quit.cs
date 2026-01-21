 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void quit()
    {
        Debug.Log("Home!");
        SceneManager.LoadScene("Main");


        Destroy(GameObject.FindWithTag("Trap"));
        Destroy(GameObject.FindWithTag("Traping"));

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
