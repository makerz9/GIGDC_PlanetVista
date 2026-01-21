using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Panel_GameOver : MonoBehaviour
{

    public GameObject GameOver;


    private void Awake()
    {
        GameOver.SetActive(false); // ������ ���۵Ǹ� GameOver �˾� â�� ������ �ʵ��� �Ѵ�.
    }


    /*
    public void OnClick_Retry() 
    {
        SceneManager.LoadScene("GameScene"); 
                                             
    }
    */

}

