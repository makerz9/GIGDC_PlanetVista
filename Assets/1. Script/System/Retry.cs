using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //씬 사용 허가


public class Retry : MonoBehaviour
{
    public void retry()
    {
        Debug.Log("start!"); //확인용 디버그 로그 출력
        SceneManager.LoadScene("Tutorial");
        Destroy(GameObject.FindWithTag("Trap"));
        Destroy(GameObject.FindWithTag("Traping"));
        Application.LoadLevel(Application.loadedLevel);

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
