using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw_Eff : MonoBehaviour
{

	public GameObject dustFactory;


	private void OnCollisionEnter(Collision collision)
	{


		if (collision.gameObject.tag == "Planet")

		{


			Debug.Log(collision.gameObject.name);
			GameObject dust = Instantiate(dustFactory);
			dust.transform.position = transform.position;


		}


	}



}
