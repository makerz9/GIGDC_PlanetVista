using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_destroy : MonoBehaviour
{

	public GameObject MachinGun_DisAppear;
	public float time = 3f;
	// Start is called before the first frame update
	void Start()
	{
		Destroy(gameObject, time);



	}

	// Update is called once per frame
	void OnDestroy()

	{
		Instantiate(MachinGun_DisAppear, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
	}




}




/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_Destroy : MonoBehaviour
{


	// Start is called before the first frame update
	void Start()
	{
		Destroy( gameObject, 6f );
	}

	// Update is called once per frame
	void Update()

	{

	}




}

*/

