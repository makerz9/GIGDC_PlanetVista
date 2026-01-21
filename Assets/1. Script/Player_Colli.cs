using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Colli : MonoBehaviour
{

	public GameObject dustFactory;
	public GameObject MachinGun;


    //[SerializeField] public GameObject StopPlanet;
    public Behaviour StopPlanet;


    private void Start()
	{
		Destroy(GameObject.FindWithTag("Trap"));
		Destroy(GameObject.FindWithTag("Traping"));
	}

	void Update()
	{

	}


    private void OnCollisionEnter(Collision collision)
	{


		if (collision.gameObject.tag == "Trap")

		{


			//Debug.Log(collision.gameObject.name);
			Debug.Log("collllli");
			GameObject dust = Instantiate(dustFactory);
			dust.transform.position = transform.position;
			Instantiate(MachinGun, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

            StopPlanet.enabled = false;


            Destroy(GameObject.FindWithTag("Eff"));
            Destroy(gameObject);
			//this.GetComponent<rotObj>().enabled = false;


        }


	}



}
