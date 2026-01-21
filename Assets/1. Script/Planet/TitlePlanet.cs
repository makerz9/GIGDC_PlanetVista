using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TitlePlanet : MonoBehaviour
{
    public GameObject GameOver;


    // Start is called before the first frame update
    private void Awake()
    {
        GameOver.SetActive(false); // ������ ���۵Ǹ� GameOver �˾� â�� ������ �ʵ��� �Ѵ�.

    }

    // Update is called once per frame
    void Update()
    {

       

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                gameObject.GetComponent<PlanetRotate>().enabled = false; // 스크립트 비활성화

                GameOver.SetActive(true);
            }
        }


    }


}


