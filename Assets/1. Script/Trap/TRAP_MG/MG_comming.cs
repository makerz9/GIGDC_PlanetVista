using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_comming : MonoBehaviour
{

	public Transform target1;
    //public Transform target2;
    public float smoothTime = 1F;
	private Vector3 velocity = Vector3.zero;
	////public static DieCamera instance = null;
	// Start is called before the first frame update
	void Awake()
	{

	}




	// Update is called once per frame

	void Update()
	{

		this.transform.position = Vector3.SmoothDamp(transform.position, target1.transform.position, ref velocity, smoothTime);
        //this.transform.position = Vector3.SmoothDamp(transform.position, target2.transform.position, ref velocity, smoothTime);

    }
}
