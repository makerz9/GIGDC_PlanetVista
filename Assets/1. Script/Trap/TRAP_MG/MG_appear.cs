using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_appear : MonoBehaviour
{

	public GameObject MachinGun;
	public float time = 3f;
	// Start is called before the first frame update
	void Start()
	{
		Destroy(gameObject, time);

		Invoke("OnDestroy", time);

	}

	// Update is called once per frame
	void OnDestroy()

	{
		Instantiate(MachinGun, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
	}




}

