using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Eff : MonoBehaviour
{

	public GameObject dustFactory;


	private void OnCollisionEnter(Collision collision)
	{


		if (collision.gameObject.tag == "Planet")

		{


			Debug.Log(collision.gameObject.name);
			Destroy(gameObject);
			GameObject dust = Instantiate(dustFactory);
			dust.transform.position = transform.position;


		}


	}



}
