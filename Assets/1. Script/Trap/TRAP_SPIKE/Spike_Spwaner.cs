using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_Spwaner : MonoBehaviour
{
	public float interval;
	public GameObject Spike;
	public GameObject Plannet;
	public float range = 9.0f;
	public GameObject RealSpike;
	// Start is called before the first frame update
	IEnumerator Start()
	{
		while (true)
		{
			transform.position = new Vector3(transform.position.x, Random.Range(-range, range), transform.position.z);

			Instantiate(Spike, transform.position, transform.rotation);

			yield return new WaitForSeconds(interval);
		}

	}



	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			Spike.transform.Rotate(Input.GetAxis("Mouse Y") * 10, 0, -Input.GetAxis("Mouse X") * 10);
		}

	}
}


