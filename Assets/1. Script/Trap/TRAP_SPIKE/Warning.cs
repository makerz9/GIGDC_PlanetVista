using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{

	public GameObject Spike;
	// Start is called before the first frame update
	void Start()
	{
		Vector3 dir = new Vector3(Random.Range(-10, 10) * 0.5f, Random.Range(-10, 10) * 0.5f, Random.Range(-10, 10) * 0.5f);
		dir.Normalize(); // dir 이 Vector3.zero 
		transform.position = dir * Random.Range(2.75f, 2.75f);
	}



	// Update is called once per frame
	/*
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			Spike.transform.Rotate(Input.GetAxis("Mouse Y") * 10, 0, -Input.GetAxis("Mouse X") * 10);
		}


		if (Input.GetMouseButton(1))
		{
			Camera.main.transform.Rotate(Input.GetAxis("Mouse Y") * 10, Input.GetAxis("Mouse X") * 10, 0);
		}
	}
	*/
}

