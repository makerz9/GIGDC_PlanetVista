using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

	public static GameManager instance = null;
	public Camera camera;
	public Transform target;
	public GameObject GameOverPanel;
	//public GameObject OptionPanel;

	// Start is called before the first frame update
	void Start()
	{
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update()
	{


	}

}
