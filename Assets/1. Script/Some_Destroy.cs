using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Some_Destroy : MonoBehaviour
{
	public float time = 3f;
	// Start is called before the first frame update
	void Start()
	{
		Destroy(gameObject, time);



	}

	// Update is called once per frame
	void Update()
    {
        
    }



}
