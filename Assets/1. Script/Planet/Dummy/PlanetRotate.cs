using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlanetRotate : MonoBehaviour
{
	public GameObject plannet;

	public float rotSpeed = 200f;

	float mx = 0;
	float my = 0;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		float mouse_X = Input.GetAxis("Mouse X");
		float mouse_Y = Input.GetAxis("Mouse Y");

		if (Input.GetMouseButton(0))
		{
			plannet.transform.Rotate(Input.GetAxis("Mouse Y") * 1, 0, -Input.GetAxis("Mouse X") * 1);
			mx += mouse_X * rotSpeed * Time.deltaTime;
			my += mouse_Y * rotSpeed * Time.deltaTime;
			transform.eulerAngles = new Vector3(-my, mx, 0);



		}

		/*
		if(Input.GetMouseButton(1))
		{
			Camera.main.transform.Rotate(Input.GetAxis("Mouse X")*1,Input.GetAxis("Mouse Y")*1,0);
			mx += mouse_X * rotSpeed * Time.deltaTime;
			my += mouse_Y * rotSpeed * Time.deltaTime;
			transform.eulerAngles = new Vector3 (-my, mx, 0);
		}
		*/
	}
}






/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlannetRotate : MonoBehaviour
{
	public GameObject plannet;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetMouseButton(0))
		{
			plannet.transform.Rotate(Input.GetAxis("Mouse Y")*10,0,-Input.GetAxis("Mouse X")*10);
		}


		if(Input.GetMouseButton(1))
		{
			Camera.main.transform.Rotate(Input.GetAxis("Mouse Y")*10,Input.GetAxis("Mouse X")*10,0);
		}
	}
}
*/
