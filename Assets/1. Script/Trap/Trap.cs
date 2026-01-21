using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
	
	public GameObject player;

	public float range = 3f;
	public float rotationMaxSpeed = 3f;
	public float checkAngle = 30f;

	public void Start()
	{
		player = GameObject.Find("Planet");

	}

	private void Update()
	{
		var dir = player.transform.position - transform.position;

		if (Vector3.Distance(transform.position, player.transform.position) < range &&
			Vector3.Angle(transform.forward, dir) < checkAngle / 2f)
		{
			transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(dir, transform.up), rotationMaxSpeed);
		}
	}

	/// for gizmo.

	private void OnDrawGizmos()
	{
		var dt = Mathf.PI / 12f;
		var checkRadian = checkAngle * Mathf.Deg2Rad;

		Gizmos.DrawLine(transform.position, GetPosByAngle(-checkRadian / 2f));
		Gizmos.DrawLine(transform.position, GetPosByAngle(checkRadian / 2f));

		for (float t = -checkRadian / 2f; t < checkRadian / 2f; t += dt)
		{
			Gizmos.DrawLine(GetPosByAngle(t), GetPosByAngle(Mathf.Min(t + dt, checkRadian / 2f)));
		}

		Gizmos.DrawLine(transform.position, transform.position + transform.forward);
	}

	Vector3 GetPosByAngle(float radian)
	{
		return transform.position + range * transform.forward * Mathf.Cos(radian) + range * transform.right * Mathf.Sin(radian);
	}
	
}