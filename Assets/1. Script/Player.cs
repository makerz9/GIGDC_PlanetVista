using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
	public static Player instance = null;
	public GameObject mandie2;

	public bool crash;
	public Camera camera;
	public Transform target;
	public float smoothTime = 1F;
	private Vector3 velocity = Vector3.zero;
	public GameObject gm;

	void Awake()
	{
		crash = false;

	}



	void OnTriggerEnter(Collider other)
	{


		crash = true;
		Destroy(gameObject);

		Instantiate(mandie2, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		gm.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);

		


	}



}




