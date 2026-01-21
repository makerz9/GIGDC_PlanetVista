using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colli : MonoBehaviour
{
	//[SerializeField] ParticleSystem collectParticle = null;



	private void OnCollisionEnter(Collision collision)
	{


		if (collision.gameObject.tag == "Planet")

		{


			Debug.Log(collision.gameObject.name);
			Destroy(gameObject);
			//Collect();
			//collectParticle.Play();


		}


	}

	//public void Collect()
	//{
	//	collectParticle.Play();

	//}

}
