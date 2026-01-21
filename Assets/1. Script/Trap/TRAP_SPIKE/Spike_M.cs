using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_M : MonoBehaviour
{
	public float interval;
	public GameObject MachinGun;

	public float range = 9.0f;
	public GameObject Bullet;
	// Start is called before the first frame update
	IEnumerator Start()
	{
		while (true)
		{


			Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

			yield return new WaitForSeconds(interval);
		}

	}



	// Update is called once per frame
	void Update()
	{


	}
}