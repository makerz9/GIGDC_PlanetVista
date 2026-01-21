using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_Change : MonoBehaviour
{

	public GameObject RealSpike;
	public float time = 5f;
	// Start is called before the first frame update
	void Start()
	{
		Destroy(gameObject, time);

		Invoke("OnDestroy", time);

	}

	// Update is called once per frame
	void OnDestroy()

	{
		Instantiate(RealSpike, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
	}




}

