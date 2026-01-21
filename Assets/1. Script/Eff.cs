using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eff : MonoBehaviour
{
    public bool crash;

    void Awake()
    {
        crash = false;

    }

	void OnTriggerEnter(Collider other)
	{

		//SceneManager.LoadScene("EGG-226");
		//Debug.Log("충돌");

		crash = true;



		Destroy(gameObject);





	}

}
